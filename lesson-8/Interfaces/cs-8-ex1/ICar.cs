using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs_8_ex1
{
    public interface ICar
    {
        float Power { get; set; }

        string ToString();
        void modifyPower(float percent);
    }
}
