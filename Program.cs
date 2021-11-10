using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            Console.WriteLine(derivedClass.publicField);
            derivedClass.Show();                            //show private field of BaseClass

            Console.WriteLine("\nBASECLASS COSNTRUCTOR CALL");
            DerivedClass instanceDerived = new DerivedClass(1, 2);
            Console.WriteLine(instanceDerived.basNumber);
            Console.WriteLine(instanceDerived.DerivedField);

            Console.WriteLine("\nSHOW HASHCODES OF DERIVED CLASS INSTANCE AND BASECLASS WITH UPCAST");
            BaseClass instanceBase = (BaseClass)instanceDerived; //UpCast
            Console.WriteLine("instance Id      {0}", instanceDerived.GetHashCode());
            Console.WriteLine("newInstance Id   {0}", instanceBase.GetHashCode());

            Console.WriteLine("\nNON VIRTULA METHODS CALL");
            instanceDerived.Method();   //Method from DerivedClass
            instanceBase.Method();      //Method from Base class
            DerivedClass instanceDown = (DerivedClass)instanceBase;
            instanceDown.Method();      //Method form DerivedClass, (DownCast)

            //virtual method call
            Console.WriteLine("\nVIRTUAL METHODS CALL");
            DerivedClass instance1 = new DerivedClass();
            instance1.VirtualMethod();
            BaseClass newInstance1 = (DerivedClass)instance1; //Upcast
            newInstance1.VirtualMethod();
            DerivedClass newInstance2 = (DerivedClass)instance1; //DownCast
            newInstance2.VirtualMethod();

            //call BaseClass (virtual )methot 
            Console.WriteLine("\nBASE CLASS VIRTUAL METHOD CALL");
            DerivedClass instance2 = new DerivedClass();
            instance2.NonVirtualMethod();

            // is - operator
            Console.WriteLine("\nOPERATOR IS");
            DerivedClass derivedClass1 = new DerivedClass();
            BaseClass baseClass1 = new BaseClass();

            if (derivedClass1 is BaseClass)
            {
                Console.WriteLine("DerivedClass derrived from BaseClass");
            }

            // as - operator
            Console.WriteLine("\nOPERATOR AS");
            DerivedClass derivedClass2 = new DerivedClass();
            derivedClass2.Method();
            BaseClass baseClass2 = derivedClass2 as BaseClass;
            baseClass2.Method();
            DerivedClass derivedClass3 = derivedClass2 as DerivedClass;
            derivedClass3.Method();
        }
    }
}
