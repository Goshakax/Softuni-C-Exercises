﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
		private int age;
        private string name;

		public Person(string name, int age)
		{
			Name = name;
			if (age>=0)
			{
				Age = age;
			}
		}

        public int Age
		{
			get { return age; }
			set { age = value; }                      
		}

		

		public string Name
		{
			get { return name; }
			set { name = value; }
		}


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                                 this.Name,
                                 this.Age));

            return stringBuilder.ToString();

        }

    }
}
