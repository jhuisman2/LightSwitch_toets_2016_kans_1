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
    public partial class BioscoopReviews
    {
        partial void BioscoopReviews_Saving(ref bool handled)
        {
            // Write your code here.
            try
            {
                DataWorkspace.ApplicationData.SaveChanges();
                DataWorkspace.CinemaData.SaveChanges();
                handled = true;
                this.ShowMessageBox("De review is opgeslagen");
            }
            catch
            {
                this.ShowMessageBox("Fout opgetreden bij opslaan review");
            }

        }

        partial void BioscoopReviews_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            saveChangesTo.Add(DataWorkspace.ApplicationData);
            saveChangesTo.Add(DataWorkspace.CinemaData);
        }
    }
}