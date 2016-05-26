using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class Voorstelling
    {
        partial void BioscoopNaam_Compute(ref string result)
        {
            // Set result to the desired field value
            result = this.Zaal.Bioscoop.Naam;
        }

        partial void BioscoopPlaats_Compute(ref string result)
        {
            // Set result to the desired field value
            result = this.Zaal.Bioscoop.Stad;
        }
    }
}