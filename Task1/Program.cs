int n = new Random().Next(10000, 99999);
int myNumber = 1357997531;
char[] numbers = n.ToString().ToCharArray();
char[] myNumbers = myNumber.ToString().ToCharArray();
Console.WriteLine(numbers);
Console.WriteLine(isPalindrom(numbers));
Console.WriteLine();
Console.WriteLine(myNumbers);
Console.WriteLine(isPalindrom(myNumbers));

String isPalindrom(char[] numbers)
{
    String msg = "Это палиндром";
    for (int i = 0; i < (numbers.Length) / 2; i++)
    {
        if (numbers[i] != numbers[(numbers.Length) - i - 1])
        {
            msg = "Не палиндром";
            break;
        }
    }
    return msg;
}

