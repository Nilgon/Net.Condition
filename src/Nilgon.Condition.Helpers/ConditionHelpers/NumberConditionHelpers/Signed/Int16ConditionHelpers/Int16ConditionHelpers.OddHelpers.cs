﻿namespace Nilgon.Condition.Helpers;

public static partial class Int16ConditionHelpers
{
    /// <summary>
    ///    Checks if the <paramref name="value" /> is odd.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    ///    <see langword="true" /> if the <paramref name="value"/> is odd; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsOdd(this short value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }

    /// <summary>
    ///    Checks if the <paramref name="value" /> is not odd.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    ///    <see langword="true" /> if the <paramref name="value"/> is not odd; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsNotOdd(this short value)
    {
        bool conditionResult = value % 2 == 0;

        return conditionResult;
    }
}
