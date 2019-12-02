using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculatorTestProject
{
    /*
     * to get hourly, divide anual salary by 2080
     * $100,006.40 / 2080 = $48.09 / hr
     * 
     * to get annual, multiply hourly by 2080
     * $48.08 * 2080 = $100,006.40
     */
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AnnualSalary_Test()
        {
            //Arrange
            SalaryCalculator sc = new SalaryCalculator();
            
            //Act
            decimal annualSalary = sc.GetAnnualSalary(50);

            //Assert
            Assert.AreEqual(104000, annualSalary);
        }
    }
}
