using system;
public class Program {
	public static void Main() {
		int num = Console.ReadLine();
		int pre = num;
		int rev = 0;
		while (num > 0) {
			rev = (rev * 10) + (num % 10);
			num /= 10;
		}
		if (pre == rev) Console.WriteLine("Palindrome Number");
		else Console.WriteLine("Not Palindrome");
	}
}