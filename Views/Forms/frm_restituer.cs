using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADTMPDapk.Controllers;
using ADTMPDapk.Models;

namespace ADTMPDapk.Views.Forms
{
    public partial class frm_restituer : Form
    {
        clsRestituer controller = new clsRestituer();
        
        public frm_restituer()
        {
            InitializeComponent();
        }
    }
}
