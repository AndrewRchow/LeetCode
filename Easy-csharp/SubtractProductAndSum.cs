using System;

namespace Easy_csharp
{
    public static class SubtractProductAndSum
    {
        public static int Solution(int n) {
            string stringNumber = n.ToString();
            int addition = 0;
            int multiplication = 1;
            for (var i = 0; i<stringNumber.Length; i++) {
                addition += Convert.ToInt32(stringNumber[i].ToString());
                multiplication *= Convert.ToInt32(stringNumber[i].ToString());
            }
            return multiplication - addition;
        }
    }
}
