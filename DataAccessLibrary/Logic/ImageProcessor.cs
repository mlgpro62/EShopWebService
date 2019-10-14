﻿using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Logic
{
    public static class  ImageProcessor
    {
        public static void AddProductImage(ImageModel image)
        {
            var sql = $"INSERT INTO dbo.ProductImage (ImagePath, ProductID) VALUES (@ImagePath, @ProductID);";

            DataAccess.DataAccess.SaveData<ImageModel>(sql, image);
        }

        public static List<ImageModel> GetProductImages(int productID)
        {
            var sql = $"select * from dbo.ProductImage where ProductID = {productID};";

            return DataAccess.DataAccess.LoadData<ImageModel>(sql);
        }
    }
}
