using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_09_2018_Lab_Delegate_Event
{
    public abstract class Car
    {
        public string Name { get; set; }

        public virtual void Drive()
        {
            MessageBox.Show("I'm driver");
        }
    }

    public class BMW : Car
    {
        public override void Drive()
        {
            MessageBox.Show("I'm chip driver");
        }
    }

    public class Mercedes : Car
    {
        public override void Drive()
        {
            MessageBox.Show("I'm chip driver");

            Ferrari ferrari = new Ferrari();
        }
    }

    public class Ferrari : Car, IFerrariTwoDoor
    {
        public string Surname { get; set; }

        public void Door()
        {
            MessageBox.Show("I'm also two door");
        }
    }
}
