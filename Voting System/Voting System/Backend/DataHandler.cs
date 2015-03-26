using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Voting_System.Database;
using Voting_System.DTO;

namespace Voting_System.Backend
{
    public class DataHandler
    {
        public List<PartyDTO> method()
        {
            using (var dbContext = new DatabaseContainer())
            {
                var query = from party in dbContext.PartySet select party;
                var list = new List<PartyDTO>();

                foreach (var element in query)
                {
                    var party = new PartyDTO {Navn = element.Name, Bogstav = element.Letter};
                    list.Add(party);
                }

                return list;

            }
        }



        // public PartyDTO testing()
        //{
        //  InitDb();
        // PartyDTO party = new PartyDTO{name = "FEJLEDE!!!"};

        public void testing()
        {
            PartyDTO party = new PartyDTO {Navn = "FEJLEDE!!!"};

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


            // return party;

            //}
        }
    }
}
