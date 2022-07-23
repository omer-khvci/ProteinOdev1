using Base.BaseModel;
using System.Collections.Generic;

namespace Data.Model
{
    public class Country:BaseModel
    {
        public string CountryName { get; set; }
        public string Continent { get; set; }
        public string Currency { get; set; }
        public List<Department> Departments { get; set; }
    }
}
