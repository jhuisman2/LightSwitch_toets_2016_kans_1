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
    public partial class VoegFilmToe
    {
        partial void VoegFilmToe_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.FilmProperty = new Film();
        }

        partial void VoegFilmToe_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.FilmProperty);
        }

        partial void VoegFilmToe_Created()
        {
            // Write your code here.
            this.FilmProperty.LeeftijdIndicatie = 16;
            this.FilmProperty.ReleaseDatum = DateTime.Now;

        }
    }
}