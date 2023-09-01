namespace ADTMPDapk.Views.Forms
{
    partial class frm_login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.db_adtmpdDataSet1 = new ADTMPDapk.db_adtmpdDataSet();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpasswer = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnenregistrer = new Guna.UI.WinForms.GunaButton();
            this.btnretour = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelsexe = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblcomptecreer = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_adtmpdDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnretour)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ADTMPDapk.Properties.Resources.about;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 345);
            this.panel1.TabIndex = 2;
            // 
            // db_adtmpdDataSet1
            // 
            this.db_adtmpdDataSet1.DataSetName = "db_adtmpdDataSet";
            this.db_adtmpdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtusername
            // 
            this.txtusername.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtusername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtusername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.DefaultText = "";
            this.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.IconLeft = global::ADTMPDapk.Properties.Resources.user_96pxee;
            this.txtusername.Location = new System.Drawing.Point(46, 111);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(153)))), ((int)(((byte)(241)))));
            this.txtusername.PlaceholderText = "username";
            this.txtusername.SelectedText = "";
            this.txtusername.Size = new System.Drawing.Size(275, 36);
            this.txtusername.TabIndex = 38;
            // 
            // txtpasswer
            // 
            this.txtpasswer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtpasswer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtpasswer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.txtpasswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpasswer.DefaultText = "";
            this.txtpasswer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpasswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpasswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpasswer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpasswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpasswer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtpasswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(151)))), ((int)(((byte)(69)))));
            this.txtpasswer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpasswer.IconLeft = global::ADTMPDapk.Properties.Resources.key_96px;
            this.txtpasswer.Location = new System.Drawing.Point(46, 177);
            this.txtpasswer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtpasswer.Name = "txtpasswer";
            this.txtpasswer.PasswordChar = 'x';
            this.txtpasswer.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.txtpasswer.PlaceholderText = "password";
            this.txtpasswer.SelectedText = "";
            this.txtpasswer.Size = new System.Drawing.Size(275, 41);
            this.txtpasswer.TabIndex = 39;
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.AnimationHoverSpeed = 0.07F;
            this.btnenregistrer.AnimationSpeed = 0.03F;
            this.btnenregistrer.BackColor = System.Drawing.Color.Transparent;
            this.btnenregistrer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.btnenregistrer.BorderColor = System.Drawing.Color.Black;
            this.btnenregistrer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnenregistrer.FocusedColor = System.Drawing.Color.Empty;
            this.btnenregistrer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(195)))), ((int)(((byte)(254)))));
            this.btnenregistrer.Image = null;
            this.btnenregistrer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnenregistrer.ImageSize = new System.Drawing.Size(20, 20);
            this.btnenregistrer.Location = new System.Drawing.Point(128, 294);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(151)))), ((int)(((byte)(70)))));
            this.btnenregistrer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnenregistrer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnenregistrer.OnHoverImage = null;
            this.btnenregistrer.OnPressedColor = System.Drawing.Color.Black;
            this.btnenregistrer.Size = new System.Drawing.Size(193, 32);
            this.btnenregistrer.TabIndex = 44;
            this.btnenregistrer.Text = "Connexion";
            this.btnenregistrer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // btnretour
            // 
            this.btnretour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnretour.BackColor = System.Drawing.Color.Transparent;
            this.btnretour.Image = global::ADTMPDapk.Properties.Resources.left_96pxEEE;
            this.btnretour.ImageActive = null;
            this.btnretour.Location = new System.Drawing.Point(3, 3);
            this.btnretour.Name = "btnretour";
            this.btnretour.Size = new System.Drawing.Size(34, 29);
            this.btnretour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnretour.TabIndex = 45;
            this.btnretour.TabStop = false;
            this.btnretour.Zoom = 10;
            this.btnretour.Click += new System.EventHandler(this.btnretour_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.btnretour);
            this.panel2.Controls.Add(this.btnenregistrer);
            this.panel2.Controls.Add(this.lblcomptecreer);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.labelsexe);
            this.panel2.Controls.Add(this.txtpasswer);
            this.panel2.Controls.Add(this.txtusername);
            this.panel2.Location = new System.Drawing.Point(440, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 335);
            this.panel2.TabIndex = 3;
            // 
            // labelsexe
            // 
            this.labelsexe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelsexe.AutoSize = true;
            this.labelsexe.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsexe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.labelsexe.Location = new System.Drawing.Point(199, 43);
            this.labelsexe.Name = "labelsexe";
            this.labelsexe.Size = new System.Drawing.Size(122, 25);
            this.labelsexe.TabIndex = 40;
            this.labelsexe.Text = "Se connecter";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(151)))), ((int)(((byte)(70)))));
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(153)))), ((int)(((byte)(241)))));
            this.linkLabel1.Location = new System.Drawing.Point(50, 239);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 15);
            this.linkLabel1.TabIndex = 42;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Mot de passe oublié";
            // 
            // lblcomptecreer
            // 
            this.lblcomptecreer.AutoSize = true;
            this.lblcomptecreer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcomptecreer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomptecreer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(153)))), ((int)(((byte)(241)))));
            this.lblcomptecreer.Location = new System.Drawing.Point(225, 239);
            this.lblcomptecreer.Name = "lblcomptecreer";
            this.lblcomptecreer.Size = new System.Drawing.Size(96, 15);
            this.lblcomptecreer.TabIndex = 43;
            this.lblcomptecreer.Text = "Creer un compte";
            this.lblcomptecreer.Click += new System.EventHandler(this.lblcomptecreer_Click_1);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::ADTMPDapk.Properties.Resources.logo;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(10, 8);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(87, 72);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 46;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // frm_login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 342);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_adtmpdDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnretour)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private db_adtmpdDataSet db_adtmpdDataSet1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public Guna.UI2.WinForms.Guna2TextBox txtusername;
        public Guna.UI2.WinForms.Guna2TextBox txtpasswer;
        private Guna.UI.WinForms.GunaButton btnenregistrer;
        private Bunifu.Framework.UI.BunifuImageButton btnretour;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblcomptecreer;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelsexe;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}