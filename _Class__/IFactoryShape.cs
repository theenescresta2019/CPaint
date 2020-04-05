using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPaint.Class
{

	class FactoryDataItem
	{
		public FactoryDataItem(object dataItem)
		{
			_dataItem = dataItem;
		}
		private object _dataItem;
		public object DataItem { get { return _dataItem; } }
	}

	interface IFactoryShape
	{
		FactoryDataItem GetData(int type);
	}


	abstract class AbstractFactory: IFactoryShape
	{
		public abstract FactoryDataItem GetData(int type);
	}

	class _ShapeFactory : AbstractFactory
	{
		public override FactoryDataItem GetData(int type)
		{
			FactoryDataItem factoryDataItem = null;

			switch ((_ShapeType)type)
			{
				case _ShapeType.circle:
					factoryDataItem = new FactoryDataItem(new _Circle());
					break;
				case _ShapeType.line:
					factoryDataItem = new FactoryDataItem(new _Line());
					break;
				case _ShapeType.rectangle:
					factoryDataItem = new FactoryDataItem(new _Rectangle());
					break;
					case _ShapeType.triangle:
					factoryDataItem = new FactoryDataItem(new _Triangle());
					break;

			}
			return factoryDataItem;
		}
	}



	class _ColorsFactory : AbstractFactory
	{
		public override FactoryDataItem GetData(int type)
		{
			FactoryDataItem factoryDataItem = null;

			
			switch ((_colorType)type)
			{
				case _colorType.red:
					factoryDataItem = new FactoryDataItem(new _Red());
					break;
				case _colorType.green:
					factoryDataItem = new FactoryDataItem(new _Green());
					break;
				

			}
			return factoryDataItem;
		}
	}


	//ShapeFactory shapeFactory = new ShapeFactory();
	//Color



	#region Shapes 
	enum _ShapeType
	{
		circle=1,
		rectangle=2,
		triangle=3,
		line=4
	}


	class _Circle
	{
		public void GetInfo()
		{
			Console.WriteLine("this is circle");
		}
	}

	class _Triangle
	{
		public void GetInfo()
		{
			Console.WriteLine("this is triangle ");
		}
	}


	class _Rectangle
	{
		public void GetInfo()
		{
			Console.WriteLine("this is rectangle");
		}
	}
	class _Line
	{
		public void GetInfo()
		{
			Console.WriteLine("this is line");
		}
	}
	#endregion Shapes 
	#region Colors 

	enum _colorType
	{
		red = 1,
		green= 2,
	}


	class _Red
	{
		public void GetInfo()
		{
			Console.WriteLine("this is red color ");
		}
	}

	class _Green
	{
		public void GetInfo()
		{
			Console.WriteLine("this is green");
		}
	}
	#endregion Colors
}
