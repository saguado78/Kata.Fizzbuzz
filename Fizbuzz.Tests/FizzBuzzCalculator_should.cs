using NUnit.Framework;
using Fizbuzz.Logic;

namespace Fizbuzz.Tests
{
    public class FizzBuzzCalculator_should
    {
        public const string test_FIZZ="FIZZ";
        [Test]       
        public void return_the_same_number_by_default(){
            FizzBuzzCalculator calc=new FizzBuzzCalculator();

            string res=calc.Calculate(1);

            Assert.AreEqual("1",res,"Unexpected resutl");
        }

        [Test]
        [TestCase(3)]
        [TestCase(6)]
        public void return_FIZZ_when_divisible_by_3(int input){
            FizzBuzzCalculator calc=new FizzBuzzCalculator();

            string res=calc.Calculate(input);

            Assert.AreEqual(test_FIZZ,res,"Unexpected resutl");
        }
    }
}