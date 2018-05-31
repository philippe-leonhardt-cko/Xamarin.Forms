using System;
using System.Linq;

using NUnit.Framework;

namespace Xamarin.Forms.Xaml.UnitTests
{
	[TestFixture]
	public class ShameHatCodeInjected
	{
		[Test]
		public void InjectedCodeIsPresent()
		{
			var resLoader = typeof(Xamarin.Forms.Internals.ResourceLoader);
			Assert.True(resLoader.GetMethods().Any(mi => mi.Name == "get_ResourceProvider" && mi.ReturnType == typeof(Func<string,string>)));

		}
	}
}
