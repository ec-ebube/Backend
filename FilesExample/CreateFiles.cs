using System;
using System.IO;
namespace FilesExample
{
    public class CreateFiles
    {
        public void Create()
        {
            string writeText = "Hello World";
            File.WriteAllText("filename.txt", writeText);

            string readText = File.ReadAllText("filename.txt");
        }
    }
}