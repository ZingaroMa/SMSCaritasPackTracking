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
    public partial class Form_Main : BaseForm
    {


        public Form_Main()
        {
            InitializeComponent();
            ImpostaPagina();
        }

        private void btnNuovoAssistito_Click(object sender, EventArgs e)
        {
            try
            {
                Database.database.AddToAssistito(leggiDatiUIeCreaNuovoAssistito());
                Database.database.SaveChanges();
                ImpostaPagina();
                MessageBox.Show("Operazione avvenuta con successo", "Esito inserimento nuovo assistito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Esito inserimento nuovo assistito");
            }
        }

        private Assistito leggiDatiUIeCreaNuovoAssistito()
        {
            Assistito ass = new Assistito();
            ass.NumeroTessera = (int)System.Convert.ToInt32(txt_RA_NumeroTessera.Text);
            ass.Nome = txt_RA_Nome.Text;
            ass.Cognome = txt_RA_Cognome.Text;

            if (!(dt_RA_DataDiNascita.Format == DateTimePickerFormat.Custom))
            {
                ass.DataDiNascita = dt_RA_DataDiNascita.Value;
            }
            ass.ComuneDiNascita = txt_RA_ComuneDiNascita.Text;
            ass.Indirizzo = txt_RA_Indirizzo.Text;
            ass.CAP = txt_RA_CAP.Text;
            ass.ComponentiNucleoFamiliare = string.IsNullOrEmpty(txt_RA_ComponentiNucleoFamiliare.Text) ? null : (short?)System.Convert.ToInt16(txt_RA_ComponentiNucleoFamiliare.Text);
            ass.TelefonoAbitazione = txt_RA_TelefonoAbitazione.Text;
            ass.TelefonoCellulare = txt_RA_TelefonoCellulare.Text;
            ass.StatoDiProvenienza = txt_RA_StatoDiProvenienza.Text;
            if (!(dt_RA_DataConsegnaOlio.Format == DateTimePickerFormat.Custom))
            {
                ass.DataConsegnaOlio = dt_RA_DataConsegnaOlio.Value;
            }
            if (!(dt_RA_DataConsegnaCaffe.Format == DateTimePickerFormat.Custom))
            {
                ass.DataConsegnaCaffe = dt_RA_DataConsegnaCaffe.Value;
            }
            if (!(dt_RA_ScadenzaAssistenza.Format == DateTimePickerFormat.Custom))
            {
                ass.DataScadenzaAssistenza = dt_RA_ScadenzaAssistenza.Value;
            }
            ass.Note = txt_RA_Note.Text;
            return ass;
        }

        private void ImpostaPagina()
        {
            txt_RA_Nome.Text = string.Empty;
            txt_RA_Cognome.Text = string.Empty;
            txt_RA_NumeroTessera.Text = Database.database.Assistito.NextId(set => set.NumeroTessera).ToString();

            dt_RA_DataDiNascita.Value = DateTime.Now;
            dt_RA_DataDiNascita.Format = DateTimePickerFormat.Custom;
            dt_RA_DataDiNascita.CustomFormat = "---";

            dt_RA_DataConsegnaOlio.Value = DateTime.Now;
            dt_RA_DataConsegnaOlio.Format = DateTimePickerFormat.Custom;
            dt_RA_DataConsegnaOlio.CustomFormat = "---";

            dt_RA_DataConsegnaCaffe.Value = DateTime.Now;
            dt_RA_DataConsegnaCaffe.Format = DateTimePickerFormat.Custom;
            dt_RA_DataConsegnaCaffe.CustomFormat = "---";

            dt_RA_ScadenzaAssistenza.Value = DateTime.Now;
            dt_RA_ScadenzaAssistenza.Format = DateTimePickerFormat.Custom;
            dt_RA_ScadenzaAssistenza.CustomFormat = "---";

            txt_RA_ComuneDiNascita.Text = string.Empty;
            txt_RA_Indirizzo.Text = string.Empty;
            txt_RA_CAP.Text = string.Empty;
            txt_RA_ComponentiNucleoFamiliare.Text = string.Empty;
            txt_RA_TelefonoAbitazione.Text = string.Empty;
            txt_RA_TelefonoCellulare.Text = string.Empty;
            txt_RA_StatoDiProvenienza.Text = string.Empty;

            txt_RA_Note.Text = string.Empty;

            txt_CA_Cognome.Text = string.Empty;
            txt_CA_Nome.Text = string.Empty;
            txt_CA_Indirizzo.Text = string.Empty;
            txt_CA_NumeroTessera.Text = string.Empty;

            dg_CA_Assistiti.DataSource = null;


            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.MinimumSize = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void txtRicerca_Click(object sender, EventArgs e)
        {
            IQueryable<Assistito> AssistitiFiltrati = Database.database.Assistito;

            if (!string.IsNullOrEmpty(txt_RC_Nome.Text))
            {
                AssistitiFiltrati = AssistitiFiltrati.Where(set => set.Nome.Contains(txt_RC_Nome.Text));
            }

            if (!string.IsNullOrEmpty(txt_RC_Cognome.Text))
            {
                AssistitiFiltrati = AssistitiFiltrati.Where(set => set.Cognome.Contains(txt_RC_Cognome.Text));
            }

            if (!string.IsNullOrEmpty(txt_RC_NumeroTessera.Text))
            {
                int NumeroTessera = System.Convert.ToInt32(txt_RC_NumeroTessera.Text);
                AssistitiFiltrati = AssistitiFiltrati.Where(set => set.NumeroTessera.Equals(NumeroTessera));
            }

            if (!string.IsNullOrEmpty(txt_RC_Indirizzo.Text))
            {
                AssistitiFiltrati = AssistitiFiltrati.Where(set => set.Indirizzo.Contains(txt_RC_Indirizzo.Text));
            }

            dg_RC_Assistiti.DataSource = AssistitiFiltrati.OrderBy(set=> set.Cognome).ToList<Assistito>();
        }

        private void dgAssistiti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //l'evento dgAssistiti_CellContentClick scatta ogni volta che si clicca sulla riga.
                //Si controlla che effettivamente si è premuto il bottone presente nella colonna 4
                if (e.ColumnIndex == 4)
                {
                    DataGridViewRow riga = dg_RC_Assistiti.Rows[e.RowIndex];
                    int NumeroTesseraSelezionato = System.Convert.ToInt32(riga.Cells[0].Value);
                    Form_InserimentoRitiroPacco formInserimentoDataRitiro = new Form_InserimentoRitiroPacco();
                    formInserimentoDataRitiro.NumeroTessera = NumeroTesseraSelezionato;
                    if (formInserimentoDataRitiro.ShowDialog() == DialogResult.OK)
                    {
                        Assistito ass = Database.database.Assistito.Where(set => set.NumeroTessera.Equals(NumeroTesseraSelezionato)).First();
                        List<Ritiro> RitiriEffettuati = ass.Ritiro.ToList<Ritiro>();
                        Ritiro NuovoRitiro = new Ritiro
                        {
                            Id = Database.database.Ritiro.NextId(set => set.Id),
                            Data = formInserimentoDataRitiro.DataRitiro,
                            Note = formInserimentoDataRitiro.nota
                        };
                        ass.Ritiro.Add(NuovoRitiro);
                        Database.database.SaveChanges();
                        MessageBox.Show("Operazione avvenuta con successo", "Esito inserimento nuovo ritiro");
                    }

                }

             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Esito inserimento nuovo ritiro");
            }

        }

        private void btn_CA_Cerca_Click(object sender, EventArgs e)
        {
            IQueryable<Assistito> AssistitiFiltrati = Database.database.Assistito;

            if (!string.IsNullOrEmpty(txt_CA_Nome.Text))
            {
                AssistitiFiltrati = AssistitiFiltrati.Where(set => set.Nome.Contains(txt_CA_Nome.Text));
            }

            if (!string.IsNullOrEmpty(txt_CA_Cognome.Text))
            {
                AssistitiFiltrati = AssistitiFiltrati.Where(set => set.Cognome.Contains(txt_CA_Cognome.Text));
            }

            if (!string.IsNullOrEmpty(txt_CA_NumeroTessera.Text))
            {
                int NumeroTessera = System.Convert.ToInt32(txt_CA_NumeroTessera.Text);
                AssistitiFiltrati = AssistitiFiltrati.Where(set => set.NumeroTessera.Equals(NumeroTessera));
            }

            if (!string.IsNullOrEmpty(txt_CA_Indirizzo.Text))
            {
                AssistitiFiltrati = AssistitiFiltrati.Where(set => set.Indirizzo.Contains(txt_CA_Indirizzo.Text));
            }

            dg_CA_Assistiti.DataSource = AssistitiFiltrati.OrderBy(set => set.Cognome).ToList<Assistito>();
        }

        private void dg_CA_Assistiti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //l'evento dgAssistiti_CellContentClick scatta ogni volta che si clicca sulla riga.
                //Si controlla che effettivamente si è premuto il bottone presente nella colonna 4
                if (e.ColumnIndex == 4)
                {
                    DataGridViewRow riga = dg_CA_Assistiti.Rows[e.RowIndex];
                    int NumeroTesseraSelezionato = System.Convert.ToInt32(riga.Cells[0].Value);
                    Form_DettaglioAssistito formDettaglioAssistito = new Form_DettaglioAssistito(NumeroTesseraSelezionato);
                    formDettaglioAssistito.ShowDialog();
                    //Ripulisco i campi della ricerca e i risultati
                    ImpostaPagina();
                }

                //l'evento dgAssistiti_CellContentClick scatta ogni volta che si clicca sulla riga.
                //Si controlla che effettivamente si è premuto il bottone presente nella colonna 5 (Eliminazione Assistito)
                if (e.ColumnIndex == 5)
                {
                    DataGridViewRow riga = dg_CA_Assistiti.Rows[e.RowIndex];
                    int NumeroTesseraSelezionato = System.Convert.ToInt32(riga.Cells[0].Value);
                    string Cognome = riga.Cells[1].Value +"";
                    string msg = @"Sei sicuro di voler cancellare tutte le informazioni relative all'assistito\a " + Cognome + " ?";

                    DialogResult dialogResult = MessageBox.Show(msg, "Cancellazione", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        Assistito ass = Database.database.Assistito.Where(set => set.NumeroTessera.Equals(NumeroTesseraSelezionato)).First();

                        List<Ritiro> lstRiritoToDelete = ass.Ritiro.ToList<Ritiro>();

                        foreach (var rit in lstRiritoToDelete)
                        {
                            Database.database.Ritiro.DeleteObject(rit);
                        }

                        Database.database.Assistito.DeleteObject(ass);
                        Database.database.SaveChanges();
                        MessageBox.Show("Operazione avvenuta con successo");
                        btn_CA_Cerca_Click(sender, e);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRORE!");
            }
        }
        
        private void dt_RA_DataDiNascita_ValueChanged_1(object sender, EventArgs e)
        {
            if (dt_RA_DataDiNascita.Format == DateTimePickerFormat.Custom)
            {
                dt_RA_DataDiNascita.Format = DateTimePickerFormat.Short;
            }

        }

        private void dt_RA_DataConsegnaOlio_ValueChanged_1(object sender, EventArgs e)
        {
            if (dt_RA_DataConsegnaOlio.Format == DateTimePickerFormat.Custom)
            {
                dt_RA_DataConsegnaOlio.Format = DateTimePickerFormat.Short;
            }
        }

        private void dt_RA_ScadenzaAssistenza_ValueChanged_1(object sender, EventArgs e)
        {
            if (dt_RA_ScadenzaAssistenza.Format == DateTimePickerFormat.Custom)
            {
                dt_RA_ScadenzaAssistenza.Format = DateTimePickerFormat.Short;
            }
        }

        private void dt_RA_DataConsegnaCaffe_ValueChanged_1(object sender, EventArgs e)
        {
            if (dt_RA_DataConsegnaCaffe.Format == DateTimePickerFormat.Custom)
            {
                dt_RA_DataConsegnaCaffe.Format = DateTimePickerFormat.Short;
            }
        }

    }
}
