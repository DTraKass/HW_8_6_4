using System;
using System.IO;

namespace Program
{
    class Program
    {
        static string path = @"C:\Users\demon\Desktop\Students";

        public static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2004, 12, 18);
            DateTime date2 = new DateTime(2005, 5, 11);
            DateTime date3 = new DateTime(2006, 8, 27);

            Directory.CreateDirectory(path);

            Directory.CreateDirectory(path + @"\Group 1");
            Directory.CreateDirectory(path + @"\Group 2");
            Directory.CreateDirectory(path + @"\Group 3");

            using (BinaryWriter writer = new BinaryWriter(File.Open(path + @"\group1.txt", FileMode.Create)))
            {
                writer.Write("Student 1\n");
                writer.Write("Name Alex\n");
                writer.Write("Group 1\n");
                writer.Write($"Date of birth {date1}\n");
                writer.Write("4.64");
            }
            using (BinaryWriter writer = new BinaryWriter(File.Open(path + @"\group2.txt", FileMode.Create)))
            {
                writer.Write("Student 2\n");
                writer.Write("Name Peter\n");
                writer.Write("Group 2\n");
                writer.Write($"Date of birth {date2}\n");
                writer.Write("4.87");
            }
            using (BinaryWriter writer = new BinaryWriter(File.Open(path + @"\group3.txt", FileMode.Create)))
            {
                writer.Write("Student 3\n");
                writer.Write("Name Liam\n");
                writer.Write("Group 3\n");
                writer.Write($"Date of birth {date3}\n");
                writer.Write(" 4.76");
            }

            FileInfo file1 = new FileInfo(path + @"\group1.txt");
            FileInfo file2 = new FileInfo(path + @"\group2.txt");
            FileInfo file3 = new FileInfo(path + @"\group3.txt");

            Students(path, file1, file2, file3);
        }
        public static void Students(string Path, FileInfo File1, FileInfo File2, FileInfo File3)
        {
            if (!File1.Exists)
                File1.MoveTo(Path + @"\Group 1\student.txt");
            if (!File2.Exists)
                File2.MoveTo(Path + @"\Group 2\student.txt");
            if (!File3.Exists)
                File3.MoveTo(Path + @"\Group 3\student.txt");
        }
    }

}