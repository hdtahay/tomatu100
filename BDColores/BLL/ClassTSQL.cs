using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MODELS;
using System.Collections;
using System.Data;
using System.Data.Sql;

namespace BLL
{
    public class ClassTSQL
    {
        public int Login(string user, string pass)
        {
            BDColoresEntities db = new BDColoresEntities();
            try
            {
                int resultado = db.Database.SqlQuery<int>("Select dbo.f_Escalar1(@user, @pass)", new SqlParameter("@user", user), new SqlParameter("@pass", pass)).FirstOrDefault<int>();
                return Convert.ToInt32(resultado.ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
