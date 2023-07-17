using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tikkei.Repository.Repositories;
using Tikkei.Repository.Repository;

namespace Tikkei.Repository.Common
{
    public interface IUnitOfWork : IDisposable
    {
        /// <returns></returns>
        IBillDetailRepository billDetailRepository { get; }
        IBillRepository billRepository { get; }
        ICategoryRepository categoryRepository { get; }
        IColorRepository colorRepository { get; }
        IImageRepository imageRepository { get; }

        IProductDetailRepository productDetailRepository { get; }
        IProductRepository productRepository { get; }
        ISizeRepository sizeRepository { get; }
        IUserRepository userRepository { get; }
        IUserRoleRepository userRoleRepository { get; }


        /// <summary>
        /// Function use to Save all Object is changed into Database 
        /// </summary>
        void SaveChanges();
        void TransactionSaveChanges();
    }
}
