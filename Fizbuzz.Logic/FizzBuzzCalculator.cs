using System;

namespace Fizbuzz.Logic
{
    public class FizzBuzzCalculator
    {
        public string Calculate(int input)
        {
            string res=string.Empty;
            if(input % 3==0){
                res="FIZZ";
            }
            else{
                res=input.ToString();
            }
            return res;
        }
    }
}
