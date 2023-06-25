using KlinikaWeterynaryjna.Domain;
//using KlinikaWeterynaryjna.Models;
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
        private ZwierzetaZwlascicielami _zwierze;
        private readonly KlinikaWeterynaryjnaContext _dbContext = new KlinikaWeterynaryjnaContext();
        public AddEditAnimalDialog(ZwierzetaZwlascicielami zwierze = null)
        {
            InitializeComponent();
            PobierzWlascicieli();
            if (zwierze != null)
            {
                _zwierze = zwierze;
                animalInfo.Text = $"Edycja zwierzęcia: {zwierze.Nazwa}";
                nazwaTextBox.Text = zwierze.Nazwa;
                try
                {
                    gatunekComboBox.SelectedItem = zwierze.Gatunek;
                }
                catch(Exception ex)
                {

                    MessageBox.Show("Gatunek nie został odnaleziony");
                }
                
            }

        }
        void PobierzWlascicieli()
        {
            var wlasciciele = _dbContext.Wlasciciels;
            wlascicieleComboBox.DataSource = wlasciciele.Select(x => new
            {
                ImieNazwisko = $"{x.Imie} {x.Nazwisko}",
                IdWlasciciel = x.IdWlasciciel

            }).ToList();
            wlascicieleComboBox.DisplayMember = "ImieNazwisko";
            wlascicieleComboBox.ValueMember = "IdWlasciciel";
        }

        private void anulujButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nazwaTextBox.Text == "" || gatunekComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Nie wszystkie pola zostały poprawnie uzupełnione");
                return;
            }

            var dataOstWizyty = dataOstWIzytyDatePicker.Value;
            if (_zwierze == null)
            {
                var zwierzeToAdd = new Zwierze()
                {
                    Nazwa = nazwaTextBox.Text,
                    Gatunek = gatunekComboBox.Text,
                    DataOstWizyty = dataOstWizyty,
                    IdWlasciciel = (int)wlascicieleComboBox.SelectedValue

                };
                _dbContext.Zwierzes.Add(zwierzeToAdd);
            }
            else
            {
                var zwierzeToUpdate = _dbContext.Zwierzes.FirstOrDefault(x => x.IdZwierze == _zwierze.IdZwierze);
                if(zwierzeToUpdate == null)
                {
                    MessageBox.Show("Zwierze do aktualizacji nie zostało znalezione w bazie danych");
                }
                zwierzeToUpdate.Nazwa = nazwaTextBox.Text;
                zwierzeToUpdate.Gatunek = gatunekComboBox.Text;
                zwierzeToUpdate.DataOstWizyty = dataOstWizyty;
                zwierzeToUpdate.IdWlasciciel = (int)wlascicieleComboBox.SelectedValue;
                _dbContext.Zwierzes.Update(zwierzeToUpdate);
            }
            _dbContext.SaveChanges();
            Close();
        }
    }
}
