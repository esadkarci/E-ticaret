﻿using MultiShop.Cargo.DataAcsessLayer.Abstract;
using MultiShop.Cargo.DataAcsessLayer.Concrete;
using MultiShop.Cargo.DataAcsessLayer.Repositories;
using MultiShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.DataAcsessLayer.EntityFramework
{
    public class EfCargoCompanyDal : GenericRepository<CargoCompany>, ICargoCompanyDal
    {
        public EfCargoCompanyDal(CargoContext context) : base(context)
        {

        }
    }
}