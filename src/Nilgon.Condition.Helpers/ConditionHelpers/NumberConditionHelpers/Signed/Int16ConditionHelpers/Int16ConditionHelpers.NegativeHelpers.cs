﻿namespace Nilgon.Condition.Helpers;

public static partial class Int16ConditionHelpers
{
    public static bool IsNegative(this short value)
    {
        bool conditionResult = value < 0;

        return conditionResult;
    }

    public static bool IsNotNegative(this short value)
    {
        bool conditionResult = value > 0;

        return conditionResult;
    }
}
