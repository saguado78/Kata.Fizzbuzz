using System;

namespace Fizbuzz.Logic
{
    public class FizzBuzzCalculator
    {
        private const string FIZZ="FIZZ";
        private const string BUZZ="BUZZ";
        public string Calculate(int input)
        {
            string res=string.Empty;
            if(input % 3==0){
                res=FIZZ;
            }
            else if(input % 5==0){
                res=BUZZ;
            }
            else{
                res=input.ToString();
            }
            return res;
        }
    }
}
