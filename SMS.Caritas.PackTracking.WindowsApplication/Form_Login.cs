using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMS.Caritas.PackTracking.WindowsApplication
{

    public partial class Form_Login : BaseForm
    {



        public Form_Login()
        {
            InitializeComponent();
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckKeys);
            lblMessaggio.Text = string.Empty;
        }

        private void CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                controllaPassword();
            }
        }

        private void btnAccedi_Click(object sender, EventArgs e)
        {

            controllaPassword();
        }


        private void controllaPassword()
        {
            User u = User.Instance; 

            if (txtPassword.Text.ToUpper().Equals(Costanti.UTENTE_GENERICO))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                u.CurrentUser = Costanti.UTENTE_GENERICO;
            }
            else if (txtPassword.Text.ToUpper().Equals(Costanti.UTENTE_AMMINISTRATORE))
	        {
                 this.DialogResult = System.Windows.Forms.DialogResult.OK;
                 u.CurrentUser = Costanti.UTENTE_AMMINISTRATORE;
	        }
            else
            {
                lblMessaggio.Text = "Attenzione la password inserita non è corretta.";
                this.DialogResult = System.Windows.Forms.DialogResult.No;
            }
        }

    }
}
