using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;
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
        string str = "abcdeedcba";
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
        String s = "abcdba";

        StringBuilder str = new StringBuilder();

        int left = 0;
        int max = 0;
        int len = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (set.Contains(s[right]))
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
    public async Task MaximumSumofsizek() { }

    [Test]
    public async Task SmallestSubArray()
    {
        int[] a = { 2, 3, 1, 2, 4, 3 };
        int target = 7;
        int left = 0;
        int right = 0;
        int min = 0;
        int sum = 0;

        for (right = 0; right < a.Length; right++)
        {
            sum += a[right];

            while (sum >= target)
            {
                min = Math.Min(min, right - left + 1);
                sum = a[left];
                left++;


            }


        }


    }

    [Test]
    public async Task ResversString()
    {

        string str = "Helloankit";
        string str2 = "";

        Stack<char> stack = new Stack<char>();

        foreach (var c in str)
        {
            stack.Push(c);


        }




    }

    [Test]

    public async Task Secondlargest()
    {

        int[] a = { 2, 5, 1, 50, 20 };
        int Length = a.Length;
        int largest = -1;
        int secondlargest = -1;

        for (int i = 0; i < Length; i++)
        {
            if (a[i] > largest)
            {
                secondlargest = largest;
                largest = a[i];


            }

            else if (a[i] < largest && a[i] > secondlargest)
            {
                secondlargest = a[i];
            }






        }
        Console.WriteLine(secondlargest);





    }

    [Test]
    public async Task GetIndexofElement()
    {
        int[] a = { 1, 3, 3, 4, 5, 6, 6, 7, 8, 9, 9 };
        int input = 9;

        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

        for (int i = 0; i < a.Length; i++)
        {
            if (!dict.ContainsKey(a[i]))
            {
                dict[a[i]] = new List<int>();
                Console.WriteLine(dict.Keys + " : " + dict.Values);
            }

            dict[a[i]].Add(i);


        }

        foreach (var item in dict)
        {
            Console.WriteLine(item.Key + " -> " + string.Join(",", item.Value));
        }








    }

    [Test]


    public async Task ReturindexforDuplicates()
    {


        int[] input = { 1, 2, 3, 3, 4, 5, 6, 6, 7, 8, 9, 9 };
        Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();

        for (int i = 0; i < input.Length; i++)
        {
            if (!dic.ContainsKey(input[i]))
            {
                dic[input[i]] = new List<int>();//dic[0]
            }

            dic[input[i]].Add(i);

        }

        foreach (var item in dic)
        {
            Console.WriteLine("for each :" + item.Key + "  indexes is :" + string.Join(',', item.Value));

        }





    }



}


