
using ADTMPDapk.Views.UserControls;

namespace ADTMPDapk
{
    partial class frm_membre
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
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnenregistrer = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdateNaiss = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labellieuNaiss = new System.Windows.Forms.Label();
            this.labelsexe = new System.Windows.Forms.Label();
            this.labelphone = new System.Windows.Forms.Label();
            this.labeladreese = new System.Windows.Forms.Label();
            this.labelpostnom = new System.Windows.Forms.Label();
            this.labelnom = new System.Windows.Forms.Label();
            this.lbl_matricule = new System.Windows.Forms.Label();
            this.txtlieuNaiss = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbsexe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtadresse = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpostnom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtphone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmatricule = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeltitre = new System.Windows.Forms.Label();
            this.t_loginTableAdapter1 = new ADTMPDapk.db_adtmpdDataSetTableAdapters.t_loginTableAdapter();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btmfermer = new Bunifu.Framework.UI.BunifuImageButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gunaShadowPanel1.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btmfermer)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.btnenregistrer);
            this.gunaShadowPanel1.Controls.Add(this.gunaElipsePanel1);
            this.gunaShadowPanel1.Controls.Add(this.bunifuImageButton1);
            this.gunaShadowPanel1.Controls.Add(this.panel1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(1, 1);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(684, 443);
            this.gunaShadowPanel1.TabIndex = 0;
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
            this.btnenregistrer.Location = new System.Drawing.Point(149, 392);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnenregistrer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnenregistrer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnenregistrer.OnHoverImage = null;
            this.btnenregistrer.OnPressedColor = System.Drawing.Color.Black;
            this.btnenregistrer.Size = new System.Drawing.Size(426, 32);
            this.btnenregistrer.TabIndex = 25;
            this.btnenregistrer.Text = "ENREGISTRER";
            this.btnenregistrer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gunaElipsePanel1.Controls.Add(this.textBox1);
            this.gunaElipsePanel1.Controls.Add(this.label1);
            this.gunaElipsePanel1.Controls.Add(this.txtdateNaiss);
            this.gunaElipsePanel1.Controls.Add(this.gunaButton1);
            this.gunaElipsePanel1.Controls.Add(this.pictureBox1);
            this.gunaElipsePanel1.Controls.Add(this.labellieuNaiss);
            this.gunaElipsePanel1.Controls.Add(this.labelsexe);
            this.gunaElipsePanel1.Controls.Add(this.labelphone);
            this.gunaElipsePanel1.Controls.Add(this.labeladreese);
            this.gunaElipsePanel1.Controls.Add(this.labelpostnom);
            this.gunaElipsePanel1.Controls.Add(this.labelnom);
            this.gunaElipsePanel1.Controls.Add(this.lbl_matricule);
            this.gunaElipsePanel1.Controls.Add(this.txtlieuNaiss);
            this.gunaElipsePanel1.Controls.Add(this.cmbsexe);
            this.gunaElipsePanel1.Controls.Add(this.txtadresse);
            this.gunaElipsePanel1.Controls.Add(this.txtpostnom);
            this.gunaElipsePanel1.Controls.Add(this.txtphone);
            this.gunaElipsePanel1.Controls.Add(this.txtnom);
            this.gunaElipsePanel1.Controls.Add(this.txtmatricule);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(15, 82);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 3;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(659, 304);
            this.gunaElipsePanel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(258, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Date de Naissance";
            // 
            // txtdateNaiss
            // 
            this.txtdateNaiss.Checked = true;
            this.txtdateNaiss.FillColor = System.Drawing.Color.White;
            this.txtdateNaiss.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdateNaiss.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtdateNaiss.Location = new System.Drawing.Point(250, 232);
            this.txtdateNaiss.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdateNaiss.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdateNaiss.Name = "txtdateNaiss";
            this.txtdateNaiss.Size = new System.Drawing.Size(204, 36);
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
            this.labellieuNaiss.Location = new System.Drawing.Point(258, 139);
            this.labellieuNaiss.Name = "labellieuNaiss";
            this.labellieuNaiss.Size = new System.Drawing.Size(127, 20);
            this.labellieuNaiss.TabIndex = 37;
            this.labellieuNaiss.Text = "Lieu de Naissance";
            // 
            // labelsexe
            // 
            this.labelsexe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelsexe.AutoSize = true;
            this.labelsexe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.labelsexe.Location = new System.Drawing.Point(256, 2);
            this.labelsexe.Name = "labelsexe";
            this.labelsexe.Size = new System.Drawing.Size(48, 20);
            this.labelsexe.TabIndex = 36;
            this.labelsexe.Text = "Genre";
            // 
            // labelphone
            // 
            this.labelphone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelphone.AutoSize = true;
            this.labelphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.labelphone.Location = new System.Drawing.Point(255, 66);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(78, 20);
            this.labelphone.TabIndex = 35;
            this.labelphone.Text = "Telephone";
            // 
            // labeladreese
            // 
            this.labeladreese.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeladreese.AutoSize = true;
            this.labeladreese.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.labeladreese.Location = new System.Drawing.Point(30, 217);
            this.labeladreese.Name = "labeladreese";
            this.labeladreese.Size = new System.Drawing.Size(61, 20);
            this.labeladreese.TabIndex = 34;
            this.labeladreese.Text = "Adresse";
            // 
            // labelpostnom
            // 
            this.labelpostnom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelpostnom.AutoSize = true;
            this.labelpostnom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.labelpostnom.Location = new System.Drawing.Point(30, 143);
            this.labelpostnom.Name = "labelpostnom";
            this.labelpostnom.Size = new System.Drawing.Size(66, 20);
            this.labelpostnom.TabIndex = 33;
            this.labelpostnom.Text = "Postnom";
            // 
            // labelnom
            // 
            this.labelnom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelnom.AutoSize = true;
            this.labelnom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.labelnom.Location = new System.Drawing.Point(29, 69);
            this.labelnom.Name = "labelnom";
            this.labelnom.Size = new System.Drawing.Size(42, 20);
            this.labelnom.TabIndex = 32;
            this.labelnom.Text = "Nom";
            // 
            // lbl_matricule
            // 
            this.lbl_matricule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_matricule.AutoSize = true;
            this.lbl_matricule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.lbl_matricule.Location = new System.Drawing.Point(29, 2);
            this.lbl_matricule.Name = "lbl_matricule";
            this.lbl_matricule.Size = new System.Drawing.Size(71, 20);
            this.lbl_matricule.TabIndex = 23;
            this.lbl_matricule.Text = "Matricule";
            this.lbl_matricule.Visible = false;
            // 
            // txtlieuNaiss
            // 
            this.txtlieuNaiss.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtlieuNaiss.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtlieuNaiss.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlieuNaiss.DefaultText = "";
            this.txtlieuNaiss.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtlieuNaiss.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtlieuNaiss.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtlieuNaiss.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtlieuNaiss.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlieuNaiss.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtlieuNaiss.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlieuNaiss.Location = new System.Drawing.Point(252, 155);
            this.txtlieuNaiss.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtlieuNaiss.Name = "txtlieuNaiss";
            this.txtlieuNaiss.PasswordChar = '\0';
            this.txtlieuNaiss.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtlieuNaiss.PlaceholderText = "Lieu de naissance";
            this.txtlieuNaiss.SelectedText = "";
            this.txtlieuNaiss.Size = new System.Drawing.Size(202, 36);
            this.txtlieuNaiss.TabIndex = 30;
            // 
            // cmbsexe
            // 
            this.cmbsexe.BackColor = System.Drawing.Color.Transparent;
            this.cmbsexe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbsexe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbsexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsexe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbsexe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbsexe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbsexe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbsexe.ItemHeight = 30;
            this.cmbsexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.cmbsexe.Location = new System.Drawing.Point(252, 16);
            this.cmbsexe.Name = "cmbsexe";
            this.cmbsexe.Size = new System.Drawing.Size(200, 36);
            this.cmbsexe.TabIndex = 29;
            // 
            // txtadresse
            // 
            this.txtadresse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtadresse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtadresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtadresse.DefaultText = "";
            this.txtadresse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtadresse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtadresse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtadresse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtadresse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtadresse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtadresse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtadresse.Location = new System.Drawing.Point(26, 232);
            this.txtadresse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.PasswordChar = '\0';
            this.txtadresse.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtadresse.PlaceholderText = "Entrer l\'adresse";
            this.txtadresse.SelectedText = "";
            this.txtadresse.Size = new System.Drawing.Size(202, 36);
            this.txtadresse.TabIndex = 28;
            // 
            // txtpostnom
            // 
            this.txtpostnom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtpostnom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtpostnom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpostnom.DefaultText = "";
            this.txtpostnom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpostnom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpostnom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpostnom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpostnom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpostnom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtpostnom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpostnom.Location = new System.Drawing.Point(25, 158);
            this.txtpostnom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpostnom.Name = "txtpostnom";
            this.txtpostnom.PasswordChar = '\0';
            this.txtpostnom.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtpostnom.PlaceholderText = "Entrer le postnom";
            this.txtpostnom.SelectedText = "";
            this.txtpostnom.Size = new System.Drawing.Size(202, 36);
            this.txtpostnom.TabIndex = 27;
            // 
            // txtphone
            // 
            this.txtphone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtphone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphone.DefaultText = "";
            this.txtphone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphone.Location = new System.Drawing.Point(250, 85);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtphone.Name = "txtphone";
            this.txtphone.PasswordChar = '\0';
            this.txtphone.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtphone.PlaceholderText = "Numero Tel";
            this.txtphone.SelectedText = "";
            this.txtphone.Size = new System.Drawing.Size(202, 36);
            this.txtphone.TabIndex = 26;
            // 
            // txtnom
            // 
            this.txtnom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtnom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtnom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnom.DefaultText = "";
            this.txtnom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtnom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnom.Location = new System.Drawing.Point(25, 85);
            this.txtnom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnom.Name = "txtnom";
            this.txtnom.PasswordChar = '\0';
            this.txtnom.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtnom.PlaceholderText = "Entrer le nom";
            this.txtnom.SelectedText = "";
            this.txtnom.Size = new System.Drawing.Size(202, 36);
            this.txtnom.TabIndex = 25;
            // 
            // txtmatricule
            // 
            this.txtmatricule.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtmatricule.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtmatricule.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtmatricule.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmatricule.DefaultText = "";
            this.txtmatricule.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmatricule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmatricule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmatricule.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmatricule.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmatricule.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmatricule.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmatricule.Location = new System.Drawing.Point(25, 16);
            this.txtmatricule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmatricule.Modified = true;
            this.txtmatricule.Name = "txtmatricule";
            this.txtmatricule.PasswordChar = '\0';
            this.txtmatricule.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtmatricule.PlaceholderText = "Entrer le matricule";
            this.txtmatricule.SelectedText = "";
            this.txtmatricule.Size = new System.Drawing.Size(202, 36);
            this.txtmatricule.TabIndex = 24;
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
            // t_loginTableAdapter1
            // 
            this.t_loginTableAdapter1.ClearBeforeFill = true;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.White;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.gunaButton1.Image = global::ADTMPDapk.Properties.Resources.image24px;
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(476, 162);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 3;
            this.gunaButton1.Size = new System.Drawing.Size(153, 32);
            this.gunaButton1.TabIndex = 40;
            this.gunaButton1.Text = "Inserer une image";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(496, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 143);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
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
            this.btmfermer.Click += new System.EventHandler(this.btmfermer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(501, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 43;
            // 
            // frm_membre
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(687, 446);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_membre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_membre";
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btmfermer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btmfermer;
        private System.Windows.Forms.Label labeltitre;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Guna.UI.WinForms.GunaButton btnenregistrer;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labellieuNaiss;
        private System.Windows.Forms.Label labelsexe;
        private System.Windows.Forms.Label labelphone;
        private System.Windows.Forms.Label labeladreese;
        private System.Windows.Forms.Label labelpostnom;
        private System.Windows.Forms.Label labelnom;
        private System.Windows.Forms.Label lbl_matricule;
        public Guna.UI2.WinForms.Guna2TextBox txtlieuNaiss;
        public Guna.UI2.WinForms.Guna2ComboBox cmbsexe;
        public Guna.UI2.WinForms.Guna2TextBox txtadresse;
        public Guna.UI2.WinForms.Guna2TextBox txtpostnom;
        public Guna.UI2.WinForms.Guna2TextBox txtphone;
        public Guna.UI2.WinForms.Guna2TextBox txtnom;
        public Guna.UI2.WinForms.Guna2TextBox txtmatricule;
        private System.Windows.Forms.Label label1;
        private db_adtmpdDataSetTableAdapters.t_loginTableAdapter t_loginTableAdapter1;
        public Guna.UI2.WinForms.Guna2DateTimePicker txtdateNaiss;
        public System.Windows.Forms.TextBox textBox1;
        private uc_membre uc_membre;

        public frm_membre(uc_membre uc_membre)
        {
            this.uc_membre = uc_membre;
        }
    }
}