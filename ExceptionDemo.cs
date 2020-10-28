using System;
using System.IO;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string fileName = @"c:\Course\School.sql";
                ReadFile(fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Er is een niet voorziene fout opgetreden");
                Console.WriteLine("geef de volgende melding door aan de helpdesk");
                Console.WriteLine(ex.Message);
                ex.
            }
        }

        static void ReadFile(string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line); ;
                    line = sr.ReadLine();
                }
            }

            catch (DirectoryNotFoundException ex)//specifiek
            {
                Console.WriteLine("De folder  is niet gevonden");
                Console.WriteLine(ex.Message);
                throw ex;//veroorzaak de fout opnieuw zodat de aanroepende code weet dat er iets is fout gegaan
            }
            catch (FileNotFoundException ex)//specifiek
            {
                Console.WriteLine("het bestand is niet gevonden");
                Console.WriteLine(ex.Message);
                throw ex;//veroorzaak de fout opnieuw zodat de aanroepende code weet dat er iets is fout gegaan

            }
            catch (IOException ex)//meer generiek
            {
                Console.WriteLine("er is iets op IO gebied fout gegaan");
            }
            finally
            {
                Console.WriteLine("Running finally block");
                //Opruim werkzaamheden
            }

        }
    }
}
