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
        private static NvdBookStore nvdDb;
        public NvdCategoriesController()
        {
            nvdDb = new NvdBookStore();
        }
        // GET: NvdCategories
        public ActionResult NvdIndex()
        {
            /*
             * Khởi tạo DbContext
             * EF sẽ tìm thông tin kết nối trong file machinee.config của .NET Framework trên máy
             * và sau đó tạo csdl
             * */
            NvdBookStore nvdDb = new NvdBookStore();
            var nvdCategories = nvdDb.NvdCategories.ToList();
            return View(nvdCategories);
        }
        public ActionResult NvdCreate()
        {
            var nvdCategories = new NvdCategory();
            return View(nvdCategories);
        }
        [HttpPost]
        public ActionResult NvdCreate(NvdCategory nvdCategory)
        {
            nvdDb.NvdCategories.Add(nvdCategory);
            nvdDb.SaveChanges();
            return RedirectToAction("NvdIndex");
        }
    }
}