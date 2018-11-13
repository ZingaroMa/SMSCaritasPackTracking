using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMS.CaritasPackTracking.Model;

namespace SMS.Caritas.PackTracking.WindowsApplication
{
    public partial class Form_DettaglioAssistito : BaseForm
    {


        public Form_DettaglioAssistito(int numeroTessera)
        {
            InitializeComponent();
            ValorizzaCampi(Database.database.Assistito.Where(set => set.NumeroTessera.Equals(numeroTessera)).FirstOrDefault());
        }

        private void ValorizzaCampi(Assistito assistito)
        {
            txt_DA_Nome.Text = assistito.Nome;
            txt_DA_Cognome.Text = assistito.Cognome;
            txt_DA_NumeroTessera.Text = assistito.NumeroTessera.ToString();
            if (assistito.DataDiNascita != null)
            {
                dt_DA_DataDiNascita.Value = assistito.DataDiNascita.Value;
            }
            else
            {
                dt_DA_DataDiNascita.Format = DateTimePickerFormat.Custom;
                dt_DA_DataDiNascita.CustomFormat = "---";
            }
            txt_DA_ComuneDiNascita.Text = assistito.ComuneDiNascita;
            txt_DA_Indirizzo.Text = assistito.Indirizzo;
            txt_DA_CAP.Text = assistito.CAP;
            txt_DA_ComponentiNucleoFamiliare.Text = assistito.ComponentiNucleoFamiliare.ToString();
            txt_DA_TelefonoAbitazione.Text = assistito.TelefonoAbitazione;
            txt_DA_TelefonoCellulare.Text = assistito.TelefonoCellulare;
            txt_DA_StatoDiProvenienza.Text = assistito.StatoDiProvenienza;
            if (assistito.DataConsegnaOlio != null)
            {
                dt_DA_DataConsegnaOlio.Value = assistito.DataConsegnaOlio.Value;
            }
            else
            {
                dt_DA_DataConsegnaOlio.Format = DateTimePickerFormat.Custom;
                dt_DA_DataConsegnaOlio.CustomFormat = "---";
            }
            if (assistito.DataConsegnaCaffe != null)
            {
                dt_DA_DataConsegnaCaffe.Value = assistito.DataConsegnaCaffe.Value;
            }
            else
            {
                dt_DA_DataConsegnaCaffe.Format = DateTimePickerFormat.Custom;
                dt_DA_DataConsegnaCaffe.CustomFormat = "---";
            }
            if (assistito.DataScadenzaAssistenza != null)
            {
                dt_DA_ScadenzaAssistenza.Value = assistito.DataScadenzaAssistenza.Value;
            }
            else
            {
                dt_DA_ScadenzaAssistenza.Format = DateTimePickerFormat.Custom;
                dt_DA_ScadenzaAssistenza.CustomFormat = "---";

            }
            txt_DA_Note.Text = assistito.Note;
            this.dg_DA_ListaConsegne.DataSource=assistito.Ritiro.ToList<Ritiro>();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.MinimumSize = Screen.PrimaryScreen.WorkingArea.Size;
        }

        

