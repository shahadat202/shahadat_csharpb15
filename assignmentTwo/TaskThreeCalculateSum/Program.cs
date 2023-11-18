using System;

class Program
{
    static void Main()
    {
        string a, b;
        a = Console.ReadLine();
        b = Console.ReadLine();

        if (a.Length > b.Length)
        {
            Swap(ref a, ref b);
        }

        string ans = "";
        int len1 = a.Length, len2 = b.Length;
        int diff = len2 - len1;
        int sum, carry = 0;

        for (int i = len1 - 1; i >= 0; i--)
        {
            sum = ((a[i] - '0') + (b[i + diff] - '0') + carry);
            ans += (sum % 10).ToString();
            carry = sum / 10;
        }

        for (int i = diff - 1; i >= 0; i--)
        {
            sum = ((b[i] - '0') + carry);
            ans += (sum % 10).ToString();
            carry = sum / 10;
        }

        if (carry > 0)
            ans += carry.ToString();

        char[] ansArray = ans.ToCharArray();
        Array.Reverse(ansArray);
        ans = new string(ansArray);

        Console.WriteLine(ans);
    }

    static void Swap(ref string a, ref string b)
    {
        string temp = a;
        a = b;
        b = temp;
    }
}
