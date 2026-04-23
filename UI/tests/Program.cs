using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.Playwright;
using NUnit.Framework;


public class Program
{
    // public void Run()
    // {

    //     Console.WriteLine("Hell, Your program executed ");
    // }


    [Test]

    public async Task Palindrom()
    {
        string str = "abcba";
        StringBuilder str2 = new StringBuilder();
        int left = 0;
        int right = str.Length - 1;

        while (left <= right)
        {
            if (str[left] != str[right])
            {
                Console.WriteLine("this is not a pallindrom");
            }

            str2.Append(str[left]);

            left++;
            right--;

        }

        Console.WriteLine(str2);

    }

    [Test]
    public async Task MaxSum()
    {
        int[] a = [1, 3, 5, 7, 9, 2];
        int k = 3;
        int sum = 0;
        int i;
        int max = 0;

        for (i = 0; i < k; i++)
        {
            sum += a[i];
        }

        max = sum;
        for (i = k; i < a.Length; i++)
        {
            sum = sum + a[i] - a[i - k];

            max = Math.Max(max, sum);

        }

        Console.WriteLine(max);


    }

    [Test]
    public async Task LongestSubstring()
    {
        HashSet<char> set = new HashSet<char>();
        String s= "abcdba";

        StringBuilder str = new StringBuilder();

        int left = 0;
        int max = 0;
        int len=0;

        for (int right = 0; right < s.Length; right++)
        {
            while ( set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }

            set.Add(s[right]);

            len = right - left + 1;
            max = Math.Max(max, len);
        }
        Console.WriteLine(len);
        Console.WriteLine(string.Join(",", set));
     


    }

    [Test]
    public async Task MaximumSumofsizek()
    {
        


    }


    [Test]
    public async Task SmallestSubArray()
    {
        int[] a = {2,3,1,2,4,3};
        int target =7;     
        int left=0;
        int right=0;
        int min=0;
        int sum=0;

        for(right =0; right<a.Length;right++)
        {
            sum+=a[right];

            while(sum>=target)
            {
                min = Math.Min(min, right-left+1);
                sum =a[left];
                left++;
                

            }
            

        }

    


    }


    [Test]
    public async Task ResversString()
    {

        string str = "Helloankit";

        Stack<char> stack = new Stack<char>();

        foreach(var c in str)
        {
            stack.Push(c);
            

        }        
        
        
    }




}


