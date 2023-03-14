namespace codeforces_solutions ;

class CodeForces
{
    public static void Main(string[] args)
    {
        int a, b;
        string R1;
        
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        R1 = Convert.ToString(a + b);
        string aResult = "";
        string bResult = "";

        for (int i = 0; i < a.ToString().Length; i++)
        {
            if ((a.ToString()[i] - '0') == 0)
            {
                continue;
            }

            aResult += a.ToString()[i];
        }
        for (int i = 0; i < b.ToString().Length; i++)
        {
            if ((b.ToString()[i] - '0') == 0)
            {
                continue;
            }

            bResult += b.ToString()[i];
        }
        
        string Result1 = "";
        for (int i = 0; i < R1.Length; i++)
        {
            if ((R1[i]-'0') == 0)
            {
                continue;
                
            }

            Result1 += R1[i];
            
        }
        
       
        if (int.Parse(aResult) + int.Parse(bResult) == int.Parse(Result1))
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
        



    }
}

