using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Serialization;

namespace this_is_for_xml_testing
{
	[Serializable]
	public class burgers
    {
        public string Name { get; set; }
        public string Weight { get; set; }
        public string Price { get; set; }

    }
}
