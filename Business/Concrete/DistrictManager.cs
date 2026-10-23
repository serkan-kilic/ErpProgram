using Business.Abstract;
using Business.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DistrictManager : GenericManager<district,DistrictValidation>,IDistrictService
    {
        public DistrictManager(IDistrictRepository districtRepository) : base(districtRepository,new DistrictValidation())
        {
            
        }
    }
}
