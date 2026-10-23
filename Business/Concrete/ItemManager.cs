using Business.Abstract;
using Business.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.concrete;
using FluentValidation.Results;
using System;
using System.Text;

namespace Business.Concrete
{
    public class ItemManager : GenericManager<item,ItemValidation>,IItemService
    {
        private readonly IItemRepository _itemRepository;
        public ItemManager(IItemRepository itemRepository) : base(itemRepository, new ItemValidation())
        {
            _itemRepository = itemRepository;
        }

        public void TDeleteItemWithLineAndStock(int ItemId)
        {
            _itemRepository.DeleteItemWithLineAndStock(ItemId);
        }
    }
}
