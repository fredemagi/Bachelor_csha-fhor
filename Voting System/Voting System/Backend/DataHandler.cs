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
        // register to vote
        public void Register(int cpr)
        {
            using(var db = new DatabaseContainer())
            {
                db.VotingSet.Add(new Voting { CPR = cpr });
                db.SaveChanges();
            }
        }

        // eligible to vote
        public bool Eligible(int cpr)
        {
            using(var db = new DatabaseContainer())
            {
                var queue = db.VotingSet.SingleOrDefault(x => x.CPR == cpr);
                if (queue.CPR != null) 
                    return true; 
                else return false;
            }
        }

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
                    recipient.Votes += 1;
                    db.SaveChanges();
                }
            }
        }

        // remove voter
        public void RemoveRegistered(int cpr)
        {
            using (var db = new DatabaseContainer())
            {
                db.VotingSet.Remove(db.VotingSet.SingleOrDefault(x => x.CPR == cpr));
                db.SaveChanges();
            }
        }
        
        // get parties
        public List<VSDTO> GetParties()
        {
            List<VSDTO> parties = new List<VSDTO>();
            IQueryable queue;
            using (var db = new DatabaseContainer())
            {
                queue = from p in db.PartySet select p;
            }

            foreach(Party p in queue)
            {
                parties.Add(new VSDTO { Name = p.Name });
            }

            return parties;
        }

        // get people
        public List<VSDTO> GetPeople()
        {
            List<VSDTO> people = new List<VSDTO>();
            IQueryable queue;
            using (var db = new DatabaseContainer())
            {
                queue = from p in db.PersonSet select p;
            }

            foreach (Person p in queue)
            {
                people.Add(new VSDTO { Name = p.Name });
            }

            return people;
        }

        // add party
        public void AddParty(VSDTO party)
        {
            if(party.Name != null && party.Name != "" && party.Letter != null && party.Letter != "") //med flere
            {
                using (var db = new DatabaseContainer())
                {
                    db.PartySet.Add(new Party { Name = party.Name, Letter = party.Letter, Votes = 0 });
                    db.SaveChanges();
                }
            }
        }

        // add person
        public void AddPerson(VSDTO person)
        {
            if (person.Name != null && person.Name != "") //med flere
            {
                using (var db = new DatabaseContainer())
                {
                    Person p = new Person { Name = person.Name, Votes = 0 };
                    p.Party = db.PartySet.SingleOrDefault(x => x.Id == person.PartyId);
                    db.PersonSet.Add(p);
                    db.SaveChanges();
                }
            }
        }

        // remove party
        public void RemoveParty(string name)
        {
            using (var db = new DatabaseContainer())
            {
                db.PartySet.Remove(db.PartySet.FirstOrDefault(x => x.Name == name));
                db.SaveChanges();
            }
        }

        // remove person
        public void RemovePerson(string name)
        {
            using (var db = new DatabaseContainer())
            {
                db.PersonSet.Remove(db.PersonSet.FirstOrDefault(x => x.Name == name));
                db.SaveChanges();
            }
        }

        // get votes
        public int GetVotes(string name, bool isParty)
        {
            int votes;
            using (var db = new DatabaseContainer())
            {
                if (isParty) 
                    votes = db.PartySet.FirstOrDefault(x => x.Name == name).Votes;
                else
                    votes = db.PersonSet.FirstOrDefault(x => x.Name == name).Votes;
            }
            return votes;
        }
    }
}
