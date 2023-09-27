using ClassLibrary2Practos;

namespace TestProject3Delta
{
    [TestClass]
    public class CalculateDelta
    {
        [TestMethod]
        public void Calculate_precent_result()
        {
            double newNumber = 47;
            double oldNumber = 23;

            double delta = newNumber - oldNumber;
            double result_here = (delta / oldNumber) * 100;

            CalculDelta calculDelta = new CalculDelta();
            double result_in_method = calculDelta.CalculateDelta(oldNumber, 
                newNumber);

            Assert.AreEqual(result_here, result_in_method);
        }
    }
}