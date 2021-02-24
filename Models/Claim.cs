using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MemberClaimsService.Models
{
    public class Claim
    {   
        [Key]
        public int ClaimID { get; set; }

        [ForeignKey("Member")]
        public int MemberID { get; set; }
        public DateTime ClaimDate { get; set; }
        public float ClaimAmount { get; set; }

        public Member Member { get; set; }
    }
}