using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare_Plus
{
    internal class Resource
    {
        public string ResourceId { get; set; }

        public string TypeResource { get; set; }

        public string ResourceName { get; set; }

        public string Available { get; set; }

        public string Cost { get; set; }

        public string Location { get; set; }

        // create constructor

        public Resource(string ResourceId, string TypeResource, string ResourceName, string Available, string Cost, string Location)
        { 
            this.ResourceId = ResourceId;
            this.TypeResource = TypeResource;
            this.ResourceName = ResourceName;
            this.Available = Available;
            this.Cost = Cost;
            this.Location = Location;
        }

        public Resource()
        {
        }
    }
}
