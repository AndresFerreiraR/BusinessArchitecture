namespace Pacagroup.Ecommerce.Domain.Core
{
    using Pacagroup.Ecommerce.Domain.Entity;
    using Pacagroup.Ecommerce.Domain.Interface;
    using Pacagroup.Ecommerce.Infraestructura.Interface;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;


    public class CategoriesDomain : ICategoriesDomain
    {

        private readonly IUnitOfWork _categoriesUnitOfWork;

        public CategoriesDomain(IUnitOfWork categoriesUnitOfWork)
        {
            _categoriesUnitOfWork = categoriesUnitOfWork;
        }


        public async Task<IEnumerable<Categories>> GetAll()
        {
            return await _categoriesUnitOfWork.Categories.GetAll();
        }
    }
}
