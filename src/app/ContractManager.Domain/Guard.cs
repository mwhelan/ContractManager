using System;

namespace ContractManager.Domain
{
    public class Guard
    {
        public static void Against(bool condition, string errorMessage)
        {
            if (condition)
            {
                throw new ArgumentException(errorMessage);
            }
        }
        public static void ForLessEqualZero(int value, string parameterName)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(parameterName);
            }
        }

        public static void ForNullOrEmpty(string value, string parameterName)
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentOutOfRangeException(parameterName);
            }
        }
    }
}
