using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OilPrice;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WebApplication1.Model;
using static OilPrice.OilPriceSoapClient;

namespace WebApplication1.Controllers
{
    [Route("api/")]
    [ApiController]
    public class OilController : ControllerBase
    {
        private readonly ILogger<OilController> _logger;
        public OilController(ILogger<OilController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Get Information From Service
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetListOfPriceData")]
        public async Task<IActionResult> GetListOfPriceData()
        {
            var result = new PriceOilResponseModel();
            try
            {
                var client = new OilPriceSoapClient(EndpointConfiguration.OilPriceSoap);
                var data = await client.CurrentOilPriceAsync("TH");
                var prices = data.Body.CurrentOilPriceResult;
                XmlSerializer serializer = new XmlSerializer(typeof(PTTORDS));
                using (StringReader reader = new StringReader(prices))
                {
                    var pricelist = (PTTORDS)serializer.Deserialize(reader);
                    DateTime Now = DateTime.Now;
                    result.Code = (int)ECode.Success;
                    result.Description = $"วันที่ {Now.ToString("dd MMMM yyyy",new CultureInfo("th-TH"))} เวลา { Now.ToString("HH:mm")} น.";
                    result.ChangeDate = Now.ToString("dd/M/yyyy", new CultureInfo("th-TH"));
                    result.ChangeTime = Now.ToString("HH:mm");
                    result.ListOfPrice = new List<PriceList>();
                    foreach(var subprice in pricelist.FUEL)
                    {
                        result.ListOfPrice.Add(new PriceList()
                        {
                            MAT_Name = subprice.PRODUCT,
                            PRICE0 = subprice.PRICE
                        });
                    }
                    return Ok(result);
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                result.Code = (int)ECode.Error;
                return BadRequest(result);
            }
        }
    }
}
