using Client.Model;
using System.Collections.Generic;

namespace Client.IBLL
{
   public partial interface IUsersService:IBaseService<Users>
    {
       bool DeleteEntities(List<string>list);
       //IQueryable<Users> LoadSearchEntities(UserInfoSearch userInfoSearch, short delFlag);
       //bool SetUserRoleInfo(string userId,List<string>roleIdList);
       //bool SetUserActionInfo(int actionId,string userId,bool isPass);
    }
}
