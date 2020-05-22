using SDDataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFServiceTest.DEV1Service;
using WCFServiceTest.MathService;

namespace WCFServiceTest
{
    public partial class Form1 : Form
    {
        //private static string CONNECTION_STRING = "Provider=OraOLEDB.Oracle;Data Source=DAILY_STAT;user id=waldekd;password=waldekd123;PLSQLRSet=1;";//"Provider=MSDAORA;DataSource=\"(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=sccdrdb1p.dr.softcomputer.com)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=sd.dr.softcomputer.com)))\";UserID=waldekd;Password=waldekd123";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            //string s = DBWrapper.GetBurnDownData();
            DEV1ServiceClient client = new DEV1ServiceClient();
            ((BasicHttpBinding)client.Endpoint.Binding).MaxReceivedMessageSize = 200000000;
            string s = client.GetBurnDownData();
            client.Close();
        }
    }
}
