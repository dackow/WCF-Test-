using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using Newtonsoft.Json;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IDEV1Service
{
	static string s = @"<NewDataSet></NewDataSet>";
	public string GetBurnDownData()
	{
        //string s = SDDataBase.DBWrapper.GetBurnDownData();
        //return  JsonConvert.SerializeObject(s);
        return s+s+s+s+s+s;
	}
}
