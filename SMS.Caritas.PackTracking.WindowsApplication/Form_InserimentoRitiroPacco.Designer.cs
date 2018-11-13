namespace SMS.Caritas.PackTracking.WindowsApplication
{
    partial class Form_InserimentoRitiroPacco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConferma = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.lblDataRitiro = new System.Windows.Forms.Label();
            this.dtRitiro = new System.Windows.Forms.DateTimePicker();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNotaRitiroPacco = new System.Windows.Forms.TextBox();
            this.lblErrore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(237, 224);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 3;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnulla.Location = new System.Drawing.Point(344, 224);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulla.TabIndex = 4;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // lblDataRitiro
            // 
            this.lblDataRitiro.AutoSize = true;
            this.lblDataRitiro.Location = new System.Drawing.Point(27, 41);
            this.lblDataRitiro.Name = "lblDataRitiro";
            this.lblDataRitiro.Size = new System.Drawing.Size(60, 13);
            this.lblDataRitiro.TabIndex = 3;
            this.lblDataRitiro.Text = "Data Ritiro:";
            // 
            // dtRitiro
            // 
            this.dtRitiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRitiro.Location = new System.Drawing.Point(106, 34);
            this.dtRitiro.Name = "dtRitiro";
            this.dtRitiro.Size = new System.Drawing.Size(106, 20);
            this.dtRitiro.TabIndex = 1;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(27, 96);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(33, 13);
            this.lblNote.TabIndex = 5;
            this.lblNote.Text = "Note:";
            // 
            // txtNotaRitiroPacco
            // 
            this.txtNotaRitiroPacco.Location = new System.Drawing.Point(106, 89);
            this.txtNotaRitiroPacco.Multiline = true;
            this.txtNotaRitiroPacco.Name = "txtNotaRitiroPacco";
            this.txtNotaRitiroPacco.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotaRitiroPacco.Size = new System.Drawing.Size(522, 90);
            this.txtNotaRitiroPacco.TabIndex = 2;
            // 
            // lblErrore
            // 
            this.lblErrore.AutoSize = true;
            this.lblErrore.ForeColor = System.Drawing.Color.Red;
            this.lblErrore.Location = new System.Drawing.Point(327, 34);
            this.lblErrore.Name = "lblErrore";
            this.lblErrore.Size = new System.Drawing.Size(181, 13);
            this.lblErrore.TabIndex = 7;
            this.lblErrore.Text = "Già presente un ritiro per questa data";
            this.lblErrore.Visible = false;
            // 
            // Form_InserimentoRitiroPacco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 276);
            this.Controls.Add(this.lblErrore);
            this.Controls.Add(this.txtNotaRitiroPacco);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.dtRitiro);
            this.Controls.Add(this.lblDataRitiro);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnConferma);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(670, 314);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(670, 314);
            this.Name = "Form_InserimentoRitiroPacco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserimento Data Ritiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Label lblDataRitiro;
        private System.Windows.Forms.DateTimePicker dtRitiro;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNotaRitiroPacco;
        private System.Windows.Forms.Label lblErrore;
    }
}