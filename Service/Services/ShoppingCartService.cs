using Data.Infrastructure;
using Service.Dto;
using Service.Exceptions;
using Service.Factories.Interfaces;
using Service.Mappers;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IShoppingCartFactory _shoppingCartFactory;

        public ShoppingCartService(IUnitOfWork unitOfWork, IShoppingCartFactory shoppingCartFactory)
        {
            _unitOfWork = unitOfWork;
            _shoppingCartFactory = shoppingCartFactory;
        }

        public async Task<ShoppingCartDto> Add(ShoppingCartDto shoppingCartDto)
        {
            var shoppingCart = ShoppingCartMapper.ToShoppingCart(shoppingCartDto);

            var saveResult = await _unitOfWork.ShoppingCartRepository.Add(shoppingCart);
            await _unitOfWork.Save();

            var saveResultDto = ShoppingCartMapper.ToShoppingCartDto(saveResult);
            await _shoppingCartFactory.PrepareShoppingCartDto(saveResultDto);

            return saveResultDto;

        }

        public async Task<ShoppingCartDto> GetByID(int id)
        {
            var shoppingCart = await _unitOfWork.ShoppingCartRepository.GetByID(id);

            if (shoppingCart == null)
                throw new ShoppingCartNotFound();

            var shoppingCartDto = ShoppingCartMapper.ToShoppingCartDto(shoppingCart);
            await _shoppingCartFactory.PrepareShoppingCartDto(shoppingCartDto);

            return shoppingCartDto;
        }

        public async Task<ShoppingCartDto> Update(ShoppingCartDto shoppingCartDto, int id)
        {
            var shoppingCart = await _unitOfWork.ShoppingCartRepository.GetByID(id);
            shoppingCart.ToShoppingCart(shoppingCartDto);


            var saveResult = _unitOfWork.ShoppingCartRepository.Update(shoppingCart);
            await _unitOfWork.Save();

            var saveResultDto = ShoppingCartMapper.ToShoppingCartDto(saveResult);
            await _shoppingCartFactory.PrepareShoppingCartDto(saveResultDto);

            return saveResultDto;
        }
    }
}
