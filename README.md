# Flickr Asset URL

This is a sample application that will work as an [eDocBuilder](http://www.edocbuilder.com/) Assets URL that query photos from Flickr.

The URL returns a collection of images in the JSON format expected by the eDocBuilder Orders page.

```
{
  "assetImages": [
    {
      "url": "https://farm5.staticflickr.com/4352/36389367664_e4906320a3_b.jpg",
      "thumbUrl": "https://farm5.staticflickr.com/4352/36389367664_e4906320a3_t.jpg",
      "name": "36389367664_e4906320a3_b.jpg",
      "category": "Flickr",
      "description": "Pinnacle, Ben Lomond"
    },
    {
      "url": "https://farm5.staticflickr.com/4349/37036235636_39dae44b2b_b.jpg",
      "thumbUrl": "https://farm5.staticflickr.com/4349/37036235636_39dae44b2b_t.jpg",
      "name": "37036235636_39dae44b2b_b.jpg",
      "category": "Flickr",
      "description": "Valle del Asn"
    },
	(...)
  ],
  "categories": [
    {
      "name": "Flickr",
      "parent": ""
    }
  ]
}

```

You can try it using the following URL: http://flickr-assetsurl.azurewebsites.net/

The application will grab the last parameter and use it to query Flickr for photos, no mather what the key name is. For example, one could query for "oceans" using the following URL:

```
http://flickr-assetsurl.azurewebsites.net/?q=oceans
```

## Required Settings

Before running the application, you have to set your [Flickr API key](https://www.flickr.com/services/api/misc.api_keys.html).

```
  <appSettings>
    (...)
    <add key="flickr:apikey" value="ADD_APIKEY_HERE" />
    <add key="flickr:secret" value="ADD_SECRET_HERE" />
  </appSettings>
```
