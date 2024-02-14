using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cinema.Models
{
    public class Biglietto
    {
        public Utente Utente { get; set; }
        public string Sala { get; set; }
        public string TipoBiglietto { get; set; } 
    }

}