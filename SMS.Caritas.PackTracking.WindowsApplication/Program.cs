using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace SMS.Caritas.PackTracking.WindowsApplication
{
    static class Program
    {
        private static bool StateLogIn = true;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!System.Convert.ToBoolean(ConfigurationManager.AppSettings["IsAuthenticationRequired"]))
            {
                Application.Run(new Form_Main());
            }
            else
            {

                // login form
                Form_Login login = new Form_Login();

            PresentaMascheraLogin:
                // show login form first, force user to logged on system
                login.ShowDialog();
                if (StateLogIn)
                {
                    StateLogIn = false;
                    switch (login.DialogResult)
                    {
                        case DialogResult.Abort:
                            break;
                        case DialogResult.Cancel:
                            Application.Exit();
                            break;
                        case DialogResult.Ignore:
                            break;
                        case DialogResult.No:
                            StateLogIn = true;
                            goto PresentaMascheraLogin;

                        case DialogResult.None:
                            break;
                        case DialogResult.OK:
                            Application.Run(new Form_Main());
                            break;
                        case DialogResult.Retry:
                            break;
                        case DialogResult.Yes:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    if (login.DialogResult == DialogResult.OK)
                    {
                        (new Form_Main()).Visible = true;
                    }
                }
            }

        }
    }
}
