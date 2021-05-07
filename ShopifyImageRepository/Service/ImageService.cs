﻿using Dapper;
using ShopifyImageRepository.Data;
using ShopifyImageRepository.IService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ShopifyImageRepository.Service
{
    public class ImageService : IImageService
    {
        ImageModel _objImage = new ImageModel();
        public ImageModel GetSavedImage()
        {
            _objImage = new ImageModel();
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                var objImages = connection.Query<ImageModel>("SELECT * FROM Images").ToList();

                if(objImages != null && objImages.Count() > 0)
                {
                    _objImage = objImages.First();
                }

                return _objImage;
            }
        }

        public ImageModel Save(ImageModel objImage)
        {
            _objImage = new ImageModel();
            using (IDbConnection connection = new SqlConnection(Global.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                var objImages = connection.Query<ImageModel>("SP_Images", 
                    this.SetParameters(objImage), 
                    commandType: CommandType.StoredProcedure);

                if (objImages != null && objImages.Count() > 0)
                {
                    _objImage = objImages.First();
                }

                return _objImage;
            }
        }

        private DynamicParameters SetParameters(ImageModel objImage)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@ImageId", objImage.ImageId);
            parameters.Add("@ImageName", objImage.ImageName); 
            parameters.Add("@Image", objImage.Image);

            return parameters;
        }
    }
}
