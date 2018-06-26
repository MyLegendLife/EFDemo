 
using Client.DAL;
using Client.IDAL;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace Client.DALFactory
{
	public partial class DBSession : IDBSession
    {
	
		private IMenuDal _MenuDal;
        public IMenuDal MenuDal
        {
            get
            {
                if(_MenuDal == null)
                {
                    _MenuDal = AbstractFactory.CreateMenuDal();
                }
                return _MenuDal;
            }
            set { _MenuDal = value; }
        }
	
		private IOfficeDal _OfficeDal;
        public IOfficeDal OfficeDal
        {
            get
            {
                if(_OfficeDal == null)
                {
                    _OfficeDal = AbstractFactory.CreateOfficeDal();
                }
                return _OfficeDal;
            }
            set { _OfficeDal = value; }
        }
	
		private IOperatorDal _OperatorDal;
        public IOperatorDal OperatorDal
        {
            get
            {
                if(_OperatorDal == null)
                {
                    _OperatorDal = AbstractFactory.CreateOperatorDal();
                }
                return _OperatorDal;
            }
            set { _OperatorDal = value; }
        }
	
		private IOperatorMenuAuthorityDal _OperatorMenuAuthorityDal;
        public IOperatorMenuAuthorityDal OperatorMenuAuthorityDal
        {
            get
            {
                if(_OperatorMenuAuthorityDal == null)
                {
                    _OperatorMenuAuthorityDal = AbstractFactory.CreateOperatorMenuAuthorityDal();
                }
                return _OperatorMenuAuthorityDal;
            }
            set { _OperatorMenuAuthorityDal = value; }
        }
	
		private IRoleDal _RoleDal;
        public IRoleDal RoleDal
        {
            get
            {
                if(_RoleDal == null)
                {
                    _RoleDal = AbstractFactory.CreateRoleDal();
                }
                return _RoleDal;
            }
            set { _RoleDal = value; }
        }
	
		private IUsersDal _UsersDal;
        public IUsersDal UsersDal
        {
            get
            {
                if(_UsersDal == null)
                {
                    _UsersDal = AbstractFactory.CreateUsersDal();
                }
                return _UsersDal;
            }
            set { _UsersDal = value; }
        }
	}	
}