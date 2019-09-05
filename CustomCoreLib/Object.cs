namespace System
{
    public class Object
    {
        internal Object()
        {
        }

        public void TestObjectMethod()
        {
        }

        public void ToStringIsDead()
        {
        }
    }

    public class Attribute
    {

    }

    // Add these because of the auto-generated file containing [TargetFrameworkAttribute] (can that be disabled?)
    namespace Reflection
    {
        public class Foo
        {

        }
    }

    namespace Runtime.Versioning
    {
        public class TargetFrameworkAttribute: Attribute
        {
            public string FrameworkDisplayName { get; set; }
            public TargetFrameworkAttribute(string a)
            {
            }
        }
    }
}
