using System;

namespace ADTMPDapk.Models
{
    class Membre
    {
        public string matricule { get; set; }
        public string nom { get; set; }
        public string postnom { get; set; }
        public string adresse { get; set; }
        public string phone { get; set; }
        public string sexe { get; set; }
        public string lieuNaiss { get; set; }
   
        public DateTime dateNaiss { get; set; }
      
        public string photo { get; set; }
        public string ref_type { get; set; }


    }
}
