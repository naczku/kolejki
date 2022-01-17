using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Queues;

namespace Queues
{
    class kolejka
    {
        Pacjent T, H;

        public bool Empty() { return H != null; }

        public int Front()
        {
            if (H != null) return T.GetValue();
            else return 0;
        }

        public void Push(int n)
        {
            Pacjent temp = new Pacjent(n);

            if (H == null)
                H = T = null;
            else
            {
                T.SetNext(temp);
                T = temp;
            }
        }
        public void Pop()
        {
            if (H != null)
            {
                if (H.GetNext() == null)
                    T = null;

                H = H.GetNext();
            }
            else return;
        }
    }
}
