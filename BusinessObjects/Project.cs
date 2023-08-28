using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Project
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EstimatedStartDate { get; set; }
        public DateTime EstimatedEndDate { get; set; }
        public string Contact { get; set; }
        public double EstimatedValue { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Sponsor { get; set; }
    }
}
