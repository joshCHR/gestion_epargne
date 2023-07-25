
namespace ADTMPDapk
{
    partial class frm_typemembre
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labellieuNaiss = new System.Windows.Forms.Label();
            this.labelsexe = new System.Windows.Forms.Label();
            this.txtdesignation = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbtypemembre = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labellieuNaiss);
            this.panel1.Controls.Add(this.labelsexe);
            this.panel1.Controls.Add(this.txtdesignation);
            this.panel1.Controls.Add(this.cmbtypemembre);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 146);
            this.panel1.TabIndex = 42;
            // 
            // labellieuNaiss
            // 
            this.labellieuNaiss.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labellieuNaiss.AutoSize = true;
            this.labellieuNaiss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.labellieuNaiss.Location = new System.Drawing.Point(96, 73);
            this.labellieuNaiss.Name = "labellieuNaiss";
            this.labellieuNaiss.Size = new System.Drawing.Size(89, 20);
            this.labellieuNaiss.TabIndex = 45;
            this.labellieuNaiss.Text = "Designation";
            // 
            // labelsexe
            // 
            this.labelsexe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelsexe.AutoSize = true;
            this.labelsexe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.labelsexe.Location = new System.Drawing.Point(94, 8);
            this.labelsexe.Name = "labelsexe";
            this.labelsexe.Size = new System.Drawing.Size(65, 20);
            this.labelsexe.TabIndex = 44;
            this.labelsexe.Text = "Membre";
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
            this.txtdesignation.Location = new System.Drawing.Point(90, 89);
            this.txtdesignation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdesignation.Name = "txtdesignation";
            this.txtdesignation.PasswordChar = '\0';
            this.txtdesignation.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtdesignation.PlaceholderText = "designation";
            this.txtdesignation.SelectedText = "";
            this.txtdesignation.Size = new System.Drawing.Size(257, 36);
            this.txtdesignation.TabIndex = 43;
            // 
            // cmbtypemembre
            // 
            this.cmbtypemembre.BackColor = System.Drawing.Color.Transparent;
            this.cmbtypemembre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbtypemembre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbtypemembre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtypemembre.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbtypemembre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbtypemembre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbtypemembre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbtypemembre.ItemHeight = 30;
            this.cmbtypemembre.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.cmbtypemembre.Location = new System.Drawing.Point(90, 22);
            this.cmbtypemembre.Name = "cmbtypemembre";
            this.cmbtypemembre.Size = new System.Drawing.Size(255, 36);
            this.cmbtypemembre.TabIndex = 42;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::ADTMPDapk.Properties.Resources.update_left_rotation_96px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(446, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(36, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 43;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // frm_typemembre
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 200);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_typemembre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_typemembre";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labellieuNaiss;
        private System.Windows.Forms.Label labelsexe;
        public Guna.UI2.WinForms.Guna2TextBox txtdesignation;
        public Guna.UI2.WinForms.Guna2ComboBox cmbtypemembre;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}