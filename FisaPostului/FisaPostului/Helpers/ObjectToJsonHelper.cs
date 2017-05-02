using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace FisaPostului.Helpers
{
    public class ObjectToJsonHelper
    {
        public String ToJson(object obj)
        {
            var json = new JavaScriptSerializer().Serialize(obj);
            return json.ToString();
        }
    }
}