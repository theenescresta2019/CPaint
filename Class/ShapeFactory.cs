using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPaint.Class
{
	class ShapeFactory:AbstractFactory
	{
		public override FactoryShape GetShape(string shapeType)
		{
			FactoryShape factoryShape = null;
			if (shapeType.Equals("circle"))
			{
				factoryShape = new FactoryShape(new Circle());
			}

			return factoryShape;
		}
	}
}
