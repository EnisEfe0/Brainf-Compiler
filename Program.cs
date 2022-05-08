namespace Brainf;
class Program
{
    static void Main(string[] args)
    {
        string text;
        while (true)
        {
            text = Console.ReadLine();
            new Brainf().eval(text);
        }
    }
}