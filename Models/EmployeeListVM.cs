using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class EmployeeListVM
    {   
        /// <summary>
        /// Data that will be displayed on the page, that is what a view model is. 
        /// In this case, its name, datejoined and email
        /// </summary>
        public string Id { get; set; }

        [Display(Name = "First Name")]
        public string Firstname { get; set; }

        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        [Display(Name = "Date Joined")]
        public string DateJoined { get; set; }

        [Display(Name = "Email Address")]
        public string Email {get; set; }
    }
}
