using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting_System.Database;
using Voting_System.DTO;

namespace Voting_System.Backend
{
    public class DataHandler
    {
        public void InitDb()
        {
            using (var dbContext = new DatabaseContainer())
            {
                dbContext.PartySet.Add(
                        new Party { Id = 1, Name = "Socialdemokraterne", 
                                    Letter = "A", 
                                    Votes = 1000, 
                                    Person = new Collection<Person>() });
            }
        }

        public void method()
        {
            using (var dbContext = new DatabaseContainer())
            {
                var query = from party in dbContext.PartySet where party.Id == 1 select party;
            }
        }


        public PartyDTO testing()
        {
            InitDb();
            PartyDTO party = new PartyDTO{name = "FEJLEDE!!!"};
           /* using (var dbContext = new DatabaseContainer())
            {
                var query = from p in dbContext.PartySet select p;



                try
                {
                    party = new PartyDTO {name = query.First().Name};
                    return party;
                }
                catch (EntityException e)
                {
                }
                
                
            }*/


            return party;

        }
    }
}
