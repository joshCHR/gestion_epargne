using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTMPDapk.Models
{
    class Epargne
    {
        public int IdEpargne { get; set; }
        public string MatriculeMembre { get; set; }
        public string IdUser { get; set; }
        public string NumeroEpargne { get; set; }
        public string DesignationEpargne { get; set; }
        public string LibeleCompte { get; set; }
        public  SqlMoney MontantEpargne { get; set; }
        public DateTime DateVersement { get; set; }

    }
}
