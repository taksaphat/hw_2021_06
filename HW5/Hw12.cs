using System;
using System.Linq;
using System.Collections.Generic;

namespace HW5
{
    public interface IHomework12
{
    char FirstDuplicateCharactor(string text);
    char FirstNotDuplicateCharactor(string text);
}
    class Dupes : IHomework12
    {
        public char FirstDuplicateCharactor(string text)
            {
                char[] arr = text.ToCharArray();
                int count = 0;

                for(int i = 0; i < arr.Length; i++) {  
                    count = 1;  
                    for(int j = i+1; j < arr.Length; j++) {  
                    if(arr[i] == arr[j] && arr[i] != ' ') {  
                            count++;  
                            arr[j] = '0';  
                    }  
            }  
            //A character is considered as duplicate if count is greater than 1  
            if(count > 1 && arr[i] != '0')  {
                Console.WriteLine("First duplicate charactor is: "+arr[i]);  
                break;
                }
        }  
                return '\0';
            }
        public char FirstNotDuplicateCharactor(string text)
            {
                for (int i = 0; i < text.Length; i++)
                    {
                        if (text.IndexOf(text[i]) == text.LastIndexOf(text[i])){
                            Console.WriteLine("First not duplicate charactor is: "+text[i]);
                            }
                    }
                Console.WriteLine("First not duplicate charactor is: -"); 
                return '\0';
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dupes dup = new Dupes();
            string text = "ZXCZXCVBNMASDFGHJVBNMASZXCVBNMASDFGHJDFGHJ";
            dup.FirstDuplicateCharactor(text);
            dup.FirstNotDuplicateCharactor(text);
        }
    }
}