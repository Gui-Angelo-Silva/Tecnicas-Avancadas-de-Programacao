using ExercicioPolimorfismoHeranca;

class Program
{
	static void Main(string[] args)
	{
		Trabalho trabalho = new Trabalho();
		trabalho.qtdEixos = 1;
		trabalho.capacidadePeso = 1;
		trabalho.valor = 50000;

		Console.WriteLine("A quantidade de eixos é: " + trabalho.qtdEixos + " e a capacidade de peso é: " + trabalho.capacidadePeso);
		Console.WriteLine(" O valor do automovel de trabalho é: " + trabalho.Desconto());

		Utilitario utilitario = new Utilitario();
		utilitario.qtdLugares = 2;
		utilitario.cor = "prata";
		utilitario.valor = 80000;

		Console.WriteLine("\n A quantidade de lugares é: " + utilitario.qtdLugares + " e sua cor é: " + utilitario.cor);
		Console.WriteLine(" O valor do automovel utilitario é: " + utilitario.Desconto());
	}
}