using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Feature.NexaWeb.Models;
using Sitecore.Mvc.Presentation;
using Sitecore.Resources.Media;
using Sitecore.Web.UI.WebControls;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Sitecore.Feature.NexaWeb.Controllers
{
    public class EBookingController : Controller
    {

        // GET: EBooking
        public ActionResult Index()
        {
            Sitecore.Data.Database master = Sitecore.Configuration.Factory.GetDatabase("master");

            Sitecore.Data.Items.Item home = master.GetItem("/sitecore/content/AllSites/NexaWeb/Data/NexaWebCarModel");
            //Sitecore.Context.Database
            var model = new NexaCarModel();

            List<CarDetails> carDetails = new List<CarDetails>();
            
            List<Item> childItem = new List<Item>();

            IMvcContext mvcContext = new MvcContext();
            var model1 = mvcContext.GetContextItem<NexaCarModel>();
          
            foreach (Item item in home.Children)
            {
                childItem.Add(item);
             }

           
            foreach(var item in childItem)
            {
                //if (item.Fields["CarModelCode"].Value == "B")
                //{
                    //Sitecore.Data.Fields.ImageField imgField = ((Sitecore.Data.Fields.ImageField)item.Fields["CarImage"]);
                    //var CarImageUrl = Sitecore.Resources.Media.MediaManager.GetMediaUrl(imgField.MediaItem);

                    //Sitecore.Data.Fields.ImageField LogoImgField = ((Sitecore.Data.Fields.ImageField)item.Fields["CarLogoImage"]);
                    //var CarLogoUrl = Sitecore.Resources.Media.MediaManager.GetMediaUrl(LogoImgField.MediaItem);
                    
                    var CarImage = new MvcHtmlString(FieldRenderer.Render(item, "CarImage"));
                    var CarLogoImage = new MvcHtmlString(FieldRenderer.Render(item, "CarLogoImage"));
                    var CarModelName = item.Fields["CarModelName"].Value;
                    var CarModelCode = item.Fields["CarModelCode"].Value;

                    carDetails.Add(new CarDetails
                    {
                        CarImage = CarImage,
                        CarLogoImage = CarLogoImage,
                        CarModelCode = CarModelCode,
                        CarModelName = CarModelName
                    });
                    model.NexaCars = carDetails;
                    //model.CarImage = CarImageUrl;
                    //model.CarModelCode = item.Fields["CarModelCode"].Value;
                    //model.CarLogoImage = CarLogoUrl;
                    //model.CarModelName = item.Fields["CarModelName"].Value;
                //}
            }
            return View(model);
        }
    }
}
