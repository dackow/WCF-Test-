using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceTest
{
    [ServiceContract]
    public interface IDEV1SDService
    {
        [OperationContract]
        string BurnDownData();
    }
}
