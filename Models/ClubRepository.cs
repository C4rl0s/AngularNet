using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace WebApplicationAngularCsharp.Models
{
    public class ClubRepository
    {
        private List<ClubsModels.Club> clubs = new List<ClubsModels.Club>()
            {
             new ClubsModels.Club{Id = 1, Name="Arsenal", City="London"},
            new ClubsModels.Club{Id = 2, Name="Aston Villa", City="Birmingham"},
            new ClubsModels.Club{Id = 3, Name="Burnley", City="Burnley"},
            new ClubsModels.Club{Id = 4, Name="Chelsea", City="London"},
            new ClubsModels.Club{Id = 5, Name="Crystal Palace", City="London"},
            new ClubsModels.Club{Id = 6, Name="Everton", City="Liverpool"},
            new ClubsModels.Club{Id = 7, Name="Hull", City="Hull"},
            new ClubsModels.Club{Id = 8, Name="Leicester", City="Leicester"},
            new ClubsModels.Club{Id = 9, Name="Liverpool", City="Liverpool"},
            new ClubsModels.Club{Id = 10, Name="Man City", City="London"},
            new ClubsModels.Club{Id = 11, Name="Man Utd", City="Manchester"},
            new ClubsModels.Club{Id = 12, Name="Newcastle", City="Newcastle"},
            new ClubsModels.Club{Id = 13, Name="QPR", City="London"},
            new ClubsModels.Club{Id = 14, Name="Southampton", City="Southampton"},
            new ClubsModels.Club{Id = 15, Name="Stoke", City="Stoke"},
            new ClubsModels.Club{Id = 16, Name="Swansea", City="Swansea"},
            new ClubsModels.Club{Id = 17, Name="Sunderland", City="Sunderland"},
            new ClubsModels.Club{Id = 18, Name="Tottenham", City="London"},
            new ClubsModels.Club{Id = 19, Name="West Bromwich Albion", City="West Bromwich"},
            new ClubsModels.Club{Id = 20, Name="West Ham", City="London"}
            };
        public IQueryable<ClubsModels.Club> Clubs
        {
            get { return clubs.AsQueryable(); }
        }
    };
   
}