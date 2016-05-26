using Microsoft.LightSwitch.Presentation.Extensions;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.IO;
using System.Linq;
using System;

namespace LightSwitchApplication
{
    public partial class FilmVoorstellingen
    {
        partial void FilmVoorstellingen_Created()
        {
            AantalVoorstellingen = this.Voorstellings.Count();
            AantalVoorstellingenToekomst = this.Voorstellings.Where(x => x.Datum > DateTime.Now).Count();
        }
        partial void Films_SelectionChanged()
        {
            AantalVoorstellingen = this.Voorstellings.Count();
            AantalVoorstellingenToekomst = this.Voorstellings.Where(x => x.Datum > DateTime.Now).Count();
        }

        partial void PrijsInfo_Execute()
        {
            // Write your code here.
            decimal LaagstePrijsDecimal = 0;
            var LaatstePrijs = this.Voorstellings.OrderBy(x => x.Prijs).FirstOrDefault();

            if (LaatstePrijs != null)
            {
                LaagstePrijsDecimal = (decimal)LaatstePrijs.Prijs;
            }


            decimal HoogstePrijsDecimal = 0;
            var HoogstePrijs = this.Voorstellings.OrderByDescending(x => x.Prijs).FirstOrDefault();

            if (HoogstePrijs != null)
            {
                HoogstePrijsDecimal = (decimal)HoogstePrijs.Prijs;
            }

            this.ShowMessageBox("Goedkoopste voorstellingsprijs: " + LaagstePrijsDecimal + Environment.NewLine + "Duurste voorstellingsprijs: " + HoogstePrijsDecimal);
        }

        partial void AantalBioscopen_Execute()
        {
      
            this.ShowMessageBox("Aantal (verschillende) bioscopen, waar deze film draait of heeft gedraaid: " + this.Voorstellings.Select(x => x.Zaal.Bioscoop).GroupBy(x => x.BioscoopId).Count().ToString());
        }
    }
}