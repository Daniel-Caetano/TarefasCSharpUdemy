using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace ExercicioArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathFile = @"C:\Users\daniel.ferreira\Documents\desenvolvimento\udemy\C#-Completo\TarefasCSharpUdemy\ExercicioArquivos\itens.csv";
            string createDirectory = @"C:\Users\daniel.ferreira\Documents\desenvolvimento\udemy\C#-Completo\TarefasCSharpUdemy\ExercicioArquivos\out";
            string createNewFileCsv = @"C:\Users\daniel.ferreira\Documents\desenvolvimento\udemy\C#-Completo\TarefasCSharpUdemy\ExercicioArquivos\out\summary.csv";
            // List<string> lines = new List<string>();
            //string path = @"C:\Users\daniel.ferreira\Documents\desenvolvimento\udemy\C#-Completo\TarefasCSharpUdemy\ExercicioArquivos\totalitensvendidos.txt";
            try
            {
                if (!Directory.Exists(createDirectory))
                {
                    Directory.CreateDirectory(createDirectory);
                }
                if (!File.Exists(createNewFileCsv))
                {
                    File.Create(createNewFileCsv);
                }

                using (StreamWriter arquivo  = File.AppendText(createNewFileCsv))
                {
                    string[] lines = File.ReadAllLines(pathFile);
                    FileInfo aux = new FileInfo(pathFile);
                    StringBuilder nome = new StringBuilder();
                    foreach (string line in lines)
                    {

                        string [] teste = line.Split(',');
                        string name = teste[0];
                        double price = double.Parse(teste[1],CultureInfo.InvariantCulture);
                        int quantity = int.Parse(teste[2], CultureInfo.InvariantCulture);

                        arquivo.WriteLine(name + ',' + (price * (double)quantity).ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception ocurred" + ex.ToString());
            }
        }

    }
}
