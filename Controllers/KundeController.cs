using System;
using System.Collections.Generic;
using KundeApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace KundeApp.Controllers
{
    [Route("[controller]/[action]")]
    public class KundeController :ControllerBase
    {
        public List<Kunde> HentAlle()
        {
            var kundene = new List<Kunde>();

            var kunde1 = new Kunde();
            kunde1.navn = "Per Hansen";
            kunde1.adresse = "Osloveien 2";

            var kunde2 = new Kunde()
            {
                navn = "Line Hansen",
                adresse = "Drammenveien 2"
            };

            kundene.Add(kunde1);
            kundene.Add(kunde2);

            return kundene;
            
        }
        
    }
}

