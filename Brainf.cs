namespace Brainf;
internal class Brainf
{
    public int[] array { get; set; }
    public int index { get; set; }
    private int bracket;

    public const int maxSize = 3;
    public Brainf()
    {
        this.array = new int[maxSize];
        for (int i = 0; i < Brainf.maxSize; i++)
            this.array[i] = 0;
        this.index = 0; 
    }
    public void eval(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            switch (text[i])
            {
                case '>':
                    if (this.index == Brainf.maxSize - 1)
                        this.index = 0;
                    else
                        this.index++;
                    break;
                case '<':
                    if (this.index == 0)
                        this.index = Brainf.maxSize - 1;
                    else
                        this.index--;
                    break;
                case '+':
                    if (this.array.ElementAt(this.index) == 255)
                        this.array[this.index] = 0;
                    else
                        this.array[this.index]++;
                    break;
                case '-':
                    if (this.array.ElementAt(this.index) == 0)
                        this.array[this.index] = 255;
                    else
                        this.array[this.index]--;
                    break;
                case '.':
                    Console.WriteLine($"{this.array.ElementAt(this.index)}");
                    break;
                case ',':
                    Console.Write($"> ");
                    this.array[this.index] = Convert.ToInt32(Console.ReadLine());
                    break;
                case '[':
                    if (this.array.ElementAt(this.index) == 0)
                    {
                        bracket++;
                        while (this.array.ElementAt(this.index) != ']' || bracket != 0)
                        {
                            i++;
                            if (this.array.ElementAt(this.index) == '[')
                            {
                                bracket++;
                            }
                            else if (this.array.ElementAt(this.index) == ']')
                            {
                                bracket--;
                            }
                        }
                    }
                    break;
                case ']':
                    if (this.array.ElementAt(this.index) != 0)
                    {
                        this.bracket++;
                        while (text[i] != '[' || this.bracket != 0)
                        {
                            i--;
                            if (text[i] == ']')
                            {
                                this.bracket++;
                            }
                            else if (text[i] == '[')
                            {
                                this.bracket--;
                            }
                        }
                    }
                    break;
            }
        }
    }
}
