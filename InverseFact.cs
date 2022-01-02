using System;

// Marco Vincenzi 2022
public class Factorial 
{	
	/// <summary>
	/// Returns true if the passed int is the result of factorial int.
	/// </summary>
	public static bool IsFact(int n) 
	{
		if (n < 0) return false;
		if (n <= 1) return true;

		int div = n;

		for (int x = 1; x <= n; x++) 
		{
			if (div % x != 0) break;
			div /= x;
		}

		return div == 1;
	}

	/// <summary>
	/// Returns an int x so that x! = n. 
	/// Returns -1 if n is not the factorial of any int.
	/// </summary>
	public static int InverseFact(int n)
	{
		if (n < 0) return -1;
		if (n <= 1) return 1;

		int div = n;
		int x;

		for (x = 1; x <= n; x++)
		{
			if (div % x != 0) break;
			div /= x;
		}

		return x * (div == 1 ? 1 : 0) - 1;
	}
}
