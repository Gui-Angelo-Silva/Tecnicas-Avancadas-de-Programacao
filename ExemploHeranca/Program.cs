using ExemploHeranca;
class Program
{
	static void Main(String[] args)
	{
		FuncionarioN1 n1 = new FuncionarioN1();
		n1.nome = "Guilherme";
		n1.sexo = 'M';

		Console.WriteLine("O nome do funcionário é " + n1.nome + " e o sexo é " + n1.sexo);
		Console.WriteLine("\nA comissão é" + n1.participacaoLucro().ToString());

		FuncionarioN2 n2 = new FuncionarioN2();
		n2.nome = "Ana";
		n2.sexo = 'F';
		n2.idade = 18;

		Console.WriteLine("---------------------------------------------\n");
		Console.WriteLine("O nome da funcionária é " + n2.nome + " e o sexo é " + n2.sexo + " e a sua idade é " + n2.idade);
		Console.WriteLine("\nA comissão é" + n2.participacaoLucro().ToString());
	}
}
