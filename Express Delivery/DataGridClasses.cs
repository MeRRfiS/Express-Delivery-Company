using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Express_Delivery
{
    class BoxTable
    {
        public BoxTable(int Id, float Weight, string Fragality, string ReturnDoc, string Package, string Delivery, string DateStorage, string DateReceiving)
        {
            this.Id = Id;
            this.Weight = Weight;
            this.Fragality = Fragality;
            this.ReturnDoc = ReturnDoc;
            this.Package = Package;
            this.Delivery = Delivery;
            this.DateStorage = DateStorage;
            this.DateReceiving = DateReceiving;
        }
        public int Id { get; set; }
        public float Weight { get; set; }
        public string Fragality { get; set; }
        public string ReturnDoc { get; set; }
        public string Package { get; set; }
        public string Delivery { get; set; }
        public string DateStorage { get; set; }
        public string DateReceiving { get; set; }
    }

    class OrderInformation
    {
        public OrderInformation(string Name, string Information)
        {
            this.Name = Name;
            this.Information = Information;
        }
        public string Name { get; set; }
        public string Information { get; set; }
    }
}
