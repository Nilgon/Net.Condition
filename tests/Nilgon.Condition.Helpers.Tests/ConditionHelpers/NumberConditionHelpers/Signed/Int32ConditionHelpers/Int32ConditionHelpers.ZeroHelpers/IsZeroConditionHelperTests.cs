﻿using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.Int32ConditionHelpers.ZeroHelpers
{
    public sealed class IsZero_Condition_Helper_Tests
    {
        [Fact]
        public void IsZero_ReturnsTrue_WhenNumberIsZero()
        {
            int numberToTest = 0;
            
            bool result = numberToTest.IsZero();

            Assert.True(result);
        }

        [Fact]
        public void IsZero_ReturnsFalse_WhenNumberIsNotZero()
        {
            int numberToTest = 1;

            bool result = numberToTest.IsZero();

            Assert.False(result);
        }
    }
}
