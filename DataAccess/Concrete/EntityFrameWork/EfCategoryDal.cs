﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCategoryDal :EFEntityRepositoryBase<UdMyDbContext,Category>,ICategoryDal
    {
    }
}