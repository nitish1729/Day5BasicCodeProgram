// Program to Compute Quotient and Remainder

nt dividend; int remainder;
Console.WriteLine("Enter a Dividend");

 dividend = Convert.ToInt32(Console.ReadLine());
		int divisor ;
		Console.WriteLine("Enter a Divisor");
		divisor = Convert.ToInt32(Console.ReadLine());
		int quoteint;
		
		quoteint = dividend/divisor;
		Console.WriteLine("quotent :" +quoteint);
		remainder = dividend%divisor;
		
 Console.WriteLine("Remainder :" +remainder);
	