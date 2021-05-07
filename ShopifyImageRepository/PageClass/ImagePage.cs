using ShopifyImageRepository.Data;
using ShopifyImageRepository.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopifyImageRepository.PageClass
{
    public class ImagePage
    {
        IImageService _imageService = null;
        public ImagePage(IImageService imageService)
        {
            _imageService = imageService;
        }

        public string SaveImageInformations(byte[] fileBytes, ImageModel objImage)
        {
            objImage.Image = fileBytes;
            objImage = _imageService.Save(objImage);
            if(objImage.ImageId > 0)
            {
                return "Saved";
            }

            return "Failed";
        }

        public ImageModel GetSavedImage()
        {
            var image = _imageService.GetSavedImage();
            image.Image = this.GetImage(Convert.ToBase64String(image.Image));
            image.ImageUrl = string.Format("data:image/jpg;base64," + Convert.ToBase64String(image.Image));
            return image;
        }

        public byte[] GetImage(string base64String)
        {
            byte[] bytes = null;
            if (!String.IsNullOrEmpty(base64String))
            {
                bytes = Convert.FromBase64String(base64String);
            }
            return bytes;
        }
    }
}
