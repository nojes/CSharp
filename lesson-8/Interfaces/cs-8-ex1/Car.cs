using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_8_ex1
{
    public class Car : ICar
    {
        string mark;
        int cylinders;
        float power;

        public Car(string mark, int cylinders, float power)
        {
            this.mark = mark;
            this.cylinders = cylinders;
            this.power = power;
        }

        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public int Cylinders
        {
            get { return cylinders; }
            set { cylinders = value; }
        }

        public float Power
        {
            get { return power; }
            set { power = value; }
        }

        public override string ToString()
        {
            return String.Format("\n Mark: {0} \n Cylinders: {1} \n Power: {2} ", mark, cylinders, power);
        }

        public virtual void modifyPower(float percent)
        {
            power = power + (power / percent * 100);
        }
    }
}
