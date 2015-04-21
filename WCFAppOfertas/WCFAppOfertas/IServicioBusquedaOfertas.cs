using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DAL; // Added manually after another manual DLL reference

namespace WCFAppOfertas
{
    [ServiceContract]
    public interface IServicioBusquedaOfertas
    {

        [OperationContract]
        List<Oferta> GetByClave();

        [OperationContract]
        List<Oferta> GetOfertaByAreaId(int id);

    }

    [DataContract]
    public class Oferta
    {
        int areaId;

        [DataMember]
        public int AreaId
        {
            get { return areaId; }
            set { areaId = value; }
        }
        string titulo;

        [DataMember]
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }

        }
        string vencimiento;

        [DataMember]
        public string Vencimiento
        {
            get { return vencimiento; }
            set { vencimiento = value; }
        }
        string cargo;
        [DataMember]
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        string horarios;
        [DataMember]
        public string Horarios
        {
            get { return horarios; }
            set { horarios = value; }
        }
        string descripcionTareas;
        [DataMember]
        public string DescripcionTareas
        {
            get { return descripcionTareas; }
            set { descripcionTareas = value; }
        }
        string remuneracion;
        [DataMember]
        public string Remuneracion
        {
            get { return remuneracion; }
            set { remuneracion = value; }
        }
        string rangoEdad;
        [DataMember]
        public string RangoEdad
        {
            get { return rangoEdad; }
            set { rangoEdad = value; }
        }
        string tipoFormacion;
        [DataMember]
        public string TipoFormacion
        {
            get { return tipoFormacion; }
            set { tipoFormacion = value; }
        }
        string idiomas;
        [DataMember]
        public string Idiomas
        {
            get { return idiomas; }
            set { idiomas = value; }
        }
        string competencias;
        [DataMember]
        public string Competencias
        {
            get { return competencias; }
            set { competencias = value; }
        }
        string otrosEstudios;
        [DataMember]
        public string OtrosEstudios
        {
            get { return otrosEstudios; }
            set { otrosEstudios = value; }
        }
        string estado;
        [DataMember]
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        string areaTrabajo;
        [DataMember]
        public string AreaTrabajo
        {
            get { return areaTrabajo; }
            set { areaTrabajo = value; }
        }
        string tipoContrato;
        [DataMember]
        public string TipoContrato
        {
            get { return tipoContrato; }
            set { tipoContrato = value; }
        }
    }
}
