using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DAL;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace WCFAppOfertas
{
    public class ServicioBusquedaOfertas : IServicioBusquedaOfertas
    {
        public List<Oferta> GetByClave(string clave)
        {
            List<Oferta> lst = new List<Oferta>();
            SqlDataReader dr = DALOfertas.select_byClave(clave);
            while (dr.Read())
            {

                lst.Add(cargarOferta(dr));
            }

            return lst;
        }


        public List<Oferta> GetOfertaByAreaId(int id)
        {
            List<Oferta> lst = new List<Oferta>();
            SqlDataReader dr = DALOfertas.select_byArea(id);
            while (dr != null && dr.Read())
            {
                lst.Add(cargarOferta(dr));
            }
            return lst;
        }
        Oferta cargarOferta(SqlDataReader dr)
        {

            Oferta p = new Oferta();            
            p.AreaId = int.Parse(dr["AreaId"].ToString());
            p.Titulo = dr["Titulo"].ToString();
            p.Cargo = dr["Cargo"].ToString();
            p.Horarios = dr["Horarios"].ToString();
            p.DescripcionTareas = dr["DescripcionTareas "].ToString();
            p.Remuneracion = dr["Remuneracion"].ToString();
            p.RangoEdad = dr["RangoEdad"].ToString();
            p.TipoFormacion = dr["TipoFormacion"].ToString();
            p.Idiomas = dr["Idiomas"].ToString();
            p.Competencias = dr["Competencias"].ToString();
            p.OtrosEstudios = dr["OtrosEstudios"].ToString();
            p.Estado = dr["Estado"].ToString();
            p.AreaTrabajo = dr["AreaTrabajo"].ToString();
            p.TipoContrato = dr["TipoContrato"].ToString();

            return p;

        }
    }
}
