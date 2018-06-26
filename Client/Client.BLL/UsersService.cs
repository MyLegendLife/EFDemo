using Client.IBLL;
using Client.Model;
using System.Collections.Generic;

namespace Client.BLL
{
    public partial class UsersService : BaseService<Users>, IUsersService
    {
        /// <summary>
        /// 批量删除多条用户数据
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool DeleteEntities(List<string> list)
        {
            var userInfoList = this.CurrentDBSession.UsersDal.LoadEntities(u => list.Contains(u.Userid));
            foreach (var userInfo in userInfoList)
            {
                this.CurrentDBSession.UsersDal.DeleteEntity(userInfo);
            }
            return this.CurrentDBSession.SaveChanges();
        }
    }
   
}
