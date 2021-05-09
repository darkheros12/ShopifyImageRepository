using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopifyImageRepository.Data;
using ShopifyImageRepository.IService;
using ShopifyImageRepository.Service;
using System.Data.SqlClient;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class TestImageService
    {
        private string connectionString = "Data Source=shopifyimagedb.database.windows.net;Initial Catalog=ShopifyImageDB;Persist Security Info=True;User ID=darkheros12;Password=A1b2c3d4e5f6";

        [TestMethod]
        public void TestGetSavedImages()
        {
            // Arrange
            ImageModel image = new ImageModel();
            IImageService imageService = new ImageService();

            // Act
            var imageList = imageService.GetSavedImages(connectionString);

            // Assert
            Assert.IsTrue(imageList.Count() > 0);
        }

        [TestMethod]
        public void TestSave()
        {
            // Arrange
            ImageModel image = new ImageModel();
            IImageService imageService = new ImageService();

            // Act
            var imageList = imageService.Save(image, connectionString);

            // Assert
            Assert.IsTrue(imageList.Count() > 0);
        }

    }
}
