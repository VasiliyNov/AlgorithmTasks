using System;
using System.Text;

namespace Task5
{
    class Program
    {
        private static void CheckSelfDividingNumber(int left, int right)
        {
            string tmpStr;
            bool isSuccess;
            StringBuilder sb = new();

            for (int i = left; i <= right; i++)
            {
                tmpStr = Convert.ToString(i);

                if (!tmpStr.Contains("0"))
                {
                    isSuccess = true;

                    for (int j = 0; j < tmpStr.Length; j++)
                    {
                        if (i % Convert.ToInt32(tmpStr[j].ToString()) != 0)
                        {
                            isSuccess = false;
                            break;
                        }
                    }

                    if (isSuccess)
                    {
                        sb.Append(tmpStr + ", ");
                    }
                }
            }
            Console.WriteLine(sb.ToString().Substring(0, sb.Length - 2));
        }
        static void Main(string[] args)
        {
            CheckSelfDividingNumber(0, 22);
        }
    }
}
