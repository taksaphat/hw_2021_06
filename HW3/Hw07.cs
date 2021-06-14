using System;
using System.Text;
using System.Linq;
namespace HW3
{
    public interface IHomework07
    {
    string RemoveAndSortTextByAlphabetical(string text);
    }
    class Sort : IHomework07
    {
        /*public string n;
        public Number(string text){
            n = text;
        }*/
         // remove dupes and sort alphabetically
        public string RemoveAndSortTextByAlphabetical(string text)
            {
                var result = string.Join(" ", text.Split(' ').Distinct().OrderBy(result => result));
                Console.WriteLine(result);
                return text;
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sort sort = new Sort();
            sort.RemoveAndSortTextByAlphabetical("hello world and practice makes perfect and hello world again");
        }
    }
}
