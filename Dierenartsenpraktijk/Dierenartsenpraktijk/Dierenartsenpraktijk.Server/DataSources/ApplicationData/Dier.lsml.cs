using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Diagnostics;

namespace LightSwitchApplication
{
    public partial class Dier
    {
        partial void DierSummary_Compute(ref string result)
        {
            // Set result to the desired field value
            // Maak een lege string aan
            string extraValueForRas = "";
            
            // Wanneer ras niet leeg is, maak dan een variable met extra tekst om het ras te duiden
            if(this.Ras != null)
            {
                extraValueForRas = " is een " + this.Ras;
            }
            result = this.Soort + ' ' + this.Naam + " van " + this.Eigenaar.Naam + extraValueForRas;
        }

        partial void Leeftijd_Compute(ref int result)
        {
            // Set result to the desired field value
            if (this.Geboortedatum != null)
            {
                result = (DateTime.Now.Year) - (DateTime.Parse(this.Geboortedatum.ToString()).Year);
            }

        }

        partial void Klasse_Compute(ref string result)
        {
            // Set result to the desired field value
            if (this.Gewicht < 15)
            {
                result = "Klein";
            }
            else
            {
                if (this.Gewicht >= 15 && this.Gewicht < 30)
                {
                    result = "Middel";
                }
                else {
                    result = "Groot";
                }
            }
        }

        partial void Soort_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if(Soort != "HO" && Soort != "KA" && Soort != "KN" && Soort != "VO" && Soort != "VI")
            {
                results.AddPropertyError("Deze diersoort is niet bekend");
            }
        }

        partial void Gewicht_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if (Soort == "HO") {
                if (Gewicht > 60)
                {
                    results.AddPropertyResult("Het ingevulde gewicht van de hond is bijzonder groot", ValidationSeverity.Informational);
                }
            }
        }
    }
}