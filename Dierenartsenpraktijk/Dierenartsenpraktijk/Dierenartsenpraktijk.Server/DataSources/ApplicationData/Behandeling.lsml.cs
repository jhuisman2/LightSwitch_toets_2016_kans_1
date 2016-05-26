using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class Behandeling
    {
        partial void Behandeldatum_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if(Behandeldatum > DateTime.Now)
            {
                results.AddPropertyError("Een behandeldatum kan niet in de toekomst liggen!");
            }
        }
    }
}