using System;
public class Program
{
    public static bool ValidateEmail()
    {
        string str = Console.ReadLine();
        int last_dot = 0;
        int a = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '.')
            {
                last_dot = i;
            }
            if (str[i] == '@')
            {
                a = i;
            }
        }
        if (last_dot > a && a > 0)
        {
            return true;
        }
        else return false;
    }
}
