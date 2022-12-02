using System;

namespace Task_1_2
{
	class Programm
	{
		static void Main(string[] agrs)
		{
			int a;

			while (true)
			{
				Console.Write("Введите a: ");
				a = Convert.ToInt32(Console.ReadLine());
				
				if ((a > 9 && a < 100) || (a < -9 && a > -100))
				{
					break;
				}

				Console.WriteLine("Число должно быть двухзначным");
			}

			string aS = a.ToString();

			if (a < 0)
			{
				aS = aS.Remove(0, 1);
			}

			if (aS[0] == aS[1])
			{
				Console.WriteLine("Цифры у данного числа равны");
			}
			else
			{
				Console.WriteLine("Цифры у данного числа неравны");
			}
		}
	}
}