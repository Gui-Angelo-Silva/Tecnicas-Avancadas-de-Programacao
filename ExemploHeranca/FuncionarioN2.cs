using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
	class FuncionarioN2 : Pai
	{
		public int idade { get; set; }

		public override double participacaoLucro()
		{
			return 1200 * 0.05;
		}
	}
}
