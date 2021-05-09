using ShopifyImageRepository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopifyImageRepository.IService
{
    public interface IImageService
    {
        ImageModel Save(ImageModel objImage, string hardCodedConnectionString = null);
        List<ImageModel> GetSavedImages(string hardCodedConnectionString = null);
    }
}
