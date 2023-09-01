namespace ADTMPDapk.Rapports.frm_rapport
{
    partial class frm_bonEntrer
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Plan_remboursement1 = new ADTMPDapk.Rapports.Plan_remboursement();
            this.Bon_entrerCaisse1 = new ADTMPDapk.Rapports.Bon_entrerCaisse();
            this.listeMembre11 = new ADTMPDapk.Rapports.listeMembre1();
            this.listeMembre12 = new ADTMPDapk.Rapports.listeMembre1();
            this.Bon_entrerCaisse2 = new ADTMPDapk.Rapports.Bon_entrerCaisse();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.Bon_entrerCaisse2;
            this.crystalReportViewer1.Size = new System.Drawing.Size(901, 288);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // frm_bonEntrer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 288);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frm_bonEntrer";
            this.Text = "frm_bonEntrer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Plan_remboursement Plan_remboursement1;
        private Bon_entrerCaisse Bon_entrerCaisse1;
        private listeMembre1 listeMembre11;
        private listeMembre1 listeMembre12;
        private Bon_entrerCaisse Bon_entrerCaisse2;
    }
}