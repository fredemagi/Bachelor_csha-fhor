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
                new Party
                {
                    Name = "Socialdemokraterne", Letter = "A", Votes = 0, Person = new Collection<Person>
                    {
                        new Person{Name = "Helle Thorning-Schmidt", Votes = 0},
                        new Person{Name = "Ole Hækkerup", Votes = 0},
                        new Person{Name = "Mette Gjerskov", Votes = 0},
                        new Person{Name = "Anne Sina", Votes = 0},
                        new Person{Name = "Bjarne Corydon", Votes = 0},
                    } 
                
                },
                new Party
                {
                    Name = "Venstre", Letter = "V", Votes = 0, Person = new Collection<Person>
                    {
                        new Person{Name = "Lars Løkke Rasmussen", Votes = 0},
                        new Person{Name = "Anni Matthiesen", Votes = 0},
                        new Person{Name = "Bertel Haarder", Votes = 0},
                        new Person{Name = "Birgitte Josefsen", Votes = 0},
                        new Person{Name = "Birthe Rønn Hornbech", Votes = 0}
                    
                    } 
                
                },
                new Party
                {
                    Name = "Konservative", Letter = "C", Votes = 0, Person = new Collection<Person>
                    {
                        new Person{Name = "Lars Barfoed", Votes = 0},
                        new Person{Name = "Anne Hansen", Votes = 0},
                        new Person{Name = "Helle Bonnesen", Votes = 0},
                        new Person{Name = "Tom Steifel-Kristensen", Votes = 0},
                        new Person{Name = "Rasmus Jarlov", Votes = 0}
                    }
                
                }
            }.ForEach( x => context.PartySet.Add(x) );


           



            new List<Voting>
            {
                new Voting { CPR = 1234567890 }
            }.ForEach(x => context.VotingSet.Add(x));


            //base.Seed(context);

        }
    }
}
