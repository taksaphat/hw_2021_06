using System;
using System.Text;
namespace HW2
{
    interface IHomework05
    {
        string DisplayLEDOnScreen(string ledNo);
    }
    class Led : IHomework05
    {
        /*public string n;
        public Number(string text){
            n = text;
        }*/
       
        public string DisplayLEDOnScreen(string ledNo)
            {
                int num = 1;
                StringBuilder sb = new StringBuilder(ledNo);
                
                Console.WriteLine(ledNo);
                Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A");
                while(num == 1){
                Console.Write("Please choose LED to turn On/Off: ");
                string light = Console.ReadLine();
                if (light == "1"){
                    if(sb[1].Equals(' ')){
                        sb[1] = '!';
                        ledNo = sb.ToString(); 
                    }else
                    {
                        sb[1] = ' ';
                        ledNo = sb.ToString(); 
                    }
                }
                if (light == "2"){
                    if(sb[5].Equals(' ')){
                        sb[5] = '!';
                        ledNo = sb.ToString(); 
                    }else
                    {
                        sb[5] = ' ';
                        ledNo = sb.ToString(); 
                    }
                }
                if (light == "3"){
                    if(sb[9].Equals(' ')){
                        sb[9] = '!';
                        ledNo = sb.ToString(); 
                    }else
                    {
                        sb[9] = ' ';
                        ledNo = sb.ToString(); 
                    }
                }
                if (light == "4"){
                    if(sb[13].Equals(' ')){
                        sb[13] = '!';
                        ledNo = sb.ToString(); 
                    }else
                    {
                        sb[13] = ' ';
                        ledNo = sb.ToString(); 
                    }
                }
                if (light == "5"){
                    if(sb[17].Equals(' ')){
                        sb[17] = '!';
                        ledNo = sb.ToString(); 
                    }else
                    {
                        sb[17] = ' ';
                        ledNo = sb.ToString(); 
                    }
                }
                if (light == "6"){
                    if(sb[21].Equals(' ')){
                        sb[21] = '!';
                        ledNo = sb.ToString(); 
                    }else
                    {
                        sb[21] = ' ';
                        ledNo = sb.ToString(); 
                    }
                }
                if (light == "7"){
                    if(sb[25].Equals(' ')){
                        sb[25] = '!';
                        ledNo = sb.ToString(); 
                    }else
                    {
                        sb[25] = ' ';
                        ledNo = sb.ToString(); 
                    }
                }
                if (light == "8"){
                    if(sb[29].Equals(' ')){
                        sb[29] = '!';
                        ledNo = sb.ToString(); 
                    }else
                    {
                        sb[29] = ' ';
                        ledNo = sb.ToString(); 
                    }
                }
                if (light == "9"){
                    if(sb[33].Equals(' ')){
                        sb[33] = '!';
                        ledNo = sb.ToString(); 
                    }else
                    {
                        sb[33] = ' ';
                        ledNo = sb.ToString(); 
                    }
                }
                if (light == "A"){
                    if(sb[37].Equals(' ')){
                        sb[37] = '!';
                        ledNo = sb.ToString(); 
                    }else
                    {
                        sb[37] = ' ';
                        ledNo = sb.ToString(); 
                    }
                }

                Console.WriteLine(ledNo);
                Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A");
                }
                return ledNo;
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Led led = new Led();
            led.DisplayLEDOnScreen("[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]");
            //[1] [5] [9] [13] [17] [21] [25] [29] [33] [37]
                        
        }
    }
}
