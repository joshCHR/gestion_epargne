﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADTMPDapk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            crystalReportViewer1.SelectionFormula = "{Plan_remboursement.Noms}='" + txtsearch.Text + "'";
            crystalReportViewer1.Refresh();
            crystalReportViewer1.RefreshReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
