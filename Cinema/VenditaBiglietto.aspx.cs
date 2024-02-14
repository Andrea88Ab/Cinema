using Cinema.Data;
using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



    

    public partial class VenditaBiglietto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Qui potresti inizializzare ulteriormente la tua UI se necessario
                // Ad esempio, potresti caricare dinamicamente le sale da un database
            }
        }

        protected void ButtonVendi_Click(object sender, EventArgs e)
        {
            try
            {
                // Crea un nuovo biglietto basato sui dati dell'interfaccia
                Biglietto nuovoBiglietto = new Biglietto
                {
                    Utente = new Utente
                    {
                        Nome = TextBoxNome.Text,
                        Cognome = TextBoxCognome.Text
                    },
                    Sala = DropDownListSala.SelectedValue,
                    TipoBiglietto = DropDownListTipoBiglietto.SelectedValue
                };

                // Qui dovresti aggiungere la logica per salvare il biglietto,
                // ad esempio aggiungendolo a una lista in sessione o salvandolo in un database
                // Per questo esempio, immaginiamo di aggiungerlo a una lista in sessione
                List<Biglietto> bigliettiVenduti = Session["BigliettiVenduti"] as List<Biglietto> ?? new List<Biglietto>();
                bigliettiVenduti.Add(nuovoBiglietto);
                Session["BigliettiVenduti"] = bigliettiVenduti;

                // Imposta un messaggio di successo
                LabelMessaggi.Text = "Biglietto venduto con successo!";
                LabelMessaggio.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                // In caso di errore, mostra un messaggio
                LabelMessaggio.Text = "Errore nella vendita del biglietto: " + ex.Message;
                LabelMessaggio.ForeColor = System.Drawing.Color.Red;
            }
        }
    }



