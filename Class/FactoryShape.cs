using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPaint.Class
{
	class FactoryShape
	{
		public FactoryShape(object shape)
		{
			_shape = shape;
		}
		private object _shape;
		public object Shape{get{ return _shape; } }


	}
}
