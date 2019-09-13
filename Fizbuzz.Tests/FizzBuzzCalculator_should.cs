using NUnit.Framework;
using Fizbuzz.Logic;

namespace Fizbuzz.Tests
{
    public class FizzBuzzCalculator_should
    {
        [Test]       
        public void return_the_same_number_by_default(){
            FizzBuzzCalculator calc=new FizzBuzzCalculator();

            string res=calc.Calculate(1);

            Assert.AreEqual("1",res,"Unexpected resutl");
        }
    }
}