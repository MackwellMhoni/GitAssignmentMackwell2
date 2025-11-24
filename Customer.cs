using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Assignment3
{
	public class Customer
	{
		public string Name { get; set; }
		public INewMember Mem { get; set; }

		public Customer(string name, INewMember membership)
		{
			Name = name;
			Mem = membership;
		}
	}
}
