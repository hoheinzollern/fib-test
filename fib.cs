using System;

namespace Application
{
	public class fib
	{
		private static int fibr(int n) {
			if (n < 2) return 1;
			return fibr(n-1) + fibr(n-2);
		}
		
		public static void Main(string[] args) {
			Console.Out.WriteLine(fibr(int.Parse(args[0])));
		}
	}
}
