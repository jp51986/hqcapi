using Newtonsoft.Json;
using HQC.Common;
using HQC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WHC.Framework.ControlUtil;
using HQCMVCWeb.DALSQL;
using HQCMVCWeb.Entity;

namespace HQC.Controllers
{
    public class HospitalController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetHospital(string id)
        {
            var data = BLLFactory<MedHospitalMgr>.Instance.FindByID("70adc6ee-68fc-413e-bfda-cc1c4a97859a");
            ResultMsg resultMsg = null;
            resultMsg = new ResultMsg();
            resultMsg.StatusCode = (int)StatusCodeEnum.Success;
            resultMsg.Info = StatusCodeEnum.Success.GetEnumText();
            resultMsg.Data = data;
            return HttpResponseExtension.toJson(JsonConvert.SerializeObject(resultMsg));
        }
        [HttpPost]
        public HttpResponseMessage AddHospital(MedHospitalMgrInfo info)
        {
            ResultMsg resultMsg = null;
            resultMsg = new ResultMsg();
            resultMsg.StatusCode = (int)StatusCodeEnum.Success;
            resultMsg.Info = StatusCodeEnum.Success.GetEnumText();
            resultMsg.Data = info;
            try
            {
                BLLFactory<MedHospitalMgr>.Instance.Insert(info);
            }
            catch (Exception ex)
            {
                resultMsg.StatusCode = (int)StatusCodeEnum.Error;
                resultMsg.Info = StatusCodeEnum.Error.GetEnumText();
                resultMsg.Data = ex.Message.ToString();
            }

            
            return HttpResponseExtension.toJson(JsonConvert.SerializeObject(resultMsg));
        }

	}
}