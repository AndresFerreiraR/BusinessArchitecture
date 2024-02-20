
namespace Pacagroup.Ecommerce.Application.UseCases.Customers
{
    using AutoMapper;
    using Pacagroup.Ecommerce.Application.DTO;
    using Pacagroup.Ecommerce.Application.Interface.Persistence;
    using Pacagroup.Ecommerce.Application.Interface.UseCases;
    using Pacagroup.Ecommerce.Domain.Entities;
    using Pacagroup.Ecommerce.Transversal.Common;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;


    public class CustomersApplication : ICustomersApplication
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private IAppLogger<CustomersApplication> _logger;

        public CustomersApplication(IUnitOfWork unitOfWork,
                                    IMapper mapper,
                                    IAppLogger<CustomersApplication> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        #region Métodos Sincronos


        public Response<bool> Insert(CustomerDto customersDto)
        {
            var response = new Response<bool>();

            var customer = _mapper.Map<Customer>(customersDto);
            response.Data = _unitOfWork.Customers.Insert(customer);

            if (response.Data)
            {
                response.IsSuccess = true;
                response.Message = "Registro Exitoso!!!";
            }

            return response;
        }


        public Response<bool> Update(CustomerDto customersDto)
        {
            var response = new Response<bool>();

            var customer = _mapper.Map<Customer>(customersDto);
            response.Data = _unitOfWork.Customers.Update(customer);

            if (response.Data)
            {
                response.IsSuccess = true;
                response.Message = "Actualizacion Exitosa!!!";
            }

            return response;
        }


        public Response<bool> Delete(string customerId)
        {
            var response = new Response<bool>();

            response.Data = _unitOfWork.Customers.Delete(customerId);

            if (response.Data)
            {
                response.IsSuccess = true;
                response.Message = "Eliminacion exitosa!!!";
            }

            return response;
        }


        public Response<CustomerDto> Get(string customerId)
        {
            var response = new Response<CustomerDto>();

            var customer = _unitOfWork.Customers.Get(customerId);
            response.Data = _mapper.Map<CustomerDto>(customer);

            if (response.Data != null)
            {
                response.IsSuccess = true;
                response.Message = "Registro consultado exitosamente";
            }

            return response;
        }


        public Response<IEnumerable<CustomerDto>> GetAll()
        {
            var response = new Response<IEnumerable<CustomerDto>>();

            var customers = _unitOfWork.Customers.GetAll();
            response.Data = _mapper.Map<IEnumerable<CustomerDto>>(customers);

            if (response.Data != null)
            {
                response.IsSuccess = true;
                response.Message = "Registros consultados exitosamente";
                _logger.LogInformation("Consuta Exitosa");
            }

            return response;
        }

        public ResponsePagination<IEnumerable<CustomerDto>> GetAllWithPagination(int pageNumber, int pageSize)
        {
            var response = new ResponsePagination<IEnumerable<CustomerDto>>();

            var count = _unitOfWork.Customers.Count();

            var customers = _unitOfWork.Customers.GetAllWithPagination(pageNumber, pageSize);

            response.Data = _mapper.Map<IEnumerable<CustomerDto>>(customers);

            if (response.Data != null)
            {
                response.PageNumber = pageNumber;
                response.TotalPages = (int)Math.Ceiling(count / (double)pageSize);
                response.TotalCount = count;
                response.IsSuccess = true;
                response.Message = "Consulta paginada exitosa";
            }

            return response;
        }

        #endregion

        #region Métodos Asíncronos


        public async Task<Response<bool>> InsertAsync(CustomerDto customersDto)
        {
            var response = new Response<bool>();
            var customer = _mapper.Map<Customer>(customersDto);
            response.Data = await _unitOfWork.Customers.InsertAsync(customer);

            if (response.Data)
            {
                response.IsSuccess = true;
                response.Message = "Registro Exitoso!!!";
            }

            return response;
        }


        public async Task<Response<bool>> UpdateAsync(CustomerDto customersDto)
        {
            var response = new Response<bool>();
            var customer = _mapper.Map<Customer>(customersDto);
            response.Data = await _unitOfWork.Customers.UpdateAsync(customer);

            if (response.Data)
            {
                response.IsSuccess = true;
                response.Message = "Actualizacion Exitosa!!!";
            }

            return response;
        }


        public async Task<Response<bool>> DeleteAsync(string customerId)
        {
            var response = new Response<bool>();

            response.Data = await _unitOfWork.Customers.DeleteAsync(customerId);

            if (response.Data)
            {
                response.IsSuccess = true;
                response.Message = "Eliminacion exitosa!!!";
            }

            return response;
        }


        public async Task<Response<CustomerDto>> GetAsync(string customerId)
        {
            var response = new Response<CustomerDto>();

            var customer = await _unitOfWork.Customers.GetAsync(customerId);
            response.Data = _mapper.Map<CustomerDto>(customer);

            if (response.Data != null)
            {
                response.IsSuccess = true;
                response.Message = "Registro consultado exitosamente";
            }

            return response;
        }


        public async Task<Response<IEnumerable<CustomerDto>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<CustomerDto>>();

            var customers = await _unitOfWork.Customers.GetAllAsync();
            response.Data = _mapper.Map<IEnumerable<CustomerDto>>(customers);

            if (response.Data != null)
            {
                response.IsSuccess = true;
                response.Message = "Registros consultados exitosamente";
            }

            return response;
        }

        public async Task<ResponsePagination<IEnumerable<CustomerDto>>> GetAllWithPaginationAsync(int pageNumber, int pageSize)
        {
            var response = new ResponsePagination<IEnumerable<CustomerDto>>();

            var count = await _unitOfWork.Customers.CountAsync();

            var customers = await _unitOfWork.Customers.GetAllWithPaginationAsync(pageNumber, pageSize);

            response.Data = _mapper.Map<IEnumerable<CustomerDto>>(customers);

            if (response.Data != null)
            {
                response.PageNumber = pageNumber;
                response.TotalPages = (int)Math.Ceiling(count / (double)pageSize);
                response.TotalCount = count;
                response.IsSuccess = true;
                response.Message = "Consulta paginada exitosa";
            }

            return response;
        }

        #endregion
    }
}
