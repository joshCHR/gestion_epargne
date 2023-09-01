namespace ADTMPDapk.Views.Forms
{
    partial class frm_user
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.checkStatut = new Guna.UI.WinForms.GunaCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtposte = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbniveau = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labeladreese = new System.Windows.Forms.Label();
            this.labelpostnom = new System.Windows.Forms.Label();
            this.labelnom = new System.Windows.Forms.Label();
            this.lbl_matricule = new System.Windows.Forms.Label();
            this.txtpostnom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmatricule = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnretour = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelInscription = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnretour)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.labelInscription);
            this.guna2ShadowPanel1.Controls.Add(this.btnretour);
            this.guna2ShadowPanel1.Controls.Add(this.checkStatut);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Controls.Add(this.btnSave);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.txtposte);
            this.guna2ShadowPanel1.Controls.Add(this.cmbniveau);
            this.guna2ShadowPanel1.Controls.Add(this.labeladreese);
            this.guna2ShadowPanel1.Controls.Add(this.labelpostnom);
            this.guna2ShadowPanel1.Controls.Add(this.labelnom);
            this.guna2ShadowPanel1.Controls.Add(this.lbl_matricule);
            this.guna2ShadowPanel1.Controls.Add(this.txtpostnom);
            this.guna2ShadowPanel1.Controls.Add(this.txtnom);
            this.guna2ShadowPanel1.Controls.Add(this.txtmatricule);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(343, 466);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // checkStatut
            // 
            this.checkStatut.BaseColor = System.Drawing.Color.White;
            this.checkStatut.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkStatut.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkStatut.FillColor = System.Drawing.Color.White;
            this.checkStatut.Location = new System.Drawing.Point(86, 407);
            this.checkStatut.Name = "checkStatut";
            this.checkStatut.Size = new System.Drawing.Size(45, 20);
            this.checkStatut.TabIndex = 72;
            this.checkStatut.Text = "Off";
            this.checkStatut.Click += new System.EventHandler(this.checkStatut_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.label3.Location = new System.Drawing.Point(16, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "Statut";
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(195)))), ((int)(((byte)(254)))));
            this.btnSave.Image = null;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(155, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(158, 32);
            this.btnSave.TabIndex = 69;
            this.btnSave.Text = "Terminer";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.label1.Location = new System.Drawing.Point(15, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Poste";
            // 
            // txtposte
            // 
            this.txtposte.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtposte.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtposte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtposte.DefaultText = "";
            this.txtposte.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtposte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtposte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtposte.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtposte.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtposte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtposte.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtposte.Location = new System.Drawing.Point(13, 280);
            this.txtposte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtposte.Name = "txtposte";
            this.txtposte.PasswordChar = '\0';
            this.txtposte.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtposte.PlaceholderText = "Poste";
            this.txtposte.SelectedText = "";
            this.txtposte.Size = new System.Drawing.Size(300, 36);
            this.txtposte.TabIndex = 66;
            // 
            // cmbniveau
            // 
            this.cmbniveau.BackColor = System.Drawing.Color.Transparent;
            this.cmbniveau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.cmbniveau.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbniveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbniveau.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbniveau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbniveau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbniveau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.cmbniveau.ItemHeight = 30;
            this.cmbniveau.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbniveau.Location = new System.Drawing.Point(14, 347);
            this.cmbniveau.Name = "cmbniveau";
            this.cmbniveau.Size = new System.Drawing.Size(299, 36);
            this.cmbniveau.TabIndex = 63;
            this.cmbniveau.SelectedIndexChanged += new System.EventHandler(this.cmbsexe_SelectedIndexChanged);
            // 
            // labeladreese
            // 
            this.labeladreese.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeladreese.AutoSize = true;
            this.labeladreese.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.labeladreese.Location = new System.Drawing.Point(15, 323);
            this.labeladreese.Name = "labeladreese";
            this.labeladreese.Size = new System.Drawing.Size(55, 20);
            this.labeladreese.TabIndex = 62;
            this.labeladreese.Text = "Niveau";
            // 
            // labelpostnom
            // 
            this.labelpostnom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelpostnom.AutoSize = true;
            this.labelpostnom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.labelpostnom.Location = new System.Drawing.Point(15, 175);
            this.labelpostnom.Name = "labelpostnom";
            this.labelpostnom.Size = new System.Drawing.Size(66, 20);
            this.labelpostnom.TabIndex = 61;
            this.labelpostnom.Text = "Postnom";
            // 
            // labelnom
            // 
            this.labelnom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelnom.AutoSize = true;
            this.labelnom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.labelnom.Location = new System.Drawing.Point(10, 105);
            this.labelnom.Name = "labelnom";
            this.labelnom.Size = new System.Drawing.Size(42, 20);
            this.labelnom.TabIndex = 60;
            this.labelnom.Text = "Nom";
            // 
            // lbl_matricule
            // 
            this.lbl_matricule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_matricule.AutoSize = true;
            this.lbl_matricule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.lbl_matricule.Location = new System.Drawing.Point(10, 33);
            this.lbl_matricule.Name = "lbl_matricule";
            this.lbl_matricule.Size = new System.Drawing.Size(75, 20);
            this.lbl_matricule.TabIndex = 56;
            this.lbl_matricule.Text = "Username";
            this.lbl_matricule.Visible = false;
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
            this.txtpostnom.Location = new System.Drawing.Point(13, 209);
            this.txtpostnom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpostnom.Name = "txtpostnom";
            this.txtpostnom.PasswordChar = '\0';
            this.txtpostnom.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtpostnom.PlaceholderText = "Entrer le postnom";
            this.txtpostnom.SelectedText = "";
            this.txtpostnom.Size = new System.Drawing.Size(300, 36);
            this.txtpostnom.TabIndex = 59;
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
            this.txtnom.Location = new System.Drawing.Point(13, 137);
            this.txtnom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnom.Name = "txtnom";
            this.txtnom.PasswordChar = '\0';
            this.txtnom.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtnom.PlaceholderText = "Entrer le nom";
            this.txtnom.SelectedText = "";
            this.txtnom.Size = new System.Drawing.Size(300, 36);
            this.txtnom.TabIndex = 58;
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
            this.txtmatricule.Location = new System.Drawing.Point(13, 65);
            this.txtmatricule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmatricule.Name = "txtmatricule";
            this.txtmatricule.PasswordChar = '\0';
            this.txtmatricule.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtmatricule.PlaceholderText = "Identifiant";
            this.txtmatricule.SelectedText = "";
            this.txtmatricule.Size = new System.Drawing.Size(300, 36);
            this.txtmatricule.TabIndex = 57;
            // 
            // btnretour
            // 
            this.btnretour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnretour.BackColor = System.Drawing.Color.Transparent;
            this.btnretour.Image = global::ADTMPDapk.Properties.Resources.left_96pxEEE;
            this.btnretour.ImageActive = null;
            this.btnretour.Location = new System.Drawing.Point(8, 2);
            this.btnretour.Name = "btnretour";
            this.btnretour.Size = new System.Drawing.Size(34, 29);
            this.btnretour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnretour.TabIndex = 74;
            this.btnretour.TabStop = false;
            this.btnretour.Zoom = 10;
            this.btnretour.Click += new System.EventHandler(this.btnretour_Click);
            // 
            // labelInscription
            // 
            this.labelInscription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInscription.AutoSize = true;
            this.labelInscription.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInscription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.labelInscription.Location = new System.Drawing.Point(224, 9);
            this.labelInscription.Name = "labelInscription";
            this.labelInscription.Size = new System.Drawing.Size(89, 25);
            this.labelInscription.TabIndex = 75;
            this.labelInscription.Text = "S\'inscrire";
            // 
            // frm_user
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(343, 466);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_user";
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnretour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox txtposte;
        public Guna.UI2.WinForms.Guna2ComboBox cmbniveau;
        private System.Windows.Forms.Label labeladreese;
        private System.Windows.Forms.Label labelpostnom;
        private System.Windows.Forms.Label labelnom;
        private System.Windows.Forms.Label lbl_matricule;
        public Guna.UI2.WinForms.Guna2TextBox txtpostnom;
        public Guna.UI2.WinForms.Guna2TextBox txtnom;
        public Guna.UI2.WinForms.Guna2TextBox txtmatricule;
        private Guna.UI.WinForms.GunaButton btnSave;
        private System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaCheckBox checkStatut;
        public System.Windows.Forms.Label labelInscription;
        public Bunifu.Framework.UI.BunifuImageButton btnretour;
    }
}