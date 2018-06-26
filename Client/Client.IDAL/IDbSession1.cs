
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Client.IDAL
{
    public partial interface IDBSession
    {	
			IMenuDal MenuDal{get;set;}
		
			IOfficeDal OfficeDal{get;set;}
		
			IOperatorDal OperatorDal{get;set;}
		
			IOperatorMenuAuthorityDal OperatorMenuAuthorityDal{get;set;}
		
			IRoleDal RoleDal{get;set;}
		
			IUsersDal UsersDal{get;set;}
	}	
}