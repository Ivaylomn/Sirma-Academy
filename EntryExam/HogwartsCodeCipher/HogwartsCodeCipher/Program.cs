namespace HogwartsCodeCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            char[] decryptedChars = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (char.IsUpper(currentChar))
                {
                    char decryptedChar = (char)(currentChar - n);
                    if (decryptedChar < 'A')
                    {
                        decryptedChar = (char)(decryptedChar + 26);
                    }
                    decryptedChars[i] = decryptedChar;
                }
                else if (char.IsLower(currentChar))
                {
                    char decryptedChar = (char)(currentChar - n);
                    if (decryptedChar < 'a')
                    {
                        decryptedChar = (char)(decryptedChar + 26);
                    }
                    decryptedChars[i] = decryptedChar;
                }
                else
                {
                    if (input.Length - i == 1)
                    {
                        char lastSymbol = input[input.Length - 1];
                        if (!char.IsLetter(lastSymbol))
                        {
                            decryptedChars[i] = '!';
                        }
                    }
                    else
                    {
                        decryptedChars[i] = ' ';
                    }
                }
            }

            Console.WriteLine(string.Join("", decryptedChars));
        }
    }
}
