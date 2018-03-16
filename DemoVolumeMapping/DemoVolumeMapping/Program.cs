using System;
using System.IO;
using System.Threading.Tasks;

namespace DemoVolumeMapping
{
    class Program
    {
        static int Main(string[] args)
        {
            int counter = args.Length > 0 ? Convert.ToInt32(args[0]) : 30;

            string fileName = args.Length >0 ? args[1] : "Default.log";

            using (var stream = new StreamWriter(fileName))
            {
                for (int i = 0; i < counter; i++)
                {
                    stream.WriteLine($"Line: {i}");
                }

                stream.Flush();
            }

            return 0;
        }
    }
}
