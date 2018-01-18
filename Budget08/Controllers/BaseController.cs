using Budget08.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Budget08.Controllers
{
    //add base controller
    public class BaseController : Controller
    {
        public dynamic getUserIdByEmail(string email)
        {
            using (var context = new yeloBizEntities())
            {
                var q = from bgUser in context.BgUsers
                        where bgUser.email == email
                        select bgUser;

                var userId = (q.Count() == 1) ? q.ToList().ElementAt(0).id : -1;
                System.Diagnostics.Debug.WriteLine("ViewBag.currentUserId=" + userId);
                return userId;
            }
        }
    }
}