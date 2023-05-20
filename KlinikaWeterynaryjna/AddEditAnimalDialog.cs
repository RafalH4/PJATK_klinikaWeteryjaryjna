using KlinikaWeterynaryjna.Models;
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
    public partial class AddEditAnimalDialog : Form
    {
        private Zwierze _zwierze;
        public AddEditAnimalDialog(Zwierze zwierze = null)
        {
            InitializeComponent();
            PobierzWlascicieli();
            if (zwierze != null)
            {
                _zwierze = zwierze;
                animalInfo.Text = $"Edycja zwierzęcia: {zwierze.Nazwa}";
                nazwaTextBox.Text = zwierze.Nazwa;
                gatunekTextBox.Text = zwierze.Gatunek;
            }

        }
        void PobierzWlascicieli()
        {
            using SqlConnection con = new SqlConnection(Constants.ConnectionString);
            SqlCommand com = new SqlCommand();
            var sql = "select * from Wlasciciel";
            com.Connection = con;
            com.CommandText = sql;
            con.Open();

            SqlDataReader dr = com.ExecuteReader();
            var wlasciciele = new List<Wlasciciel>();

            while (dr.Read() == true)
            {
                wlasciciele.Add(new Wlasciciel()
                {
                    IdWlasciciel = (int)dr["IdWlasciciel"],
                    Imie = dr["Imie"].ToString(),
                    Nazwisko = dr["Nazwisko"].ToString(),
                });
            }
            wlascicieleComboBox.DataSource = wlasciciele;
            wlascicieleComboBox.DisplayMember = "ImieNazwisko";
            wlascicieleComboBox.ValueMember = "IdWlasciciel";
            con.Dispose();
        }

        private void anulujButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nazwaTextBox.Text == "" || gatunekTextBox.Text == "")
            {
                MessageBox.Show("Nie wszystkie pola zostały uzupełnione");
                return;
            }
            var dataOstWizyty = dataOstWIzytyDatePicker.Value;
            var con = new SqlConnection(Constants.ConnectionString);
            var com = new SqlCommand();
            com.Connection = con;

            if (_zwierze == null)
            {
                com.CommandText = "insert into Zwierze(Nazwa, Gatunek, DataOstWizyty, IdWlasciciel) values (@nazwa, @gatunek, @dataOstWizyty, @wlascicielId)";
            }
            else
            {
                com.CommandText = "Update Zwierze " +
                    "Set nazwa = @nazwa" +
                    ",gatunek = @gatunek" +
                    ",dataOstWizyty = @dataOstWizyty," +
                    "idWlasciciel = @wlascicielId where IdZwierze = @idZwierze";
                com.Parameters.AddWithValue("@idPracownik", _zwierze.IdZwierze);
            }

            com.Parameters.AddWithValue("@nazwa", nazwaTextBox.Text);
            com.Parameters.AddWithValue("@gatunek", gatunekTextBox.Text);
            com.Parameters.AddWithValue("@dataOstWizyty", dataOstWizyty);
            com.Parameters.AddWithValue("@wlascicielId", (int)wlascicieleComboBox.SelectedValue);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            Close();
        }
    }
}
