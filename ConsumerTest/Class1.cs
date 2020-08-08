using System;

namespace ConsumerTest
{
    public static class Class1
    {
        public static void Test()
        {
            // We can't overload many operators for String (e.g. +), as the compiler seems to treat it
            // special (e.g. tries to expand the + operator to a Concat() call). We can add an implicit cast to int though!
            
            // We can call .NET 5.0 libraries without an underline appearing in the IDE (assuming it uses types
            // defined in the custom core lib). But it won't actually compile because it wants a ref to System.Runtime.
            // Calling into a .NET Standard 1.0 library will make it explode (complains/underlines about no refs to built in types).
            // Calling into a .NET Standard 2.0-2.1 project will have a similar error to .NET 5.0 (wants ref to netstandard).
            int a = "Strings are ints." * RegularLibrary.Class1.ReturnInt(156);
            a += 37;
            //a. // Try out Intellisense and see that you only get the methods we definied in CustomCoreLib::Object.
        }
    }

    // Non-static classes can't be declared because CustomCoreLib::Object::Object() is internal.
    /*public class Foo // Compiler error
    {

    }*/
}
