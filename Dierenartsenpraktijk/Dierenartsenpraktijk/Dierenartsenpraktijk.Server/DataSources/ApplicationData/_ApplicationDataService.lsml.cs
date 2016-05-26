using Microsoft.LightSwitch.Security.Server;
using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {
        partial void Diers_Inserting(Dier entity)
        {
            if(Diers.Count() < 1000)
            {
                this.DataWorkspace.ApplicationData.SaveChanges();
            } else
            {

                entity = null;
            }
        }

        partial void MeerDanTienDieren_PreprocessQuery(ref IQueryable<Dierenarts> query)
        {
            query = query.Where(x => x.AantalBehandelingen > 10);
        }

        partial void DierenartsenBijAantalBehandelingenInput_PreprocessQuery(int? AantalBehandelingenParameter, ref IQueryable<Dierenarts> query)
        {
            query = query.Where(x => x.AantalBehandelingen > AantalBehandelingenParameter);
        }
    }
}