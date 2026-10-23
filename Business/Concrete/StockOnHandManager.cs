using Business.Abstract;
using Business.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class StockOnHandManager : GenericManager<stockonhand,StockValidation>,IStockOnHandService
    {
        private readonly IStockOnHandRepository _stockOnHandRepository;
        public StockOnHandManager(IStockOnHandRepository stockOnHandRepository) : base(stockOnHandRepository, new StockValidation(stockOnHandRepository))
        {
            _stockOnHandRepository = stockOnHandRepository;
        }

        public void TDeleteStockWithOrderStockReservation(int stockId)
        {
            _stockOnHandRepository.DeleteStockWithOrderStockReservation(stockId);
        }
    }
}
