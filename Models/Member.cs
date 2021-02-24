using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MemberClaimsService.Models
{
    public class Member
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberID { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Claim> Claims { get; set; }

    }
}