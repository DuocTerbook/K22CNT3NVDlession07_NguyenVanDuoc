using Nvd_lession07.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nvd_lession07.Controllers
{
    public class NvdCategoriesController : Controller
    {
        // GET: NvdCategories
        public ActionResult NvdIndex()
        {
            NvdBookStore _db = new NvdBookStore();
            var listCate = _db.NvdCategories.ToList();
            return View(listCate);
        }
    }
}