using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPaint.Class
{
	abstract class AbstractFactory:IFactoryShape
	{
		public abstract FactoryShape GetShape(string shapeType);
	}
}
