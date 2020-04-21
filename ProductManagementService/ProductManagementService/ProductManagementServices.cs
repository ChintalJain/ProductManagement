using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProductManagementService
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        int AddProduct(Product product);

        [OperationContract]
        List<Product> GetAllProduct();

        [OperationContract]
        void UpdateProductName(int id,string name);
        [OperationContract]
        void UpdateProductPrice(int id, int price);
        [OperationContract]
        void UpdateProductTotalQuantity(int id, int tq);
        [OperationContract]
        void UpdateProductQuantityAtShop(int id, int qas);
        [OperationContract]
        void UpdateProductQuantityAtGodown(int id, int qag);
        [OperationContract]
        void UpdateProductDescription(int id, string des);
        [OperationContract]
        List<Product> GetProductOutOfStock();

    }
}
