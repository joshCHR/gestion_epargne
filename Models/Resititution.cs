using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTMPDapk.Models
{
    class Resititution
    {
        public Int32 Id_restituer { get; set; }
        public Int32 Ref_pret { get; set; }
        public Int32 Ref_rembourser { get; set; }
        public SqlMoney Interets { get; set; }
        public SqlMoney Rest_apayer { get; set; }
        public DateTime Date_rest { get; set; }
        

    }
}
