//using KlinikaWeterynaryjna.Models;
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
    public partial class MainForm : Form
    {
        private readonly KlinikaWeterynaryjnaContext _dbContext = new KlinikaWeterynaryjnaContext();
        public MainForm()
        {
            InitializeComponent();
            PobierzDane();
        }
        private void PobierzDane()
        {
            var data = _dbContext.ZwierzetaZwlascicielamis;

            zwierzetaGrid.DataSource = data.ToList();
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
                var zwierze = selectedRows[0].DataBoundItem as ZwierzetaZwlascicielami;
                var zwierzeDoUsuniecia = _dbContext.Zwierzes.FirstOrDefault(x => x.IdZwierze == zwierze.IdZwierze);
                if (zwierzeDoUsuniecia == null)
                {
                    MessageBox.Show("Zwierze nie zostało zaznaczone");
                }
                _dbContext.Zwierzes.Remove(zwierzeDoUsuniecia);
                _dbContext.SaveChanges();
                PobierzDane();
            }
        }

        private void edytujButton_Click(object sender, EventArgs e)
        {
            var selectedRows = zwierzetaGrid.SelectedRows;
            if (selectedRows.Count != 1)
            {
                MessageBox.Show("Musisz zaznaczyć jeden wiersz");
            }
            else
            {
                var zwierze = selectedRows[0].DataBoundItem as ZwierzetaZwlascicielami;
                var okno = new AddEditAnimalDialog(zwierze);
                okno.ShowDialog();
                PobierzDane();
            }
        }
    }
}
