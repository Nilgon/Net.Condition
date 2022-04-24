﻿using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.StringConditionHelpers
{
    public sealed class StringConditionHelpers_IsNotEmpty_Tests
    {
        [Fact]
        public void IsNotEmpty_ReturnsFalse_WhenStringIsEmpty()
        {
            string stringToTest = string.Empty;

            bool result = stringToTest.IsNotEmpty();

            Assert.False(result);
        }
        
        [Fact]
        public void IsNotEmpty_ReturnsTrue_WhenStringIsFull()
        {
            string stringToTest = "test";
            
            bool result = stringToTest.IsNotEmpty();

            Assert.True(result);
        }

        [Fact]
        public void IsNotEmpty_ReturnsFalse_WhenStringIsNull()
        {
            string stringToTest = null;

            bool result = stringToTest.IsNotEmpty();

            Assert.True(result);
        }
    }
}
