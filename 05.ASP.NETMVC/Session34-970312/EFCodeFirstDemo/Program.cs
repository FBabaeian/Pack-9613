﻿using EFCodeFirstDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopModel ctx = new ShopModel();
            var photo = ctx.ProductPhotos.Find(1);
            //photo.Product.Id

        }
    }
}
