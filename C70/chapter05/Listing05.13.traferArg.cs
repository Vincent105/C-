using System;
using System.Collections.Generic;
using System.Text;

namespace chapter05
{
    class Listing0513
    {
        static void Main0513()
        {
            string fullName;
            string driverLetter = "C:";
            string folderPath = "Data";
            string fileName = "index.html";

            fullName = Combine(driverLetter, folderPath, fileName);
            System.Console.WriteLine(fullName);
        }

        static string Combine(string driverLetter, string folderPath, string fileName)
        {
            string Path;
            Path = string.Format("{1}{0}{2}{0}{3}",System.IO.Path.DirectorySeparatorChar, driverLetter, folderPath, fileName);
            return Path;
        }
    }
}
