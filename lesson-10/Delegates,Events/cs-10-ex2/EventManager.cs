using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_10_ex2
{
    public delegate void MyDelegate();

    class EventManager
    {
        public event MyDelegate MyEvent;

        public void OnEvent()
        {
            MyEvent();
        }
    }
}
