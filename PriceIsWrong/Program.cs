using System;
using System.Collections.Generic;
using System.Linq;

//Note to self, download linqpad.... huzzah!
namespace PriceIsWrong
{
	class Program
	{
		static void Main(string[] args)
		{
			MyObject obj1 = new MyObject(new DateTime(2017, 1, 1));
			MyObject obj2 = new MyObject(new DateTime(2017, 1, 15));
			MyObject obj3 = new MyObject(new DateTime(2017, 2, 1));
			MyObject obj4 = new MyObject(new DateTime(2017, 2, 5));
			MyObject obj5 = new MyObject(new DateTime(2017, 2, 18));
			MyObject obj6 = new MyObject(new DateTime(2017, 3, 1));

			List<MyObject> myObjects = new List<MyObject>();
			myObjects.Add(obj6);
			myObjects.Add(obj1);
			myObjects.Add(obj4);
			myObjects.Add(obj2);
			myObjects.Add(obj5);
			myObjects.Add(obj3);

			DateTime theTime = DateTime.Now;

			Print("unordered", myObjects);
			Console.WriteLine(ClosestWithoutGoingOver(myObjects, theTime).MyDate);

			MyObject query = myObjects
				.Where(n => n.MyDate <= theTime)
				.OrderByDescending(n => n.MyDate)
				.FirstOrDefault();

			Console.WriteLine(string.Format("Price is right: {0}", query.MyDate));
			Console.Read();
		}

		static private void Print(string message, List<MyObject> objects)
		{
			Console.WriteLine(message);
			objects.ForEach(x => Console.WriteLine(string.Format("obj date: {0}", x.MyDate)));
			Console.WriteLine(Environment.NewLine);
		}

		static MyObject ClosestWithoutGoingOver(List<MyObject> listObjs, DateTime theDate)
		{
			MyObject retVal = new MyObject(DateTime.MinValue);

			foreach(MyObject obj in listObjs)
			{
				if(obj.MyDate.Date <= theDate.Date)
				{
					retVal = obj;
				}
			}

			return retVal;
		}
	}
}
