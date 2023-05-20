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

    }
}
