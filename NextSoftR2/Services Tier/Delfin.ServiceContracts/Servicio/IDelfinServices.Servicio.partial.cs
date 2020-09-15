using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using Delfin.Entities;
using Delfin.BusinessLogic;

namespace Delfin.ServiceContracts
{
   public partial interface IDelfinServices
   {

      ObservableCollection<Servicio> GetAllServicioByViaRegimen(String CONS_TabVia, String CONS_CodVia, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabLNG, String CONS_CodLNG);
      ObservableCollection<Servicio> GetAllServicioByFiltros(Boolean AcceptNulls, String CONS_TabVia, String CONS_CodVia, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabLNG, String CONS_CodLNG, String SERV_TipoMov, Boolean SERV_AfeIgv, Boolean SERV_AfeDet);
      ObservableCollection<ServiciosDocumentos> GetAllServiciosDocumentosByServCodigo(Int32 SERV_codigo);

      ObservableCollection<Servicio> GetAllServiciosFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);

      System.Data.DataTable GetAllServiciosDTByFilters(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);

      /// <summary>
      /// Verifica si existe un servicio FLETE con el misma Configuracion Linea, Regimen, Via
      /// </summary>
      /// <param name="Item"></param>
      /// <returns></returns>
      String CheckServicio(Servicio x_Item);
      //ObservableCollection<Servicio> GetAllServicioByCachetes(String Nombre);
   }
}
