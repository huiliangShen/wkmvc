using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.ServiceImp
{
    /// <summary>
    /// 
    /// </summary>
    public class UserManage : RepositoryBase<Domain.SYS_USER>, IUserManage
    {
        /// <summary>
        /// 管理用户登录验证
        /// </summary>
        /// <param name="useraccount"></param>
        /// <param name="password">加密密码（AES）</param>
        /// <returns></returns>
        public Domain.SYS_USER UserLogin(string useraccount, string password)
        {
            var entity = this.Get(p => p.ACCOUNT == useraccount);

            if (entity != null && new Common.AESCrypt().Decrypt(entity.PASSWORD) == password)
            {
                return entity;
            }
            else
                return null;
        }

        /// <summary>
        /// 是否是超级管理员
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool IsAdmin(int userId)
        {
            //now,we no admin manager in sql table.so,return true.
            return true;
        }

        public string GetUserName(int Id)
        {
            var query = this.LoadAll(c => c.ID == Id);
            if (query == null && !query.Any())
            {
                return "";
            }
            else
                return query.First().NAME;
        }
    }
}
