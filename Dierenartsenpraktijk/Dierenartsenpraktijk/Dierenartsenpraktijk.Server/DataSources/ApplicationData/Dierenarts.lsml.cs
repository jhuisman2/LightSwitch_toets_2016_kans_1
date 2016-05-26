using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class Dierenarts
    {
        partial void Salaris_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if(Salaris < 1850 || Salaris > 5000)
            {
                results.AddPropertyError("Dit salaris valt buiten de range (1850 - 5000 euro)");
            }
        }

        partial void Dierenarts_Created()
        {
            Salaris = 2500;
        }

        partial void AantalBehandelingen_Compute(ref int result)
        {
            // Set result to the desired field value
            result = this.Behandelings.Count();
        }

      
    }
}