using System;

namespace ConsumerTest
{
    public static class Class1
    {
        public static void Test()
        {
            // We can't overload many operators for String (e.g. +), as the compiler seems to treat it
            // special (e.g. tries to expand the + operator to a Concat() call). We can add an implicit cast to int though!
            int a = "Strings are ints." * 156;
            a += 37;
            //a. // Try out Intellisense and see that you only get the methods we definied in CustomCoreLib::Object.
        }
    }

    // Non-static classes can't be declared because CustomCoreLib::Object::Object() is internal.
    /*public class Foo // Compiler error
    {

    }*/
}
