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
      
      ObservableCollection<Contrato> GetAllContratoByFiltro(Int16 EMPR_Codigo, Nullable<Int32> ENTC_CodTransportista, Nullable<DateTime> CONT_FecDesde, Nullable<DateTime> CONT_FecHasta, Boolean CONT_Activo);

      
      ObservableCollection<Contrato> GetAllContratoByAyuda(Int16 EMPR_Codigo, Nullable<Int32> ENTC_CodTransportista, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Nullable<DateTime> CONT_FecDesde, Nullable<DateTime> CONT_FecHasta);


      System.Data.DataTable GetAllContratoByAyudaPivot(Int16 EMPR_Codigo, Int32 ENTC_CodTransportista, DateTime CONT_FecDesde, DateTime CONT_FecHasta, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino, Boolean CCOT_Versionada = false);

      
      System.Data.DataTable GetAllContratoByAyudaPivotOV(Int16 EMPR_Codigo, Int32 ENTC_CodTransportista, DateTime CONT_FecDesde, DateTime CONT_FecHasta, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino);

      
      System.Data.DataTable GetAllContratoByReporte(Int16 EMPR_Codigo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, DateTime CONT_Fecha, Nullable<Int32> PACK_Codigo, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> CONT_Codigo, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino, Boolean CONT_Activo);

      
      System.Data.DataTable GetAllContratoByReporteCosto(Int16 EMPR_Codigo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, DateTime CONT_Fecha, Nullable<Int32> PACK_Codigo, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> CONT_Codigo, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino, Boolean CONT_Activo);

      
      Contrato GetOneContratoCopy(Int16 EMPR_Codigo, Int32 CONT_Codigo, String AUDI_Usuario);

      
      Boolean GetOneContratoValidacion(Int32 CONT_Codigo, String CONT_Numero, DateTime CONT_FecIni, DateTime CONT_FecFin);

      
      Contrato GetOneContratoCopiar(Boolean CopiarContrato, Contrato Item, Contrato ItemNew, String AUDI_Usuario, Int32 PUER_Codigo);
   }
}
