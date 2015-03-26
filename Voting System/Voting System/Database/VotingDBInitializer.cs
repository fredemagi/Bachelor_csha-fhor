using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_System.Database
{
    public class VotingDBInitializer : CreateDatabaseIfNotExists<DatabaseContainer>
    {
        protected override void Seed(DatabaseContainer context)
        {
           
            new List<Party>
            {
                new Party { Id = 0, Name = "Socialdemokraterne", Letter = "A", Votes = 0, Person = new Collection<Person>() },
                new Party { Id = 1, Name = "Venstre", Letter = "V", Votes = 0, Person = new Collection<Person>() }
            }.ForEach( x => context.PartySet.Add(x) );

            new List<Voting>
            {
                new Voting { CPR = 1234567890 }
            }.ForEach(x => context.VotingSet.Add(x));


            //base.Seed(context);

        }
    }
}
