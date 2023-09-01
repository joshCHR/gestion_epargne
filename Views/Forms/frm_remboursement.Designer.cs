
namespace ADTMPDapk
{
    partial class frm_remboursement
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtperception = new Guna.UI2.WinForms.Guna2TextBox();
            this.t_loginTableAdapter1 = new ADTMPDapk.db_adtmpdDataSetTableAdapters.t_loginTableAdapter();
            this.labeltitre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btmfermer = new Bunifu.Framework.UI.BunifuImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.daterembousement = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labelsexe = new System.Windows.Forms.Label();
            this.txtmontant = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnenregistrer = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.labelphone = new System.Windows.Forms.Label();
            this.cmbmembre = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnactualiser = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btmfermer)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnactualiser)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.label3.Location = new System.Drawing.Point(61, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "01";
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
            this.txtperception.Location = new System.Drawing.Point(341, 166);
            this.txtperception.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtperception.Name = "txtperception";
            this.txtperception.PasswordChar = '\0';
            this.txtperception.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtperception.PlaceholderText = "nom du percepteur";
            this.txtperception.SelectedText = "";
            this.txtperception.Size = new System.Drawing.Size(268, 37);
            this.txtperception.TabIndex = 49;
            // 
            // t_loginTableAdapter1
            // 
            this.t_loginTableAdapter1.ClearBeforeFill = true;
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
            this.labeltitre.Size = new System.Drawing.Size(118, 20);
            this.labeltitre.TabIndex = 3;
            this.labeltitre.Text = "Remboursement";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.labeltitre);
            this.panel1.Controls.Add(this.btmfermer);
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 35);
            this.panel1.TabIndex = 0;
            // 
            // btmfermer
            // 
            this.btmfermer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmfermer.BackColor = System.Drawing.Color.Transparent;
            this.btmfermer.Image = global::ADTMPDapk.Properties.Resources.close_window_96px;
            this.btmfermer.ImageActive = null;
            this.btmfermer.Location = new System.Drawing.Point(632, 3);
            this.btmfermer.Name = "btmfermer";
            this.btmfermer.Size = new System.Drawing.Size(36, 29);
            this.btmfermer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btmfermer.TabIndex = 2;
            this.btmfermer.TabStop = false;
            this.btmfermer.Zoom = 10;
            this.btmfermer.Click += new System.EventHandler(this.btmfermer_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.label4.Location = new System.Drawing.Point(337, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Nom du percepteur";
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.label2.Location = new System.Drawing.Point(31, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(337, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Date de remboursement";
            // 
            // daterembousement
            // 
            this.daterembousement.Checked = true;
            this.daterembousement.FillColor = System.Drawing.Color.White;
            this.daterembousement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.daterembousement.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.daterembousement.Location = new System.Drawing.Point(341, 86);
            this.daterembousement.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.daterembousement.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.daterembousement.Name = "daterembousement";
            this.daterembousement.Size = new System.Drawing.Size(268, 45);
            this.daterembousement.TabIndex = 41;
            this.daterembousement.Value = new System.DateTime(2023, 7, 19, 15, 36, 14, 47);
            // 
            // labelsexe
            // 
            this.labelsexe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelsexe.AutoSize = true;
            this.labelsexe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.labelsexe.Location = new System.Drawing.Point(34, 63);
            this.labelsexe.Name = "labelsexe";
            this.labelsexe.Size = new System.Drawing.Size(65, 20);
            this.labelsexe.TabIndex = 36;
            this.labelsexe.Text = "Membre";
            // 
            // txtmontant
            // 
            this.txtmontant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtmontant.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtmontant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmontant.DefaultText = "";
            this.txtmontant.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmontant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmontant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmontant.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmontant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmontant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmontant.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmontant.Location = new System.Drawing.Point(29, 166);
            this.txtmontant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmontant.Name = "txtmontant";
            this.txtmontant.PasswordChar = '\0';
            this.txtmontant.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtmontant.PlaceholderText = "Montant verser";
            this.txtmontant.SelectedText = "";
            this.txtmontant.Size = new System.Drawing.Size(256, 37);
            this.txtmontant.TabIndex = 26;
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
            this.btnenregistrer.Location = new System.Drawing.Point(198, 381);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnenregistrer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnenregistrer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnenregistrer.OnHoverImage = null;
            this.btnenregistrer.OnPressedColor = System.Drawing.Color.Black;
            this.btnenregistrer.Size = new System.Drawing.Size(273, 32);
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
            this.gunaElipsePanel1.Controls.Add(this.label3);
            this.gunaElipsePanel1.Controls.Add(this.label4);
            this.gunaElipsePanel1.Controls.Add(this.txtperception);
            this.gunaElipsePanel1.Controls.Add(this.label2);
            this.gunaElipsePanel1.Controls.Add(this.label1);
            this.gunaElipsePanel1.Controls.Add(this.daterembousement);
            this.gunaElipsePanel1.Controls.Add(this.labelsexe);
            this.gunaElipsePanel1.Controls.Add(this.labelphone);
            this.gunaElipsePanel1.Controls.Add(this.cmbmembre);
            this.gunaElipsePanel1.Controls.Add(this.txtmontant);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(15, 77);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 3;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(659, 304);
            this.gunaElipsePanel1.TabIndex = 24;
            // 
            // labelphone
            // 
            this.labelphone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelphone.AutoSize = true;
            this.labelphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.labelphone.Location = new System.Drawing.Point(34, 141);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(149, 20);
            this.labelphone.TabIndex = 35;
            this.labelphone.Text = "Montant Rembourser";
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
            this.cmbmembre.Location = new System.Drawing.Point(30, 95);
            this.cmbmembre.Name = "cmbmembre";
            this.cmbmembre.Size = new System.Drawing.Size(255, 36);
            this.cmbmembre.TabIndex = 29;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.btnenregistrer);
            this.gunaShadowPanel1.Controls.Add(this.gunaElipsePanel1);
            this.gunaShadowPanel1.Controls.Add(this.btnactualiser);
            this.gunaShadowPanel1.Controls.Add(this.panel1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(2, 2);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(677, 423);
            this.gunaShadowPanel1.TabIndex = 3;
            // 
            // btnactualiser
            // 
            this.btnactualiser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnactualiser.BackColor = System.Drawing.Color.Transparent;
            this.btnactualiser.Image = global::ADTMPDapk.Properties.Resources.update_left_rotation_96px;
            this.btnactualiser.ImageActive = null;
            this.btnactualiser.Location = new System.Drawing.Point(631, 44);
            this.btnactualiser.Name = "btnactualiser";
            this.btnactualiser.Size = new System.Drawing.Size(36, 27);
            this.btnactualiser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnactualiser.TabIndex = 23;
            this.btnactualiser.TabStop = false;
            this.btnactualiser.Zoom = 10;
            // 
            // frm_remboursement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 427);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_remboursement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_remboursement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btmfermer)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.gunaShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnactualiser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox txtperception;
        private db_adtmpdDataSetTableAdapters.t_loginTableAdapter t_loginTableAdapter1;
        private System.Windows.Forms.Label labeltitre;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btmfermer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnactualiser;
        private System.Windows.Forms.Label labelsexe;
        public Guna.UI2.WinForms.Guna2TextBox txtmontant;
        private Guna.UI.WinForms.GunaButton btnenregistrer;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.Label labelphone;
        public Guna.UI2.WinForms.Guna2ComboBox cmbmembre;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        public Guna.UI2.WinForms.Guna2DateTimePicker daterembousement;
    }
}