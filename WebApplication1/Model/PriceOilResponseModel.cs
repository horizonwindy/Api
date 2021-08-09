using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class PriceOilResponseModel
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public bool IsNotify { get; set; }
        public bool IsChange { get; set; }
        public string ChangeDate { get; set; }
        public string ChangeTime { get; set; }
        public List<PriceList> ListOfPrice { get; set; }
    }
    public class PriceList
    {
        public string MAT_Name { get; set; }
        public int DIVISION_ID { get; set; }
        public string DIVISION_NAME { get; set; }
        public string MAT_NAME2 { get; set; }
        public int TYPE_NAME { get; set; }
        public string MAT_ID { get; set; }
        public double PRICE0 { get; set; }
    }
}
