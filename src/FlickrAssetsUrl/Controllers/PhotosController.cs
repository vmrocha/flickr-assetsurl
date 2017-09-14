using FlickrAssetsUrl.Models;
using System.Web.Mvc;

namespace FlickrAssetsUrl.Controllers
{
    public class PhotosController : BaseController
    {
        private string GetSearchTerm()
        {
            var searchTerm =
                Request.QueryString.Count == 0 ? "" :
                Request.QueryString[Request.QueryString.Count - 1];

            if (searchTerm == "")
                searchTerm = "Mountain";

            return searchTerm;
        }

        public ActionResult Index()
        {
            return JsonCamelCase(FlickrProxy.SearchPhotos(GetSearchTerm()));
        }
    }
}