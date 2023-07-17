using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tikkei.Entity.Entity;
using Tikkei.Repository.Repositories;
using Tikkei.Repository.Repository;

namespace Tikkei.Repository.Common
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly TikkeiSystemModel context;

        public UnitOfWork(TikkeiSystemModel context)
        {
            this.context = context;
        }

        public IBillDetailRepository billDetailRepository =>  new BillDetailRepository(context);

        public IBillRepository billRepository =>  new BillRepository(context);

        public ICategoryRepository categoryRepository =>  new CategoryRepository(context);

        public IColorRepository colorRepository =>  new ColorRepository(context);

        public IImageRepository imageRepository =>  new ImageRepository(context);

        public IProductDetailRepository productDetailRepository =>  new ProductDetailRepository(context);

        public IProductRepository productRepository =>  new ProductRepository(context);

        public ISizeRepository sizeRepository =>  new SizeRepository(context);

        public IUserRepository userRepository =>  new UserRepository(context);

        public IUserRoleRepository userRoleRepository =>  new UserRoleRepository(context);

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void TransactionSaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
