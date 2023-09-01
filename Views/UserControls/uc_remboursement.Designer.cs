
namespace ADTMPDapk.Views.UserControls
{
    partial class uc_remboursement
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
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_remboursement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnactualiser = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MembreEnregistrer = new System.Windows.Forms.GroupBox();
            this.dtg_remboursement = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnexcel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnprint = new Bunifu.Framework.UI.BunifuImageButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesFichesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoursementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hebdomadaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depotDeLabonnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.journalierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planRemboursementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnactualiser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.panel1.SuspendLayout();
            this.MembreEnregistrer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_remboursement)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnexcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnprint)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
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
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation5;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.btnactualiser);
            this.gunaElipsePanel1.Controls.Add(this.txtsearch);
            this.gunaElipsePanel1.Controls.Add(this.btnAdd);
            this.gunaElipsePanel1.Controls.Add(this.menuStrip1);
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
            // btnactualiser
            // 
            this.btnactualiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnactualiser.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnactualiser, BunifuAnimatorNS.DecorationType.None);
            this.btnactualiser.Image = global::ADTMPDapk.Properties.Resources.update_left_rotation_96px1;
            this.btnactualiser.ImageActive = null;
            this.btnactualiser.Location = new System.Drawing.Point(1068, -1);
            this.btnactualiser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnactualiser.Name = "btnactualiser";
            this.btnactualiser.Size = new System.Drawing.Size(35, 24);
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
            // MembreEnregistrer
            // 
            this.MembreEnregistrer.Controls.Add(this.dtg_remboursement);
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
            this.MembreEnregistrer.Text = "Enregistrement ";
            // 
            // dtg_remboursement
            // 
            this.dtg_remboursement.AllowUserToOrderColumns = true;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtg_remboursement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dtg_remboursement.BackgroundColor = System.Drawing.Color.White;
            this.dtg_remboursement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_remboursement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_remboursement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtg_remboursement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_remboursement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricule,
            this.nom,
            this.phone,
            this.postnom,
            this.sexe,
            this.Column1});
            this.bunifuTransition1.SetDecoration(this.dtg_remboursement, BunifuAnimatorNS.DecorationType.None);
            this.dtg_remboursement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_remboursement.DoubleBuffered = true;
            this.dtg_remboursement.EnableHeadersVisualStyles = false;
            this.dtg_remboursement.GridColor = System.Drawing.Color.White;
            this.dtg_remboursement.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.dtg_remboursement.HeaderForeColor = System.Drawing.Color.White;
            this.dtg_remboursement.Location = new System.Drawing.Point(4, 25);
            this.dtg_remboursement.Name = "dtg_remboursement";
            this.dtg_remboursement.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_remboursement.Size = new System.Drawing.Size(1098, 387);
            this.dtg_remboursement.TabIndex = 0;
            this.dtg_remboursement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_remboursement_CellContentClick);
            // 
            // matricule
            // 
            this.matricule.DataPropertyName = "id_remb";
            this.matricule.HeaderText = "Id";
            this.matricule.Name = "matricule";
            // 
            // nom
            // 
            this.nom.DataPropertyName = "membre";
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.Width = 210;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "dateRemb";
            this.phone.HeaderText = "Date remboursement";
            this.phone.Name = "phone";
            this.phone.Width = 220;
            // 
            // postnom
            // 
            this.postnom.DataPropertyName = "montantRemb";
            this.postnom.HeaderText = "Montant Remb";
            this.postnom.Name = "postnom";
            this.postnom.Width = 210;
            // 
            // sexe
            // 
            this.sexe.DataPropertyName = "user";
            this.sexe.HeaderText = "Nom du percepteur";
            this.sexe.Name = "sexe";
            this.sexe.Width = 210;
            // 
            // Column1
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Supprimer";
            this.Column1.UseColumnTextForButtonValue = true;
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
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnexcel);
            this.panel2.Controls.Add(this.btnprint);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 552);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 55);
            this.panel2.TabIndex = 7;
            // 
            // btnexcel
            // 
            this.btnexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexcel.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnexcel, BunifuAnimatorNS.DecorationType.None);
            this.btnexcel.Image = global::ADTMPDapk.Properties.Resources.microsoft_excel_96px;
            this.btnexcel.ImageActive = null;
            this.btnexcel.Location = new System.Drawing.Point(979, 18);
            this.btnexcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(50, 32);
            this.btnexcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnexcel.TabIndex = 6;
            this.btnexcel.TabStop = false;
            this.btnexcel.Zoom = 10;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
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
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // menuStrip1
            // 
            this.bunifuTransition1.SetDecoration(this.menuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapportToolStripMenuItem,
            this.mesFichesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rapportToolStripMenuItem
            // 
            this.rapportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.journalierToolStripMenuItem,
            this.planRemboursementToolStripMenuItem});
            this.rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            this.rapportToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.rapportToolStripMenuItem.Text = "Rapport";
            // 
            // mesFichesToolStripMenuItem
            // 
            this.mesFichesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remoursementToolStripMenuItem,
            this.depotDeLabonnerToolStripMenuItem});
            this.mesFichesToolStripMenuItem.Name = "mesFichesToolStripMenuItem";
            this.mesFichesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.mesFichesToolStripMenuItem.Text = "Mes fiches";
            // 
            // remoursementToolStripMenuItem
            // 
            this.remoursementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hebdomadaireToolStripMenuItem});
            this.remoursementToolStripMenuItem.Name = "remoursementToolStripMenuItem";
            this.remoursementToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.remoursementToolStripMenuItem.Text = "Remoursement";
            // 
            // hebdomadaireToolStripMenuItem
            // 
            this.hebdomadaireToolStripMenuItem.Name = "hebdomadaireToolStripMenuItem";
            this.hebdomadaireToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.hebdomadaireToolStripMenuItem.Text = "Hebdomadaire";
            // 
            // depotDeLabonnerToolStripMenuItem
            // 
            this.depotDeLabonnerToolStripMenuItem.Name = "depotDeLabonnerToolStripMenuItem";
            this.depotDeLabonnerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.depotDeLabonnerToolStripMenuItem.Text = "Depot de l\'abonner";
            // 
            // journalierToolStripMenuItem
            // 
            this.journalierToolStripMenuItem.Name = "journalierToolStripMenuItem";
            this.journalierToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.journalierToolStripMenuItem.Text = "Journalier";
            this.journalierToolStripMenuItem.Click += new System.EventHandler(this.journalierToolStripMenuItem_Click);
            // 
            // planRemboursementToolStripMenuItem
            // 
            this.planRemboursementToolStripMenuItem.Name = "planRemboursementToolStripMenuItem";
            this.planRemboursementToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.planRemboursementToolStripMenuItem.Text = "Plan Remboursement";
            this.planRemboursementToolStripMenuItem.Click += new System.EventHandler(this.planRemboursementToolStripMenuItem_Click);
            // 
            // uc_remboursement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uc_remboursement";
            this.Size = new System.Drawing.Size(1114, 610);
            this.Load += new System.EventHandler(this.uc_remboursement_Load);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnactualiser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.MembreEnregistrer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_remboursement)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnexcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnprint)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Bunifu.Framework.UI.BunifuImageButton btnactualiser;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox MembreEnregistrer;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtg_remboursement;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnexcel;
        private Bunifu.Framework.UI.BunifuImageButton btnprint;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn postnom;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesFichesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoursementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hebdomadaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depotDeLabonnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem journalierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planRemboursementToolStripMenuItem;
    }
}
