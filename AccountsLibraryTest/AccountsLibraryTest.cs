using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountsLibrary.Extensions;

namespace AccountsLibraryTest
{
    [TestClass]
    public class AccountsLibraryTest
    {
        [TestMethod]
        public void should_return_true_when_the_two_dateTime_is_the_same_year_same_month()
        {
            DateTime dateTime = new DateTime(2019, 6, 30);
            DateTime targetDateTime = new DateTime(2019, 6, 30);
            bool result = dateTime.IsSameMonthOfSameYear(targetDateTime);
            Assert.IsTrue(result);
        }
    }
}
