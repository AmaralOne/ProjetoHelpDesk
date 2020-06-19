using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ColecaoDeTickets : IEnumerable
    {
        private List<Ticket> ticket = new List<Ticket>();

        public void Add(List<Ticket> tickets)
        {
            ticket.AddRange(tickets);
        }

        public IEnumerator GetEnumerator()
        {
            foreach(Ticket t in ticket)
            {
                yield return t;
            }
        }
    }
}
