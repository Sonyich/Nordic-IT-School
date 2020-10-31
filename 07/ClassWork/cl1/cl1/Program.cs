using System;
using System.IO;
using System.Text;

namespace cl1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filename = @"c:\test.txt";
            const string content = "Hello from deep space!";

            // FileStream stream = File.Create(
            //   filename,
            // bufferSize: 4096);

            FileStream stream = File.Open(
                filename,
                FileMode.OpenOrCreate,
                FileAccess.ReadWrite,
                FileShare.None);

            byte[] bytes = Encoding.ASCII.GetBytes(content);

            stream.Write(bytes);
            stream.Close();
        }
    }
}
