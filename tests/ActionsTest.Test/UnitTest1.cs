using ActionsTest.Pages;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Xunit;

namespace ActionsTest.Test
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			// Arrange
			var pageModel = new IndexModel();

			// Act
			var result = pageModel.OnGet();

			// Assert
			Assert.IsAssignableFrom<PageResult>(result);
		}
	}
}
