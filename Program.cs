using System;
using System.Collections.Generic;

namespace OCP.Assignment3
{
	
	

	public class Program
	{
		public static void Main()
		{
			var customers = new List<Customer>
			{
				new Customer("Alice", "Regular"),
				new Customer("Bob", "Premium"),
				new Customer("Cathy", "VIP")
			};

			var discountCalculator = new DiscountCalculator();

			foreach (var c in customers)
			{
				double discount = discountCalculator.CalculateDiscount(c);
				Console.WriteLine($"{c.Name} ({c.MembershipType}) gets {discount * 100}% discount.");
			}

			var membershipCalculator = new MembershipCostCalculator();

			foreach (var c in customers)
			{
				double membershipCost = membershipCalculator.CalculateMembership(c, 12);
				Console.WriteLine($"{c.Name} ({c.MembershipType}) for 12 months costs {membershipCost}.");

				membershipCost = membershipCalculator.CalculateMembership(c, 18);
				Console.WriteLine($"{c.Name} ({c.MembershipType}) for 18 months costs {membershipCost}.");

				membershipCost = membershipCalculator.CalculateMembership(c, 24);
				Console.WriteLine($"{c.Name} ({c.MembershipType}) for 24 months costs {membershipCost}.");
			}
		}
	}
}