        private void btn_DA_SalvaModifiche_Click(object sender, EventArgs e)
        {
            try
            {
                int NumeroTessera = System.Convert.ToInt32(txt_DA_NumeroTessera.Text);
                Assistito assistitoDaAggiornare = Database.database.Assistito.Where(set => set.NumeroTessera.Equals(NumeroTessera)).FirstOrDefault();

                assistitoDaAggiornare.Nome = txt_DA_Nome.Text;
                assistitoDaAggiornare.Cognome = txt_DA_Cognome.Text;
                if (!(dt_DA_DataDiNascita.Format == DateTimePickerFormat.Custom))
                {
                    assistitoDaAggiornare.DataDiNascita = dt_DA_DataDiNascita.Value;
                }
                assistitoDaAggiornare.ComuneDiNascita = txt_DA_ComuneDiNascita.Text;
                assistitoDaAggiornare.Indirizzo = txt_DA_Indirizzo.Text;
                assistitoDaAggiornare.CAP = txt_DA_CAP.Text;
                assistitoDaAggiornare.ComponentiNucleoFamiliare = string.IsNullOrEmpty(txt_DA_ComponentiNucleoFamiliare.Text) ? null : (short?)System.Convert.ToInt16(txt_DA_ComponentiNucleoFamiliare.Text);
                assistitoDaAggiornare.TelefonoAbitazione = txt_DA_TelefonoAbitazione.Text;
                assistitoDaAggiornare.TelefonoCellulare = txt_DA_TelefonoCellulare.Text;
                assistitoDaAggiornare.StatoDiProvenienza = txt_DA_StatoDiProvenienza.Text;
                if (!(dt_DA_DataConsegnaOlio.Format == DateTimePickerFormat.Custom))
                {
                    assistitoDaAggiornare.DataConsegnaOlio = dt_DA_DataConsegnaOlio.Value;
                }
                if (!(dt_DA_DataConsegnaCaffe.Format == DateTimePickerFormat.Custom))
                {
                    assistitoDaAggiornare.DataConsegnaCaffe = dt_DA_DataConsegnaCaffe.Value;
                }
                if (!(dt_DA_ScadenzaAssistenza.Format == DateTimePickerFormat.Custom))
                {
                    assistitoDaAggiornare.DataScadenzaAssistenza = dt_DA_ScadenzaAssistenza.Value;
                }
                assistitoDaAggiornare.Note = txt_DA_Note.Text;
                Database.database.SaveChanges();
                MessageBox.Show("Operazione avvenuta con successo", "Esito aggiornamento assisitito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Esito aggiornamento assisitito");
            }
        }

        private void dt_DA_DataDiNascita_ValueChanged(object sender, EventArgs e)
        {
            if (dt_DA_DataDiNascita.Format == DateTimePickerFormat.Custom)
            {
                dt_DA_DataDiNascita.Format = DateTimePickerFormat.Short;
            }

        }

        private void dt_DA_DataConsegnaOlio_ValueChanged(object sender, EventArgs e)
        {
            if (dt_DA_DataConsegnaOlio.Format == DateTimePickerFormat.Custom)
            {
                dt_DA_DataConsegnaOlio.Format = DateTimePickerFormat.Short;
            }
        }

        private void dt_DA_ScadenzaAssistenza_ValueChanged(object sender, EventArgs e)
        {
            if (dt_DA_ScadenzaAssistenza.Format == DateTimePickerFormat.Custom)
            {
                dt_DA_ScadenzaAssistenza.Format = DateTimePickerFormat.Short;
            }
        }

        private void dt_DA_DataConsegnaCaffe_ValueChanged(object sender, EventArgs e)
        {
            if (dt_DA_DataConsegnaCaffe.Format == DateTimePickerFormat.Custom)
            {
                dt_DA_DataConsegnaCaffe.Format = DateTimePickerFormat.Short;
            }
        }

        private void dg_DA_ListaConsegne_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //l'evento scatta ogni volta che si clicca sulla riga.
                //Si controlla che effettivamente si è premuto il bottone presente nella colonna 3
                if (e.ColumnIndex == 3)
                {
                    DataGridViewRow riga = dg_DA_ListaConsegne.Rows[e.RowIndex];
                    int IdRitiro = System.Convert.ToInt32(riga.Cells[0].Value);

                    Ritiro RitiroToDelete = Database.database.Ritiro.Where(ritiro => ritiro.Id.Equals(IdRitiro)).First();

                    Database.database.Ritiro.DeleteObject(RitiroToDelete);
                    Database.database.SaveChanges();
                    Database.database.AcceptAllChanges();
                    MessageBox.Show("Operazione avvenuta con successo", "Esito cancellazione consegna");
                   
                    //devo per forza chiudere la finestra altrimenti nn salva la cancellazione.....
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Esito cancellazione consegna");
            }

        }


        private void datasourcechanged(object sender, EventArgs e)
        {

        }
    }
}
