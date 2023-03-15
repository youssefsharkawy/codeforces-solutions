using System.Diagnostics.Metrics;

namespace codeforces_solutions;

public class main
{
    static void Main(string[] args)
    {
        Dictionary < int, int > digital = new Dictionary < int, int > ();
        digital.Add(0,2);
        digital.Add(1,7);
        digital.Add(2,2);
        digital.Add(3,3);
        digital.Add(4,3);
        digital.Add(5,4);
        digital.Add(6,2);
        digital.Add(7,5);
        digital.Add(8,1);
        digital.Add(9,2);

        int n = int.Parse(Console.ReadLine());
        int i = 0;
        int lastDigit = n % 10;
        n = n / 10;
        int lastDigit2 = n;

        int res = digital[lastDigit] * digital[lastDigit2];
       
               

        Console.WriteLine(res);

    }
}