using Client.Common;
using Client.Entity;
using HQC.Models;
using HQCMVCWeb.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Method
{
    public class All
    {
        public string Get(string url, Dictionary<string, string> parames)
        {
            int staffId = int.Parse(AppSettingsConfig.StaffId);
            var tokenResult = WebApiHelper.GetSignToken(staffId);
            Tuple<string, string> parameters = WebApiHelper.GetQueryString(parames);
            var data = WebApiHelper.Get<HospitalMsg>(url, parameters.Item1, parameters.Item2, staffId);
           return  JsonConvert.SerializeObject(data);
        }

        public string Post(string url,object dt)
        {
            int staffId = int.Parse(AppSettingsConfig.StaffId);
            var tokenResult = WebApiHelper.GetSignToken(staffId);
            var newdt = Json.ToObject<MedHospitalMgrInfo>(Json.ToJson(dt));
            MedHospitalMgrInfo info = new MedHospitalMgrInfo() { ID = newdt.ID, HospitalName = newdt.HospitalName };
   

            var data = WebApiHelper.Post<HospitalMsg>(url, JsonConvert.SerializeObject(info), staffId);
            return JsonConvert.SerializeObject(data);
        }

    }
}
