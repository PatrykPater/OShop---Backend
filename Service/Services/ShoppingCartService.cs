using Data.Infrastructure;
using Service.Dto;
using Service.Exceptions;
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

        public ShoppingCartService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ShoppingCartDto> Add(ShoppingCartDto shoppingCartDto)
        {
            var shoppingCart = ShoppingCartMapper.ToShoppingCart(shoppingCartDto);

            var saveResult = await _unitOfWork.ShoppingCartRepository.Add(shoppingCart);
            await _unitOfWork.Save();

            var saveResultDto = ShoppingCartMapper.ToShoppingCartDto(saveResult);
            return saveResultDto;

        }

        public async Task<ShoppingCartDto> GetByID(int id)
        {
            var shoppingCart = await _unitOfWork.ShoppingCartRepository.GetByID(id);

            if (shoppingCart == null)
                throw new ShoppingCartNotFound();

            return ShoppingCartMapper.ToShoppingCartDto(shoppingCart);
        }

        public async Task<ShoppingCartDto> Update(ShoppingCartDto productDto, int id)
        {
            var shoppingCart = await _unitOfWork.ShoppingCartRepository.GetByID(id);
            ShoppingCartMapper.ToShoppingCart(productDto);


            var saveResult = await _unitOfWork.ShoppingCartRepository.Update(product);
            await _unitOfWork.Save();

            var saveResultDto = ProductMapper.ToProductDto(saveResult);
            return saveResultDto;
        }
    }
}
