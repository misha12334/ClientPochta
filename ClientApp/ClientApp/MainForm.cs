using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class MainForm : Form
    {
        public Client client;
        bool flag;

        public MainForm()
        {
            InitializeComponent();
            flag = false;

            client = new Client("127.0.0.1", 11000);

            RegistrationForm form = new RegistrationForm(client);
            form.ShowDialog();

            if (form.autorization == false)
            {
                client.closeConnection();
                Environment.Exit(0);    
            }

            if (client.getStatusUser() == "Пользователь")
            {
                StatusRegcomboBox.Enabled = false;
                StatusRegcomboBox.SelectedIndex = 1;
                SendButton.Text = "Отправить письмо";

                textBoxFIOSen.Text = client.currentUser._FIO;
                textBox1.Text = client.currentUser._city;
                textBoxAdressSen.Text = client.currentUser._adress;

                fillListLetters();
            }
            else
            {
                textBoxAdrrec.Enabled = false;
                textBoxAdrrec.ForeColor = Color.Black;
                textBoxFIOrec.Enabled = false;
                textBoxFIOrec.ForeColor = Color.Black;
                textBoxCityRec.Enabled = false;
                textBoxCityRec.ForeColor = Color.Black;

                if (client.getStatusUser() == "Оператор\t")
                {
                    SendButton.Text = "Сохранить изменения";
                    StatusRegcomboBox.Enabled = true;
                    comboBoxCurier.Enabled = true;

                    fillAllListLetters();
                    fillComboBoxCurriers();
                  
                }
                else
                {
                    StatusRegcomboBox.Enabled = false;
                    SendButton.Visible = false;
                    fillListCurrierLetters();
                }


            }
          
        }

        #region работа с кнопками
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFIOSen_Enter(object sender, EventArgs e)
        {
            if (textBoxFIOSen.Text == "ФИО отправителя")
            {
                textBoxFIOSen.Text = "";
                textBoxFIOSen.ForeColor = Color.Black;
                textBoxFIOSen.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void textBoxFIOSen_Leave(object sender, EventArgs e)
        {
            if (textBoxFIOSen.Text == "")
            {
                textBoxFIOSen.Text = "ФИО отправителя";
                textBoxFIOSen.ForeColor = Color.Silver;
                textBoxFIOSen.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Город отправителя")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                textBox1.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Город отправителя";
                textBox1.ForeColor = Color.Silver;
                textBox1.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void textBoxAdressSen_Enter(object sender, EventArgs e)
        {
            if (textBoxAdressSen.Text == "Адрес отправителя")
            {
                textBoxAdressSen.Text = "";
                textBoxAdressSen.ForeColor = Color.Black;
                textBoxAdressSen.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void textBoxAdressSen_Leave(object sender, EventArgs e)
        {
            if (textBoxAdressSen.Text == "")
            {
                textBoxAdressSen.Text = "Адрес отправителя";
                textBoxAdressSen.ForeColor = Color.Silver;
                textBoxAdressSen.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void textBoxFIOrec_Enter(object sender, EventArgs e)
        {
            if (textBoxFIOrec.Text == "ФИО получателя")
            {
                textBoxFIOrec.Text = "";
                textBoxFIOrec.ForeColor = Color.Black;
                textBoxFIOrec.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void textBoxFIOrec_Leave(object sender, EventArgs e)
        {
            if (textBoxFIOrec.Text == "")
            {
                textBoxFIOrec.Text = "ФИО получателя";
                textBoxFIOrec.ForeColor = Color.Silver;
                textBoxFIOrec.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void textBoxCityRec_Enter(object sender, EventArgs e)
        {
            if (textBoxCityRec.Text == "Город получателя")
            {
                textBoxCityRec.Text = "";
                textBoxCityRec.ForeColor = Color.Black;
                textBoxCityRec.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void textBoxCityRec_Leave(object sender, EventArgs e)
        {
            if (textBoxCityRec.Text == "")
            {
                textBoxCityRec.Text = "Город получателя";
                textBoxCityRec.ForeColor = Color.Silver;
                textBoxCityRec.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void textBoxAdrrec_Enter(object sender, EventArgs e)
        {
            if (textBoxAdrrec.Text == "Адрес получателя")
            {
                textBoxAdrrec.Text = "";
                textBoxAdrrec.ForeColor = Color.Black;
                textBoxAdrrec.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void textBoxAdrrec_Leave(object sender, EventArgs e)
        {
            if (textBoxAdrrec.Text == "")
            {
                textBoxAdrrec.Text = "Адрес получателя";
                textBoxAdrrec.ForeColor = Color.Silver;
                textBoxAdrrec.TextAlign = HorizontalAlignment.Center;
            }
        }
        #endregion

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (client.getStatusUser() == "Пользователь")
            {
                client.SendLetter(textBoxFIOrec.Text, textBoxCityRec.Text, textBoxAdrrec.Text);
                fillDataGrid();
                fillListLetters();
            }
            else
            {
                int idLetter = Convert.ToInt32(LettersGridView.Rows[LettersGridView.CurrentRow.Index].Cells[0].Value);
                client.saveChanges(StatusRegcomboBox.SelectedItem.ToString(), comboBoxCurier.SelectedItem.ToString(), idLetter);
                fillAllListLetters();
                fillDataGrid();
            }
        }

        public void fillComboBoxCurriers()
        {
            List<User> list = client.getListCuriers();


            comboBoxCurier.Items.Add("Не назначен");
            for (int i = 0; i < list.Count(); i++)
            {
                comboBoxCurier.Items.Add(list[i]._FIO);
            }
        }

        public void fillListLetters()
        {
            flag = true;
            List<Letter> letters = client.getListLetters();

            LettersGridView.Rows.Clear();

            foreach (Letter ltr in letters)
            {
                LettersGridView.Rows.Add();
                int count = LettersGridView.Rows.Count;
                LettersGridView.Rows[count - 1].Cells[0].Value = ltr._id;
                LettersGridView.Rows[count - 1].Cells[1].Value = ltr._FIO_recipient;
                LettersGridView.Rows[count - 1].Cells[2].Value = ltr._status;

            }
            flag = false;
        }

        public void fillDataGrid()
        {
            if (!flag)
            {
                int idLetter = Convert.ToInt32(LettersGridView.Rows[LettersGridView.CurrentRow.Index].Cells[0].Value);
                string FIOcur = "";
                string FIOsen = "";
                string Citysen = "";
                string Adrsen = "";
                Letter letter = client.getLetter(idLetter, ref FIOsen, ref  Citysen, ref  Adrsen, ref FIOcur);

                textBoxFIOSen.Text = FIOsen;
                textBox1.Text = Citysen;
                textBoxAdressSen.Text = Adrsen;

                textBoxFIOrec.Text = letter._FIO_recipient;
                textBoxCityRec.Text = letter._city_recipient;
                textBoxAdrrec.Text = letter._adress_recipient;

                textBoxFIOrec.ForeColor = Color.Black;
                textBoxCityRec.ForeColor = Color.Black;
                textBoxAdrrec.ForeColor = Color.Black;

                StatusRegcomboBox.SelectedItem = letter._status;

                if (client.getStatusUser() != "Оператор\t")
                {
                    comboBoxCurier.Items.Clear();
                    comboBoxCurier.Items.Add(FIOcur);
                }

                comboBoxCurier.SelectedItem = FIOcur;

            }
        }

        public void fillAllListLetters()
        {
            flag = true;
            List<Letter> letters = client.getListAllLetters();

            LettersGridView.Rows.Clear();

            foreach (Letter ltr in letters)
            {
                LettersGridView.Rows.Add();
                int count = LettersGridView.Rows.Count;
                LettersGridView.Rows[count - 1].Cells[0].Value = ltr._id;
                LettersGridView.Rows[count - 1].Cells[1].Value = ltr._FIO_recipient;
                LettersGridView.Rows[count - 1].Cells[2].Value = ltr._status;

            }
            flag = false;
        }

        public void fillListCurrierLetters()
        {
            flag = true;
            List<Letter> letters = client.getListCurrierLetters();

            LettersGridView.Rows.Clear();

            foreach (Letter ltr in letters)
            {
                LettersGridView.Rows.Add();
                int count = LettersGridView.Rows.Count;
                LettersGridView.Rows[count - 1].Cells[0].Value = ltr._id;
                LettersGridView.Rows[count - 1].Cells[1].Value = ltr._FIO_recipient;
                LettersGridView.Rows[count - 1].Cells[2].Value = ltr._status;

            }
            flag = false;
        }

        private void LettersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillDataGrid();
        }

    }
}
