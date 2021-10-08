using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var lstArticle = new List<Article>
            {
                new Article(1,"Top 3 JavaScript Frameworks","Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient.","blog-post-thumb-card-1.jpg"),
                new Article(2,"About Remote Working","Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient.","blog-post-thumb-card-2.jpg"),
                new Article(3,"A Guide to Becoming a Full-Stack Developer","Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient.","blog-post-thumb-card-3.jpg"),
            };
            return View("_Articles", lstArticle);
        }
    }
}
