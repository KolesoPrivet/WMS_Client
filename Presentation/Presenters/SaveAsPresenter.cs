using Presentation.Common;

using DomainModel.Abstract;
using DomainModel.Entity;

using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace Presentation.Presenters
{
    public class SaveAsPresenter : Presenter
    {
        public void SaveFileExcel(List<Data> dataForSavingParam, string filePathParam, string fileNameParam)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Workbooks.Add();

                Excel._Worksheet workSheet = excelApp.ActiveSheet;

                workSheet.Cells[1, "A"] = "Date";
                workSheet.Cells[1, "B"] = "Time";
                workSheet.Cells[1, "C"] = "Value";

                int row = 0;

                foreach (var d in dataForSavingParam)
                {
                    row++;
                    workSheet.Cells[row, "A"] = d.Date.ToString();
                    workSheet.Cells[row, "B"] = d.Time.ToString();
                    workSheet.Cells[row, "C"] = d.Value.ToString();
                }

                workSheet.SaveAs( string.Format(@"{0}\{1}.xlsx", filePathParam, fileNameParam) );

                excelApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString() );
            }
        }

        public override void Run(IView viewParam, IRepository<Sensor> sensorRepositoryParam, IRepository<Data> dataRepositoryParam)
        {
            View = viewParam;

            SensorRepository = sensorRepositoryParam;
            DataRepository = dataRepositoryParam;

            View.ShowDialog();
        }
    }
}
