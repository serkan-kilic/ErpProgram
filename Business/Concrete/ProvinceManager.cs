using Business.Abstract;
using Business.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProvinceManager : GenericManager<province,ProvinceValidation>,IProvinceService
    {
        public ProvinceManager(IProvinceRepository provinceRepository) : base(provinceRepository, new ProvinceValidation())
        {
            
        }
    }
}
