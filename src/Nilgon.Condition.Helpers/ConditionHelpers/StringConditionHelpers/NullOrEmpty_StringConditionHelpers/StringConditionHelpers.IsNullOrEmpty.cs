﻿namespace Nilgon.Condition.Helpers
{
	public static partial class StringConditionHelpers
	{
		public static bool IsNullOrEmpty(this string value)
        {
			return string.IsNullOrEmpty(value);
        }
	}
}