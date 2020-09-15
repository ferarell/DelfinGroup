using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Infrastructure.Aspect.DataAccess;
using Infrastructure.Aspect.BusinessEntity;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLMovimiento
	{
      public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Planillas> LoaderPlanillas { get; set; }

		#region [ Consultas ]

      private Planillas SelectOnePlanillas(Int16 EMPR_Codigo, String PLAN_Tipo, String PLAN_Codigo)
      {
         try
         {
            Planillas item = new Planillas();
            DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_PLANSS_UnReg");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrPLAN_Tipo", PLAN_Tipo, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchPLAN_Codigo", PLAN_Codigo, SqlDbType.VarChar, 20, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               if (reader.Read())
               {
                  LoaderPlanillas = new BusinessEntityLoader<Planillas>();
                  LoaderPlanillas.EntityType = item.GetType();
                  LoaderPlanillas.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Unchanged;
               }
               else
               { throw new Exception("No se encontro el registro."); }
            }
            return item;
         }
         catch (Exception)
         { throw; }
      }

		#endregion

		#region [ Metodos ]

      private bool UpdateAnular(ref Movimiento Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_MOVISU_UnRegAnular");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintMOVI_Codigo", Item.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEST", Item.CONS_CodEST, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_UserAnulacion", Item.MOVI_UserAnulacion, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmMOVI_FecAnulacion", Item.MOVI_FecAnulacion, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_GlosaAnulacion", Item.MOVI_GlosaAnulacion, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", Item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@Transferencia", Item.Transferencia, SqlDbType.Bit, 1, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               { return true; }
               else
               { return false; }
            }
            else
            { return true; }
         }
         catch (Exception)
         { throw; }
      }

      private bool UpdateChequeBlanco(ref Movimiento Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_MOVISU_UnRegChequeBlanco");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintMOVI_Codigo", Item.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCUBA_Codigo", Item.CUBA_Codigo, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", Item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabEST", Item.CONS_TabEST, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEST", Item.CONS_CodEST, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_Numero", Item.MOVI_Numero, SqlDbType.VarChar, 15, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmMOVI_FecEmision", Item.MOVI_FecEmision, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_OrdenDe", Item.MOVI_OrdenDe, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecMOVI_MontoDebe", Item.MOVI_MontoDebe, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecMOVI_TipoCambio", Item.MOVI_TipoCambio, SqlDbType.Decimal, 6, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecMOVI_MontoHaber", Item.MOVI_MontoHaber, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitMOVI_Cheque", Item.MOVI_Cheque, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrMOVI_EstadoCheque", Item.MOVI_EstadoCheque, SqlDbType.Char, 12, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmMOVI_FecVigencia", Item.MOVI_FecVigencia, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_Responsable", Item.MOVI_Responsable, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecMOVI_MontoLimite", Item.MOVI_MontoLimite, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMOV", Item.TIPO_TabMOV, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMOV", Item.TIPO_CodMOV, SqlDbType.Char, 3, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", Item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               { return true; }
               else
               { return false; }
            }
            else
            { return true; }
         }
         catch (Exception)
         { throw; }
      }

      private bool UpdateTransferencia(ref Movimiento Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_MOVISU_UnRegTransferencia");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintMOVI_Codigo", Item.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", Item.SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCUBA_Codigo", Item.CUBA_Codigo, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrPLAN_Tipo", Item.PLAN_Tipo, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchPLAN_Codigo", Item.PLAN_Codigo, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintTRAN_Codigo", Item.TRAN_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", Item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMOV", Item.TIPO_TabMOV, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMOV", Item.TIPO_CodMOV, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabEST", Item.CONS_TabEST, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEST", Item.CONS_CodEST, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_AsientoContable", Item.MOVI_AsientoContable, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_Numero", Item.MOVI_Numero, SqlDbType.VarChar, 15, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmMOVI_FecEmision", Item.MOVI_FecEmision, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_Concepto", Item.MOVI_Concepto, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_OrdenDe", Item.MOVI_OrdenDe, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecMOVI_MontoDebe", Item.MOVI_MontoDebe, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecMOVI_TipoCambio", Item.MOVI_TipoCambio, SqlDbType.Decimal, 6, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecMOVI_MontoHaber", Item.MOVI_MontoHaber, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_Agrupacion", Item.MOVI_Agrupacion, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitMOVI_Cheque", Item.MOVI_Cheque, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrMOVI_EstadoCheque", Item.MOVI_EstadoCheque, SqlDbType.Char, 12, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_UserEntregaCheque", Item.MOVI_UserEntregaCheque, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmMOVI_FecEntregaCheque", Item.MOVI_FecEntregaCheque, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmMOVI_FecDiferido", Item.MOVI_FecDiferido, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitMOVI_ChequeImpreso", Item.MOVI_ChequeImpreso, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_UserAnulacion", Item.MOVI_UserAnulacion, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmMOVI_FecAnulacion", Item.MOVI_FecAnulacion, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_GlosaAnulacion", Item.MOVI_GlosaAnulacion, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_NroOperacion", Item.MOVI_NroOperacion, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_NroOficina", Item.MOVI_NroOficina, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_Referencia", Item.MOVI_Referencia, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmMOVI_FecVigencia", Item.MOVI_FecVigencia, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_Responsable", Item.MOVI_Responsable, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecMOVI_MontoLimite", Item.MOVI_MontoLimite, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabDES", Item.TIPO_TabDES, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodDES", Item.TIPO_CodDES, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecMOVI_MontoDescuadre", Item.MOVI_MontoDescuadre, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", Item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               { return true; }
               else
               { return false; }
            }
            else
            { return true; }
         }
         catch (Exception)
         { throw; }
      }

      private bool DeleteChequeBlanco(ref Movimiento Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_MOVISD_UnRegChequeBlanco");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintMOVI_Codigo", Item.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               { return true; }
               else
               { return false; }
            }
            else
            { return true; }
         }
         catch (Exception)
         { throw; }
      }

      private bool UpdateEjecutarDiferido(ref Movimiento Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_MOVISU_UnRegEjecutarDiferido");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintMOVI_Codigo", Item.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCUBA_Codigo", Item.CUBA_Codigo, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmMOVI_FecEjecutado", Item.MOVI_FecEjecutado, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_NroOperacion", Item.MOVI_NroOperacion, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMOV_Dif", Item.TIPO_CodMOV, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", Item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);
               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               { return true; }
               else
               { return false; }
            }
            else
            { return true; }
         }
         catch (Exception)
         { throw; }
      }
      
      private bool UpdatePlanilla(ref Movimiento Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_MOVISU_UnRegPlanilla");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintMOVI_Codigo", Item.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrPLAN_Tipo", Item.PLAN_Tipo, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchPLAN_Codigo", Item.PLAN_Codigo, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", Item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);
               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               { return true; }
               else
               { return false; }
            }
            else
            { return true; }
         }
         catch (Exception)
         { throw; }
      }

      private bool UpdateRediferirMovimiento(ref Movimiento Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_MOVISU_UnRegRediferirMovimiento");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintMOVI_Codigo", Item.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmMOVI_FecDiferido", Item.MOVI_FecDiferido, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", Item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);
               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               { return true; }
               else
               { return false; }
            }
            else
            { return true; }
         }
         catch (Exception)
         { throw; }
      }

      private bool UpdateConciliacion(ref Movimiento Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_MOVISU_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", Item.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintMOVI_Codigo", Item.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintMOVI_CodPadre", Item.MOVI_CodPadre, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinSUCR_Codigo", Item.SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCUBA_Codigo", Item.CUBA_Codigo, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrPLAN_Tipo", Item.PLAN_Tipo, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchPLAN_Codigo", Item.PLAN_Codigo, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintTRAN_Codigo", Item.TRAN_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinTIPE_Codigo", Item.TIPE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", Item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMOV", Item.TIPO_TabMOV, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMOV", Item.TIPO_CodMOV, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabEST", Item.CONS_TabEST, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEST", Item.CONS_CodEST, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabDES", Item.TIPO_TabDES, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodDES", Item.TIPO_CodDES, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabSerie", Item.TIPO_TabSerie, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodSerie", Item.TIPO_CodSerie, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintMOVI_DocNumero", Item.MOVI_DocNumero, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_AsientoContable", Item.MOVI_AsientoContable, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_Numero", Item.MOVI_Numero, SqlDbType.VarChar, 15, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmMOVI_FecEmision", Item.MOVI_FecEmision, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_Concepto", Item.MOVI_Concepto, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_OrdenDe", Item.MOVI_OrdenDe, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecMOVI_MontoDebe", Item.MOVI_MontoDebe, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecMOVI_TipoCambio", Item.MOVI_TipoCambio, SqlDbType.Decimal, 6, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecMOVI_MontoHaber", Item.MOVI_MontoHaber, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_Agrupacion", Item.MOVI_Agrupacion, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitMOVI_Cheque", Item.MOVI_Cheque, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrMOVI_EstadoCheque", Item.MOVI_EstadoCheque, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_UserEntregaCheque", Item.MOVI_UserEntregaCheque, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmMOVI_FecEntregaCheque", Item.MOVI_FecEntregaCheque, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmMOVI_FecDiferido", Item.MOVI_FecDiferido, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmMOVI_FecDiferidoAnterior", Item.MOVI_FecDiferidoAnterior, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitMOVI_ChequeImpreso", Item.MOVI_ChequeImpreso, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_UserAnulacion", Item.MOVI_UserAnulacion, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmMOVI_FecAnulacion", Item.MOVI_FecAnulacion, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_GlosaAnulacion", Item.MOVI_GlosaAnulacion, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_NroOperacion", Item.MOVI_NroOperacion, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_NroOficina", Item.MOVI_NroOficina, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_Referencia", Item.MOVI_Referencia, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmMOVI_FecVigencia", Item.MOVI_FecVigencia, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchMOVI_Responsable", Item.MOVI_Responsable, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecMOVI_MontoLimite", Item.MOVI_MontoLimite, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecMOVI_MontoDescuadre", Item.MOVI_MontoDescuadre, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmMOVI_FecEjecutado", Item.MOVI_FecEjecutado, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmMOVI_FecOperacion", Item.MOVI_FecOperacion, SqlDbType.DateTime, 8, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", Item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               { return true; }
               else
               { return false; }
            }
            else
            { return true; }
         }
         catch (Exception)
         { throw; }
      }

		#endregion
	}
}
