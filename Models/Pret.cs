using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace ADTMPDapk.Models
{
    class Pret
    {
        public int Id_pret { get; set; }
        public string Membre { get; set; }
        public string Secteur { get; set; }
        public SqlMoney Versement { get; set; }
        public string Activite { get; set; }
        public DateTime Date_pret { get; set; }
        public string User { get; set; }
    }
}
