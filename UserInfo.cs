using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UserInfo
    {
        [Key]
        [MaxLength(50, ErrorMessage = "The text entered exceeds the maximum length of 50")]
        public string UserID { get; set; }
        [MaxLength(25, ErrorMessage = "The text entered exceeds the maximum length of 25")]
        public string EmpID { get; set; }
        [MaxLength(100, ErrorMessage = "The text entered exceeds the maximum length of 100")]
        public string EmpName { get; set; }
        public long EmpRecID { get; set; }
        public bool Active { get; set; }
        [MaxLength(50, ErrorMessage = "The text entered exceeds the maximum length of 50")]
        public string ADAccount { get; set; }
        [MaxLength(255, ErrorMessage = "The text entered exceeds the maximum length of 255")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }
        [MaxLength(10, ErrorMessage = "The text entered exceeds the maximum length of 10")]
        public string Region { get; set; }
        [MaxLength(4, ErrorMessage = "The text entered exceeds the maximum length of 4")]
        public string LegalEntity { get; set; }
        public string AuthenticationType { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsSrManagement { get; set; }
        public bool IsGlobalHR { get; set; }
        public bool IsBUHead { get; set; }
        public bool IsRegionalHR { get; set; }
        public bool IsRegionalHRHead { get; set; }
        public bool IsDepartmentHead { get; set; }
        public bool IsReportingManager { get; set; }
        public bool OBBUHead { get; set; }
        public bool OBDepHead { get; set; }
        public bool OBLeave { get; set; }
        public bool CanDelegateApproval { get; set; }
        [MaxLength(60, ErrorMessage = "The text entered exceeds the maximum length of 60")]
        public string CreatedBy { set; get; }
        public DateTime? CreatedDate { get; set; }
        [MaxLength(60, ErrorMessage = "The text entered exceeds the maximum length of 60")]
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}