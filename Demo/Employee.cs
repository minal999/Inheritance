using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo
{
    internal class Employee
    {

        protected int id;
        private static int count = 0;
        protected string name;
        protected double bs, hra, da, pf, pt,total,netpaid;

        //public Employee()
        //{
        //    name = "";
        //    bs =0.0;
        //    pt = 0.0;
        //}
        public Employee(string name,double bs,double pt)
        {
            count++;
            id = count;
            this.name = name;
            this.bs = bs;
            this.pt = pt;
        }
        public static int DisplayCount()
        {
            return count;
        }
        public virtual void CalculateSalary()
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;
            total = bs + hra + da;
            netpaid = total - (pf + pt);
        }
        public override string ToString()
        {
            return $"Employee Id : {id}\nEmployee name : {name}\nTotal salary : {total}\nNet paid : {netpaid}";
        }
        public class Manager : Employee
        {
            private double ta;
            //public Manager() : base() // call constructor
            //{
            //    ta = 0.0;
            //}
            public Manager(string name, double bs, double pt, double ta) : base(name, bs, pt) // call constructor of base class
            {
                this.ta = ta;
            }
            public override void CalculateSalary()
            {
                hra = bs * 0.40;
                da = bs * 0.20;
                pf = bs * 0.12;
                total = bs + hra + da + ta;
                netpaid = total - (pf + pt);
            }
            public override string ToString()
            {
                return $"Manager Id : {id}\nManager name : {name}\nTotal salary : {total}\nNet paid : {netpaid}";
            }
        }
        public class SalesManager : Employee
        {
            private double comm,bonus;
            //public Manager() : base() // call constructor
            //{
            //    ta = 0.0;
            //}
            public SalesManager(string name, double bs, double pt, double comm, double bonus) : base(name, bs, pt) // call constructor of base class
            {
                this.comm = comm;
                this.bonus = bonus;
            }
            public override void CalculateSalary()
            {
                hra = bs * 0.40;
                da = bs * 0.20;
                pf = bs * 0.12;
                total = bs + hra + da + comm+bonus;
                netpaid = total - (pf + pt);
            }
            public override string ToString()
            {
                return $"SalesManager Id : {id}\nSalesManager name : {name}\ntotal salary : {total}\nNet paid : {netpaid}";
            }
        }


    }
}
