using system;
public class Program {
	public static void Main() {

//bd phone number check
		string s = Console.ReadLine();

		int len = s.Length;

		bool validPhn = true;
		if (len != 11) validPhn = false;
		if (s[0] != '0' || s[1] != '1') validPhn = false;
		if (s[2] == '2' || s[2] == '0' || s[2] == '1') validPhn = false;

		int ok = 0;
		for (int i = 0; i < len; i++) {
			if (s[i] >= '0' && s[i] <= 'z') ok = 1;
			else {
				validPhn = false;
				break;
			}
		}

		Console.WriteLine("Phone number is : " + validPhn);

	}
}