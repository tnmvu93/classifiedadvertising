using System;
using System.Collections.Generic;
using System.Text;

namespace ClassifiedAdvertising.Data.Entities
{
    public class Advertising : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TypeAdvertisingId { get; set; }

        public TypeAdvertising TypeAdvertising { get; set; }
    }
}
