using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections;
using System.Configuration;



namespace DAL
{
    public class DALOfertas : DALBase
    {

        public static SqlDataReader select_byClave(string clave)
        {
            SqlParameter param = new SqlParameter();
            param.Value = clave;
            param.ParameterName = "areaId"; ;
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(param);
            string StoredProcedure = "spu_selectOfertaByClave";
            SqlDataReader dr = select(null, StoredProcedure, CommandType.StoredProcedure);
            return dr;
        }

        public static SqlDataReader select_byArea(int areaId)
        {

            SqlParameter param = new SqlParameter();
            param.Value = areaId;
            param.ParameterName = "areaId"; ;
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(param);
            string StoreProcedure = "spu_selectOfertaByAreaId";
            SqlDataReader dr = select(parameters, StoreProcedure, CommandType.StoredProcedure);
            return dr;
        }
    }

}
