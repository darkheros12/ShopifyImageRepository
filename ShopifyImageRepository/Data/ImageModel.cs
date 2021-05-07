using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopifyImageRepository.Data
{
    public class ImageModel
    {
        public int ImageId { get; set; }
        public string ImageName { get; set; }
        public byte[] Image { get; set; }
        public string ImageUrl { get; set; }
    }
}
