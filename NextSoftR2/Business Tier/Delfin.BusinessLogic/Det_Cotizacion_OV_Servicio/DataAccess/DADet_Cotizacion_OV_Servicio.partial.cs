using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Infrastructure.Aspect.DataAccess;
using Delfin.Entities;
using Infrastructure.Aspect.BusinessEntity;

namespace Delfin.BusinessLogic
{
	public partial class BLDet_Cotizacion_OV_Servicio
	{
		#region [ Consultas ]
      private ObservableCollection<Det_Cotizacion_OV_Servicio> SelectAllByCab_Cotizacion_OV(Int16 CCOT_Tipo, Int32 CCOT_Numero)
      {
         try
         {
            ObservableCollection<Det_Cotizacion_OV_Servicio> items = new ObservableCollection<Det_Cotizacion_OV_Servicio>();
            Det_Cotizacion_OV_Servicio item = new Det_Cotizacion_OV_Servicio();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Det_Cotizacion_OV_Servicio");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Det_Cotizacion_OV_Servicio();
                  Loader.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Unchanged;
                  items.Add(item);
               }
            }
            return items;
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion

		#region [ Metodos ]
      private bool UpdateDocumento(ref Det_Cotizacion_OV_Servicio Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("[TCOM_SP_ACTUALIZAR_Det_Cotizacion_OV_Servicio_Documento]");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", Item.CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", Item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintSCOT_Item", Item.SCOT_Item, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTDO", Item.TIPO_TabTDO, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTDO", Item.TIPO_CodTDO, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSCOT_NumeroTDO", Item.SCOT_NumeroTDO, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSCOT_SerieTDO", Item.SCOT_SerieTDO, SqlDbType.VarChar, 20, ParameterDirection.Input);

               // Autor-Fec.Mod.-Desc : Ysaacx - 13/03/2017 - Agregar el campo Fecha de Emisión -- Dinamica de Otros Traficos
               DataAccessEnterpriseSQL.DAAgregarParametro("@SCOT_FechaEmision", Item.SCOT_FechaEmision, SqlDbType.DateTime, 8, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", Item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               { return true; }
               else
               { return false; }
            }
            else
            { return true; }
         }
         catch (Exception ex)
         { throw ex; }
      }

      private bool UpdateSerieNumero(ref Det_Cotizacion_OV_Servicio item)
      {
         try
         {
            if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_ACTUALIZAR_Det_Cotizacion_OV_Servicio_SerieNumero");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", item.CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", item.CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintSCOT_Item", item.SCOT_Item, SqlDbType.Int, 4, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCCOT_IngresoGasto", item.CCOT_IngresoGasto, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", item.SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrSCOT_Origen", item.SCOT_Origen, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pnumSCOT_Cantidad", item.SCOT_Cantidad, SqlDbType.Decimal, 12, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSCOT_PrecioUni", item.SCOT_PrecioUni, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSCOT_Importe_Ingreso", item.SCOT_Importe_Ingreso, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSCOT_Importe_Egreso", item.SCOT_Importe_Egreso, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMnd", item.TIPO_TabMnd, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMnd", item.TIPO_CodMnd, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecSCOT_PreSugerido", item.SCOT_PreSugerido, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_Codigo", item.TIPE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintTARI_Codigo", item.TARI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabBas", item.CONS_TabBas, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodBas", item.CONS_CodBas, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSCOT_Exonerado", item.SCOT_Exonerado, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitSCOT_ChageControl", item.SCOT_ChageControl, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchPFAC_Numero", item.PFAC_Numero, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTDO", item.TIPO_TabTDO, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTDO", item.TIPO_CodTDO, SqlDbType.Char, 3, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSCOT_NumeroTDO", item.SCOT_NumeroTDO, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchSCOT_SerieTDO", item.SCOT_SerieTDO, SqlDbType.VarChar, 20, ParameterDirection.Input);
               
               // Autor-Fec.Mod.-Desc : Ysaacx - 13/03/2017 - Agregar el campo Fecha de Emisión -- Dinamica de Otros Traficos
               DataAccessEnterpriseSQL.DAAgregarParametro("@SCOT_FechaEmision", item.SCOT_FechaEmision, SqlDbType.DateTime, 8, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               { return true; }
               else
               { return false; }
            }
            else
            { return true; }
         }
         catch (Exception ex)
         { throw ex; }
      }
		#endregion
	}
}
