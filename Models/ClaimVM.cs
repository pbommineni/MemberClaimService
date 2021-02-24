using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberClaimsService.Models
{
    public class ClaimVM
    {
        public int ClaimID { get; set; }
        public int MemberID { get; set; }
        public DateTime ClaimDate { get; set; }
        public float ClaimAmount { get; set; }
    }
}