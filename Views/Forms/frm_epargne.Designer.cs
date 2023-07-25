
namespace ADTMPDapk
{
    partial class frm_epargne
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
            this.t_loginTableAdapter1 = new ADTMPDapk.db_adtmpdDataSetTableAdapters.t_loginTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdateNaiss = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labellieuNaiss = new System.Windows.Forms.Label();
            this.labelsexe = new System.Windows.Forms.Label();
            this.labelphone = new System.Windows.Forms.Label();
            this.labeltitre = new System.Windows.Forms.Label();
            this.lbl_matricule = new System.Windows.Forms.Label();
            this.cmbmembre = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtversement = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtdesignation = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnenregistrer = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnemeroEpargne = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btmfermer = new Bunifu.Framework.UI.BunifuImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtperception = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaElipsePanel1.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btmfermer)).BeginInit();
            this.SuspendLayout();
            // 
            // t_loginTableAdapter1
            // 
            this.t_loginTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(362, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Date de versement";
            // 
            // txtdateNaiss
            // 
            this.txtdateNaiss.Checked = true;
            this.txtdateNaiss.FillColor = System.Drawing.Color.White;
            this.txtdateNaiss.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdateNaiss.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtdateNaiss.Location = new System.Drawing.Point(354, 106);
            this.txtdateNaiss.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdateNaiss.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdateNaiss.Name = "txtdateNaiss";
            this.txtdateNaiss.Size = new System.Drawing.Size(268, 36);
            this.txtdateNaiss.TabIndex = 41;
            this.txtdateNaiss.Value = new System.DateTime(2023, 7, 19, 15, 36, 14, 47);
            // 
            // labellieuNaiss
            // 
            this.labellieuNaiss.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labellieuNaiss.AutoSize = true;
            this.labellieuNaiss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.labellieuNaiss.Location = new System.Drawing.Point(29, 30);
            this.labellieuNaiss.Name = "labellieuNaiss";
            this.labellieuNaiss.Size = new System.Drawing.Size(93, 20);
            this.labellieuNaiss.TabIndex = 37;
            this.labellieuNaiss.Text = "N°d\'Epargne";
            // 
            // labelsexe
            // 
            this.labelsexe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelsexe.AutoSize = true;
            this.labelsexe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.labelsexe.Location = new System.Drawing.Point(29, 92);
            this.labelsexe.Name = "labelsexe";
            this.labelsexe.Size = new System.Drawing.Size(65, 20);
            this.labelsexe.TabIndex = 36;
            this.labelsexe.Text = "Membre";
            // 
            // labelphone
            // 
            this.labelphone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelphone.AutoSize = true;
            this.labelphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.labelphone.Location = new System.Drawing.Point(359, 27);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(78, 20);
            this.labelphone.TabIndex = 35;
            this.labelphone.Text = "Versement";
            // 
            // labeltitre
            // 
            this.labeltitre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltitre.AutoSize = true;
            this.labeltitre.ForeColor = System.Drawing.Color.White;
            this.labeltitre.Location = new System.Drawing.Point(11, 10);
            this.labeltitre.Name = "labeltitre";
            this.labeltitre.Size = new System.Drawing.Size(50, 20);
            this.labeltitre.TabIndex = 3;
            this.labeltitre.Text = "label1";
            // 
            // lbl_matricule
            // 
            this.lbl_matricule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_matricule.AutoSize = true;
            this.lbl_matricule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.lbl_matricule.Location = new System.Drawing.Point(27, 150);
            this.lbl_matricule.Name = "lbl_matricule";
            this.lbl_matricule.Size = new System.Drawing.Size(89, 20);
            this.lbl_matricule.TabIndex = 23;
            this.lbl_matricule.Text = "Designation";
            this.lbl_matricule.Visible = false;
            // 
            // cmbmembre
            // 
            this.cmbmembre.BackColor = System.Drawing.Color.Transparent;
            this.cmbmembre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbmembre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbmembre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmembre.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbmembre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbmembre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbmembre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbmembre.ItemHeight = 30;
            this.cmbmembre.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.cmbmembre.Location = new System.Drawing.Point(25, 106);
            this.cmbmembre.Name = "cmbmembre";
            this.cmbmembre.Size = new System.Drawing.Size(255, 36);
            this.cmbmembre.TabIndex = 29;
            // 
            // txtversement
            // 
            this.txtversement.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtversement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtversement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtversement.DefaultText = "";
            this.txtversement.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtversement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtversement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtversement.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtversement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtversement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtversement.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtversement.Location = new System.Drawing.Point(354, 46);
            this.txtversement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtversement.Name = "txtversement";
            this.txtversement.PasswordChar = '\0';
            this.txtversement.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtversement.PlaceholderText = "Montant verser";
            this.txtversement.SelectedText = "";
            this.txtversement.Size = new System.Drawing.Size(268, 36);
            this.txtversement.TabIndex = 26;
            // 
            // txtdesignation
            // 
            this.txtdesignation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtdesignation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtdesignation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdesignation.DefaultText = "";
            this.txtdesignation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdesignation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdesignation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdesignation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdesignation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdesignation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdesignation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdesignation.Location = new System.Drawing.Point(23, 164);
            this.txtdesignation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdesignation.Name = "txtdesignation";
            this.txtdesignation.PasswordChar = '\0';
            this.txtdesignation.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtdesignation.PlaceholderText = "Designation";
            this.txtdesignation.SelectedText = "";
            this.txtdesignation.Size = new System.Drawing.Size(257, 36);
            this.txtdesignation.TabIndex = 24;
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.AnimationHoverSpeed = 0.07F;
            this.btnenregistrer.AnimationSpeed = 0.03F;
            this.btnenregistrer.BackColor = System.Drawing.Color.Transparent;
            this.btnenregistrer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.btnenregistrer.BorderColor = System.Drawing.Color.Black;
            this.btnenregistrer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnenregistrer.FocusedColor = System.Drawing.Color.Empty;
            this.btnenregistrer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.ForeColor = System.Drawing.Color.White;
            this.btnenregistrer.Image = null;
            this.btnenregistrer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnenregistrer.ImageSize = new System.Drawing.Size(20, 20);
            this.btnenregistrer.Location = new System.Drawing.Point(371, 394);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnenregistrer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnenregistrer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnenregistrer.OnHoverImage = null;
            this.btnenregistrer.OnPressedColor = System.Drawing.Color.Black;
            this.btnenregistrer.Size = new System.Drawing.Size(268, 32);
            this.btnenregistrer.TabIndex = 25;
            this.btnenregistrer.Text = "ENREGISTRER";
            this.btnenregistrer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gunaElipsePanel1.Controls.Add(this.label4);
            this.gunaElipsePanel1.Controls.Add(this.txtperception);
            this.gunaElipsePanel1.Controls.Add(this.bunifuImageButton2);
            this.gunaElipsePanel1.Controls.Add(this.label2);
            this.gunaElipsePanel1.Controls.Add(this.label3);
            this.gunaElipsePanel1.Controls.Add(this.guna2TextBox1);
            this.gunaElipsePanel1.Controls.Add(this.guna2TextBox2);
            this.gunaElipsePanel1.Controls.Add(this.label1);
            this.gunaElipsePanel1.Controls.Add(this.txtdateNaiss);
            this.gunaElipsePanel1.Controls.Add(this.labellieuNaiss);
            this.gunaElipsePanel1.Controls.Add(this.labelsexe);
            this.gunaElipsePanel1.Controls.Add(this.labelphone);
            this.gunaElipsePanel1.Controls.Add(this.lbl_matricule);
            this.gunaElipsePanel1.Controls.Add(this.txtnemeroEpargne);
            this.gunaElipsePanel1.Controls.Add(this.cmbmembre);
            this.gunaElipsePanel1.Controls.Add(this.txtversement);
            this.gunaElipsePanel1.Controls.Add(this.txtdesignation);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(15, 82);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 3;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(659, 304);
            this.gunaElipsePanel1.TabIndex = 24;
            this.gunaElipsePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaElipsePanel1_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.label2.Location = new System.Drawing.Point(361, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Versement";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.label3.Location = new System.Drawing.Point(29, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Libelle du compte";
            this.label3.Visible = false;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(356, 164);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.guna2TextBox1.PlaceholderText = "Montant verser";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(266, 36);
            this.guna2TextBox1.TabIndex = 45;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(25, 232);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.guna2TextBox2.PlaceholderText = "Libeller";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(255, 36);
            this.guna2TextBox2.TabIndex = 44;
            // 
            // txtnemeroEpargne
            // 
            this.txtnemeroEpargne.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtnemeroEpargne.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtnemeroEpargne.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnemeroEpargne.DefaultText = "";
            this.txtnemeroEpargne.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnemeroEpargne.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnemeroEpargne.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnemeroEpargne.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnemeroEpargne.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnemeroEpargne.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtnemeroEpargne.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnemeroEpargne.Location = new System.Drawing.Point(23, 46);
            this.txtnemeroEpargne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnemeroEpargne.Name = "txtnemeroEpargne";
            this.txtnemeroEpargne.PasswordChar = '\0';
            this.txtnemeroEpargne.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtnemeroEpargne.PlaceholderText = "Numero epargne";
            this.txtnemeroEpargne.SelectedText = "";
            this.txtnemeroEpargne.Size = new System.Drawing.Size(257, 36);
            this.txtnemeroEpargne.TabIndex = 30;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.btnenregistrer);
            this.gunaShadowPanel1.Controls.Add(this.gunaElipsePanel1);
            this.gunaShadowPanel1.Controls.Add(this.bunifuImageButton1);
            this.gunaShadowPanel1.Controls.Add(this.panel1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(-7, -18);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(684, 443);
            this.gunaShadowPanel1.TabIndex = 1;
            this.gunaShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaShadowPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.labeltitre);
            this.panel1.Controls.Add(this.btmfermer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 38);
            this.panel1.TabIndex = 0;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::ADTMPDapk.Properties.Resources.ad_96px1;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(286, 106);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(36, 36);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 47;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::ADTMPDapk.Properties.Resources.update_left_rotation_96px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(638, 44);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(36, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 23;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // btmfermer
            // 
            this.btmfermer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmfermer.BackColor = System.Drawing.Color.Transparent;
            this.btmfermer.Image = global::ADTMPDapk.Properties.Resources.close_window_96px;
            this.btmfermer.ImageActive = null;
            this.btmfermer.Location = new System.Drawing.Point(641, 3);
            this.btmfermer.Name = "btmfermer";
            this.btmfermer.Size = new System.Drawing.Size(36, 32);
            this.btmfermer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btmfermer.TabIndex = 2;
            this.btmfermer.TabStop = false;
            this.btmfermer.Zoom = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.label4.Location = new System.Drawing.Point(358, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Nom du percepteur";
            this.label4.Visible = false;
            // 
            // txtperception
            // 
            this.txtperception.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtperception.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtperception.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtperception.DefaultText = "";
            this.txtperception.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtperception.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtperception.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtperception.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtperception.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtperception.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtperception.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtperception.Location = new System.Drawing.Point(354, 232);
            this.txtperception.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtperception.Name = "txtperception";
            this.txtperception.PasswordChar = '\0';
            this.txtperception.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtperception.PlaceholderText = "nom du percepteur";
            this.txtperception.SelectedText = "";
            this.txtperception.Size = new System.Drawing.Size(268, 36);
            this.txtperception.TabIndex = 49;
            // 
            // frm_epargne
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 427);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_epargne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_epargne";
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btmfermer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btmfermer;
        private db_adtmpdDataSetTableAdapters.t_loginTableAdapter t_loginTableAdapter1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtdateNaiss;
        private System.Windows.Forms.Label labellieuNaiss;
        private System.Windows.Forms.Label labelsexe;
        private System.Windows.Forms.Label labelphone;
        private System.Windows.Forms.Label labeltitre;
        private System.Windows.Forms.Label lbl_matricule;
        public Guna.UI2.WinForms.Guna2ComboBox cmbmembre;
        public Guna.UI2.WinForms.Guna2TextBox txtversement;
        public Guna.UI2.WinForms.Guna2TextBox txtdesignation;
        private Guna.UI.WinForms.GunaButton btnenregistrer;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        public Guna.UI2.WinForms.Guna2TextBox txtnemeroEpargne;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2TextBox txtperception;
    }
}