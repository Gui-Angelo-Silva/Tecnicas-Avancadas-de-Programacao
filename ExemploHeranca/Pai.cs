using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
	class Pai
	{
		public string nome { get; set; }
		public char sexo { get; set; }

		public virtual double participacaoLucro()
		{
			return 1200 * 0.02;
		}
	}
}
