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
            SqlConnection con = new SqlConnection(Constants.ConnectionString);
            SqlCommand com = new SqlCommand();
            var sql = "select * from uzytkownik where login = @login and haslo = @haslo";
            com.Connection = con;
            com.CommandText = sql;
            com.Parameters.AddWithValue("@login", loginTextBox.Text);
            com.Parameters.AddWithValue("@haslo", hasloTextBox.Text);

            con.Open();
            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {
                string login = dr["Login"].ToString();
                var glowneOkno = new MainForm();
                Hide();
                glowneOkno.Show();
            }
            else
            {
                MessageBox.Show("Niepoprawny login/hasło");
            }

            //5. Zamknięcie połączenia
            con.Dispose();
        }

        private void anulujButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
