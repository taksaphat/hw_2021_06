using System;

namespace HW
{
    interface IHomework04
    {
        string GetDivisibleBy5Text(string text);
    }
    class Number : IHomework04
    {
        /*public string n;
        public Number(string text){
            n = text;
        }*/
        public string GetDivisibleBy5Text(string texts)
            {
                string[] binList = texts.Split(",");
                foreach (string text in binList){
                    int num, decVal = 0, baseVal = 1, rem;
                    var binNum = Int32.Parse(text);
                    num = binNum;
                    while (num > 0) {
                        rem = num % 10;
                        decVal = decVal + rem * baseVal;
                        num = num / 10 ;

                        baseVal = baseVal * 2;
                    }
                    if (decVal %5 == 0)
                    Console.WriteLine(binNum);
                }
                return texts;
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number();
            num.GetDivisibleBy5Text("0100,0011,1010,1001");
        }
    }
}
