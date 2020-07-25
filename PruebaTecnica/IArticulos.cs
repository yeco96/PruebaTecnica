﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PruebaTecnica
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.

    public interface IArticulos
    {

        [OperationContract]
        void ObtenerArticulos();

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.

    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";


        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }


        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
