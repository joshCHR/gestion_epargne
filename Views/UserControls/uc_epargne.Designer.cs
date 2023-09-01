
namespace ADTMPDapk.Views.UserControls
{
    partial class uc_epargne
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_epargne));
            this.MembreEnregistrer = new System.Windows.Forms.GroupBox();
            this.dtg_epargne = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaNaiss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationEpargne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libeleCompte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieuNaiss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.btnRecu = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnexcel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnprint = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnactualiser = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.MembreEnregistrer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_epargne)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnprint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnactualiser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // MembreEnregistrer
            // 
            this.MembreEnregistrer.Controls.Add(this.dtg_epargne);
            this.bunifuTransition1.SetDecoration(this.MembreEnregistrer, BunifuAnimatorNS.DecorationType.None);
            this.MembreEnregistrer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MembreEnregistrer.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembreEnregistrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.MembreEnregistrer.Location = new System.Drawing.Point(0, 0);
            this.MembreEnregistrer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MembreEnregistrer.Name = "MembreEnregistrer";
            this.MembreEnregistrer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MembreEnregistrer.Size = new System.Drawing.Size(1106, 417);
            this.MembreEnregistrer.TabIndex = 1;
            this.MembreEnregistrer.TabStop = false;
            this.MembreEnregistrer.Text = "EnregistrementEpargne";
            // 
            // dtg_epargne
            // 
            this.dtg_epargne.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtg_epargne.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_epargne.BackgroundColor = System.Drawing.Color.White;
            this.dtg_epargne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_epargne.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_epargne.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_epargne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_epargne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricule,
            this.nom,
            this.detaNaiss,
            this.Column2,
            this.designationEpargne,
            this.libeleCompte,
            this.sexe,
            this.lieuNaiss,
            this.Column1});
            this.bunifuTransition1.SetDecoration(this.dtg_epargne, BunifuAnimatorNS.DecorationType.None);
            this.dtg_epargne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_epargne.DoubleBuffered = true;
            this.dtg_epargne.EnableHeadersVisualStyles = false;
            this.dtg_epargne.GridColor = System.Drawing.Color.White;
            this.dtg_epargne.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.dtg_epargne.HeaderForeColor = System.Drawing.Color.White;
            this.dtg_epargne.Location = new System.Drawing.Point(4, 25);
            this.dtg_epargne.Name = "dtg_epargne";
            this.dtg_epargne.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_epargne.Size = new System.Drawing.Size(1098, 387);
            this.dtg_epargne.TabIndex = 1;
            this.dtg_epargne.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_epargne_CellContentClick);
            // 
            // matricule
            // 
            this.matricule.DataPropertyName = "idEpargne";
            this.matricule.HeaderText = "Id";
            this.matricule.Name = "matricule";
            this.matricule.Width = 60;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "membre";
            this.nom.HeaderText = "Membre";
            this.nom.Name = "nom";
            this.nom.Width = 140;
            // 
            // detaNaiss
            // 
            this.detaNaiss.DataPropertyName = "idUser";
            this.detaNaiss.HeaderText = "Percepteur";
            this.detaNaiss.Name = "detaNaiss";
            this.detaNaiss.Width = 140;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "numeroEpargne";
            this.Column2.HeaderText = "Numero";
            this.Column2.Name = "Column2";
            // 
            // designationEpargne
            // 
            this.designationEpargne.DataPropertyName = "designationEpargne";
            this.designationEpargne.FillWeight = 120F;
            this.designationEpargne.HeaderText = "Designation";
            this.designationEpargne.Name = "designationEpargne";
            this.designationEpargne.Width = 140;
            // 
            // libeleCompte
            // 
            this.libeleCompte.DataPropertyName = "libeleCompte";
            this.libeleCompte.HeaderText = "Libelle";
            this.libeleCompte.Name = "libeleCompte";
            this.libeleCompte.Width = 120;
            // 
            // sexe
            // 
            this.sexe.DataPropertyName = "montantEpargne";
            this.sexe.HeaderText = "Montant";
            this.sexe.Name = "sexe";
            this.sexe.Width = 130;
            // 
            // lieuNaiss
            // 
            this.lieuNaiss.DataPropertyName = "dateVersement";
            this.lieuNaiss.HeaderText = "Date";
            this.lieuNaiss.Name = "lieuNaiss";
            this.lieuNaiss.Width = 120;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Supprimer";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.btnactualiser);
            this.gunaElipsePanel1.Controls.Add(this.txtsearch);
            this.gunaElipsePanel1.Controls.Add(this.btnAdd);
            this.bunifuTransition1.SetDecoration(this.gunaElipsePanel1, BunifuAnimatorNS.DecorationType.None);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaElipsePanel1.Location = new System.Drawing.Point(4, 5);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 3;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1106, 112);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gunaElipsePanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1114, 610);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRecu);
            this.panel2.Controls.Add(this.btnexcel);
            this.panel2.Controls.Add(this.btnprint);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 552);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 55);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MembreEnregistrer);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(4, 127);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 417);
            this.panel1.TabIndex = 1;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // gunaContextMenuStrip1
            // 
            this.bunifuTransition1.SetDecoration(this.gunaContextMenuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.gunaContextMenuStrip1.Name = "gunaContextMenuStrip1";
            this.gunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btnRecu
            // 
            this.btnRecu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecu.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnRecu, BunifuAnimatorNS.DecorationType.None);
            this.btnRecu.Image = global::ADTMPDapk.Properties.Resources.receipt_96px;
            this.btnRecu.ImageActive = null;
            this.btnRecu.Location = new System.Drawing.Point(937, 18);
            this.btnRecu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecu.Name = "btnRecu";
            this.btnRecu.Size = new System.Drawing.Size(50, 32);
            this.btnRecu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRecu.TabIndex = 7;
            this.btnRecu.TabStop = false;
            this.btnRecu.Zoom = 10;
            this.btnRecu.Click += new System.EventHandler(this.btnRecu_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexcel.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnexcel, BunifuAnimatorNS.DecorationType.None);
            this.btnexcel.Image = global::ADTMPDapk.Properties.Resources.microsoft_excel_96px;
            this.btnexcel.ImageActive = null;
            this.btnexcel.Location = new System.Drawing.Point(995, 18);
            this.btnexcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(50, 32);
            this.btnexcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnexcel.TabIndex = 6;
            this.btnexcel.TabStop = false;
            this.btnexcel.Zoom = 10;
            // 
            // btnprint
            // 
            this.btnprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprint.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnprint, BunifuAnimatorNS.DecorationType.None);
            this.btnprint.Image = global::ADTMPDapk.Properties.Resources.print_96px;
            this.btnprint.ImageActive = null;
            this.btnprint.Location = new System.Drawing.Point(1053, 18);
            this.btnprint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(50, 32);
            this.btnprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnprint.TabIndex = 5;
            this.btnprint.TabStop = false;
            this.btnprint.Zoom = 10;
            // 
            // btnactualiser
            // 
            this.btnactualiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnactualiser.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnactualiser, BunifuAnimatorNS.DecorationType.None);
            this.btnactualiser.Image = global::ADTMPDapk.Properties.Resources.update_left_rotation_96px1;
            this.btnactualiser.ImageActive = null;
            this.btnactualiser.Location = new System.Drawing.Point(1052, 0);
            this.btnactualiser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnactualiser.Name = "btnactualiser";
            this.btnactualiser.Size = new System.Drawing.Size(50, 32);
            this.btnactualiser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnactualiser.TabIndex = 4;
            this.btnactualiser.TabStop = false;
            this.btnactualiser.Zoom = 10;
            this.btnactualiser.Click += new System.EventHandler(this.btnactualiser_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtsearch.BorderRadius = 3;
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txtsearch, BunifuAnimatorNS.DecorationType.None);
            this.txtsearch.DefaultText = "";
            this.txtsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.IconRight = global::ADTMPDapk.Properties.Resources.search_32px;
            this.txtsearch.Location = new System.Drawing.Point(798, 76);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.txtsearch.PlaceholderText = "Rechecher membre";
            this.txtsearch.SelectedText = "";
            this.txtsearch.Size = new System.Drawing.Size(304, 32);
            this.txtsearch.TabIndex = 3;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnAdd, BunifuAnimatorNS.DecorationType.None);
            this.btnAdd.Image = global::ADTMPDapk.Properties.Resources.ad_96px;
            this.btnAdd.ImageActive = null;
            this.btnAdd.Location = new System.Drawing.Point(11, 76);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 32);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 2;
            this.btnAdd.TabStop = false;
            this.btnAdd.Zoom = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // uc_epargne
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uc_epargne";
            this.Size = new System.Drawing.Size(1114, 610);
            this.Load += new System.EventHandler(this.uc_epargne_Load);
            this.MembreEnregistrer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_epargne)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRecu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnprint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnactualiser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.GroupBox MembreEnregistrer;
        private Bunifu.Framework.UI.BunifuImageButton btnactualiser;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtg_epargne;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnexcel;
        private Bunifu.Framework.UI.BunifuImageButton btnprint;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn detaNaiss;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationEpargne;
        private System.Windows.Forms.DataGridViewTextBoxColumn libeleCompte;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieuNaiss;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private Bunifu.Framework.UI.BunifuImageButton btnRecu;
    }
}
