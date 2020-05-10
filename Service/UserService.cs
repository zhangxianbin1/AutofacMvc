using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IService;
using Model;

namespace Service
{
    public class UserService:IUserService
    {
        //获取用户列表
        public List<user> GetUsers()
        {
            DbContext context = DbFactory.getDbContext();
            return context.Set<user>().ToList<user>();
        }
    }
}
