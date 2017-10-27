using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsGen_Hackathon
{
    public class ProcessCsv
    {
        public void ProcessCsvFile(string filePath, string outputPath, string roundNo)
        {
            if (String.IsNullOrEmpty(filePath))
                throw new Exception("The file path for " + roundNo + " round results must be provided!");
            if (String.IsNullOrEmpty(outputPath))
                throw new Exception("The output path must be provided!");

            //results
            List<CsvRow> results = new List<CsvRow>();
            // Read sample data from CSV file
            using (CsvFileReader reader = new CsvFileReader(filePath))
            {
                CsvRow row = new CsvRow();
                int counter = 0;

                // Write sample data to CSV file
                string file = outputPath + @"\" + roundNo + "RoundResults_final.csv";

                if (!File.Exists(file))
                {
                    using (CsvFileWriter writer = new CsvFileWriter(file))
                    {
                        while (reader.ReadRow(row))
                        {
                            if (counter == 0 || row.Contains("$"))
                            {
                                counter++;
                                continue;
                            }
                            if (counter == 1)
                            {
                                row.Clear();
                                string heading = roundNo + " Round Results";
                                row.Add(heading);
                                row.LineText = heading;
                            }

                            writer.WriteRow(row);
                            counter++;
                        }
                    }
                }
                else
                    throw new Exception("The file " + roundNo + "RoundResults_final.csv already exists! Please remove it if you need to regenerate the CSV file.");
            }
        }

        public void ProcessFinalResults(string outputPath)
        {
            if (String.IsNullOrEmpty(outputPath))
                throw new Exception("The output path must be provided!");
            try
            {
                List<FinalResultsData> finalResults = new List<FinalResultsData>();
                string[] files = Directory.GetFiles(outputPath);
                int rounds = 0;
                foreach (var file in files)
                {
                    rounds++;
                    // Read sample data from CSV file
                    using (CsvFileReader reader = new CsvFileReader(file))
                    {
                        CsvRow row = new CsvRow();
                        int counter = 0;

                        while (reader.ReadRow(row))
                        {
                            if (counter <= 1)
                            {
                                counter++;
                                continue;
                            }
                            string name = "";
                            for (int i = 0; i < row.Count; i++)
                            {
                                if (i == 1)
                                {
                                    name = row[i];
                                    if (rounds == 1)
                                        finalResults.Add(new FinalResultsData { Name = name, firstRoundScore = 0, secondRoundScore = 0, thirdRoundScore = 0, finalScore = 0 });
                                }
                                if (i == 2)
                                {
                                    if (file.Contains("1st"))
                                        finalResults.First(rec => rec.Name == name).firstRoundScore = Convert.ToInt32(row[i].Split(' ')[0]);
                                    else if (file.Contains("2nd"))
                                        finalResults.First(rec => rec.Name == name).secondRoundScore = Convert.ToInt32(row[i].Split(' ')[0]);
                                    else if (file.Contains("3rd"))
                                        finalResults.First(rec => rec.Name == name).thirdRoundScore = Convert.ToInt32(row[i].Split(' ')[0]);
                                }
                            }
                        }
                    }
                }
                foreach (var result in finalResults)
                {
                    finalResults.First(rec => rec.Name == result.Name).finalScore = (result.firstRoundScore + result.secondRoundScore + result.thirdRoundScore) / rounds;

                }
                writeFinalResultsToCsv(finalResults, outputPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void writeFinalResultsToCsv(List<FinalResultsData> results, string outputPath)
        {
            if (String.IsNullOrEmpty(outputPath))
                throw new Exception("The output path must be provided!");

            // Write sample data to CSV file
            string file = outputPath + @"\FinalResults.csv";

            using (CsvFileWriter writer = new CsvFileWriter(file))
            {
                writer.WriteLine("Overall Results");
                writer.WriteLine("Rank, Team Name, Final Score, 1st Round Score, 2nd Round Score, 3rd Round Score");
                int rank = 0;
                foreach (var result in results.OrderByDescending(rec => rec.finalScore))
	            {
                    rank++;
                    CsvRow row = new CsvRow();
                    row.Add(rank.ToString());
                    row.Add(result.Name.ToString());
                    row.Add(result.finalScore.ToString());
                    row.Add(result.firstRoundScore.ToString());
                    row.Add(result.secondRoundScore != 0 ? result.secondRoundScore.ToString() : "TBD");
                    
                    row.Add(result.thirdRoundScore != 0 ? result.thirdRoundScore.ToString() : "TBD");
                    writer.WriteRow(row);
                }
            }

        }
    }

    class FinalResultsData
    {
        public string Name { get; set; }
        public int firstRoundScore { get; set; }
        public int secondRoundScore { get; set; }
        public int thirdRoundScore { get; set; }
        public double finalScore { get; set; }
    }
}
