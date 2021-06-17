using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEF.Model;
using PagedList;

namespace ModelEF.DAO
{
    public class UserDAO
    {
        private MaiVanPhuocContext db;

        public UserDAO()
        {
            db = new MaiVanPhuocContext();
        }
        public int login(string user, string pass)
        {
            var result = db.UserAccounts.SingleOrDefault(x => x.UserName.Contains(user) && x.Password.Contains(pass));
            if (result == null)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
       
        public bool Delete(int id)
        {
            try
            {
                var user = db.UserAccounts.Find(id);
                db.UserAccounts.Remove(user);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public long Insert(UserAccount entity)
        {
            db.UserAccounts.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }
        public UserAccount ViewDetail(int id)
        {
            return db.UserAccounts.Find(id);
        }

        public List<UserAccount> ListAll()
        {
            return db.UserAccounts.ToList();
        }
        public IEnumerable<UserAccount> ListWhereAll(string keysearch, int page, int pagesize)
        {
            IQueryable<UserAccount> model = db.UserAccounts;
            if (!string.IsNullOrEmpty(keysearch))
                model = model.Where(x => x.UserName.Contains(keysearch));
            return model.OrderBy(x => x.UserName).ToPagedList(page, pagesize);
        }

    }
}

