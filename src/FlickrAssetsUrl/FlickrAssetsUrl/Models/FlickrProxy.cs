using System;
using FlickrNet;
using System.Configuration;

namespace FlickrAssetsUrl.Models
{
    public static class FlickrProxy
    {
        public static AssetCollection SearchPhotos(string searchTerm, int pageSize = 20, int currentPage = 1)
        {
            var photos = CreateInstance().PhotosSearch(new PhotoSearchOptions
            {
                Text = searchTerm,
                PerPage = pageSize,
                Page = currentPage
            });

            var assetImages = new AssetCollection();

            foreach (var photo in photos)
            {
                assetImages.AssetImages.Add(new AssetImage
                {
                    Url = photo.LargeUrl,
                    ThumbUrl = photo.ThumbnailUrl,
                    Name = GetFileNameFromUrl(photo.LargeUrl),
                    Description = (photo.Title ?? photo.Description) ?? "No description.",
                    Category = "Flickr"
                });
            }

            assetImages.Categories.Add(new Category { Name = "Flickr", Parent = "" });

            return assetImages;
        }
        private static Flickr CreateInstance()
        {
            return new Flickr
            {
                ApiKey = ConfigurationManager.AppSettings["flickr:apikey"],
                ApiSecret = ConfigurationManager.AppSettings["flickr:secret"]
            };
        }

        private static string GetFileNameFromUrl(string url)
        {
            return url.Substring(url.LastIndexOf("/", StringComparison.Ordinal) + 1);
        }
    }
}