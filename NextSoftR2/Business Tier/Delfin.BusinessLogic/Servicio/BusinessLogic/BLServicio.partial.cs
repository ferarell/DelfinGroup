using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;
using Microsoft.Practices.Unity;

namespace Delfin.BusinessLogic
{
    public partial class BLServicio : IBLServicio
    {

        /// <summary>
        /// CRISTHIAN JOSE APAZA ARHUATA
        /// INSERTAR SERVICIOS-DOCUMENTOS
        /// </summary>
        [Dependency]
        public IBLServiciosDocumentos BL_ServicioDocumento { get; set; }
        [Dependency]
        public IBLServiciosLineaNegocio BL_ServicioLineaNegocio { get; set; }

        [Dependency]
        public IBLServiciosRegimenVia BL_ServicioRegimenVia { get; set; }



        #region [ Consultas ]
        public ObservableCollection<Servicio> GetAllByViaRegimen(String CONS_TabVia, String CONS_CodVia, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabLNG, String CONS_CodLNG)
        {
            try
            {
                return SelectAllByViaRegimen(CONS_TabVia, CONS_CodVia, CONS_TabRGM, CONS_CodRGM, CONS_TabLNG, CONS_CodLNG);
            }
            catch (Exception)
            { throw; }
        }

        public ObservableCollection<Servicio> GetAllByFiltros(Boolean AcceptNulls, String CONS_TabVia, String CONS_CodVia, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabLNG, String CONS_CodLNG, String SERV_TipoMov, Boolean SERV_AfeIgv, Boolean SERV_AfeDet)
        {
            try
            {
                return SelectAllByFiltros(AcceptNulls, CONS_TabVia, CONS_CodVia, CONS_TabRGM, CONS_CodRGM, CONS_TabLNG, CONS_CodLNG, SERV_TipoMov, SERV_AfeIgv, SERV_AfeDet);
            }
            catch (Exception)
            { throw; }
        }

        public ObservableCollection<ServiciosDocumentos> GetAllServiciosDocumentosByServCodigo(Int32 SERV_codigo)
        {
            try
            {
                return BL_ServicioDocumento.GetAllServiciosDocumentosByServCodigo(SERV_codigo);
            }
            catch (Exception)
            { throw; }
        }


        public ObservableCollection<ServiciosLineaNegocio> GetAllServiciosLineaNegocioByServCodigo(Int32 SERV_codigo)
        {
            try
            {
                return BL_ServicioLineaNegocio.GetAllServiciosLineaNegocioByServCodigo(SERV_codigo);
            }
            catch (Exception ex)
            { throw; }
        }



        public ObservableCollection<ServiciosRegimenVia> GetAllServiciosRegimenViaByServCodigo(Int32 SERV_codigo)
        {
            try
            {
                return BL_ServicioRegimenVia.GetAllServiciosRegimenViaByServCodigo(SERV_codigo);
            }
            catch (Exception ex)
            { throw; }
        }




        public System.Data.DataTable GetAllDTByFilters(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
        {
            try
            {
                return SelectAllDTByFilters(x_procedure, x_filters);
            }
            catch (Exception)
            { throw; }
        }

        public ObservableCollection<Servicio> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
        {
           try
           {
              return SelectAllByFilter(x_procedure, x_filters);
           }
           catch (Exception)
           { throw; }
        }

        public string VerificaServicio(Servicio x_Item)
        {
            try
            {
                return VerificaServicioFlete(x_Item);
            }
            catch (Exception)
            {

                throw;
            }
        }
        //public ObservableCollection<Servicio> GetAllByCachetes(string Nombre)
        //{
        //   try
        //   {
        //      return null;
        //   }
        //   catch (Exception)
        //   { throw; }
        //}
        #endregion

        #region [ Metodos ]
        public Boolean SaveServicioDocumentos(ref Servicio Item)
        {
            Boolean m_Update = false;
            try
            {
                for (int i = 0; i < Item.ServiciosDocumentos.Count; i++)
                {
                    ServiciosDocumentos _ServiciosDocumentos = Item.ServiciosDocumentos[i];
                    _ServiciosDocumentos.SERV_Codigo = Item.SERV_Codigo;

                    switch (_ServiciosDocumentos.Instance)
                    {
                        case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                            BL_ServicioDocumento.Insert(ref _ServiciosDocumentos);
                            break;
                        case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                            BL_ServicioDocumento.Update(ref _ServiciosDocumentos);
                            break;
                        case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                            BL_ServicioDocumento.Delete(ref _ServiciosDocumentos);
                            break;
                    }
                }
                m_Update = true;
            }
            catch (Exception)
            { throw; }

            return m_Update;
        }


        #endregion
    }
}
