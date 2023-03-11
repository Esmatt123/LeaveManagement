using AutoMapper;
using LeaveManagement.Web.Models;
using LeaveManagement.Web.Data;
namespace LeaveManagement.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap(); //This states that it is legal to convert from leavetype to leavetypevm and reverse
        }
    }
}
