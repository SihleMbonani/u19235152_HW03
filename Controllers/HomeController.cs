using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u19235152_HW03.Models;
using System.IO;

namespace u19235152_HW03.Controllers
{
    public class HomeController : Controller
    {
        //GET METHOD
        [HttpGet]
        public ActionResult Index()
        {
            
            return View();
        }

        /// <summary>
        /// POST METHOD
        /// </summary>
       
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file, FormCollection radFileColl)
        {
            //formCollection takes all the radio items in the form and will grouo them together in value called radFileColl
            //we need to find the "radiob" and that value will be read

            string value = Convert.ToString(radFileColl["radiob"]);
            return RedirectToAction("Index");
        }

        public ActionResult Files()
        {
            //List to get all files
            List<FileModel> files = new List<FileModel>();
            //read from all the different folders
            string[] DocPath = Directory.GetFiles(Server.MapPath("~/Content/Media/Documents"));
            string[] ImgPath = Directory.GetFiles(Server.MapPath("~/Content/Media/Documents"));
            string[] VidPath = Directory.GetFiles(Server.MapPath("~/Content/Media/Documents"));

            foreach (string dfile in DocPath)
            {
                files.Add(new FileModel { FileName = Path.GetFileName(dfile) });
            }

            foreach (string imgfile in ImgPath)
            {
                files.Add(new FileModel { FileName = Path.GetFileName(imgfile) });
            }

            foreach (string vidfile in VidPath)
            {
                files.Add(new FileModel { FileName = Path.GetFileName(vidfile) });
            }

            return View(files);
        }

        public ActionResult Images()
        {
            

            return View();
        }

        public ActionResult Videos()
        {
            

            return View();
        }

        public ActionResult AboutMe()
        {
            

            return View();
        }
    }
}