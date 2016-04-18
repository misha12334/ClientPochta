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
    public partial class RegistrationForm : Form
    {
        Client _client;
        public bool autorization;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        public RegistrationForm(Client client)
        {
            InitializeComponent();
            _client = client;
            autorization = false;
            StatusRegcomboBox.SelectedIndex = 0;
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string str = _client.Registration(LoginRegTextBox.Text, PasswordRegTextBox.Text, FIORegTextBox.Text, CityRegTextBox.Text, AdressRegtextBox.Text, TelephoneRegtextBox.Text, StatusRegcomboBox.SelectedItem.ToString());
            if (str == "+OK")
            {
                label2.Visible = false;
            }
            else
            {
                label2.Visible = true;
            }
        }

        private void buttonAutorization_Click(object sender, EventArgs e)
        {
            string str = _client.Authorization(LoginTextBox.Text, PasswordTextBox.Text);
            if (str == "+OK")
            {
                label1.Visible = false;
                _client.currentUser._login = LoginTextBox.Text;
                _client.currentUser._password = PasswordTextBox.Text;
                autorization = true;
                this.Close();
            }
            else
            {
                autorization = false;
                label1.Visible = true;
            }
        }

        
    }
}
