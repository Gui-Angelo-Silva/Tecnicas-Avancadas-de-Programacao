using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPolimorfismoHeranca
{
	class Utilitario : Automovel
	{
		public int qtdLugares { get; set; }
		public string cor { get; set; }

		public override double Desconto()
		{
			return valor - 1000;	
		}
	}
}
