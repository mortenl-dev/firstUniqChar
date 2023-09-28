using System;
using System.Globalization;
using System.Runtime.InteropServices;
public class FirstUniqueCharInString {  

    public static void Main (string[] args) {
        var myclass = new FirstUniqueCharInString();
        myclass.Tests();
    }
    public void Tests() {
        Console.WriteLine("Please enter a string");
        string input;
        input = Console.ReadLine();
        
        
        Console.WriteLine(FirstUniqChar(input));
        Thread.Sleep(30000);
    }
    public int FirstUniqChar(string s) {
            Dictionary<char, int> charDict = new Dictionary<char,int>();
        

        foreach(char c in s)
        {
            if(charDict.ContainsKey(c))
            {
                int count = charDict[c];
                count++;
                charDict[c] = count;
            }
            else
            {
                charDict.Add(c, 1);
            }
        }
        for(int i=0; i<s.Length; i++)
        {
            int count = charDict[s[i]];
            if (count == 1)
            {
                
                return i;

            }

        }

            return -1;
    }

    
}