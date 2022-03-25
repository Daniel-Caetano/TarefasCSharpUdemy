using System;
using System.Collections.Generic;
using System.IO;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> urn = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            //path = @"E:\OneDrive\Documentos\desenvolvimento\udemy\C#-Completo\TestesCSharp\ExerciseDictionary\in.txt.txt";


            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (sr.EndOfStream is false)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = int.Parse(line[1]);



                        if (urn.ContainsKey(name) is false)
                        {
                            urn.Add(name, votes);
                        }
                        else
                        {
                            urn[name] += votes;
                        }


                       // Console.WriteLine("Name "+ name + "votes: "+ votes);
                    }
                }
                foreach (var candidate in urn)
                {
                    Console.WriteLine(candidate.Key + ": " + candidate.Value);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}