using System;

namespace ClosuresExample_DynamicAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicAdd();
        }

        private static void DynamicAdd()
        {
            var m5 = GetMultiX(staticVal: 5);
            var m10 = GetMultiX(staticVal: 10);

            Console.WriteLine(m5(arg:10));
            Console.WriteLine(m10(arg:10));
        }

        private static Func<int,int>GetMultiX(int staticVal)
        {
            return x => staticVal * x;
        }
    }
}
