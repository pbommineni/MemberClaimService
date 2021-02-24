using MemberClaimsService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MemberClaimsService.Controllers
{
    public class MemberClaimsController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();

        [HttpGet]
        // GET: api/memberclaims/?date=2020-11-11T00:00:00
        public IHttpActionResult GetMemberClaimsByDate(DateTime date)
        {
            var results = from m in db.Members
                          from c in m.Claims
                          //join c in db.Claims on m.MemberID equals c.MemberID 
                          where c.ClaimDate <= date
                          select new MemberVM
                          {
                              MemberID = m.MemberID,
                              EnrollmentDate = m.EnrollmentDate,
                              FirstName = m.FirstName,
                              LastName = m.LastName ,
                              Claims = (from cc in m.Claims
                                        select new ClaimVM
                                        {
                                            ClaimID = cc.ClaimID,
                                            MemberID = cc.MemberID,
                                            ClaimDate=cc.ClaimDate,
                                            ClaimAmount = cc.ClaimAmount
                                        }).ToList()
                          };
           
            return Ok(results);
        }
    }
}
