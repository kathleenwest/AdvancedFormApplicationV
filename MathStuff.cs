using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace AdvancedConsoleApplicationV
{
	/// <summary>
	/// Adapted from: http://kashfarooq.wordpress.com/2011/07/23/calculating-pi-in-c-part-2-using-the-net-4-biginteger-class/
	/// </summary>
	class MathStuff
	{
		public static BigInteger InverseTan(int denominator, int numberOfDigitsRequired)
		{
			int demonimatorSquared = denominator * denominator;
			int degreeNeeded = GetDegreeOfPrecisionNeeded(demonimatorSquared, numberOfDigitsRequired);

			BigInteger tenToNumberPowerOfDigitsRequired = GetTenToPowerOfNumberOfDigitsRequired(numberOfDigitsRequired);

			int c = 2 * degreeNeeded + 1;

			BigInteger s = BigInteger.Divide(tenToNumberPowerOfDigitsRequired, new BigInteger(c)); 

			for (int i = 0; i < degreeNeeded; i++)
			{
				c -= 2;
				BigInteger temp1 = BigInteger.Divide(tenToNumberPowerOfDigitsRequired, new BigInteger(c));
				BigInteger temp2 = BigInteger.Divide(s, new BigInteger(demonimatorSquared));
				s = BigInteger.Subtract(temp1, temp2);
			}
			return BigInteger.Divide(s, new BigInteger(denominator));
		}

		private static int GetDegreeOfPrecisionNeeded(int demonimatorSquared, int numberOfDigitsRequired)
		{
			int degreeNeeded = 0;

			while ((Math.Log(2 * degreeNeeded + 3) + (degreeNeeded + 1) * Math.Log10(demonimatorSquared)) <= numberOfDigitsRequired * Math.Log(10))
			{
				degreeNeeded++;
			}
			return degreeNeeded;
		}

		private static BigInteger GetTenToPowerOfNumberOfDigitsRequired(int numberOfDigitsRequired)
		{
			BigInteger tenToNumberOfDigitsRequired = new BigInteger(10);
			BigInteger pow = BigInteger.Pow(tenToNumberOfDigitsRequired, numberOfDigitsRequired);
			return pow;
		}

		public static string Calculate(int numberOfDigitsRequired)
		{
			numberOfDigitsRequired += 8; //  To be safe, compute 8 extra digits, to be dropped at end. The 8 is arbitrary

			BigInteger a = BigInteger.Multiply(InverseTan(5, numberOfDigitsRequired), new BigInteger(16)); //16 x arctan(1/5)
			BigInteger b = BigInteger.Multiply(InverseTan(239, numberOfDigitsRequired), new BigInteger(4)); //4 x arctan(1/239)
			BigInteger pi = BigInteger.Subtract(a, b);

			string piAsString = BigInteger.Divide(pi, new BigInteger(100000000)).ToString();
			string piFormatted = piAsString[0] + "." + piAsString.Substring(1, numberOfDigitsRequired - 8);
			return piFormatted;
		}
	}
}
