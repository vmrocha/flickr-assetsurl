using System.Collections.Generic;

namespace FlickrAssetsUrl.Models
{
    public class AssetCollection
    {
        public AssetCollection()
        {
            AssetImages = new List<AssetImage>();
            Categories = new List<Category>();
        }

        public List<AssetImage> AssetImages { get; set; }

        public List<Category> Categories { get; set; }
    }
}