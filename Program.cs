namespace ReversingANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Please enter a number or word to reverse");
            String aNum = Console.ReadLine();

            String reversedNum = ReverseNum(aNum);

            Console.WriteLine("Here is reversed number :" + reversedNum);

        }

        static String ReverseNum(String firstString)
        {
            String reversedString = "";

            for(int i = firstString.Length -1; i >= 0; i--)
            {
                char c = firstString[i];
                reversedString += c;
            }

            return reversedString;
        }
    }
}
