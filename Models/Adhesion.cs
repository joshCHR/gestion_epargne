using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTMPDapk.Models
{
    class Adhesion
    {
        public int IdAhesion { get; set; }
        public string MatriculeMembre { get; set; }
        public DateTime DateAdhesion { get; set; }
        public  SqlMoney MontantAdhesion { get; set; }
        public string MotifAdhesion { get; set; }
        public string StatutAdhesion { get; set; }

    }
}
