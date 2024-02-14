using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cinema.Data
{
    public class GestioneCinema
    {
        
        public static List<SalaCinema> Sale => HttpContext.Current.Session["Sale"] as List<SalaCinema> ?? new List<SalaCinema>();
        public static List<Biglietto> BigliettiVenduti => HttpContext.Current.Session["BigliettiVenduti"] as List<Biglietto> ?? new List<Biglietto>();

        public static void VendiBiglietto(Biglietto biglietto)
        {
            BigliettiVenduti.Add(biglietto);
            HttpContext.Current.Session["BigliettiVenduti"] = BigliettiVenduti;

            var sala = Sale.FirstOrDefault(s => s.NomeSala == biglietto.Sala);
            if (sala != null)
            {
                sala.BigliettiVenduti++;
                if (biglietto.TipoBiglietto == "Ridotto")
                {
                    sala.BigliettiRidottiVenduti++;
                }
            }
        }
    }

}