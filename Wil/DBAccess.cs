using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Collections;
using System.IO;

//string strPath = "Data Source = CLIVE-PC\\SQLEXPRESS; Initial Catalog = myFriendsSQL; Integrated Security = SSPI";
//string strPath = "DSN=myODBCDatabase"; 

namespace Wil
{
    class DBAccess
    {

        public DBAccess()
        {
            ReadArrayFromFile();
        }

        public DataTable dataTbl = new DataTable();
        public DataTable dataTblAlt = new DataTable();
        public BindingSource bndSrc = new BindingSource();
        public BindingSource bndSrcAlt = new BindingSource();

        ArrayList arrlstOutput = new ArrayList();

        public string strPath = "";

        public void ReadArrayFromFile()
        {
            try
            {
                StreamReader reader = new StreamReader(@"config.txt");

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                     arrlstOutput.Add(line); // Add to list.
                }

                reader.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Config file not found.");
                Application.Exit();
            }
        }

        public void Do_SQLQuery(string strSQL) //, string strPath)
        {
            strPath = "Data Source = " + arrlstOutput[0] + "; Initial Catalog = OmegaFleetTracker; Integrated Security = SSPI";

            SqlDataAdapter myDBAdapter = new SqlDataAdapter(strSQL, strPath); // SQL Database

            bndSrc.DataSource = dataTbl;

            try
            {
                dataTbl.Clear();
                myDBAdapter.Fill(dataTbl);
                myDBAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Database Error");
            }

        } // Do_SQLQuery
        
        public void Do_SQLQueryAlt(string strSQL)
        {
            strPath = "Data Source = " + arrlstOutput[0] + "; Initial Catalog = OmegaFleetTracker; Integrated Security = SSPI";

            SqlDataAdapter myDBAdapter = new SqlDataAdapter(strSQL, strPath); // SQL Database

            bndSrcAlt.DataSource = dataTblAlt;

            try
            {
                dataTblAlt.Clear();
                myDBAdapter.Fill(dataTblAlt);
                myDBAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Database Error");
            }

        } // Do_SQLQuery
    }
}
