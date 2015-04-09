using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_System.DTO
{
    public class VSDTO
    {
        public string Name { get; set; }
        public string Letter { get; set; }
        public int Votes { get; set; }

        public int PartyId { get; set; } //for person only
        //+ more
    }
}
