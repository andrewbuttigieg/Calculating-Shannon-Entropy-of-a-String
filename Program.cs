using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShannonEntropy
{
    public class Program
    {
        public static double ShannonEntropy(string message){
            double sumnation = 0;
            foreach (var s in message.ToList().Distinct())
            {
                var temp = (message.Count(x=>x == s) / (double)(message.Length));
                sumnation += temp * Math.Log(temp, 2.0f);
            }
            return -1.0f * sumnation;
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine(ShannonEntropy("1223334444"));
            Console.WriteLine(ShannonEntropy("Hello, world!"));
            Console.WriteLine(ShannonEntropy("122333444455555666666777777788888888"));
            Console.WriteLine(ShannonEntropy("563881467447538846567288767728553786"));
            Console.WriteLine(ShannonEntropy("https://www.reddit.com/r/dailyprogrammer"));
            Console.WriteLine(ShannonEntropy("int main(int argc, char *argv[])"));
            Console.Read();
        }
    }
}
