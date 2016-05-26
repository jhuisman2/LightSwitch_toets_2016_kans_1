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
    public partial class Application
    {
        partial void VoegFilmToe_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = User.HasPermission(Permissions.MagFilmsBeheren);
        }
    }
}