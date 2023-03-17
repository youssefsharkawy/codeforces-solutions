namespace codeforces_solutions;

public class main2
{
    static void Main(string[] args)
    {
        string inputtedText = Console.ReadLine(); 
        int n = int.Parse(Console.ReadLine());
        string res = "";
        res = inputtedText;
        string[] input = new string[n]; 
        
        for (int i = 0; i < n; i++)
        {
            input[i] = Console.ReadLine();
        }
 
        Array.Sort(input);
        
        for (int i = 0; i < n; i++)
        {
            if (input[i].StartsWith(inputtedText))
            {
                res = input[i];
                break;
            }
            

        }
 
        Console.WriteLine(res);
    }
}