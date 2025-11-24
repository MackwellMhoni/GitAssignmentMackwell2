using System;
using System.Collections.Generic;


namespace OCP.Assignment3
{
	public interface INewMember
	{
		double CalculateDiscount(Customer customer);
		double CalculateMembership(Customer customer, int months);

	}

	public class RegularMember : INewMember
	{
		public double CalculateDiscount(Customer customer)
		{
			return 0.05;
		}

		public double CalculateMembership(Customer customer, int months)
		{
			return 400 * months;
		}
	}

	public class Premium : INewMember
	{
		public double CalculateDiscount(Customer customer)
		{
			return 0.05;
		}

		public double CalculateMembership(Customer customer, int months)
		{
			return months < 12 ? 600 * months : (500 * months) + 200;
		}
	}

	public class VIP: INewMember
	{
		public double CalculateDiscount(Customer customer)
		{
			return 0.20;
		}

		public double CalculateMembership(Customer customer, int months)
		{
			return months < 18 ? 900 * months : (550 * months) + 300;
		}
			
	}



	public class Program
	{
		public static void Main()
		{
				var customers = new List<Customer>
			{
				new Customer("Alice", new RegularMember()),
				new Customer("Bob", new Premium()),
				new Customer("Cathy", new VIP())
			};

			var discountCalculator = new DiscountCalculator();

			foreach (var c in customers)
			{
				double discount = discountCalculator.CalculateDiscount(c);
				Console.WriteLine($"{c.Name} ({c.Mem}) gets {discount * 100}% discount.");
			}

			var membershipCalculator = new MembershipCostCalculator();

			foreach (var c in customers)
			{
				double membershipCost = membershipCalculator.CalculateMembership(c, 12);
				Console.WriteLine($"{c.Name} ({c.Mem}) for 12 months costs {membershipCost}.");

				membershipCost = membershipCalculator.CalculateMembership(c, 18);
				Console.WriteLine($"{c.Name} ({c.Mem}) for 18 months costs {membershipCost}.");

				membershipCost = membershipCalculator.CalculateMembership(c, 24);
				Console.WriteLine($"{c.Name} ({c.Mem}) for 24 months costs {membershipCost}.");
			}
		}
	}
}