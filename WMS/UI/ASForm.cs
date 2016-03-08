using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WMS
{
    public partial class ASForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=KOLESO; Initial Catalog=GeneralDB; Integrated Security=true");
        public ASForm()
        {
            InitializeComponent();
        }

        private void btnAddSens_Click(object sender, EventArgs e)
        {           
            SqlCommand checkcount = new SqlCommand("SELECT COUNT(*)+1 FROM Sensors",con);
            object count = checkcount.ExecuteScalar();
            Convert.ToInt16(count);
            double LNG, LAT;
            string name = txtbxAddName.Text;
            string type = txtbxAddType.Text;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            LNG = Convert.ToDouble(txtbxLNG.Text);
            LAT = Convert.ToDouble(txtbxLAT.Text);
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Sensors([№], [Название], [Тип], [LNG], [LAT]) VALUES ('"+ count +"','"+ name +"','"+ type +"','"+ LNG +"','"+ LAT +"')", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Датчик добавлен!");
        }

        private void ASForm_Load(object sender, EventArgs e)
        {
            con.Open();
        }
    }
}
