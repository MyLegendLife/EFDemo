 
using Client.IDAL;
using System.Runtime.Remoting.Messaging;

namespace Client.DALFactory
{
    public partial class AbstractFactory
    {
		
	    public static IMenuDal CreateMenuDal()
        {

		 string fullClassName = NameSpace + ".MenuDal";
          return CreateInstance(fullClassName) as IMenuDal;

        }
		
	    public static IOfficeDal CreateOfficeDal()
        {

		 string fullClassName = NameSpace + ".OfficeDal";
          return CreateInstance(fullClassName) as IOfficeDal;

        }
		
	    public static IOperatorDal CreateOperatorDal()
        {

		 string fullClassName = NameSpace + ".OperatorDal";
          return CreateInstance(fullClassName) as IOperatorDal;

        }
		
	    public static IOperatorMenuAuthorityDal CreateOperatorMenuAuthorityDal()
        {

		 string fullClassName = NameSpace + ".OperatorMenuAuthorityDal";
          return CreateInstance(fullClassName) as IOperatorMenuAuthorityDal;

        }
		
	    public static IRoleDal CreateRoleDal()
        {

		 string fullClassName = NameSpace + ".RoleDal";
          return CreateInstance(fullClassName) as IRoleDal;

        }
		
	    public static IUsersDal CreateUsersDal()
        {

		 string fullClassName = NameSpace + ".UsersDal";
          return CreateInstance(fullClassName) as IUsersDal;

        }
	}
	
}