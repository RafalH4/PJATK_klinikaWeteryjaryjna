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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PobierzDane();
        }
        private void PobierzDane()
        {
            using SqlConnection con = new SqlConnection(Constants.ConnectionString);
            SqlCommand com = new SqlCommand();
            var sql = "select * from ZwierzetaZWlascicielami";
            com.Connection = con;
            com.CommandText = sql;
            con.Open();

            SqlDataReader dr = com.ExecuteReader();
            var zwierzeta = new List<Zwierze>();

            while (dr.Read() == true)
            {
                zwierzeta.Add(new Zwierze()
                {
                    IdZwierze = (int)dr["IdZwierze"],
                    Nazwa = dr["Nazwa"].ToString(),
                    Gatunek = dr["Gatunek"].ToString(),
                    DataOstWizyty = DateTime.Parse(dr["DataOstwizyty"].ToString()),
                    IdWlasciciel = (int)dr["IdWlasciciel"],
                    ImieWlasciciela = dr["Imie"].ToString(),
                    NazwiskoWlasciciela = dr["Nazwisko"].ToString()
                });
            }
            zwierzetaGrid.DataSource = zwierzeta;
            con.Dispose();

        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            var okno = new AddEditAnimalDialog();
            okno.ShowDialog();
            PobierzDane();
        }

        private void usunButton_Click(object sender, EventArgs e)
        {
            var selectedRows = zwierzetaGrid.SelectedRows;
            if (selectedRows.Count != 1)
            {
                MessageBox.Show("Musisz zaznaczyć jeden wiersz");
            }
            else
            {
                var zwierze = selectedRows[0].DataBoundItem as Zwierze;
                using SqlConnection con = new SqlConnection(Constants.ConnectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "delete from Zwierze where IdZwierze = @IdZwierze";
                com.Parameters.AddWithValue("@IdZwierze", zwierze.IdZwierze);
                con.Open();
                com.ExecuteNonQuery();
                PobierzDane();
            }
        }
    }
}
