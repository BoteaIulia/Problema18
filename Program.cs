using System;

public static class Globals
{
	internal static void Main()
	{
		int n;
		Console.Write("Introdu numarulpentru descompunere = ");
		n = Convert.ToInt32(Console.ReadLine());
		int d = 2; // p va fi puterea lui d in descompunere
		int p;
		// il  im partim pe n la d in mod repetat, pana cand devine 1
		Console.Write("Descompunerea in factori primi este = ");
		while (n > 1)
		{
			// numaram de cate ori se imparte n la d. Aceasta va fi puterea lui d in descompunere
			p = 0;
			while (n % d == 0)
			{
				++p;
				n /= d;
			}
			// daca s-a facut cel putin o impartire, afisam factorul si puterea
			
			if (p != 0)
			{
				
				Console.Write(d);
				Console.Write("^");
				Console.Write(p);
				Console.Write(" x ");

			}
			++d;
			//  daca d * d il depaseste pe n si n nu este 1, decidem ca n este prim,
			//  si este factor in descompunerea valorii initiale a lui n
			if (n > 1 && d * d > n)
			{
				d = n; // trecem direct la n, urmatorul factor din descompunere
			}
		}
	}
}
