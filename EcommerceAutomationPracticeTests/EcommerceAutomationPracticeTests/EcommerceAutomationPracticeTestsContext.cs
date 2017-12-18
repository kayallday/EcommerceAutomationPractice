using System;
using NUnit.Framework;

namespace EcommerceAutomationPracticeTests
{
    [TestFixture]
    public class EcommerceAutomationPracticeTestsContext
    {
        public static TestContext Context { get; private set; }

        public static void AssemblyInit(TestContext context)
        {
            Context = context;
        }
    }
}