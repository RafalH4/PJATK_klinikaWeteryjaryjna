using KlinikaWeterynaryjna.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlinikaWeterynaryjna
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "" || hasloTextBox.Text == "")
            {
                MessageBox.Show("Nie wprowadzono loginu i/lub hasła");
                return;
            }
            var context = new KlinikaWeterynaryjnaContext();
            var user = context.Uzytkowniks.FirstOrDefault(x => x.Login == loginTextBox.Text);
            if (user == null) {
                MessageBox.Show("Niepoprawny login/hasło");
            }
            if(user.Haslo != hasloTextBox.Text)
            {
                MessageBox.Show("Niepoprawny login/hasło");
            }
            var glowneOkno = new MainForm();
            Hide();
            glowneOkno.Show();

        }

        private void anulujButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
