using System;
using System.Text;
namespace HW4
{
    public interface IHomework11
    {
    int GetReadWordOfNumber(int number);
    }
    class Read : IHomework11
    {
        /*public string n;
        public Number(string text){
            n = text;
        }*/
  
        public int GetReadWordOfNumber(int number)
            {
            string valueText = number.ToString();
            StringBuilder ret = new StringBuilder();
            string[] digits = { "", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า" };
            string[] units = { "", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน" };
            if(number <= 9999999 && number >= 0){
                //321
            for (int i = 0; i < valueText.Length; i++)
            {
                if (valueText[i] != '0')
                {
                    if (i % 6 == (valueText.Length - 1) % 6)
                    {
                        switch (valueText[i])
                        {
                            case '1':
                                if (ret.Length > 0)
                                {
                                    if (valueText[i - 1] == '0')
                                    {
                                        ret.Append(digits[Convert.ToInt32(valueText[i].ToString())]);
                                    }
                                    else
                                    {
                                        ret.Append("เอ็ด");
                                    }
                                }
                                else
                                {
                                    ret.Append(digits[Convert.ToInt32(valueText[i].ToString())]);
                                }
                                break;
                            default:
                                ret.Append(digits[Convert.ToInt32(valueText[i].ToString())]);
                                break;
                        }
                    }
                    else if (i == valueText.Length - 2 || i == valueText.Length % 6 - 2)
                    {
                        switch (valueText[i])
                        {
                            case '1':
                                ret.Append("");
                                break;
                            case '2':
                                ret.Append("ยี่");
                                break;
                            default:
                                ret.Append(digits[Convert.ToInt32(valueText[i].ToString())]);
                                break;
                        }
                    }
                    else
                    {
                        ret.Append(digits[Convert.ToInt32(valueText[i].ToString())]);
                    }

                    ret.Append(units[valueText.Length - 1 - i]);

                }
                else
                {
                    if (ret.Length == 0)
                    {
                        ret.Append("ศูนย์");
                    }
                }
            }
            var readTh = ret.ToString();

            Console.WriteLine(readTh);
            }
            else
            {
                Console.WriteLine(' ');
            }
            return number;
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Read read = new Read();
            Console.Write("Please input number: ");
            string numb = Console.ReadLine();
            var intnum = Int32.Parse(numb);
            read.GetReadWordOfNumber(intnum);
        }
    }
}
