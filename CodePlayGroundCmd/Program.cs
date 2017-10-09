using CodePlayGround;
using System;

namespace CodePlayGroundCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "abas34[asdasd3[adv23[a]asdasd2[as]asd2[as]asdasf]daqsad3[asd3[sad]asd]da]sdasd3[asd]";

            Console.WriteLine("Encoded String: {0} ", input);
            Console.WriteLine("Decoded String: {0} ", input.DecodeString());

            Console.ReadLine();
        }
    }
}
