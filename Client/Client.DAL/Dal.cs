 

using Client.IDAL;
using Client.Model;

namespace Client.DAL
{
		
	public partial class MenuDal :BaseDal<Menu>,IMenuDal
    {

    }
		
	public partial class OfficeDal :BaseDal<Office>,IOfficeDal
    {

    }
		
	public partial class OperatorDal :BaseDal<Operator>,IOperatorDal
    {

    }
		
	public partial class OperatorMenuAuthorityDal :BaseDal<OperatorMenuAuthority>,IOperatorMenuAuthorityDal
    {

    }
		
	public partial class RoleDal :BaseDal<Role>,IRoleDal
    {

    }
		
	public partial class UsersDal :BaseDal<Users>,IUsersDal
    {

    }
	
}