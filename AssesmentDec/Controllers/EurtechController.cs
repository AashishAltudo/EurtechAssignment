using AssesmentDec.Models;
using Sitecore.Mvc.Presentation;
using Sitecore.Publishing.Pipelines.Publish;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssesmentDec.Controllers
{
    public class EurtechController : Controller
    {
         //GET: Eurtech xyzjfhkdsjjflasf
        public ActionResult Index()
        {

            var model = new EurtechModel()
            {
                Item = RenderingContext.Current?.Rendering.Item
            };
            return View("/Views/Eurtech/index.cshtml", model);

        }

        public ActionResult ItSolution()
        {
            var model = new ItSolutionModel
            {

                Item = RenderingContext.Current?.Rendering.Item
            };
            return View("/Views/Eurtech/ItSolution.cshtml",model);
        }

        public ActionResult ServiceCompo()
        {
            var model = new ServiceModel
            {

                Item = RenderingContext.Current?.Rendering.Item
            };
            return View("/Views/Eurtech/ServiceCompo.cshtml", model);
        }

        public ActionResult Aboutus()
        {
            var model = new AboutusModel()
            {
                Item = RenderingContext.Current.Rendering.Item
            };
            return View("/Views/Eurtech/Aboutus.cshtml", model);
        }

        public ActionResult testimonials()
        {
            var model = new testimonialsModel()
            {
                Item = RenderingContext.Current.Rendering.Item
            };
            return View("/Views/Eurtech/testimonials.cshtml", model);
        }

        public ActionResult footer()
        {
            var model = new FooterModel()
            {
                Item = RenderingContext.Current.Rendering.Item
            };
            return View("/Views/Eurtech/footer.cshtml", model);
        }



    }
}