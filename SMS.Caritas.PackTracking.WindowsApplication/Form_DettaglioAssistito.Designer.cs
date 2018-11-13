namespace SMS.Caritas.PackTracking.WindowsApplication
{
    partial class Form_DettaglioAssistito
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_DA_Anagrafica = new System.Windows.Forms.GroupBox();
            this.txt_DA_StatoDiProvenienza = new System.Windows.Forms.TextBox();
            this.lbl_DA_StatoDiProvenienza = new System.Windows.Forms.Label();
            this.dt_DA_DataDiNascita = new System.Windows.Forms.DateTimePicker();
            this.lbl_DA_DataDiNascita = new System.Windows.Forms.Label();
            this.txt_DA_ComuneDiNascita = new System.Windows.Forms.TextBox();
            this.lbl_DA_ComuneDiNascita = new System.Windows.Forms.Label();
            this.txt_DA_Cognome = new System.Windows.Forms.TextBox();
            this.lbl_DA_Nome = new System.Windows.Forms.Label();
            this.txt_DA_Nome = new System.Windows.Forms.TextBox();
            this.lbl_DA_Cognome = new System.Windows.Forms.Label();
            this.gb_DA_Recapiti = new System.Windows.Forms.GroupBox();
            this.lbl_DA_TelefonoAbitazione = new System.Windows.Forms.Label();
            this.lbl_DA_CAP = new System.Windows.Forms.Label();
            this.txt_DA_CAP = new System.Windows.Forms.TextBox();
            this.txt_DA_TelefonoCellulare = new System.Windows.Forms.TextBox();
            this.txt_DA_TelefonoAbitazione = new System.Windows.Forms.TextBox();
            this.lbl_DA_TelefonoCellulare = new System.Windows.Forms.Label();
            this.txt_DA_Indirizzo = new System.Windows.Forms.TextBox();
            this.lbl_DA_Indirizzo = new System.Windows.Forms.Label();
            this.gb_DA_UlteriotiDati = new System.Windows.Forms.GroupBox();
            this.dt_DA_ScadenzaAssistenza = new System.Windows.Forms.DateTimePicker();
            this.lbl_DA_DataScadenzaAssistenza = new System.Windows.Forms.Label();
            this.dt_DA_DataConsegnaCaffe = new System.Windows.Forms.DateTimePicker();
            this.lbl_DA_Caffe = new System.Windows.Forms.Label();
            this.dt_DA_DataConsegnaOlio = new System.Windows.Forms.DateTimePicker();
            this.txt_DA_ComponentiNucleoFamiliare = new System.Windows.Forms.TextBox();
            this.lbl_DA_Olio = new System.Windows.Forms.Label();
            this.lbl_DA_ComponentiNucleoFamiliare = new System.Windows.Forms.Label();
            this.txt_DA_Note = new System.Windows.Forms.TextBox();
            this.lbl_DA_Note = new System.Windows.Forms.Label();
            this.txt_DA_NumeroTessera = new System.Windows.Forms.TextBox();
            this.lbl_DA_NumeroTessera = new System.Windows.Forms.Label();
            this.btn_DA_SalvaModifiche = new System.Windows.Forms.Button();
            this.tabDettaglioanagrafica = new System.Windows.Forms.TabControl();
            this.tbDettaglioAssistito = new System.Windows.Forms.TabPage();
            this.tbDettaglioConsegne = new System.Windows.Forms.TabPage();
            this.dg_DA_ListaConsegne = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EliminaConsegna = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ritiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.gb_DA_Anagrafica.SuspendLayout();
            this.gb_DA_Recapiti.SuspendLayout();
            this.gb_DA_UlteriotiDati.SuspendLayout();
            this.tabDettaglioanagrafica.SuspendLayout();
            this.tbDettaglioAssistito.SuspendLayout();
            this.tbDettaglioConsegne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DA_ListaConsegne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritiroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_DA_Anagrafica
            // 
            this.gb_DA_Anagrafica.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gb_DA_Anagrafica.Controls.Add(this.txt_DA_StatoDiProvenienza);
            this.gb_DA_Anagrafica.Controls.Add(this.lbl_DA_StatoDiProvenienza);
            this.gb_DA_Anagrafica.Controls.Add(this.dt_DA_DataDiNascita);
            this.gb_DA_Anagrafica.Controls.Add(this.lbl_DA_DataDiNascita);
            this.gb_DA_Anagrafica.Controls.Add(this.txt_DA_ComuneDiNascita);
            this.gb_DA_Anagrafica.Controls.Add(this.lbl_DA_ComuneDiNascita);
            this.gb_DA_Anagrafica.Controls.Add(this.txt_DA_Cognome);
            this.gb_DA_Anagrafica.Controls.Add(this.lbl_DA_Nome);
            this.gb_DA_Anagrafica.Controls.Add(this.txt_DA_Nome);
            this.gb_DA_Anagrafica.Controls.Add(this.lbl_DA_Cognome);
            this.gb_DA_Anagrafica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DA_Anagrafica.Location = new System.Drawing.Point(16, 15);
            this.gb_DA_Anagrafica.Name = "gb_DA_Anagrafica";
            this.gb_DA_Anagrafica.Size = new System.Drawing.Size(493, 231);
            this.gb_DA_Anagrafica.TabIndex = 1000;
            this.gb_DA_Anagrafica.TabStop = false;
            this.gb_DA_Anagrafica.Text = "Anagrafica ";
            // 
            // txt_DA_StatoDiProvenienza
            // 
            this.txt_DA_StatoDiProvenienza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DA_StatoDiProvenienza.Location = new System.Drawing.Point(139, 146);
            this.txt_DA_StatoDiProvenienza.Name = "txt_DA_StatoDiProvenienza";
            this.txt_DA_StatoDiProvenienza.Size = new System.Drawing.Size(281, 26);
            this.txt_DA_StatoDiProvenienza.TabIndex = 4;
            // 
            // lbl_DA_StatoDiProvenienza
            // 
            this.lbl_DA_StatoDiProvenienza.AutoSize = true;
            this.lbl_DA_StatoDiProvenienza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DA_StatoDiProvenienza.Location = new System.Drawing.Point(6, 157);
            this.lbl_DA_StatoDiProvenienza.Name = "lbl_DA_StatoDiProvenienza";
            this.lbl_DA_StatoDiProvenienza.Size = new System.Drawing.Size(122, 15);
            this.lbl_DA_StatoDiProvenienza.TabIndex = 23;
            this.lbl_DA_StatoDiProvenienza.Text = "Stato di Provenienza:";
            // 
            // dt_DA_DataDiNascita
            // 
            this.dt_DA_DataDiNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_DA_DataDiNascita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_DA_DataDiNascita.Location = new System.Drawing.Point(139, 187);
            this.dt_DA_DataDiNascita.Name = "dt_DA_DataDiNascita";
            this.dt_DA_DataDiNascita.Size = new System.Drawing.Size(192, 26);
            this.dt_DA_DataDiNascita.TabIndex = 5;
            this.dt_DA_DataDiNascita.Value = new System.DateTime(2012, 4, 25, 0, 0, 0, 0);
            this.dt_DA_DataDiNascita.ValueChanged += new System.EventHandler(this.dt_DA_DataDiNascita_ValueChanged);
            // 
            // lbl_DA_DataDiNascita
            // 
            this.lbl_DA_DataDiNascita.AutoSize = true;
            this.lbl_DA_DataDiNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DA_DataDiNascita.Location = new System.Drawing.Point(6, 198);
            this.lbl_DA_DataDiNascita.Name = "lbl_DA_DataDiNascita";
            this.lbl_DA_DataDiNascita.Size = new System.Drawing.Size(91, 15);
            this.lbl_DA_DataDiNascita.TabIndex = 10;
            this.lbl_DA_DataDiNascita.Text = "Data di nascita:";
            // 
            // txt_DA_ComuneDiNascita
            // 
            this.txt_DA_ComuneDiNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DA_ComuneDiNascita.Location = new System.Drawing.Point(139, 104);
            this.txt_DA_ComuneDiNascita.Name = "txt_DA_ComuneDiNascita";
            this.txt_DA_ComuneDiNascita.Size = new System.Drawing.Size(281, 26);
            this.txt_DA_ComuneDiNascita.TabIndex = 3;
            // 
            // lbl_DA_ComuneDiNascita
            // 
            this.lbl_DA_ComuneDiNascita.AutoSize = true;
            this.lbl_DA_ComuneDiNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DA_ComuneDiNascita.Location = new System.Drawing.Point(6, 115);
            this.lbl_DA_ComuneDiNascita.Name = "lbl_DA_ComuneDiNascita";
            this.lbl_DA_ComuneDiNascita.Size = new System.Drawing.Size(112, 15);
            this.lbl_DA_ComuneDiNascita.TabIndex = 8;
            this.lbl_DA_ComuneDiNascita.Text = "Comune di nascita:";
            // 
            // txt_DA_Cognome
            // 
            this.txt_DA_Cognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DA_Cognome.Location = new System.Drawing.Point(139, 25);
            this.txt_DA_Cognome.Name = "txt_DA_Cognome";
            this.txt_DA_Cognome.Size = new System.Drawing.Size(281, 26);
            this.txt_DA_Cognome.TabIndex = 1;
            // 
            // lbl_DA_Nome
            // 
            this.lbl_DA_Nome.AutoSize = true;
            this.lbl_DA_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DA_Nome.Location = new System.Drawing.Point(6, 76);
            this.lbl_DA_Nome.Name = "lbl_DA_Nome";
            this.lbl_DA_Nome.Size = new System.Drawing.Size(44, 15);
            this.lbl_DA_Nome.TabIndex = 2;
            this.lbl_DA_Nome.Text = "Nome:";
            // 
            // txt_DA_Nome
            // 
            this.txt_DA_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DA_Nome.Location = new System.Drawing.Point(139, 65);
            this.txt_DA_Nome.Multiline = true;
            this.txt_DA_Nome.Name = "txt_DA_Nome";
            this.txt_DA_Nome.Size = new System.Drawing.Size(281, 26);
            this.txt_DA_Nome.TabIndex = 2;
            // 
            // lbl_DA_Cognome
            // 
            this.lbl_DA_Cognome.AutoSize = true;
            this.lbl_DA_Cognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DA_Cognome.Location = new System.Drawing.Point(6, 36);
            this.lbl_DA_Cognome.Name = "lbl_DA_Cognome";
            this.lbl_DA_Cognome.Size = new System.Drawing.Size(64, 15);
            this.lbl_DA_Cognome.TabIndex = 4;
            this.lbl_DA_Cognome.Text = "Cognome:";
            // 
            // gb_DA_Recapiti
            // 
            this.gb_DA_Recapiti.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gb_DA_Recapiti.Controls.Add(this.lbl_DA_TelefonoAbitazione);
            this.gb_DA_Recapiti.Controls.Add(this.lbl_DA_CAP);
            this.gb_DA_Recapiti.Controls.Add(this.txt_DA_CAP);
            this.gb_DA_Recapiti.Controls.Add(this.txt_DA_TelefonoCellulare);
            this.gb_DA_Recapiti.Controls.Add(this.txt_DA_TelefonoAbitazione);
            this.gb_DA_Recapiti.Controls.Add(this.lbl_DA_TelefonoCellulare);
            this.gb_DA_Recapiti.Controls.Add(this.txt_DA_Indirizzo);
            this.gb_DA_Recapiti.Controls.Add(this.lbl_DA_Indirizzo);
            this.gb_DA_Recapiti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DA_Recapiti.Location = new System.Drawing.Point(515, 15);
            this.gb_DA_Recapiti.Name = "gb_DA_Recapiti";
            this.gb_DA_Recapiti.Size = new System.Drawing.Size(469, 231);
            this.gb_DA_Recapiti.TabIndex = 1001;
            this.gb_DA_Recapiti.TabStop = false;
            this.gb_DA_Recapiti.Text = "Recapiti";
            // 
            // lbl_DA_TelefonoAbitazione
            // 
            this.lbl_DA_TelefonoAbitazione.AutoSize = true;
            this.lbl_DA_TelefonoAbitazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DA_TelefonoAbitazione.Location = new System.Drawing.Point(18, 45);
            this.lbl_DA_TelefonoAbitazione.Name = "lbl_DA_TelefonoAbitazione";
            this.lbl_DA_TelefonoAbitazione.Size = new System.Drawing.Size(118, 15);
            this.lbl_DA_TelefonoAbitazione.TabIndex = 18;
            this.lbl_DA_TelefonoAbitazione.Text = "Telefono abitazione:";
            // 
            // lbl_DA_CAP
            // 
            this.lbl_DA_CAP.AutoSize = true;
            this.lbl_DA_CAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DA_CAP.Location = new System.Drawing.Point(18, 120);
            this.lbl_DA_CAP.Name = "lbl_DA_CAP";
            this.lbl_DA_CAP.Size = new System.Drawing.Size(33, 15);
            this.lbl_DA_CAP.TabIndex = 14;
            this.lbl_DA_CAP.Text = "CAP:";
            // 
            // txt_DA_CAP
            // 
            this.txt_DA_CAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DA_CAP.Location = new System.Drawing.Point(155, 109);
            this.txt_DA_CAP.Name = "txt_DA_CAP";
            this.txt_DA_CAP.Size = new System.Drawing.Size(118, 26);
            this.txt_DA_CAP.TabIndex = 8;
            // 
            // txt_DA_TelefonoCellulare
            // 
            this.txt_DA_TelefonoCellulare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DA_TelefonoCellulare.Location = new System.Drawing.Point(155, 70);
            this.txt_DA_TelefonoCellulare.Name = "txt_DA_TelefonoCellulare";
            this.txt_DA_TelefonoCellulare.Size = new System.Drawing.Size(118, 26);
            this.txt_DA_TelefonoCellulare.TabIndex = 7;
            // 
            // txt_DA_TelefonoAbitazione
            // 
            this.txt_DA_TelefonoAbitazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DA_TelefonoAbitazione.Location = new System.Drawing.Point(155, 34);
            this.txt_DA_TelefonoAbitazione.Name = "txt_DA_TelefonoAbitazione";
            this.txt_DA_TelefonoAbitazione.Size = new System.Drawing.Size(118, 26);
            this.txt_DA_TelefonoAbitazione.TabIndex = 6;
            // 
            // lbl_DA_TelefonoCellulare
            // 
            this.lbl_DA_TelefonoCellulare.AutoSize = true;
            this.lbl_DA_TelefonoCellulare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DA_TelefonoCellulare.Location = new System.Drawing.Point(18, 81);
            this.lbl_DA_TelefonoCellulare.Name = "lbl_DA_TelefonoCellulare";
            this.lbl_DA_TelefonoCellulare.Size = new System.Drawing.Size(108, 15);
            this.lbl_DA_TelefonoCellulare.TabIndex = 20;
            this.lbl_DA_TelefonoCellulare.Text = "Telefono cellulare:";
            // 
            // txt_DA_Indirizzo
            // 
            this.txt_DA_Indirizzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DA_Indirizzo.Location = new System.Drawing.Point(155, 151);
            this.txt_DA_Indirizzo.Name = "txt_DA_Indirizzo";
            this.txt_DA_Indirizzo.Size = new System.Drawing.Size(281, 26);
            this.txt_DA_Indirizzo.TabIndex = 9;
            // 
            // lbl_DA_Indirizzo
            // 
            this.lbl_DA_Indirizzo.AutoSize = true;
            this.lbl_DA_Indirizzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DA_Indirizzo.Location = new System.Drawing.Point(18, 162);
            this.lbl_DA_Indirizzo.Name = "lbl_DA_Indirizzo";
            this.lbl_DA_Indirizzo.Size = new System.Drawing.Size(56, 15);
            this.lbl_DA_Indirizzo.TabIndex = 12;
            this.lbl_DA_Indirizzo.Text = "Indirizzo:";
            // 
            // gb_DA_UlteriotiDati
            // 
            this.gb_DA_UlteriotiDati.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gb_DA_UlteriotiDati.Controls.Add(this.dt_DA_ScadenzaAssistenza);
            this.gb_DA_UlteriotiDati.Controls.Add(this.lbl_DA_DataScadenzaAssistenza);
            this.gb_DA_UlteriotiDati.Controls.Add(this.dt_DA_DataConsegnaCaffe);
            this.gb_DA_UlteriotiDati.Controls.Add(this.lbl_DA_Caffe);
            this.gb_DA_UlteriotiDati.Controls.Add(this.dt_DA_DataConsegnaOlio);
            this.gb_DA_UlteriotiDati.Controls.Add(this.txt_DA_ComponentiNucleoFamiliare);
            this.gb_DA_UlteriotiDati.Controls.Add(this.lbl_DA_Olio);
            this.gb_DA_UlteriotiDati.Controls.Add(this.lbl_DA_ComponentiNucleoFamiliare);
            this.gb_DA_UlteriotiDati.Controls.Add(this.txt_DA_Note);
            this.gb_DA_UlteriotiDati.Controls.Add(this.lbl_DA_Note);
            this.gb_DA_UlteriotiDati.Controls.Add(this.txt_DA_NumeroTessera);
            this.gb_DA_UlteriotiDati.Controls.Add(this.lbl_DA_NumeroTessera);
            this.gb_DA_UlteriotiDati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DA_UlteriotiDati.Location = new System.Drawing.Point(16, 252);
            this.gb_DA_UlteriotiDati.Name = "gb_DA_UlteriotiDati";
            this.gb_DA_UlteriotiDati.Size = new System.Drawing.Size(959, 250);
            this.gb_DA_UlteriotiDati.TabIndex = 1004;
            this.gb_DA_UlteriotiDati.TabStop = false;
            this.gb_DA_UlteriotiDati.Text = "Ulteriori Dati";
            // 
            // dt_DA_ScadenzaAssistenza
            // 
            this.dt_DA_ScadenzaAssistenza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_DA_ScadenzaAssistenza.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_DA_ScadenzaAssistenza.Location = new System.Drawing.Point(544, 29);
            this.dt_DA_ScadenzaAssistenza.Name = "dt_DA_ScadenzaAssistenza";
            this.dt_DA_ScadenzaAssistenza.Size = new System.Drawing.Size(125, 26);
            this.dt_DA_ScadenzaAssistenza.TabIndex = 11;
            this.dt_DA_ScadenzaAssistenza.Value = new System.DateTime(2012, 4, 25, 0, 0, 0, 0);
            this.dt_DA_ScadenzaAssistenza.ValueChanged += new System.EventHandler(this.dt_DA_ScadenzaAssistenza_ValueChanged);
            // 
            // lbl_DA_DataScadenzaAssistenza
            // 
            this.lbl_DA_DataScadenzaAssistenza.AutoSize = true;
            this.lbl_DA_DataScadenzaAssistenza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DA_DataScadenzaAssistenza.Location = new System.Drawing.Point(385, 40);
            this.lbl_DA_DataScadenzaAssistenza.Name = "lbl_DA_DataScadenzaAssistenza";
            this.lbl_DA_DataScadenzaAssistenza.Size = new System.Drawing.Size(153, 15);
            this.lbl_DA_DataScadenzaAssistenza.TabIndex = 28;
            this.lbl_DA_DataScadenzaAssistenza.Text = "Data scadenza assistenza:";
            // 
            // dt_DA_DataConsegnaCaffe
            // 
            this.dt_DA_DataConsegnaCaffe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_DA_DataConsegnaCaffe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_DA_DataConsegnaCaffe.Location = new System.Drawing.Point(544, 97);
            this.dt_DA_DataConsegnaCaffe.Name = "dt_DA_DataConsegnaCaffe";
            this.dt_DA_DataConsegnaCaffe.Size = new System.Drawing.Size(125, 26);
            this.dt_DA_DataConsegnaCaffe.TabIndex = 13;
            this.dt_DA_DataConsegnaCaffe.ValueChanged += new System.EventHandler(this.dt_DA_DataConsegnaCaffe_ValueChanged);
            // 
            // lbl_DA_Caffe
            // 
            this.lbl_DA_Caffe.AutoSize = true;
            this.lbl_DA_Caffe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DA_Caffe.Location = new System.Drawing.Point(385, 106);
            this.lbl_DA_Caffe.Name = "lbl_DA_Caffe";
            this.lbl_DA_Caffe.Size = new System.Drawing.Size(122, 15);
            this.lbl_DA_Caffe.TabIndex = 26;
            this.lbl_DA_Caffe.Text = "Data consegna caffè:";
            // 
            // dt_DA_DataConsegnaOlio
            // 
            this.dt_DA_DataConsegnaOlio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_DA_DataConsegnaOlio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_DA_DataConsegnaOlio.Location = new System.Drawing.Point(139, 99);
            this.dt_DA_DataConsegnaOlio.Name = "dt_DA_DataConsegnaOlio";
            this.dt_DA_DataConsegnaOlio.Size = new System.Drawing.Size(125, 26);
            this.dt_DA_DataConsegnaOlio.TabIndex = 10;
            this.dt_DA_DataConsegnaOlio.ValueChanged += new System.EventHandler(this.dt_DA_DataConsegnaOlio_ValueChanged);
            // 
            // txt_DA_ComponentiNucleoFamiliare
            // 
            this.txt_DA_ComponentiNucleoFamiliare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_DA_ComponentiNucleoFamiliare.Location = new System.Drawing.Point(873, 28);
            this.txt_DA_ComponentiNucleoFamiliare.Name = "txt_DA_ComponentiNucleoFamiliare";
            this.txt_DA_ComponentiNucleoFamiliare.Size = new System.Drawing.Size(62, 26);
            this.txt_DA_ComponentiNucleoFamiliare.TabIndex = 12;
            // 
            // lbl_DA_Olio
            // 
            this.lbl_DA_Olio.AutoSize = true;
            this.lbl_DA_Olio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DA_Olio.Location = new System.Drawing.Point(6, 108);
            this.lbl_DA_Olio.Name = "lbl_DA_Olio";
            this.lbl_DA_Olio.Size = new System.Drawing.Size(116, 15);
            this.lbl_DA_Olio.TabIndex = 24;
            this.lbl_DA_Olio.Text = "Data consegna olio:";
            // 
            // lbl_DA_ComponentiNucleoFamiliare
            // 
            this.lbl_DA_ComponentiNucleoFamiliare.AutoSize = true;
            this.lbl_DA_ComponentiNucleoFamiliare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DA_ComponentiNucleoFamiliare.Location = new System.Drawing.Point(765, 26);
            this.lbl_DA_ComponentiNucleoFamiliare.Name = "lbl_DA_ComponentiNucleoFamiliare";
            this.lbl_DA_ComponentiNucleoFamiliare.Size = new System.Drawing.Size(86, 30);
            this.lbl_DA_ComponentiNucleoFamiliare.TabIndex = 16;
            this.lbl_DA_ComponentiNucleoFamiliare.Text = "Comp. nucleo \r\nfamiliare:";
            // 
            // txt_DA_Note
            // 
            this.txt_DA_Note.Location = new System.Drawing.Point(139, 154);
            this.txt_DA_Note.Multiline = true;
            this.txt_DA_Note.Name = "txt_DA_Note";
            this.txt_DA_Note.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_DA_Note.Size = new System.Drawing.Size(796, 81);
            this.txt_DA_Note.TabIndex = 14;
            // 
            // lbl_DA_Note
            // 
            this.lbl_DA_Note.AutoSize = true;
            this.lbl_DA_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DA_Note.Location = new System.Drawing.Point(6, 154);
            this.lbl_DA_Note.Name = "lbl_DA_Note";
            this.lbl_DA_Note.Size = new System.Drawing.Size(36, 15);
            this.lbl_DA_Note.TabIndex = 25;
            this.lbl_DA_Note.Text = "Note:";
            // 
            // txt_DA_NumeroTessera
            // 
            this.txt_DA_NumeroTessera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_DA_NumeroTessera.Location = new System.Drawing.Point(139, 37);
            this.txt_DA_NumeroTessera.Name = "txt_DA_NumeroTessera";
            this.txt_DA_NumeroTessera.ReadOnly = true;
            this.txt_DA_NumeroTessera.Size = new System.Drawing.Size(62, 26);
            this.txt_DA_NumeroTessera.TabIndex = 1003;
            // 
            // lbl_DA_NumeroTessera
            // 
            this.lbl_DA_NumeroTessera.AutoSize = true;
            this.lbl_DA_NumeroTessera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DA_NumeroTessera.Location = new System.Drawing.Point(6, 48);
            this.lbl_DA_NumeroTessera.Name = "lbl_DA_NumeroTessera";
            this.lbl_DA_NumeroTessera.Size = new System.Drawing.Size(98, 15);
            this.lbl_DA_NumeroTessera.TabIndex = 6;
            this.lbl_DA_NumeroTessera.Text = "Numero tessera:";
            // 
            // btn_DA_SalvaModifiche
            // 
            this.btn_DA_SalvaModifiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DA_SalvaModifiche.Location = new System.Drawing.Point(420, 508);
            this.btn_DA_SalvaModifiche.Name = "btn_DA_SalvaModifiche";
            this.btn_DA_SalvaModifiche.Size = new System.Drawing.Size(195, 50);
            this.btn_DA_SalvaModifiche.TabIndex = 15;
            this.btn_DA_SalvaModifiche.Text = "Salva Modifiche";
            this.btn_DA_SalvaModifiche.UseVisualStyleBackColor = true;
            this.btn_DA_SalvaModifiche.Click += new System.EventHandler(this.btn_DA_SalvaModifiche_Click);
            // 
            // tabDettaglioanagrafica
            // 
            this.tabDettaglioanagrafica.Controls.Add(this.tbDettaglioAssistito);
            this.tabDettaglioanagrafica.Controls.Add(this.tbDettaglioConsegne);
            this.tabDettaglioanagrafica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tabDettaglioanagrafica.ItemSize = new System.Drawing.Size(300, 60);
            this.tabDettaglioanagrafica.Location = new System.Drawing.Point(12, 12);
            this.tabDettaglioanagrafica.Name = "tabDettaglioanagrafica";
            this.tabDettaglioanagrafica.SelectedIndex = 0;
            this.tabDettaglioanagrafica.Size = new System.Drawing.Size(984, 670);
            this.tabDettaglioanagrafica.TabIndex = 32;
            // 
            // tbDettaglioAssistito
            // 
            this.tbDettaglioAssistito.Controls.Add(this.gb_DA_UlteriotiDati);
            this.tbDettaglioAssistito.Controls.Add(this.gb_DA_Recapiti);
            this.tbDettaglioAssistito.Controls.Add(this.gb_DA_Anagrafica);
            this.tbDettaglioAssistito.Controls.Add(this.btn_DA_SalvaModifiche);
            this.tbDettaglioAssistito.Location = new System.Drawing.Point(4, 64);
            this.tbDettaglioAssistito.Name = "tbDettaglioAssistito";
            this.tbDettaglioAssistito.Padding = new System.Windows.Forms.Padding(3);
            this.tbDettaglioAssistito.Size = new System.Drawing.Size(976, 602);
            this.tbDettaglioAssistito.TabIndex = 0;
            this.tbDettaglioAssistito.Text = "Dettaglio Assistito";
            this.tbDettaglioAssistito.UseVisualStyleBackColor = true;
            // 
            // tbDettaglioConsegne
            // 
            this.tbDettaglioConsegne.Controls.Add(this.dg_DA_ListaConsegne);
            this.tbDettaglioConsegne.Location = new System.Drawing.Point(4, 64);
            this.tbDettaglioConsegne.Name = "tbDettaglioConsegne";
            this.tbDettaglioConsegne.Padding = new System.Windows.Forms.Padding(3);
            this.tbDettaglioConsegne.Size = new System.Drawing.Size(976, 602);
            this.tbDettaglioConsegne.TabIndex = 1;
            this.tbDettaglioConsegne.Text = "Dettaglio Consegne";
            this.tbDettaglioConsegne.UseVisualStyleBackColor = true;
            // 
            // dg_DA_ListaConsegne
            // 
            this.dg_DA_ListaConsegne.AllowUserToAddRows = false;
            this.dg_DA_ListaConsegne.AllowUserToDeleteRows = false;
            this.dg_DA_ListaConsegne.AutoGenerateColumns = false;
            this.dg_DA_ListaConsegne.ColumnHeadersHeight = 60;
            this.dg_DA_ListaConsegne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_DA_ListaConsegne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.EliminaConsegna});
            this.dg_DA_ListaConsegne.DataSource = this.ritiroBindingSource;
            this.dg_DA_ListaConsegne.Location = new System.Drawing.Point(22, 51);
            this.dg_DA_ListaConsegne.Name = "dg_DA_ListaConsegne";
            this.dg_DA_ListaConsegne.ReadOnly = true;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            this.dg_DA_ListaConsegne.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_DA_ListaConsegne.RowTemplate.Height = 40;
            this.dg_DA_ListaConsegne.RowTemplate.ReadOnly = true;
            this.dg_DA_ListaConsegne.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dg_DA_ListaConsegne.Size = new System.Drawing.Size(932, 527);
            this.dg_DA_ListaConsegne.TabIndex = 0;
            this.dg_DA_ListaConsegne.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_DA_ListaConsegne_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.Frozen = true;
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 200;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 550;
            // 
            // EliminaConsegna
            // 
            this.EliminaConsegna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EliminaConsegna.FillWeight = 40F;
            this.EliminaConsegna.HeaderText = "";
            this.EliminaConsegna.Name = "EliminaConsegna";
            this.EliminaConsegna.ReadOnly = true;
            this.EliminaConsegna.Text = "Elimina";
            this.EliminaConsegna.UseColumnTextForButtonValue = true;
            // 
            // ritiroBindingSource
            // 
            this.ritiroBindingSource.DataSource = typeof(SMS.CaritasPackTracking.Model.Ritiro);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Elimina";
            this.dataGridViewImageColumn1.Image = global::SMS.Caritas.PackTracking.WindowsApplication.Properties.Resources.Delete;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // Form_DettaglioAssistito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1020, 712);
            this.Controls.Add(this.tabDettaglioanagrafica);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_DettaglioAssistito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dettaglio Assistito";
            this.gb_DA_Anagrafica.ResumeLayout(false);
            this.gb_DA_Anagrafica.PerformLayout();
            this.gb_DA_Recapiti.ResumeLayout(false);
            this.gb_DA_Recapiti.PerformLayout();
            this.gb_DA_UlteriotiDati.ResumeLayout(false);
            this.gb_DA_UlteriotiDati.PerformLayout();
            this.tabDettaglioanagrafica.ResumeLayout(false);
            this.tbDettaglioAssistito.ResumeLayout(false);
            this.tbDettaglioConsegne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_DA_ListaConsegne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritiroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_DA_Anagrafica;
        private System.Windows.Forms.TextBox txt_DA_StatoDiProvenienza;
        private System.Windows.Forms.Label lbl_DA_StatoDiProvenienza;
        private System.Windows.Forms.DateTimePicker dt_DA_DataDiNascita;
        private System.Windows.Forms.Label lbl_DA_DataDiNascita;
        private System.Windows.Forms.TextBox txt_DA_ComuneDiNascita;
        private System.Windows.Forms.Label lbl_DA_ComuneDiNascita;
        private System.Windows.Forms.TextBox txt_DA_Cognome;
        private System.Windows.Forms.Label lbl_DA_Nome;
        private System.Windows.Forms.TextBox txt_DA_Nome;
        private System.Windows.Forms.Label lbl_DA_Cognome;
        private System.Windows.Forms.GroupBox gb_DA_Recapiti;
        private System.Windows.Forms.Label lbl_DA_TelefonoAbitazione;
        private System.Windows.Forms.Label lbl_DA_CAP;
        private System.Windows.Forms.TextBox txt_DA_CAP;
        private System.Windows.Forms.TextBox txt_DA_TelefonoCellulare;
        private System.Windows.Forms.TextBox txt_DA_TelefonoAbitazione;
        private System.Windows.Forms.Label lbl_DA_TelefonoCellulare;
        private System.Windows.Forms.TextBox txt_DA_Indirizzo;
        private System.Windows.Forms.Label lbl_DA_Indirizzo;
        private System.Windows.Forms.GroupBox gb_DA_UlteriotiDati;
        private System.Windows.Forms.DateTimePicker dt_DA_ScadenzaAssistenza;
        private System.Windows.Forms.Label lbl_DA_DataScadenzaAssistenza;
        private System.Windows.Forms.DateTimePicker dt_DA_DataConsegnaCaffe;
        private System.Windows.Forms.Label lbl_DA_Caffe;
        private System.Windows.Forms.DateTimePicker dt_DA_DataConsegnaOlio;
        private System.Windows.Forms.TextBox txt_DA_ComponentiNucleoFamiliare;
        private System.Windows.Forms.Label lbl_DA_Olio;
        private System.Windows.Forms.Label lbl_DA_ComponentiNucleoFamiliare;
        private System.Windows.Forms.TextBox txt_DA_Note;
        private System.Windows.Forms.Label lbl_DA_Note;
        private System.Windows.Forms.TextBox txt_DA_NumeroTessera;
        private System.Windows.Forms.Label lbl_DA_NumeroTessera;
        private System.Windows.Forms.Button btn_DA_SalvaModifiche;
        private System.Windows.Forms.TabPage tbDettaglioAssistito;
        private System.Windows.Forms.TabPage tbDettaglioConsegne;
        public System.Windows.Forms.TabControl tabDettaglioanagrafica;
        private System.Windows.Forms.DataGridView dg_DA_ListaConsegne;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.BindingSource ritiroBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EliminaConsegna;
    }
}