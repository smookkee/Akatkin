using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AkatkinDB
{
    public partial class Form1 : Form
    {
        DBConnect dbc;
        public Form1()
        {
            InitializeComponent();
            dbc = new DBConnect();
            textBox1.Text = "SELECT TOP (1000) [StateProvinceID],[CountryRegionCode],[Name],[TerritoryID],[rowguid],[ModifiedDate]FROM[TSOOPEX].[Person].[StateProvince]";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(textBox1.Text, dbc.conection);

            dbc.conection.Open();
            SqlDataAdapter SqlAdapter = new SqlDataAdapter(textBox1.Text, DBConnect.conSt);


            DataSet datSet = new DataSet();
            SqlAdapter.Fill(datSet);
            dataGridView1.DataSource = datSet.Tables[0];


            dbc.conection.Close();
        }
    }
}
