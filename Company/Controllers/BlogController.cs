using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Company.BusinessLayer.Concrete;
using Company.DataAccessLayer.Concrete;
using Company.EntityLayer.Concrete;
using Company.Models;

namespace Company.Controllers
{
    public class BlogController : Controller
    {
        private BlogManager blog = new BlogManager();
        private CommentManager comment = new CommentManager(new EfCommentDal());
        private CategoryManager category = new CategoryManager();
        private TagManager tag = new TagManager();
        private BlogComment bc = new BlogComment();
        // GET: Blog
        public ActionResult Index()
        {
            var list = blog.GetList().OrderByDescending(x => x.Id).Take(4);
            return View(list);
        }

        public ActionResult Detail(string link, int? Id)
        {
            //1. Yöntem
            //bc.Blog = (from x in blog.GetList()
            //              where Company.Utils.Url.UrlCevir(x.Title).ToLower() == link
            //              select new Blog
            //              {
            //                  Id = x.Id,
            //                  EmployeeId = x.EmployeeId,
            //                  CategoryId = x.CategoryId,
            //                  Title = x.Title,
            //                  Contents = x.Contents,
            //                  Image = x.Image,
            //                  CreDate = x.CreDate
            //              }).FirstOrDefault();

            //2. Yöntem
            bc.Blog = blog.GetList().FirstOrDefault(x => Utils.Url.UrlCevir(x.Title) == link || x.Id == Id);

            if (bc.Blog != null)
            {
                int id = bc.Blog.Id;
                TempData["ıd"] = id;
                var blg = blog.GetById(id);
                ViewBag.FullName = blg.Employee.FullName;
                bc.CommentList = comment.GetById(id);
            }

            return View(bc);
        }

        [HttpPost]
        public ActionResult Detail(BlogComment p)
        {
            int id = (int)TempData["ıd"];
            p.Comment.BlogId = id;
            p.Comment.CreDate = DateTime.Now;
            comment.Add(p.Comment);
            return RedirectToAction("Detail", "Blog", new { id = id });
        }

        [HttpGet]
        public ActionResult Comment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Comment(Comment comment)
        {
            return View();
        }

        public PartialViewResult RecentPost()
        {
            var recent = blog.GetList().OrderByDescending(x => x.Id).Take(4);
            return PartialView(recent);
        }

        public PartialViewResult Category()
        {
            var categories = category.GetList();
            return PartialView(categories);
        }

        public PartialViewResult Archive()
        {
            var archive = blog.GetList().OrderByDescending(x => x.CreDate).ToList();
            return PartialView(archive);
        }

        public PartialViewResult Tag()
        {
            var tags = tag.GetList();
            return PartialView(tags);
        }
    }
}