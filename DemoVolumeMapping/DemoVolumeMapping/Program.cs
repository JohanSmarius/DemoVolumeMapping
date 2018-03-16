using System;
using System.IO;
using System.Threading.Tasks;

namespace DemoVolumeMapping
{
    class Program
    {
        static int Main(string[] args)
        {
            int counter = Convert.ToInt32(args[0]);

            string fileName = args[1];

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
