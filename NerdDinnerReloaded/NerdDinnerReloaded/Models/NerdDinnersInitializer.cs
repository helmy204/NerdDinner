using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NerdDinnerReloaded.Models
{
    public class NerdDinnersInitializer : DropCreateDatabaseIfModelChanges<NerdDinners>
    {
        protected override void Seed(NerdDinners context)
        {
            var dinners = new List<Dinner>
            {
                new Dinner
                {
                    Title="Sample Dinner 1",
                    EventDate=DateTime.Now.AddDays(15),
                    Address="One Microsoft Way",
                    Country="USA",
                    HostedBy="scottgu@microsoft.com"
                },
                new Dinner
                {
                    Title="Sample Dinner 2",
                    EventDate=DateTime.Now.AddMonths(1),
                    Address="Somewhere else",
                    Country="USA",
                    HostedBy="scottgu@microsoft.com"
                },
                new Dinner
                {
                    Title="Sample Dinner 3",
                    EventDate=DateTime.Now.AddDays(35),
                    Address="Malaz, Riyadh",
                    Country="Saudi Arabia",
                    HostedBy="AhmedHelmy204@Amitac.com"
                }
            };

            dinners.ForEach(d => context.Dinners.Add(d));
        }
    }
}