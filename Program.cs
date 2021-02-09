using System;
using System.Collections.Generic;

namespace collection
{
    class Program
    {
        static void Main(string[] args)
        {
        int[] arr = {1, 2, 3, 4,5,6,7,8,9}; // i made an array 1-9 and iterated through every postion 
        for (int idx = 0; idx < arr.Length; idx++)
            {
                Console.WriteLine($"num is {arr[idx]}");
            }
//////////////////////////////
        string[] arr2 = {"Tim", "Martin", "Nikki","Sara","tom", "joe"}; // i made an array for strings
        for (int idx = 0; idx < arr2.Length; idx++)
            {
                Console.WriteLine($"wordis {arr2[idx]}");
            }


//////////////////////////
        bool b = false;
          int[] arr3 = {1, 2, 3, 4,5,6,7,8,9,10,12}; //changes true false every other 
        for (int idx = 0; idx < arr3.   Length; idx++)
            {
            int num = idx ;
            if( num % 2 == 0){
                
                b = true;
                Console.WriteLine($"{b}");
            }
            else {
                b = false;
                Console.WriteLine($"{b}");
            }
            }

///////////////////
//
            List<string> icecream = new List<string>();
  
            icecream.Add("choclate");
            icecream.Add("vanilla");
            icecream.Add("red-velvet");
            icecream.Add("pistachio");
            icecream.Add("salted carmel");
            icecream.Add("birthday cake");
            Console.WriteLine(icecream[2]);
            Console.WriteLine($"We only have  {icecream.Count} ice crram flavors.");
            icecream.RemoveAt(2);
            Console.WriteLine($"We only have  {icecream.Count} ice crram flavors.");
            Console.WriteLine(icecream[2]);

///////////////////

Dictionary<string,string> favIceCream = new Dictionary<string,string>();
//Almost all the methods that exists with Lists are the same with Dictionaries

//"Tim", "Martin", "Nikki","Sara","tom", "joe"


favIceCream.Add("Tim", "choclate");
favIceCream.Add("martin", "vanilla");
favIceCream.Add("nikki", "red velvet");
favIceCream.Add("sarra", "pistachio");
favIceCream.Add("tom", "salted carmel");
favIceCream.Add("joe", "birthday cake");

foreach (KeyValuePair<string,string> entry in favIceCream)
{
     Console.WriteLine(entry.Key + " - " + entry.Value);
}




            }
    }
}
