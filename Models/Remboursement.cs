using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTMPDapk.Models
{
    class Remboursement
    {

        public int Id_remb { get; set; }
        public string IdPret { get; set; }
        public DateTime Date { get; set; }
        public SqlMoney MontantRemb { get; set; }
        public string Id_user { get; set; }
        public string Membre { get; set; }
    }
}
