using Base.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Folder:BaseModel
    {
        public string EmpId { get; set; }
        public string AccessType { get; set; }
    }
}
