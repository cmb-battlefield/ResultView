using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResultsGen_Hackathon_Class;

namespace ResultsGen_Hackathon
{
    static class ProgramCMD
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0 && args.Length <= 4)
            {
                string firstRoundResultPath = string.Empty, secondRoundResultPath = string.Empty, thirdRoundResultPath = string.Empty, outputPath = string.Empty;

                outputPath = args[args.Length - 1]; // Last in argument list is output path

                for (int i = 0; i < args.Length - 1; i++)
                {
                    switch (i)
                    {
                        case 0:
                            firstRoundResultPath = args[i];
                            break;
                        case 1:
                            secondRoundResultPath = args[i];
                            break;
                        case 2:
                            thirdRoundResultPath = args[i];
                            break;

                    }
                }

                if (string.IsNullOrEmpty(outputPath))
                {
                    System.Console.WriteLine("ERROR: Output path not defined");
                    return;
                }

                if (string.IsNullOrEmpty(firstRoundResultPath))
                {
                    System.Console.WriteLine("ERROR: At least one input file should define");
                    return;
                }

                ProcessInputCSV(firstRoundResultPath, outputPath, "1st");
                ProcessInputCSV(secondRoundResultPath, outputPath, "2nd");
                ProcessInputCSV(thirdRoundResultPath, outputPath, "3rd");

                ProcessAllCSV(outputPath);
            }
            else
            {
                System.Console.WriteLine("RoboCode output csv processor");
                System.Console.WriteLine("Usage: ResultGen_Hackathon file1 file2 file3 outPath");
            }
        }

        private static void ProcessAllCSV(string outputPath)
        {
            try
            {
                new ProcessCsv().ProcessFinalResults(outputPath);
                System.Console.WriteLine("Process Final Result Completed.");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error occur while processing final results file");
                System.Console.WriteLine("Original Error: " + ex.Message);
            }
        }

        private static void ProcessInputCSV(string firstRoundResultPath, string outputPath, string p)
        {
            try
            {
                new ProcessCsv().ProcessCsvFile(firstRoundResultPath, outputPath, p);
                System.Console.WriteLine("Process file " + p + " Completed.");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error occur while processing file " + p);
                System.Console.WriteLine("Original Error: " + ex.Message);
            }
        }
    }
}
