using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.DataAccess;

namespace Delfin.ServiceProxy
{
   using Delfin.ServiceContracts;
   using Delfin.BusinessLogic;
   using Delfin.Entities;

   public partial class DelfinServicesProxy : IDelfinServices
   {
      public ObservableCollection<Contrato> GetAllContratoByFiltro(Int16 EMPR_Codigo, Nullable<Int32> ENTC_CodTransportista, Nullable<DateTime> CONT_FecDesde, Nullable<DateTime> CONT_FecHasta, Boolean CONT_Activo)
      {
         try
         {
            return this.BL_Contrato.GetAllByFiltro(EMPR_Codigo, ENTC_CodTransportista, CONT_FecDesde, CONT_FecHasta, CONT_Activo);
         }
         catch (Exception)
         { throw; }
      }

      public ObservableCollection<Contrato> GetAllContratoByAyuda(Int16 EMPR_Codigo, Nullable<Int32> ENTC_CodTransportista, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Nullable<DateTime> CONT_FecDesde, Nullable<DateTime> CONT_FecHasta)
      {
         try
         {
            return this.BL_Contrato.GetAllByAyuda(EMPR_Codigo, ENTC_CodTransportista, CONS_TabRGM, CONS_CodRGM, CONS_TabVIA, CONS_CodVIA, CONT_FecDesde, CONT_FecHasta);
         }
         catch (Exception)
         { throw; }
      }

      public System.Data.DataTable GetAllContratoByAyudaPivot(Int16 EMPR_Codigo, Int32 ENTC_CodTransportista, DateTime CONT_FecDesde, DateTime CONT_FecHasta, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino, Boolean CCOT_Versionada = false)
      {
         try
         {
            return this.BL_Contrato.GetAllByAyudaPivot(EMPR_Codigo, ENTC_CodTransportista, CONT_FecDesde, CONT_FecHasta, CONS_TabRGM, CONS_CodRGM, CONS_TabVIA, CONS_CodVIA, PUER_CodOrigen, PUER_CodDestino, CCOT_Versionada);
         }
         catch (Exception)
         { throw; }
      }

      public System.Data.DataTable GetAllContratoByAyudaPivotOV(Int16 EMPR_Codigo, Int32 ENTC_CodTransportista, DateTime CONT_FecDesde, DateTime CONT_FecHasta, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino)
      {
         try
         {
            return this.BL_Contrato.GetAllByAyudaPivotOV(EMPR_Codigo, ENTC_CodTransportista, CONT_FecDesde, CONT_FecHasta, CONS_TabRGM, CONS_CodRGM, CONS_TabVIA, CONS_CodVIA, PUER_CodOrigen, PUER_CodDestino);
         }
         catch (Exception)
         { throw; }
      }

      public System.Data.DataTable GetAllContratoByReporte(Int16 EMPR_Codigo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, DateTime CONT_Fecha, Nullable<Int32> PACK_Codigo, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> CONT_Codigo, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino, Boolean CONT_Activo)
      {
         try
         {
            return this.BL_Contrato.GetAllByReporte(EMPR_Codigo, CONS_TabRGM, CONS_CodRGM, CONS_TabVIA, CONS_CodVIA, CONT_Fecha, PACK_Codigo, ENTC_CodTransportista, CONT_Codigo, PUER_CodOrigen, PUER_CodDestino, CONT_Activo);
         }
         catch (Exception)
         { throw; }
      }

      public System.Data.DataTable GetAllContratoByReporteCosto(Int16 EMPR_Codigo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, DateTime CONT_Fecha, Nullable<Int32> PACK_Codigo, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> CONT_Codigo, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino, Boolean CONT_Activo)
      {
         try
         {
            return this.BL_Contrato.GetAllByReporteCosto(EMPR_Codigo, CONS_TabRGM, CONS_CodRGM, CONS_TabVIA, CONS_CodVIA, CONT_Fecha, PACK_Codigo, ENTC_CodTransportista, CONT_Codigo, PUER_CodOrigen, PUER_CodDestino, CONT_Activo);
         }
         catch (Exception)
         { throw; }
      }

      public Contrato GetOneContratoCopy(Int16 EMPR_Codigo, Int32 CONT_Codigo, String AUDI_Usuario)
      {
         try
         {
            return this.BL_Contrato.GetOneCopy(EMPR_Codigo, CONT_Codigo, AUDI_Usuario);
         }
         catch (Exception)
         { throw; }
      }

      public Boolean GetOneContratoValidacion(Int32 CONT_Codigo, String CONT_Numero, DateTime CONT_FecIni, DateTime CONT_FecFin)
      {
         try
         {
            return this.BL_Contrato.GetOneValidacion(CONT_Codigo, CONT_Numero, CONT_FecIni, CONT_FecFin);
         }
         catch (Exception)
         { throw; }
      }

      public Contrato GetOneContratoCopiar(Boolean CopiarContrato, Contrato Item, Contrato ItemNew, String AUDI_Usuario, Int32 PUER_Codigo)
      {
         try
         {
            return this.BL_Contrato.CopiarContrato(CopiarContrato, Item, ItemNew, AUDI_Usuario, PUER_Codigo);
         }
         catch (Exception)
         { throw; }
      }
   }
}
