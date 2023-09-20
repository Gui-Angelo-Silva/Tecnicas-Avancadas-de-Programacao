using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
	class FuncionarioN1 : Pai
	{
		public override double participacaoLucro()
		{
			return 1200 * 0.02;
		}
	}
}
