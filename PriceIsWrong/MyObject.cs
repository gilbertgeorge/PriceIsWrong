using System;

namespace ClosestWithoutGoingOver
{
	public class MyObject
	{
		public MyObject()
		{
			objectId = 0;
			MyDate = DateTime.Now;
		}

		public MyObject(int id)
		{
			objectId = id;
			myDate = DateTime.Now;
		}

		public MyObject(DateTime date)
		{
			objectId = 0;
			MyDate = date;
		}

		public MyObject(int id, DateTime date)
		{
			objectId = id;
			myDate = date;
		}

		public DateTime MyDate
		{
			get
			{
				return myDate;
			}
			set
			{
				value = myDate;
			}
		}

		public int ObjectId
		{
			get
			{
				return objectId;
			}
			set
			{
				objectId = value;
			}

		}

		public string Info { get; set; }

		private int objectId;
		private DateTime myDate;
	}
}
