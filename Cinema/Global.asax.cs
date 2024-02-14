using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Cinema
{
    public class Global : System.Web.HttpApplication
    {
        protected void Session_Start(object sender, EventArgs e)
        {
            
            Session["Sale"] = new List<SalaCinema>()
    {
        new SalaCinema { NomeSala = "SALA NORD", BigliettiVenduti = 0, BigliettiRidottiVenduti = 0 },
        new SalaCinema { NomeSala = "SALA EST", BigliettiVenduti = 0, BigliettiRidottiVenduti = 0 },
        new SalaCinema { NomeSala = "SALA SUD", BigliettiVenduti = 0, BigliettiRidottiVenduti = 0 }
    };
            Session["BigliettiVenduti"] = new List<Biglietto>();
        }

    }


}