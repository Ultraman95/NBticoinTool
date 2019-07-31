using NBitcoin;
using System;

namespace NBticoinTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Key k1 = new Key();
            PubKey pubk1 = k1.PubKey;
            Console.WriteLine(pubk1);
            Console.WriteLine(pubk1.GetAddress(Network.Main));
        }
    }
}
