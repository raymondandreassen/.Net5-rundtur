using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.RefrenceTypes
{
    public class Student : Bruker
    {
        public Student() : base()
        {   // Constructor, som kaller base constructor og en base metode
        }

        public void DoSomethingWithStudent()
        {   // Vanlig kall av base
            base.DoSomethingElse();
        }
    }
}
