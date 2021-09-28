using ls1.Class;
using OfficeOpenXml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ls1
{
    class Program
    {
        static void Main(string[] args)
        {

            Univer univer = new Univer("Московский государственный университет имени М.В.Ломоносова", new DateTime(1775, 1, 25));
            univer.Students = new List<Student>(3)
            {
                new Student()
                {
                    Name = "Сергей",
                    DateOfEntry = new DateTime(2015, 9, 13),
                    NumberOfHomeworkCompleted = 20
                },
                new Student()
                {
                    Name = "Александр",
                    DateOfEntry = new DateTime(2017, 9, 15),
                    NumberOfHomeworkCompleted = 46
                },
                new Student()
                {
                    Name = "Генадий",
                    DateOfEntry = new DateTime(2019, 9, 10),
                    NumberOfHomeworkCompleted = 23
                }
            };
            univer.Teachers = new List<Teacher>(3)
            {
                new Teacher()
                {
                    Name = "Владислав",
                    DateOfEntry = new DateTime(2000, 2, 12),
                },
                new Teacher()
                {
                    Name = "Ермек",
                    DateOfEntry = new DateTime(1999, 5, 24),

                },
                new Teacher()
                {
                    Name = "Владимир",
                    DateOfEntry = new DateTime(1987, 4, 11),

                }
            };

            univer.Print();
            using (MemoryStream ms = new MemoryStream())
            {
                using (ExcelPackage excel = new ExcelPackage(ms))
                {
                    ExcelWorksheet worksheet = excel.Workbook.Worksheets.Add("страница 1");
                    worksheet.Cells["A1"].Value = "Фамилия";
                    worksheet.Cells["B1"].Value = "Имя";
                    worksheet.Cells["C1"].Value = "Группа";
                    worksheet.Cells["D1"].Value = "Успеваемость";
                    worksheet.Cells["F1"].Value = "Дата рождения";

                    worksheet.Cells["B1"].Style.Font.Bold = true;
                    worksheet.Cells["C1"].Style.Font.Bold = true;
                    worksheet.Cells["D1"].Style.Font.Bold = true;
                    worksheet.Cells["F1"].Style.Font.Bold = true;
                    int i = 1;
                    foreach (var item in univer.Students)
                    {
                        

                        worksheet.Cells[$"A{i}"].Value = item.Name;
                        worksheet.Cells[$"B{i}"].Value = item.Name;
                        worksheet.Cells[$"C{i}"].Value = item.Name;
                        worksheet.Cells[$"D{i}"].Value = item.Name;
                        worksheet.Cells[$"F{i}"].Value = item.Name;

                        i++;
                    }
                    excel.SaveAs(new FileInfo(@"C:\test.xlsx"));
                }
            }
            //string text = File.ReadAllText("C:\\MyFile\\myfile.txt");
            // Console.WriteLine(text);
        }
    }
}
