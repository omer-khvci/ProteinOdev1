using Base.BaseModel;
namespace Data.Model
{
    public class Department:BaseModel
    {
        public string DeptName { get; set; }
        public int CountryId { get; set; }
        public int EmployeeId { get; set; }

    }
}
