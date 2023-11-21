using System;
namespace CalculadoraDeHipotenusa{
class classe{
	static void Main(String[] args){
		
	Console.WriteLine("informe o lado A: ");
	double A = Convert.ToDouble(Console.ReadLine());
	
	Console.WriteLine("informe o lado B: ");
	double B = Convert.ToDouble(Console.ReadLine());
	
	double C = Math.Sqrt((A*A) + (B*B));
	Console.WriteLine(" a hipotenusa é: "+ C);
	
	}
}
}