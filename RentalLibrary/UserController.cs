using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RentalLibrary.Controller
{
    class UserController
    {
        public Boolean RegUser(Model.User Tmp)
        {
            try
            {
                DAL.UserDAL ObjectDAL = new DAL.UserDAL();
                return ObjectDAL.RegUser(Tmp) > 0 ? true : false;
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public Boolean LoginUser(Model.User Tmp)
        {
            try
            {
                DAL.UserDAL ObjectDAL = new DAL.UserDAL();
                return ObjectDAL.LoginUser(Tmp) > 0 ? true : false;
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
