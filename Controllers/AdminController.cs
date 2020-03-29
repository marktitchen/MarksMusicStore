using MarksMusicStore.DAL;
using MarksMusicStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarksMusicStore.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
        public ActionResult Dashboard()
        {
            return View();
        }


        public ActionResult Categories()
        {
            List<Tbl_Category> allcategories = _unitOfWork.GetRepositoryInstance<Tbl_Category>().GetAllRecordsIQueryable().Where(i => i.IsDelete == false).ToList();
            return View(allcategories);
        }
    }
}

