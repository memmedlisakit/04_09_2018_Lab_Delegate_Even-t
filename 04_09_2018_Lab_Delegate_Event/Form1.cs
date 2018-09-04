using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_09_2018_Lab_Delegate_Event
{

    public delegate void TestDel(int a, int b);

    public partial class Form1 : Form
    {

        public event TestDel DemoEvent;

        public Form1()
        {
            InitializeComponent();

            //this.Click += Form1_Click;
            //this.DoubleClick += Form1_Click; 

            //DemoEvent(5,8);


            //TestDel del = null;
            //del += SayHello;
            //del += SayBye;
            //del += Say; 


            //CallBack(del, 8, 8);

            //CallBack((int a, int b) => 
            //{
            //    MessageBox.Show("resultL "+ (a + b));
            //}, 5, 8);

            //CallBack((int a, int b) =>
            //{
            //    MessageBox.Show("reasult: " + a * b);
            //}, 2, 2); 

            BMW bmw = new BMW();
            Mercedes mercedes = new Mercedes();
            Ferrari ferrari = new Ferrari();
            bmw.Drive();
            mercedes.Drive();
            ferrari.Drive();
            ferrari.Door();
        }
         

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("form clicked");
        } 

        public void CallBack(TestDel deleg, int a, int b)
        {
            deleg(a, b);
        } 


        //public void SayHello(int a, int b)
        //{
        //    MessageBox.Show($"{a} + {b} = {a + b}"); 
        //}

        //public void SayBye(int c, int g)
        //{
        //    MessageBox.Show($"{c} * {g} = {c * g}");
        //}

        //public void Say(int c, int g)
        //{
        //    MessageBox.Show($"{c} / {g} = {(double)c / g}");
        //}


    } 
}
