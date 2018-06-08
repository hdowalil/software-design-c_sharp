using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelfDocumentation.Lab01.Sample.Solution;

namespace SelfDocumentation.UnitTests
{
    [TestClass]
    public class Lab01SampleSolutionEmployeeTest
    {
        [DataRow(true, 10, 1, true, 2000)]
        [DataRow(false, 10, 1, true, 1000)]
        [DataRow(false, 50, 3, false, 2000)]
        [DataTestMethod]
        public void TestSalary(bool related, int percentage, int years, bool ext, long expected)
        {
            Employee employee = new Employee(related, percentage, years, ext);
            Assert.AreEqual(expected, employee.Salary);
        }
    }
}
