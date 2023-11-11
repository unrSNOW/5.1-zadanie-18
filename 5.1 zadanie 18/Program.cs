Console.WriteLine("введите строку:");
char[] mas = Console.ReadLine().ToCharArray();
int count = 0;
int start = 0;
for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] == ';' || mas[i] == ':')
    {
        if (mas[start - 1] == 'а') count++;
    }
    start = i + 1;
}
Console.WriteLine("Количество слов, заканчивающихся на 'а':" + count);