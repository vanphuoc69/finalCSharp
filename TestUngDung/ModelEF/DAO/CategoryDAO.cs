using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEF.Model;
using PagedList;

namespace TestUngDung.DAO
{
    public class CategoryDAO
    {
        MaiVanPhuocContext db = null;
        public CategoryDAO()
        {
            db = new MaiVanPhuocContext();
        }

        public string Insert(Category entity)
        {
            var thing = Find(entity.CategoryID);
            if (thing == null)
            {
                db.Categories.Add(entity);
            }
            else
            {
                thing.CategoryID = entity.CategoryID;
                if (!String.IsNullOrEmpty(entity.Name))
                {
                    thing.Name = entity.Name;
                }
                if (!String.IsNullOrEmpty(entity.Description))
                {
                    thing.Description = entity.Description;
                }

            }
            db.SaveChanges();
            return entity.CategoryID.ToString();
        }
        public bool Delete(string username)
        {
            try
            {
                var user = db.Categories.Find(username);
                db.Categories.Remove(user);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public IEnumerable<Category> ListWhereAll(string keysearch, int page, int pagesize)
        {
            IQueryable<Category> model = db.Categories;
            if (!string.IsNullOrEmpty(keysearch))
                model = model.Where(x => x.Name.Contains(keysearch));
            return model.OrderBy(x => x.Name).ToPagedList(page, pagesize);
        }

        public Category Find(long ID)
        {
            return db.Categories.Find(ID);
        }
        public Category ViewDetail(int id)
        {
            return db.Categories.Find(id);
        }
        public List<Category> ListAll()
            {
                return db.Categories.ToList();
            }
        }



    }

