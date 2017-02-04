using System;

namespace PriceIsWrong
{
	public class MyObject
	{
		public MyObject()
		{
			objectId = 0;
			myDate = DateTime.MinValue;
		}

		public MyObject(int id)
		{
			objectId = id;
			myDate = DateTime.MinValue;
		}

		public MyObject(DateTime date)
		{
			objectId = 0;
			myDate = date;
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
