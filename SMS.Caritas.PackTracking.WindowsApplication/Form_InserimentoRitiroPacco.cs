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
    public partial class Form_InserimentoRitiroPacco : BaseForm
    {
        public DateTime DataRitiro
        {
            get 
            {
                DateTime dt = new DateTime(dtRitiro.Value.Year,dtRitiro.Value.Month,dtRitiro.Value.Day);
                return dt; 
            }
        }

        public string nota
        {
            get { return txtNotaRitiroPacco.Text; }
        }

        public int NumeroTessera
        {
            get;
            set;
        }

        public Form_InserimentoRitiroPacco()
        {
            InitializeComponent();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            List<Ritiro> lstRitiro = Database.database.Ritiro
                .Where((set => set.Assistito.NumeroTessera.Equals(NumeroTessera)))
                .ToList<Ritiro>();


            if (lstRitiro.Where(set => set.Data.Equals(DataRitiro)).FirstOrDefault() == null)
            {
                lblErrore.Visible = false;
                this.DialogResult= DialogResult.OK;
                Close();
            }
            else
            {
                lblErrore.Visible = true;

            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
