using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WebApplication1.Model
{

	[XmlRoot(ElementName = "FUEL")]
	public class FUEL
	{

		[XmlElement(ElementName = "PRICE_DATE")]
		public string PRICEDATE { get; set; }

		[XmlElement(ElementName = "PRODUCT")]
		public string PRODUCT { get; set; }

		[XmlElement(ElementName = "PRICE")]
		public double PRICE { get; set; }
	}

	[XmlRoot(ElementName = "PTTOR_DS")]
	public class PTTORDS
	{

		[XmlElement(ElementName = "FUEL")]
		public List<FUEL> FUEL { get; set; }
	}

}
