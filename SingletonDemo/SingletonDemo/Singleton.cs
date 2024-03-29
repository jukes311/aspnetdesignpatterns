﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*CS 2019*/

namespace SingletonDemo
{
	public sealed class Singleton
	{
		private static int counter = 0;

		/*
		 * Private property initilized with null
		 * ensures that only one instance of the object is created
		 * based on the null condition
		 */
		private static Singleton instance = null;

		/*
		 * public property is used to return only one instance of the class
		 * leveraging on the private property
		 */
		public static Singleton GetInstance
		{
			get
			{
				if (instance == null)
					instance = new Singleton();
				return instance;
			}
		}
		/*
		 * Private constructor ensures that object is not
		 * instantiated other than with in the class itself
		 */
		private Singleton()
		{
			counter++;
			Console.WriteLine("Counter Value " + counter.ToString());
		}
		/*
		 * Public method which can be invoked through the singleton instance
		 */
		public void PrintDetails(string message)
		{
			Console.WriteLine(message);
		}
	}
}
