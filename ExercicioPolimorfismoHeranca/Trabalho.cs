using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPolimorfismoHeranca
{
	class Trabalho : Automovel
	{
		public double capacidadePeso { get; set; }
		public int qtdEixos { get; set; }
		public override double Desconto()
		{
			return valor - 5000;	
		}
	}
}
