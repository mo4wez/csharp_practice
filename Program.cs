namespace StringsInCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = OneToTenWithOutInput();
            string[] SplitedResult = result.Split("|");
            for (int i = 0; i < SplitedResult.Length; i++)
            {
                Console.WriteLine(SplitedResult[i]);
            }
        }

        static string OneToTenWithOutInput() 
        {
            string result = "Finish";
            int j = 0;
            for (int i = 0; i <= 10; i++)
            {
                j += i;
                result += Convert.ToString(i);
            }
            return result + "|" + "sum:" + j;
        }
    }
}
