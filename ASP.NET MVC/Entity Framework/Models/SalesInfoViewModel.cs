using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity_Framework.Models
{
    public class SalesInfoViewModel
    {
        public int TerritoryId { get; set; }
        public int BussinessEntityId { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
    }
}