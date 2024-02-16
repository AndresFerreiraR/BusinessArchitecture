using AutoMapper;
using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Application.Interface.Infraestructure;
using Pacagroup.Ecommerce.Application.Interface.Persistence;
using Pacagroup.Ecommerce.Application.Interface.UseCases;
using Pacagroup.Ecommerce.Application.Validator;
using Pacagroup.Ecommerce.Domain.Entities;
using Pacagroup.Ecommerce.Domain.Events;
using Pacagroup.Ecommerce.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Pacagroup.Ecommerce.Application.UseCases.Discounts
{
    public class DiscountApplication : IDiscountApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IEventBus _eventBus;
        private readonly DiscountDtoValidator _discountDtoValidator;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="mapper"></param>
        /// <param name="discountDtoValidator"></param>
        public DiscountApplication(IUnitOfWork unitOfWork,
                                   IMapper mapper,
                                   IEventBus eventBus,
                                   DiscountDtoValidator discountDtoValidator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _eventBus = eventBus;
            _discountDtoValidator = discountDtoValidator;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="discountDto"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<Response<bool>> CreateAsync(DiscountDto discountDto, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                var validation = await _discountDtoValidator.ValidateAsync(discountDto, cancellationToken);

                if(!validation.IsValid)
                {
                    response.Message = "Validation erros found";
                    response.Errors = validation.Errors;
                    return response;
                }

                var entidad = _mapper.Map<Discount>(discountDto);

                var result = await _unitOfWork.Discount.InsertAsync(entidad);

                response.Data = await _unitOfWork.Save(cancellationToken)>0;
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Successfully";
                    var discoutCreateEvent = _mapper.Map<DiscountCreatedEvent>(entidad);
                    _eventBus.Publish(discoutCreateEvent);
                }
                
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                throw;
            }
            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="discountDto"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<Response<bool>> UpdateAsync(DiscountDto discountDto, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                var validation = await _discountDtoValidator.ValidateAsync(discountDto, cancellationToken);

                if (!validation.IsValid)
                {
                    response.Message = "Validation erros found";
                    response.Errors = validation.Errors;
                    return response;
                }

                var entidad = _mapper.Map<Discount>(discountDto);

                var result = await _unitOfWork.Discount.UpdateAsync(entidad);

                response.Data = await _unitOfWork.Save(cancellationToken) > 0;
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "updated successfully";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                throw;
            }
            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<Response<bool>> DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            var response = new Response<bool>();
            try
            {
                await _unitOfWork.Discount.DeleteAsync(id.ToString());
                response.Data = await _unitOfWork.Save(cancellationToken) > 0;
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "entity deleted successfully";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                throw;
            }
            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Response<DiscountDto>> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var response = new Response<DiscountDto>();
            try
            {
                var discount = await _unitOfWork.Discount.GetAsync(id, cancellationToken);

                if(discount is null)
                {
                    response.IsSuccess = true;
                    response.Message = "Discount not found";
                    return response;
                }

                response.Data = _mapper.Map<DiscountDto>(discount);
                response.IsSuccess = true;
                response.Message = "";
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                throw;
            }

            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Response<List<DiscountDto>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var response = new Response<List<DiscountDto>>();
            try
            {
                var discount = await _unitOfWork.Discount.GetAllAsync(cancellationToken);

                if (discount is null)
                {
                    response.IsSuccess = true;
                    response.Message = "Discount not found";
                    return response;
                }

                response.Data = _mapper.Map<List<DiscountDto>>(discount);
                response.IsSuccess = true;
                response.Message = "";
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                throw;
            }

            return response;
        }

        
    }
}
