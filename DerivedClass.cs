using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class DerivedClass : BaseClass
    {
        public int DerivedField;

        public DerivedClass()
        {
            publicField = "DerivedClass.publicField";
            protectedField = "DerivedClass.protectedField";
        }

        public DerivedClass(int number1, int number2)
            : base(number1)
        {
            DerivedField = number2;
        }

        public void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }
        public override void VirtualMethod()
        {
            Console.WriteLine("VirtualMethod method from DerivedClass");
        }

        public override void NonVirtualMethod()
        {
            base.VirtualMethod();
            Console.WriteLine("VirtualMethod method from DerivedClass");


        }
    }
}
