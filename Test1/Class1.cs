using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Class1
    {
        [TestCaseSource("testcases")]
        public void foo()
        {

        }

        public static IEnumerable<TestCaseData> testcases { get; } = new[] { new TestCaseData().SetName("&") };
    }
}
