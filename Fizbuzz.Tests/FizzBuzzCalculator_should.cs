using NUnit.Framework;
using Fizbuzz.Logic;

namespace Fizbuzz.Tests
{
    public class FizzBuzzCalculator_should
    {
        private const string test_FIZZ="FIZZ";
        private const string test_BUZZ="BUZZ";
        [Test]       
        public void return_the_same_number_by_default(){
            FizzBuzzCalculator calc=new FizzBuzzCalculator();

            string res=calc.Calculate(1);

            Assert.AreEqual("1",res,"Unexpected result");
        }

        [Test]
        [TestCase(3)]
        [TestCase(6)]
        public void return_FIZZ_when_divisible_by_3(int input){
            FizzBuzzCalculator calc=new FizzBuzzCalculator();

            string res=calc.Calculate(input);

            Assert.AreEqual(test_FIZZ,res,"Unexpected result");
        }

        [Test]
        [TestCase(5)]
        [TestCase(10)]
        public void return_BUZZ_when_divisible_by_5(int input){
            FizzBuzzCalculator calc=new FizzBuzzCalculator();

            string res=calc.Calculate(input);

            Assert.AreEqual(test_BUZZ,res,"Unexpected result");
        }

        [Test]
        [TestCase(15)]
        [TestCase(30)]
        public void return_FIZZBUZZ_when_divisible_by_3_and_5(int input){
            FizzBuzzCalculator calc=new FizzBuzzCalculator();

            string res=calc.Calculate(input);

            Assert.AreEqual(test_FIZZ + test_BUZZ,res,"Unexpected result");
        }
    }
}