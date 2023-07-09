using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using tpexam.Model;

namespace tpexam
{
    public class SQLiteHelper
    {
        private readonly SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<ProductModel>();
        }
        public Task<int> CreateProduct(ProductModel product)
        {
            return db.InsertAsync(product);
        }
        public Task<List<ProductModel>> ReadProducts()
        {
            return db.Table<ProductModel>().ToListAsync();
        }
        public Task<int> UpdateProduct(ProductModel product)
        {
            return db.UpdateAsync(product);
        }
        public Task<int> DeleteProduct(ProductModel product)
        {
            return db.DeleteAsync(product);
        }
        public Task<List<ProductModel>> Category(string category)
        {
            return db.Table<ProductModel>().Where(p => p.category == category).ToListAsync();
        }
    }
}
