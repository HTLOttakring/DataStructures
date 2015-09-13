using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDataStructure
{
    public class List
    {
        ListItem head = null;


        public ListItem GetHead()
        {
            return head;
        }


        public void Add(ListItem item)
        {
            if (head == null)
            {
                head = item;
            }
            else
            {
                ListItem current = GetLast();
                current.Next = item;
            }
        }

        private ListItem GetLast()
        {
            
            if (head == null)
                return null;
            ListItem last = head;
            while (last.Next != null)
            {
                last = last.Next;
            }

            return last;
        }
    }
}
