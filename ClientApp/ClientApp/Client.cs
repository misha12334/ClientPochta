using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    public class Client
    {
        public Socket _Client;
        public bool flagConnection;
        public User currentUser;

        public Client(string ip, int port)
        {
            flagConnection = false;
            currentUser = new User();
            try
            {
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

                _Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _Client.Connect(ipEndPoint);

                String Host = System.Net.Dns.GetHostName();
                System.Net.IPAddress MyIp = Dns.GetHostByName(Host).AddressList[0];
                string StringMyIp = MyIp.ToString();

                byte[] Buffer = Encoding.UTF8.GetBytes(StringMyIp);

                _Client.Send(Buffer);

                flagConnection = true;

            }
            catch (Exception e)
            {
            }
        }

        ~Client()
        {
            closeConnection();
        }

        public string getStatusUser()
        {
            return currentUser._status;
        }

        public void closeConnection()
        {
            try
            {
                if (_Client.Connected)
                {
                    sendField(_Client, "END");
                    _Client.Close();
                }
            }
            catch (Exception e)
            {
                _Client.Close();
            }
        }

        public string Registration(string login, string password, string FIO, string city, string adress, string telephone, string status)
        {
            string result = "-ERR";

            if (_Client.Connected)
            {
                sendField(_Client, "REG");

                sendField(_Client, login);
                sendField(_Client, password);
                sendField(_Client, FIO);
                sendField(_Client, city);
                sendField(_Client, adress);
                sendField(_Client, telephone);
                sendField(_Client, status);

                result = getField();
            }

            return result;
        }

        public string Authorization(string password, string login)
        {
            string result = "-ERR";

            if (_Client.Connected)
            {

                sendField(_Client, "AUTH");
                sendField(_Client, login);
                sendField(_Client, password);

                result = getField();

                if (result == "+OK")
                {
                    currentUser._password = password;

                    currentUser._id = Convert.ToInt32(getField());
                    currentUser._FIO = getField();
                    currentUser._status = getField();
                    currentUser._city = getField();
                    currentUser._adress = getField();
                }
            }

            return result;
        }

        public void SendLetter(string FIORec, string CityRec, string AdressRec)
        {           
            if (_Client.Connected)
            {
                sendField(_Client, "SEND");

                //Данные отправителя
                sendField(_Client, currentUser._id.ToString());


                //Данные получателя
                sendField(_Client, FIORec);
                sendField(_Client, CityRec);
                sendField(_Client, AdressRec);
            }        
        }


        public Letter getLetter(int idLetter, ref string fiosend, ref string citysend, ref string adrsend, ref string fioCur)
        {
            Letter letter = new Letter();

            if (_Client.Connected)
            {
                sendField(_Client, "GET");

                sendField(_Client, idLetter.ToString());

                fiosend = getField();
                citysend = getField();
                adrsend = getField();

                letter._FIO_recipient = getField();

                letter._city_recipient = getField();

                letter._adress_recipient = getField();

                letter._status = getField();

                fioCur = getField();

                

            }
            return letter;
        }

        public List<Letter> getListLetters()
        {
            List<Letter> letters = new List<Letter>();
            if (_Client.Connected)
            {
                sendField(_Client, "LIST");

                sendField(_Client, currentUser._id.ToString());

                int countLetters =Convert.ToInt32( getField());

                for (int i = 0; i < countLetters; i++)
                {
                    Letter letter = new Letter();

                    letter._id = Convert.ToInt32(getField());
                    letter._FIO_recipient = getField();
                    letter._status = getField();

                    letters.Add(letter);
                }
            }
            return letters;
        }

        public List<User> getListCuriers()
        {
            List<User> curiers = new  List<User>();

            if (_Client.Connected)
            {
                sendField(_Client, "CURIER");

                sendField(_Client, currentUser._city);

                int countUsers = Convert.ToInt32(getField());

                for (int i = 0; i < countUsers; i++)
                {
                    User user = new User();

                    user._FIO = getField();

                    curiers.Add(user);
                }
            }

            return curiers;

        }

        public void saveChanges(string status, string currier, int idLetter)
        {
            if (_Client.Connected)
            {
                sendField(_Client, "SAVE");

                sendField(_Client, idLetter.ToString());

                sendField(_Client, status);
                sendField(_Client, currier);

            }
        }

        public List<Letter> getListAllLetters()
        {
            List<Letter> letters = new List<Letter>();
            if (_Client.Connected)
            {
                sendField(_Client, "LIST_ALL");

                sendField(_Client, currentUser._city);

                int countLetters = Convert.ToInt32(getField());

                for (int i = 0; i < countLetters; i++)
                {
                    Letter letter = new Letter();

                    letter._id = Convert.ToInt32(getField());
                    letter._FIO_recipient = getField();
                    letter._status = getField();

                    letters.Add(letter);
                }
            }
            return letters;
        }

        public List<Letter> getListCurrierLetters()
        {
            List<Letter> letters = new List<Letter>();
            if (_Client.Connected)
            {
                sendField(_Client, "LETERS_CUR");

                sendField(_Client, currentUser._id.ToString());

                int countLetters = Convert.ToInt32(getField());

                for (int i = 0; i < countLetters; i++)
                {
                    Letter letter = new Letter();

                    letter._id = Convert.ToInt32(getField());
                    letter._FIO_recipient = getField();
                    letter._status = getField();

                    letters.Add(letter);
                }
            }
            return letters;
        }
        

        public string getField()
        {
            byte[] Buffer = new byte[1024];

            int Count = _Client.Receive(Buffer, 4, new SocketFlags());              //Получение размера сообщения
            int Size = Convert.ToInt32(Encoding.UTF8.GetString(Buffer, 0, Count));  //Размер сообщения

            Count = _Client.Receive(Buffer, Size, new SocketFlags());               //Получить сообщение с указанным размером
            return Encoding.UTF8.GetString(Buffer, 0, Count);
        }

        private void sendField(Socket Client, string field)
        {
            byte[] Size = new byte[4];
            byte[] Buffer = new byte[1024];
            int sizeBuffer;

            //Получение размера сообщения
            Buffer = Encoding.UTF8.GetBytes(field);
            sizeBuffer = Buffer.Length;
            Size = Encoding.Default.GetBytes(fillBits(sizeBuffer.ToString(), 4));

            //Отправить размер сообщения
            Client.Send(Size, 4, new SocketFlags());

            //Отправить сообщение с указанным размером
            Buffer = Encoding.UTF8.GetBytes(field);
            Client.Send(Buffer, sizeBuffer, new SocketFlags());
        }

        private string fillBits(string str, int numberBits)
        {
            while (str.Length < numberBits)
            {
                str = "0" + str;
            }

            return str;
        }

    }
}
