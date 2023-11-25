using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Person
    {
        //fields: характеристики - име, възраст, егн
        private string name;
        private int age;
        private string egn;

        // properties (get & set): осигуряваме достъп до полетата 
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Egn
        {
            get { return egn; }
            set { egn = value; }
        }



    }
}
