using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

/* В данном классе выполняется подключение к базе данных,
 * создание DataSet и связка таблиц в созданном DataSet.*/

namespace WMS
{
    //TODO: entity framework
    class DoSome
    {
        private string connectionString = @"Data Source=KOLESO; Initial Catalog=GeneralDB; Integrated Security=true;";
        DataSet GenDataSet;
        SqlDataAdapter sensorsDA, valuesDA;

        public DoSome()
        {
            GenDataSet = new DataSet("GeneralData");

            sensorsDA = new SqlDataAdapter("SELECT * FROM Sensors ORDER BY [№]", connectionString);
            valuesDA = new SqlDataAdapter("SELECT * FROM SValues ORDER BY Дата, Время", connectionString);
        }

        public DataSet GetAllInfo()
        {
            try
            {
            sensorsDA.Fill(GenDataSet, "SensorsTable");
            valuesDA.Fill(GenDataSet, "ValuesTable");
            DataRelation generalDR = new DataRelation("SenVal", GenDataSet.Tables["SensorsTable"].Columns["ID"],
                                                                GenDataSet.Tables["ValuesTable"].Columns["SensorID"]);
            GenDataSet.Relations.Add(generalDR);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return GenDataSet;
        }
    }
}
