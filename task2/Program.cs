namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            string inputString1 = "a@b!!b$a";
            string trashSymbolsString1 = "!@$";
            string inputString2 = "?Aa#c";
            string trashSymbolsString2 = "#?";
            
            // Example 1
            bool result1 = IsPalindrome(inputString1, trashSymbolsString1);
            Console.WriteLine(result1);

            // Example 2
            bool result2 = IsPalindrome(inputString2, trashSymbolsString2);
            Console.WriteLine(result2);
        }

        static bool IsPalindrome(string str, string trash)
        {
            str = str.ToLower();
            int l = 0;
            int r = str.Length - 1;

            while (l < r)
            {
                while (IsTrash(str[l], trash))
                    l++;
                while (IsTrash(str[r], trash))
                    r--;
                if (str[l] != str[r])
                    return false;
                l++;
                r--;
            }
            return true;
        }

        static bool IsTrash(char c, string trash)
        {
            if (trash.Contains(c))
                return true;
            else
                return false;
        }
    }
}