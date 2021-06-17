using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEF.Model;
using PagedList;

namespace TestUngDung.DAO
{
    public class ProductDAO
    {
        MaiVanPhuocContext db = null;
        public ProductDAO()
        {
            db = new MaiVanPhuocContext();
        }

        public List<Product> ListAll()
        {
            return db.Products.ToList();
        }
        public long Insert(Product entity)
        {
            db.Products.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }


        public bool Update(Product entity)
        {
            try
            {
                var sanPham = db.Products.Find(entity.ID);
                sanPham.Name = entity.Name;
                sanPham.CategoryID = entity.CategoryID;
                sanPham.UnitCost = entity.UnitCost;
                sanPham.Quantity = entity.Quantity;
                sanPham.Image = entity.Image;
                sanPham.Description = entity.Description;
                sanPham.Status = entity.Status;

                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //public long Insert(Product entity)
        //{
        //    db.Products.Add(entity);
        //    db.SaveChanges();
        //    return entity.ProductID;
        //}

        public bool Delete(string id)
        {
            try
            {
                var sanPham = db.Products.Find(id);
                db.Products.Remove(sanPham);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public Product ViewDetail(int id)
        {
            return db.Products.Find(id);
        }
        public List<Product> ListRelatedProduct(int productId)
        {
            var product = db.Products.Find(productId);
            return db.Products.Where(x => x.CategoryID != productId && x.CategoryID == product.CategoryID).ToList();
        }

        public IEnumerable<Product> ListWhereAll(string keysearch, int page, int pagesize)
        {
            IQueryable<Product> model = db.Products;
            if (!string.IsNullOrEmpty(keysearch))
            {
                model = model.Where(x => x.Name.Contains(keysearch));
            }
               
            return model.OrderBy(x => x.UnitCost).ToPagedList(page, pagesize);
        }
    }
}
