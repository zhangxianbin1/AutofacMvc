using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class DbFactory
    {
        public static DbContext getDbContext()
        {
            var dbContext = CallContext.GetData("DbContext") as DbContext;
            if (dbContext == null)  //线程在数据槽里面没有此上下文
            {
                dbContext = new test1Entities(); //创建一个EF上下文
                CallContext.SetData("DbContext", dbContext);
                dbContext.Configuration.ProxyCreationEnabled = false;
            }
            return dbContext;
        }
    }
}
