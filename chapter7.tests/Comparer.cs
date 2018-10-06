using System;
using System.Collections.Generic;
using System.Text;

namespace chapter7.tests
{
	public class Comparer
	{
		public static Comparer<T> Get<T>(Func<T, T, bool> func)
		{
			return new Comparer<T>(func);
		}
	}

	public class Comparer<T> : Comparer, IEqualityComparer<T>
	{
		private Func<T, T, bool> comparisionFunc;

		public Comparer (Func<T,T, bool> func)
		{
			comparisionFunc = func;
		}			

		public bool Equals(T x, T y)
		{
			return comparisionFunc(x, y);
		}

		public int GetHashCode(T obj)
		{
			return obj.GetHashCode();
		}
	}
}
