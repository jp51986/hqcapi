using Newtonsoft.Json;
using HQC.Common;
using HQC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HQC.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetProduct(string id)
        {
            var product = new Product() { Id = 1, Name = "哇哈哈", Count = 10, Price = 38.8 };
            ResultMsg resultMsg = null;
            resultMsg = new ResultMsg();
            resultMsg.StatusCode = (int)StatusCodeEnum.Success;
            resultMsg.Info = StatusCodeEnum.Success.GetEnumText();
            resultMsg.Data = product;
            return HttpResponseExtension.toJson(JsonConvert.SerializeObject(resultMsg));
        }


        [HttpPost]
        public HttpResponseMessage AddProudct(Product product)
        {
            ResultMsg resultMsg = null;
            resultMsg = new ResultMsg();
            resultMsg.StatusCode = (int)StatusCodeEnum.Success;
            resultMsg.Info = StatusCodeEnum.Success.GetEnumText();
            resultMsg.Data = product;
            return HttpResponseExtension.toJson(JsonConvert.SerializeObject(resultMsg));
        }
    }
}
