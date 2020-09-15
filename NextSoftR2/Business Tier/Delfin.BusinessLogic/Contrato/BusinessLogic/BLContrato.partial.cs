using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;
using Infrastructure.Aspect.DataAccess;

namespace Delfin.BusinessLogic
{
	public partial class BLContrato
	{
		#region [ Consultas ]
      public ObservableCollection<Contrato> GetAllByFiltro(Int16 EMPR_Codigo, Nullable<Int32> ENTC_CodTransportista, Nullable<DateTime> CONT_FecDesde, Nullable<DateTime> CONT_FecHasta, Boolean CONT_Activo)
      {
         try
         {
            return SelectAllByFiltro(EMPR_Codigo, ENTC_CodTransportista, CONT_FecDesde, CONT_FecHasta, CONT_Activo);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Contrato> GetAllByAyuda(Int16 EMPR_Codigo, Nullable<Int32> ENTC_CodTransportista, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Nullable<DateTime> CONT_FecDesde, Nullable<DateTime> CONT_FecHasta)
      {
         try
         {
            return SelectAllByAyuda(EMPR_Codigo, ENTC_CodTransportista, CONS_TabRGM, CONS_CodRGM, CONS_TabVIA, CONS_CodVIA, CONT_FecDesde, CONT_FecHasta);
         }
         catch (Exception)
         { throw; }
      }
      public System.Data.DataTable GetAllByAyudaPivot(Int16 EMPR_Codigo, Int32 ENTC_CodTransportista, DateTime CONT_FecDesde, DateTime CONT_FecHasta, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino, Boolean CCOT_Versionada = false)
      {
         try
         {
            return SelectAllByAyudaPivot(EMPR_Codigo, ENTC_CodTransportista, CONT_FecDesde, CONT_FecHasta, CONS_TabRGM, CONS_CodRGM, CONS_TabVIA, CONS_CodVIA, PUER_CodOrigen, PUER_CodDestino, CCOT_Versionada);
         }
         catch (Exception)
         { throw; }
      }
      public System.Data.DataTable GetAllByAyudaPivotOV(Int16 EMPR_Codigo, Int32 ENTC_CodTransportista, DateTime CONT_FecDesde, DateTime CONT_FecHasta, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino)
      {
         try
         {
            return SelectAllByAyudaPivotOV(EMPR_Codigo, ENTC_CodTransportista, CONT_FecDesde, CONT_FecHasta, CONS_TabRGM, CONS_CodRGM, CONS_TabVIA, CONS_CodVIA, PUER_CodOrigen, PUER_CodDestino);
         }
         catch (Exception)
         { throw; }
      }
      public System.Data.DataTable GetAllByReporte(Int16 EMPR_Codigo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, DateTime CONT_Fecha, Nullable<Int32> PACK_Codigo, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> CONT_Codigo, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino, Boolean CONT_Activo)
      {
         try
         {
            return SelectAllByReporte(EMPR_Codigo, CONS_TabRGM, CONS_CodRGM, CONS_TabVIA, CONS_CodVIA, CONT_Fecha, PACK_Codigo, ENTC_CodTransportista, CONT_Codigo, PUER_CodOrigen, PUER_CodDestino, CONT_Activo);
         }
         catch (Exception)
         { throw; }
      }
      public System.Data.DataTable GetAllByReporteCosto(Int16 EMPR_Codigo, String CONS_TabRGM, String CONS_CodRGM, String CONS_TabVIA, String CONS_CodVIA, DateTime CONT_Fecha, Nullable<Int32> PACK_Codigo, Nullable<Int32> ENTC_CodTransportista, Nullable<Int32> CONT_Codigo, Nullable<Int32> PUER_CodOrigen, Nullable<Int32> PUER_CodDestino, Boolean CONT_Activo)
      {
         try
         {
            return SelectAllByReporteCosto(EMPR_Codigo, CONS_TabRGM, CONS_CodRGM, CONS_TabVIA, CONS_CodVIA, CONT_Fecha, PACK_Codigo, ENTC_CodTransportista, CONT_Codigo, PUER_CodOrigen, PUER_CodDestino, CONT_Activo);
         }
         catch (Exception)
         { throw; }
      }
      #endregion
		
		#region [ Metodos ]
      public Contrato GetOneCopy(Int16 EMPR_Codigo, Int32 CONT_Codigo, String AUDI_Usuario)
      {
         try
         {
            Int32 CONT_CodigoNew = -1;
            if (SelectOneCopy(EMPR_Codigo, ref CONT_CodigoNew, CONT_Codigo, AUDI_Usuario))
            {
               Entities.Contrato Item = SelectOne(EMPR_Codigo, CONT_CodigoNew);
               Item.CONT_FecIni = null;
               Item.CONT_FecFin = null;
               if (Item != null && Item.CONT_Codigo.HasValue)
               { Item.ListTarifa = BL_Tarifa.GetAllByContrato(Item.CONT_Codigo.Value); }
               return Item;
            }
            else
            { return null; }
         }
         catch (Exception ex)
         { throw ex; }
      }
      public Boolean GetOneValidacion(Int32 CONT_Codigo, String CONT_Numero, DateTime CONT_FecIni, DateTime CONT_FecFin)
      {
         try
         {
            return SelectValidacion(CONT_Codigo, CONT_Numero, CONT_FecIni, CONT_FecFin);
         }
         catch (Exception)
         { throw; }
      }

      public Contrato CopiarContrato(Boolean CopiarContrato, Contrato Item, Contrato ItemNew, String AUDI_Usuario, Int32 PUER_Codigo)
      {
         try
         {
            DataAccessEnterpriseSQL.DABeginTransaction();
            if (Copiar(CopiarContrato, Item, ItemNew, AUDI_Usuario, PUER_Codigo))
            {
               DataAccessEnterpriseSQL.DACommitTransaction();
               ItemNew = SelectOne(ItemNew.EMPR_Codigo.Value, ItemNew.CONT_Codigo.Value);
               if (ItemNew != null && ItemNew.CONT_Codigo.HasValue)
               { ItemNew.ListTarifa = BL_Tarifa.GetAllByContrato(ItemNew.CONT_Codigo.Value); }
               return ItemNew;
            }
            else
            {
               DataAccessEnterpriseSQL.DARollbackTransaction();
               return null; 
            }
         }
         catch (Exception)
         { DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }
      #endregion
	}
}
