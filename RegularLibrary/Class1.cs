using System;

namespace RegularLibrary
{
    public static class Class1
    {
        // Call will NOT be underlined in ConsumterTest.
        public static int ReturnInt(int value)
        {
            return value;
        }

        // Call WILL be underlined in ConsumerTest (CustomCoreLib has no ref to Guid).
        public static Guid ReturnGuid()
        {
            return new Guid();
        }
    }
}
