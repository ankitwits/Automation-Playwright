using System.Text;
using Microsoft.Playwright;
using NUnit.Framework;


public class Palindrome
{
    // public void Run()
    // {
        
    //     Console.WriteLine("Hell, Your program executed ");
    // }


    [Test]

    public async Task Palin()
    {
        string str = "abcba";
        StringBuilder str2 = new StringBuilder();
        int left =0;
        int right= str.Length-1;

      while (left<=right)
        {
            if(str[left]!=str[right])
            {
                Console.WriteLine("this is not a pallindrom");
            }
             
              str2.Append(str[left]);

            left++;
            right--;    
            
        }    

        Console.WriteLine(str2);

    }

   
}