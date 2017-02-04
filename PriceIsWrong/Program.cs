using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestWithoutGoingOver
{
	class Program
	{
		static void Main(string[] args)
		{
			MyObject obj1 = new MyObject(0, new DateTime(2017, 1, 1));
			MyObject obj2 = new MyObject(1, new DateTime(2017, 1, 15));
			MyObject obj3 = new MyObject(2, new DateTime(2017, 2, 1));
			MyObject obj4 = new MyObject(3, new DateTime(2017, 2, 5));
			MyObject obj5 = new MyObject(4, new DateTime(2017, 2, 18));
			MyObject obj6 = new MyObject(5, new DateTime(2017, 3, 1));

			List<MyObject> myObjects = new List<MyObject>();
			myObjects.Add(obj6);
			myObjects.Add(obj1);
			myObjects.Add(obj4);
			myObjects.Add(obj2);
			myObjects.Add(obj5);
			myObjects.Add(obj3);

			Print(myObjects);
			List<MyObject> orderedObjects = myObjects.OrderBy(x => x.ObjectId).ToList();
			Print(orderedObjects);

			Console.Read();
		}

		static private void Print(List<MyObject> objects)
		{
			objects.ForEach(x => Console.WriteLine(string.Format("obj date: {0}", x.MyDate)));
			Console.WriteLine(Environment.NewLine);
		}
	}
}
