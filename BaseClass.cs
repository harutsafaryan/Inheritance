using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class BaseClass
    {
        public string publicField = "BaseClacc.publicField";
        protected string protectedField = "BaseClacc.protectedField";
        private string privateField = "BaseClacc.privateField";

        public int basNumber;

        public BaseClass()
        {

        }
        public BaseClass(int number)
        {
            basNumber = number;
        }
        public void Show()
        {
            Console.WriteLine(privateField);
        }

        public void Method()
        {
            Console.WriteLine("Method from BaseClass");
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine("Virtual method from BaseClass");
        }
        public virtual void NonVirtualMethod()
        {
            Console.WriteLine("Virtual method from BaseClass");
        }
    }
}
