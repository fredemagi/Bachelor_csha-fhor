using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting_System.Database;

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
    }
}
