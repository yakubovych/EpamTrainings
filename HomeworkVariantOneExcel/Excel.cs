namespace HomeworkVariantOneExcel
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.IO;
    using Newtonsoft.Json;
    using NLog;
    using OfficeOpenXml;

    public class Excel : IExcel
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static string path = ConfigurationManager.AppSettings[@"ExcelPath"].ToString();
        private HashSet<string> uniqueValues = new HashSet<string>();
        FileInfo file = new FileInfo(path);

        public Excel(int FirstColumn, int SecondColumn)
        {
            uniqueValues = CompareColumnsAndGetUnique(FirstColumn, SecondColumn);
        }

        public ICollection<string> GetUnique()
        {
            return uniqueValues;
        }

        public void ReadExcel()
        {
            try
            {
                using (var package = new ExcelPackage(AccessFilesOnOneDrive.GetFileFromOneDriveAsync().Result))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    int rowCount = worksheet.Dimension.Rows;
                    int сolCount = worksheet.Dimension.Columns;

                    var rawText = string.Empty;
                    for (int row = 1; row <= rowCount; row++)
                    {
                        for (int col = 1; col <= сolCount; col++)
                        {
                            rawText += worksheet.Cells[row, col].Value.ToString() + "\t";
                        }

                        rawText += "\n";
                    }

                    Console.WriteLine(rawText);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        public HashSet<string> CompareColumnsAndGetUnique(int FirstColumn, int SecondColumn)
        {
            var source = new HashSet<string>();
            var comparer = new HashSet<string>();

            try
            {
                using (ExcelPackage package = new ExcelPackage(AccessFilesOnOneDrive.GetFileFromOneDriveAsync().Result))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    int rowCaunt = 1;
                    while (worksheet.Cells[rowCaunt, 2].Value != null)
                    {
                        source.Add(worksheet.Cells[rowCaunt, 2].Value.ToString());
                        rowCaunt++;
                    }

                    rowCaunt = 1;
                    while (worksheet.Cells[rowCaunt, 3].Value != null)
                    {
                        comparer.Add(worksheet.Cells[rowCaunt, 3].Value.ToString());
                        rowCaunt++;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }

            var _unique = new HashSet<string>(source);
            _unique.UnionWith(comparer);
            var duplicate = new HashSet<string>(source);
            duplicate.IntersectWith(comparer);
            _unique.ExceptWith(duplicate);
            return _unique;
        }

        // public void WriteToExcel()
        // {
        //    List<PersonDetails> persons = new List<PersonDetails>()
        //    {
        //        new PersonDetails() {Id = 95, Name = "Roman", Country = "Andrew", City = "Kyiv"},
        //        new PersonDetails() {Id = 83, Name = "Andrew", Country = "Ukraine", City = "Lviv"},
        //        new PersonDetails() {Id = 62, Name = "Stepan", Country = "Stepan", City = "Kyiv" },
        //        new PersonDetails() {Id = 64, Name = "Petro", Country = "Poland", City = "Lviv"},
        //    };

        // // Lets converts our object data to Datatable for a simplified logic.
        //    DataTable table = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(persons), (typeof(DataTable)));
        //    FileInfo filePath = new FileInfo(path);
        //    using (var excelPack = new ExcelPackage(filePath))
        //    {
        //        var ws = excelPack.Workbook.Worksheets.Add("WriteTest");
        //        ws.Cells.LoadFromDataTable(table, true, OfficeOpenXml.Table.TableStyles.Light8);
        //        excelPack.Save();
        //    }
        // }
    }
}
