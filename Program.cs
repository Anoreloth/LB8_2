using System;
using System.IO;

class Test
{
    public static void Main()
    {
        string path = @"d:\temp\";

        if (!File.Exists(path + "g.txt"))
        {
            using (StreamWriter gf = File.CreateText(path + "g.txt"))
            {
                using (StreamReader ff = File.OpenText(path + "f.txt"))
                {
                    string s;
                    while ((s = ff.ReadLine()) != null)
                    {
                         gf.WriteLine(s.ToLower());
                    }
                }
            }
        }
    }
}
