 
using Client.IBLL;
using Client.Model;
using System.Collections.Generic;

namespace Client.BLL
{
	
	public partial class MenuService :BaseService<Menu>,IMenuService
    {
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.MenuDal;
        }
    }   
	
	public partial class OfficeService :BaseService<Office>,IOfficeService
    {
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.OfficeDal;
        }
    }   
	
	public partial class OperatorService :BaseService<Operator>,IOperatorService
    {
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.OperatorDal;
        }
    }   
	
	public partial class OperatorMenuAuthorityService :BaseService<OperatorMenuAuthority>,IOperatorMenuAuthorityService
    {
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.OperatorMenuAuthorityDal;
        }
    }   
	
	public partial class RoleService :BaseService<Role>,IRoleService
    {
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.RoleDal;
        }
    }   
	
	public partial class UsersService :BaseService<Users>,IUsersService
    {
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.UsersDal;
        }
    }   
	
}