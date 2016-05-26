using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class Film
    {
        partial void Kijkwijzer_Compute(ref string result)
        {
            // Set result to the desired field value
            if(LeeftijdIndicatie == 0)
            {
                result = "AL";
            } else
            {
                result = LeeftijdIndicatie.ToString();
            }
        }

      
    }
}