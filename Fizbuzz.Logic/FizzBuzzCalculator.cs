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
                res+=FIZZ;
            }
            if(input % 5==0){
                res+=BUZZ;
            }
            if(string.IsNullOrEmpty(res)){
                res=input.ToString();
            }
            return res;
        }
    }
}
