﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberClaimsService.Models
{
    public class MemberVM
    {
        public int MemberID { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<ClaimVM> Claims { get; set; }
    }
}