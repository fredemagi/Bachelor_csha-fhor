using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Voting_System.DTO;

namespace Voting_System.Backend
{
    public class DataHandler
    {


        /**
        // register vote
        public void CastVote(string who, bool isParty)
        {
            using (var db = new DatabaseContainer())
            {
                if (isParty)
                {
                    var recipient = db.PartySet.FirstOrDefault(x => x.Name == who);
                    recipient.Votes += 1;
                    db.SaveChanges();
                }
                else
                {
                    var recipient = db.PersonSet.FirstOrDefault(x => x.Name == who);
                    if (recipient != null) recipient.Votes += 1;
                    db.SaveChanges();
                }
            }
        }

        
        public List<GUIDTO> GetPartyPeople()
        {
            using (var db = new DatabaseContainer())
            {
                var list = new List<GUIDTO>();
                var q = from p in db.PartySet select p;
                if (q.Any())
                {
                    foreach (var p in q)
                    {
                       var people = p.Person;
                       list.Add(new GUIDTO { Name = p.Name, Letter = p.Letter });

                       foreach (var person in people)
                       {
                           list.Add(new GUIDTO { Name = person.Name, Letter = person.Party.Letter });
                       }

                    }
                    

                  return list;
                }
                else return null;
            }
        }



        // get votes
        public StringBuilder GetAllVotes()
        {
            
            var sb = new StringBuilder();
           
            using (var db = new DatabaseContainer())
            {
                foreach (var party in db.PartySet)
                {
                    sb.Append(party.Name +  ": " + party.Votes + "\n");
                }

                foreach (var person in db.PersonSet)
                {
                    sb.Append(person.Name + ": " + person.Votes + "\n");
                }
                
            }
            return sb;
        }
                 **/

    }
}
