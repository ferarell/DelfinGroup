using Infrastructure.Aspect.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Delfin.BusinessLogic
{
   public class GAsientos
   {
      #region [ Variables ]

      public enum TipoRegistro
      {
         RegistroCompras = 1, RegistroVentas = 2, RegistroCaja = 3, DiarioGeneral = 4, LibroPlanillas = 5
      }

      #endregion

      #region [ Propiedades ]

      public enum TipoAsiento
      {
         AsientoCompra_SLI = 0, AsientoVenta = 1, AsientoCompra_ILD = 2, AsientoCaja = 3, AsientoSTATEMENT = 4, AsientoCajaDiferido = 5, AsientoTransferencia = 6
      }

      public enum TipoActualizar
      {
         Auto = 0, RegistroCompras = 1, DiarioGeneral = 2, RegistroCaja = 3, RegistroCaja_EDiferido = 4
      }

      public TipoAsiento TAsiento { get; set; }
      public Entities.CtaCte ItemCtaCte { get; set; }
      public Entities.DocsVta ItemDocsVta { get; set; }
      public Entities.Movimiento ItemMovimiento { get; set; }
      public Entities.NaveViaje ItemNaveViaje { get; set; }
      public Entities.Transferencia ItemTransferencia { get; set; }

      public Int16 SUCR_Codigo { get; set; }
      public String CABA_Ano { get; set; }
      public String CABA_Mes { get; set; }
      public String TIPO_TabREG { get; set; }
      public String TIPO_CodReg { get; set; }
      public String CABA_NroVoucher { get; set; }

      public String CABA_Ano_DC { get; set; }
      public String CABA_Mes_DC { get; set; }
      public String TIPO_TabREG_DC { get; set; }
      public String TIPO_CodReg_DC { get; set; }
      public String CABA_NroVoucher_DC { get; set; }

      public enum TipoItem
      {
         CtaCte = 0, Movimiento = 1, DocVta = 2, NaveViaje = 3
      }

      #endregion

      #region [ Constructores ]

      public GAsientos(TipoAsiento x_tasiento)
      {
         try
         {
            TAsiento = x_tasiento;
         }
         catch (Exception)
         { throw; }
      }

      public BLParametros BL_Parametros { get; set; }

      #endregion

      #region [ Metodos ]

    public String GenerarVoucherBD(String x_usuario, TipoActualizar x_opcion = TipoActualizar.Auto)
      {
         try
         {
            string _NroVoucher = "";
            switch (TAsiento)
            {
               case TipoAsiento.AsientoCompra_SLI:
                  DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSI_GenerarAsientoCompras_SLI_V1");
                  DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", ItemCtaCte.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                  DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", ItemCtaCte.CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                  DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_Usuario", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
                  _NroVoucher = DataAccessEnterpriseSQL.DAExecuteScalar().ToString();
                  //DataAccessEnterpriseSQL.DAExecuteScalar();
                  return _NroVoucher;
                  break;
               case TipoAsiento.AsientoCompra_ILD:
                  String NroDocumento = "";
                  BL_Parametros = new BLParametros(null);
                  Entities.Parametros para = BL_Parametros.GetOneByClave("GAS_DOc_PEN");
                  if (para != null) { NroDocumento = para.PARA_Valor; }
                  DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSI_GenerarAsientoCompras_ILD_V1");
                  DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", ItemCtaCte.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                  DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", ItemCtaCte.CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                  DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_Usuario", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
                  _NroVoucher = DataAccessEnterpriseSQL.DAExecuteScalar().ToString();
                  return _NroVoucher;
                  break;
                default:
                break;
             }
         }
         catch (Exception)
         { throw; }
         return "";
    }

      public Boolean GenerarAsientoBD(String x_usuario, TipoActualizar x_opcion = TipoActualizar.Auto)
      {
         try
         {

            switch (TAsiento)
            {
               case TipoAsiento.AsientoCompra_SLI:
                  DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSI_GenerarAsientoCompras_SLI");
                  DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", ItemCtaCte.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                  DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", ItemCtaCte.CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                  DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_Usuario", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
                  return DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0;
                  break;
               case TipoAsiento.AsientoCompra_ILD:
                  String NroDocumento = "";
                  BL_Parametros = new BLParametros(null);
                  Entities.Parametros para = BL_Parametros.GetOneByClave("GAS_DOc_PEN");
                  if (para != null) { NroDocumento = para.PARA_Valor; }

                  DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSI_GenerarAsientoCompras_ILD");
                  DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", ItemCtaCte.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                  DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", ItemCtaCte.CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                  DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_Usuario", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);

                  //if (!String.IsNullOrEmpty(ItemCtaCte.CCCT_Numero_Original) && ItemCtaCte.CCCT_Numero_Original.Length > 2 && ItemCtaCte.CCCT_Numero_Original.Substring(0, 3).Equals(NroDocumento) && ItemCtaCte.CCCT_Numero_Original != ItemCtaCte.CCCT_Numero)
                  //{ DataAccessEnterpriseSQL.DAAgregarParametro("@Reversion", true, SqlDbType.Bit, 20, ParameterDirection.Input); }
                  //else if (String.IsNullOrEmpty(ItemCtaCte.CCCT_Numero_Original) && !String.IsNullOrEmpty(ItemCtaCte.CCCT_Numero))
                  //{ DataAccessEnterpriseSQL.DAAgregarParametro("@Reversion", true, SqlDbType.Bit, 20, ParameterDirection.Input); }

                  return DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0;
                  break;
               case TipoAsiento.AsientoVenta:
                  break;

               case TipoAsiento.AsientoCaja:
                        DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_MOVISI_GenerarAsientoCaja");
                        DataAccessEnterpriseSQL.DAAgregarParametro("@EMPR_Codigo", ItemMovimiento.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                        DataAccessEnterpriseSQL.DAAgregarParametro("@MOVI_Codigo", ItemMovimiento.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                        DataAccessEnterpriseSQL.DAAgregarParametro("@AUDI_Usuario", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
                        return DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0;
                        break;
               case TipoAsiento.AsientoSTATEMENT:
                  DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASS_GenerarAsientoStatement");
                  DataAccessEnterpriseSQL.DAAgregarParametro("@EMPR_Codigo", ItemNaveViaje.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                  DataAccessEnterpriseSQL.DAAgregarParametro("@SUCR_Codigo", ItemNaveViaje.SUCR_Codigo.ToString("00"), SqlDbType.Char, 2, ParameterDirection.Input);
                  DataAccessEnterpriseSQL.DAAgregarParametro("@NVIA_Codigo", ItemNaveViaje.NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                  DataAccessEnterpriseSQL.DAAgregarParametro("@AUDI_Usuario", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
                  return DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0;
                  break;
               case TipoAsiento.AsientoCajaDiferido:
                  DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_MOVISI_GenerarAsientoCaja_EjecDiferido");
                  DataAccessEnterpriseSQL.DAAgregarParametro("@EMPR_Codigo", ItemMovimiento.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                  DataAccessEnterpriseSQL.DAAgregarParametro("@MOVI_Codigo", ItemMovimiento.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                  DataAccessEnterpriseSQL.DAAgregarParametro("@AUDI_Usuario", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
                  return DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0;
                  break;
               case TipoAsiento.AsientoTransferencia:
                  DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_TRANSI_GenerarAsientoTransferencia");
                  DataAccessEnterpriseSQL.DAAgregarParametro("@EMPR_Codigo", ItemTransferencia.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                  DataAccessEnterpriseSQL.DAAgregarParametro("@TRAN_Codigo", ItemTransferencia.TRAN_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                  DataAccessEnterpriseSQL.DAAgregarParametro("@AUDI_Usuario", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
                  return DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0;
                  break;
               default:
                  break;
            }
         }
         catch (Exception)
         { throw; }
         return false;
      }

        public Boolean GenerarAsientoSAP(String x_usuario, TipoActualizar x_opcion = TipoActualizar.Auto)
        {
            try
            {

                switch (TAsiento)
                {
                    case TipoAsiento.AsientoCompra_SLI:
                        DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSI_GenerarAsientoCompras_SLI");
                        DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", ItemCtaCte.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                        DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", ItemCtaCte.CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                        DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_Usuario", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
                        return DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0;
                        break;
                    case TipoAsiento.AsientoCompra_ILD:
                        String NroDocumento = "";
                        BL_Parametros = new BLParametros(null);
                        Entities.Parametros para = BL_Parametros.GetOneByClave("GAS_DOc_PEN");
                        if (para != null) { NroDocumento = para.PARA_Valor; }

                        DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSI_GenerarAsientoCompras_ILD");
                        DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", ItemCtaCte.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                        DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", ItemCtaCte.CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                        DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_Usuario", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);

                        //if (!String.IsNullOrEmpty(ItemCtaCte.CCCT_Numero_Original) && ItemCtaCte.CCCT_Numero_Original.Length > 2 && ItemCtaCte.CCCT_Numero_Original.Substring(0, 3).Equals(NroDocumento) && ItemCtaCte.CCCT_Numero_Original != ItemCtaCte.CCCT_Numero)
                        //{ DataAccessEnterpriseSQL.DAAgregarParametro("@Reversion", true, SqlDbType.Bit, 20, ParameterDirection.Input); }
                        //else if (String.IsNullOrEmpty(ItemCtaCte.CCCT_Numero_Original) && !String.IsNullOrEmpty(ItemCtaCte.CCCT_Numero))
                        //{ DataAccessEnterpriseSQL.DAAgregarParametro("@Reversion", true, SqlDbType.Bit, 20, ParameterDirection.Input); }

                        return DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0;
                        break;
                    case TipoAsiento.AsientoVenta:
                        break;

                    case TipoAsiento.AsientoCaja:
                        DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_MOVISI_GenerarAsientoCaja");
                        DataAccessEnterpriseSQL.DAAgregarParametro("@EMPR_Codigo", ItemMovimiento.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                        DataAccessEnterpriseSQL.DAAgregarParametro("@MOVI_Codigo", ItemMovimiento.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                        DataAccessEnterpriseSQL.DAAgregarParametro("@AUDI_Usuario", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
                        return DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0;
                        break;
                    case TipoAsiento.AsientoSTATEMENT:
                        DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASS_GenerarAsientoStatement");
                        DataAccessEnterpriseSQL.DAAgregarParametro("@EMPR_Codigo", ItemNaveViaje.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                        DataAccessEnterpriseSQL.DAAgregarParametro("@SUCR_Codigo", ItemNaveViaje.SUCR_Codigo.ToString("00"), SqlDbType.Char, 2, ParameterDirection.Input);
                        DataAccessEnterpriseSQL.DAAgregarParametro("@NVIA_Codigo", ItemNaveViaje.NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                        DataAccessEnterpriseSQL.DAAgregarParametro("@AUDI_Usuario", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
                        return DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0;
                        break;
                    case TipoAsiento.AsientoCajaDiferido:
                        DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_MOVISI_GenerarAsientoCaja_EjecDiferido");
                        DataAccessEnterpriseSQL.DAAgregarParametro("@EMPR_Codigo", ItemMovimiento.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                        DataAccessEnterpriseSQL.DAAgregarParametro("@MOVI_Codigo", ItemMovimiento.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                        DataAccessEnterpriseSQL.DAAgregarParametro("@AUDI_Usuario", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
                        return DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0;
                        break;
                    case TipoAsiento.AsientoTransferencia:
                        DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_TRANSI_GenerarAsientoTransferencia");
                        DataAccessEnterpriseSQL.DAAgregarParametro("@EMPR_Codigo", ItemTransferencia.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                        DataAccessEnterpriseSQL.DAAgregarParametro("@TRAN_Codigo", ItemTransferencia.TRAN_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                        DataAccessEnterpriseSQL.DAAgregarParametro("@AUDI_Usuario", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
                        return DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            { throw; }
            return false;
        }

        /// <summary>
        /// Generar Asientos
        /// </summary>
        /// <param name="x_usuario">The x usuario.</param>
        /// <param name="x_SUCR_Codigo">The x sucr codigo.</param>
        /// <param name="x_opcion">The x opcion.</param>
        /// <returns></returns>
        public Boolean GenerarAsiento(String x_usuario, Int16 x_SUCR_Codigo, TipoActualizar x_opcion = TipoActualizar.Auto)
      {
         try
         {
            String x_TIPO_TipReg = "001";
            SUCR_Codigo = x_SUCR_Codigo;
            switch (TAsiento)
            {
               case TipoAsiento.AsientoCompra_SLI:
                  x_TIPO_TipReg = getTipoRegistro(getPTipoRegistro(GAsientos.TipoRegistro.RegistroCompras));
                  return GAsientoCompra_SLI(x_usuario, x_TIPO_TipReg);
                  break;
               case TipoAsiento.AsientoVenta:
                  x_TIPO_TipReg = getTipoRegistro(getPTipoRegistro(GAsientos.TipoRegistro.RegistroVentas));
                  return GAsientoVenta(x_usuario, x_TIPO_TipReg);
                  break;
               case TipoAsiento.AsientoCompra_ILD:
                  x_TIPO_TipReg = getTipoRegistro(getPTipoRegistro(GAsientos.TipoRegistro.RegistroCompras));
                  return GAsientoCompra_ILD(x_usuario, x_TIPO_TipReg, x_opcion);
                  break;
               case TipoAsiento.AsientoCaja:
                  x_TIPO_TipReg = getTipoRegistro(getPTipoRegistro(GAsientos.TipoRegistro.RegistroCaja));
                  return GAsientoCaja(x_usuario, x_TIPO_TipReg);
               case TipoAsiento.AsientoSTATEMENT:
                  x_TIPO_TipReg = getTipoRegistro(getPTipoRegistro(GAsientos.TipoRegistro.DiarioGeneral));
                  return GAsientoStatement(x_usuario, x_TIPO_TipReg);
                  break;
               case TipoAsiento.AsientoCajaDiferido:
                  x_TIPO_TipReg = getTipoRegistro(getPTipoRegistro(GAsientos.TipoRegistro.RegistroCaja));
                  return GAsientoCaja(x_usuario, x_TIPO_TipReg);
               default:
                  break;
            }
         }
         catch (Exception)
         { throw; }
         return false;
      }

      /// <summary>
      /// Actualización de Asiento
      /// </summary>
      /// <param name="x_usuario">The x usuario.</param>
      /// <param name="x_SUCR_Codigo">The x sucr codigo.</param>
      /// <returns></returns>
      public Boolean ActualizarAsiento(String x_usuario, Int16 x_SUCR_Codigo, TipoActualizar x_opcion = TipoActualizar.Auto)
      {
         try
         {
            String x_TIPO_TipReg = "001";
            SUCR_Codigo = x_SUCR_Codigo;
            switch (TAsiento)
            {
               case TipoAsiento.AsientoCompra_SLI:
                  x_TIPO_TipReg = getTipoRegistro(getPTipoRegistro(GAsientos.TipoRegistro.RegistroCompras));
                  //return UAsientoCompra_SLI(x_usuario, x_TIPO_TipReg);
                  break;
               case TipoAsiento.AsientoVenta:
                  x_TIPO_TipReg = getTipoRegistro(getPTipoRegistro(GAsientos.TipoRegistro.RegistroVentas));
                  //return UAsientoVenta(x_usuario, x_TIPO_TipReg);
                  break;
               case TipoAsiento.AsientoCompra_ILD:
                  x_TIPO_TipReg = getTipoRegistro(getPTipoRegistro(GAsientos.TipoRegistro.RegistroCompras));
                  return UAsientoCompra_ILD(x_usuario, x_opcion);
                  break;
               case TipoAsiento.AsientoCaja:
                  x_TIPO_TipReg = getTipoRegistro(getPTipoRegistro(GAsientos.TipoRegistro.RegistroCaja));
                  return UAsientoCaja(x_usuario);
               default:
                  break;
            }
         }
         catch (Exception)
         { throw; }
         return false;
      }

      public String getTipoRegistro(String PARA_Clave)
      {
         String x_TIPO_TipReg = "001";
         try
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_CONSULTAR_Parametros");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchPARA_Clave", PARA_Clave, SqlDbType.VarChar, 20, ParameterDirection.Input);
            DataSet ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
               x_TIPO_TipReg = ds.Tables[0].Rows[0]["PARA_Valor"].ToString();
            }
         }
         catch (Exception)
         { throw; }
         return x_TIPO_TipReg;
      }

      #region [ Generar Asientos ]

      #region [ Asiento de Compra ]

      /// <summary>
      /// Generar Asiento del Módulo de Servicio Logistico
      /// </summary>
      /// <param name="x_usuario">The x usuario.</param>
      /// <param name="x_TIPO_TipReg">The x tipo tip reg.</param>
      /// <returns></returns>
      /// <exception cref="Exception">No se ha inicializado el registro para la generación del asiento</exception>
      private Boolean GAsientoCompra_SLI(String x_usuario, String x_TIPO_TipReg)
      {
         try
         {
            if (ItemCtaCte != null)
            {
               DataSet dsAsiento = new DataSet();

               String x_glosa = "";

               if (!ItemCtaCte.TIPO_CodFPG.Equals("001") && ItemCtaCte.CCCT_FecReg.Value.ToString("yyyyMM") != ItemCtaCte.CCCT_FechaVcto.Value.ToString("yyyyMM"))
               { x_TIPO_TipReg = getTipoRegistro(getPTipoRegistro(GAsientos.TipoRegistro.DiarioGeneral)); }

               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSS_AsientoCompras_SLI");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", ItemCtaCte.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", ItemCtaCte.CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@Glosa", x_glosa, SqlDbType.VarChar, 100, ParameterDirection.InputOutput);
               dsAsiento = DataAccessEnterpriseSQL.DAExecuteDataSet();

               if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@Glosa"].Value != null)
               { x_glosa = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@Glosa"].Value.ToString().Trim(); }

               return CompletarGAsiento(dsAsiento, x_usuario, x_TIPO_TipReg, x_glosa);
            }
            else { throw new Exception("No se ha inicializado el registro para la generación del asiento"); }
         }
         catch (Exception)
         { throw; }
         return false;
      }

      /// <summary>
      /// Generar Asiento del Módulo Ingreso de Documento Libre
      /// </summary>
      /// <param name="x_usuario">The x usuario.</param>
      /// <param name="x_TIPO_TipReg">The x tipo tip reg.</param>
      /// <returns></returns>
      /// <exception cref="Exception">No se ha inicializado el registro para la generación del asiento</exception>
      private Boolean GAsientoCompra_ILD(String x_usuario, String x_TIPO_TipReg, TipoActualizar x_opcion = TipoActualizar.Auto)
      {
         try
         {
            if (ItemCtaCte != null)
            {
               DataSet dsAsiento = new DataSet();
               String x_glosa = "";
               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSS_AsientoCompras_ILD");

               if (ItemCtaCte.CCCT_FechaVcto.HasValue && !String.IsNullOrEmpty(ItemCtaCte.TIPO_CodFPG) && !ItemCtaCte.TIPO_CodFPG.Equals("001")
                   && ItemCtaCte.CCCT_FecReg.Value.ToString("yyyyMM") != ItemCtaCte.CCCT_FechaVcto.Value.ToString("yyyyMM")
                   && !ItemCtaCte.TIPO_CodDetrac.Equals("001"))
               {
                  if (!String.IsNullOrEmpty(ItemCtaCte.CCCT_NroDetraccion) && ItemCtaCte.CCCT_FecDetraccion.HasValue)
                  {
                     if (x_opcion == TipoActualizar.RegistroCompras)
                     {
                        x_TIPO_TipReg = getTipoRegistro(getPTipoRegistro(GAsientos.TipoRegistro.RegistroCompras));
                        DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSS_AsientoCompras_ILD_Reversion");
                     }
                     else if (x_opcion == TipoActualizar.Auto)
                     {
                        x_TIPO_TipReg = getTipoRegistro(getPTipoRegistro(GAsientos.TipoRegistro.RegistroCompras));
                        DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSS_AsientoCompras_ILD");
                     }
                     else if (x_opcion == TipoActualizar.DiarioGeneral)
                     {
                        x_TIPO_TipReg = getTipoRegistro(getPTipoRegistro(GAsientos.TipoRegistro.DiarioGeneral));
                        DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSS_AsientoCompras_ILD");
                     }
                  }
                  else
                  {
                     x_TIPO_TipReg = getTipoRegistro(getPTipoRegistro(GAsientos.TipoRegistro.DiarioGeneral));
                     DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSS_AsientoCompras_ILD");
                  }
               }
               //else
               //{ x_TIPO_TipReg = getTipoRegistro(getPTipoRegistro(GAsientos.TipoRegistro.RegistroCompras)); }

               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", ItemCtaCte.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", ItemCtaCte.CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@Glosa", x_glosa, SqlDbType.VarChar, 100, ParameterDirection.InputOutput);
               dsAsiento = DataAccessEnterpriseSQL.DAExecuteDataSet();

               if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@Glosa"].Value != null)
               { x_glosa = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@Glosa"].Value.ToString().Trim(); }

               return CompletarGAsiento(dsAsiento, x_usuario, x_TIPO_TipReg, x_glosa);
            }
            else { throw new Exception("No se ha inicializado el registro para la generación del asiento"); }
         }
         catch (Exception)
         { throw; }
         return false;
      }

      /// <summary>
      /// Actualizar Asiento del Módulo Ingreso de Documento Libre
      /// </summary>
      /// <param name="x_usuario">The x usuario.</param>
      /// <param name="x_TIPO_TipReg">The x tipo tip reg.</param>
      /// <returns></returns>
      /// <exception cref="Exception">No se ha inicializado el registro para la generación del asiento</exception>
      private Boolean UAsientoCompra_ILD(String x_usuario, TipoActualizar x_opcion = TipoActualizar.Auto)
      {
         try
         {
            if (ItemCtaCte != null)
            {
               DataSet dsAsiento = new DataSet();

               String x_glosa = "";

               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSS_AsientoCompras_ILD");
               switch (x_opcion)
               {
                  case TipoActualizar.Auto:
                     break;
                  case TipoActualizar.RegistroCompras:
                     DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSS_AsientoCompras_ILD_Reversion");
                     break;
                  case TipoActualizar.DiarioGeneral:
                     break;
                  default:
                     break;
               }

               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", ItemCtaCte.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", ItemCtaCte.CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@Glosa", x_glosa, SqlDbType.VarChar, 100, ParameterDirection.InputOutput);
               dsAsiento = DataAccessEnterpriseSQL.DAExecuteDataSet();

               if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@Glosa"].Value != null)
               { x_glosa = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@Glosa"].Value.ToString().Trim(); }

               return CompletarUAsiento(dsAsiento, x_usuario, x_glosa, TipoItem.CtaCte, x_opcion);
            }
            else { throw new Exception("No se ha inicializado el registro para la generación del asiento"); }
         }
         catch (Exception)
         { throw; }
         return false;
      }

      #endregion

      #region [ Asientos de Ventas ]

      /// <summary>
      /// Generación de Asientos de Venta
      /// </summary>
      /// <param name="x_usuario">The x usuario.</param>
      /// <param name="x_TIPO_TipReg">The x tipo tip reg.</param>
      /// <returns></returns>
      /// <exception cref="System.Exception">No se ha inicializado el registro para la generación del asiento</exception>
      private Boolean GAsientoVenta(String x_usuario, String x_TIPO_TipReg)
      {
         try
         {
            if (ItemCtaCte != null)
            {
               DataSet dsAsiento = new DataSet();

               String x_glosa = "";

               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSS_AsientoVentas");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", ItemCtaCte.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", ItemCtaCte.CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@Glosa", x_glosa, SqlDbType.VarChar, 100, ParameterDirection.InputOutput);
               dsAsiento = DataAccessEnterpriseSQL.DAExecuteDataSet();

               if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@Glosa"].Value != null)
               { x_glosa = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@Glosa"].Value.ToString().Trim(); }

               return CompletarGAsiento(dsAsiento, x_usuario, x_TIPO_TipReg, x_glosa);
            }
            else { throw new Exception("No se ha inicializado el registro para la generación del asiento"); }
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Asientos de Caja ]

      /// <summary>
      /// Generación de Asientos de Caja
      /// </summary>
      /// <param name="x_usuario">The x usuario.</param>
      /// <param name="x_TIPO_TipReg">The x tipo tip reg.</param>
      /// <returns></returns>
      /// <exception cref="System.Exception">No se ha inicializado el registro para la generación del asiento</exception>
      private Boolean GAsientoCaja(String x_usuario, String x_TIPO_TipReg)
      {
         try
         {
            if (ItemMovimiento != null)
            {
               DataSet dsAsiento = new DataSet();

               String x_glosa = "";

               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_MOVISS_AsientoCaja");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", ItemMovimiento.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintMOVI_Codigo", ItemMovimiento.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@Glosa", x_glosa, SqlDbType.VarChar, 100, ParameterDirection.InputOutput);
               dsAsiento = DataAccessEnterpriseSQL.DAExecuteDataSet();

               if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@Glosa"].Value != null)
               { x_glosa = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@Glosa"].Value.ToString().Trim(); }

               switch (ItemMovimiento.GetTipoMovimiento())
               {
                  case Delfin.Entities.Movimiento.TipoMovimiento.Ingresos:
                     if (ItemMovimiento.ItemCuentasBancarias.CUBA_CtaEmprVinculada)
                     {
                        TIPO_CodReg = getTipoRegistro(getPTipoRegistro(TipoRegistro.DiarioGeneral));
                        TIPO_CodReg_DC = getTipoRegistro(getPTipoRegistro(TipoRegistro.RegistroCaja));
                     }
                     else
                     { TIPO_CodReg = getTipoRegistro(getPTipoRegistro(TipoRegistro.RegistroCaja)); }

                     break;
                  case Delfin.Entities.Movimiento.TipoMovimiento.IngresosDiferidos:
                     TIPO_CodReg = getTipoRegistro(getPTipoRegistro(TipoRegistro.DiarioGeneral));
                     TIPO_CodReg_DC = getTipoRegistro(getPTipoRegistro(TipoRegistro.DiarioGeneral));
                     break;
                  case Delfin.Entities.Movimiento.TipoMovimiento.EgresosDepositos:
                     if (ItemMovimiento.ItemCuentasBancarias.CUBA_CtaEmprVinculada)
                     {
                        TIPO_CodReg = getTipoRegistro(getPTipoRegistro(TipoRegistro.DiarioGeneral));
                        TIPO_CodReg_DC = getTipoRegistro(getPTipoRegistro(TipoRegistro.RegistroCaja));
                     }
                     else
                     { TIPO_CodReg = getTipoRegistro(getPTipoRegistro(TipoRegistro.RegistroCaja)); }
                     break;
                  case Delfin.Entities.Movimiento.TipoMovimiento.EgresosCheque:
                     if (ItemMovimiento.ItemCuentasBancarias.CUBA_CtaEmprVinculada)
                     {
                        TIPO_CodReg = getTipoRegistro(getPTipoRegistro(TipoRegistro.DiarioGeneral));
                        TIPO_CodReg_DC = getTipoRegistro(getPTipoRegistro(TipoRegistro.RegistroCaja));
                     }
                     else
                     { TIPO_CodReg = getTipoRegistro(getPTipoRegistro(TipoRegistro.RegistroCaja)); }
                     break;
                  case Delfin.Entities.Movimiento.TipoMovimiento.EgresosChequeDiferido:
                     TIPO_CodReg = getTipoRegistro(getPTipoRegistro(TipoRegistro.DiarioGeneral));
                     TIPO_CodReg_DC = getTipoRegistro(getPTipoRegistro(TipoRegistro.DiarioGeneral));
                     break;
                  case Delfin.Entities.Movimiento.TipoMovimiento.EgresosTransferenciaCuentasPropias:
                     break;
                  case Delfin.Entities.Movimiento.TipoMovimiento.EgresosTransferenciaMVirtual:
                     break;
                  case Delfin.Entities.Movimiento.TipoMovimiento.IngresosTransferenciaCuentasPropias:
                     break;
                  default:
                     break;
               }

               if (dsAsiento.Tables.Count == 1)
               {
                  x_TIPO_TipReg = TIPO_CodReg; TIPO_CodReg = null;
                  return CompletarGAsiento(dsAsiento, x_usuario, x_TIPO_TipReg, x_glosa);
               }
               else
               { return CompletarGAsientoCaja(dsAsiento, x_usuario, x_TIPO_TipReg, x_glosa); }


            }
            else { throw new Exception("No se ha inicializado el registro para la generación del asiento"); }
         }
         catch (Exception)
         { throw; }
         return false;
      }

      /// <summary>
      /// Actualización de Asientos de Caja
      /// </summary>
      /// <param name="x_usuario">The x usuario.</param>
      /// <returns></returns>
      /// <exception cref="System.Exception">No se ha inicializado el registro para la generación del asiento</exception>
      private Boolean UAsientoCaja(String x_usuario)
      {
         try
         {
            if (ItemMovimiento != null)
            {
               DataSet dsAsiento = new DataSet();

               String x_glosa = "";

               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_MOVISS_AsientoCaja");
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", ItemMovimiento.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintMOVI_Codigo", ItemMovimiento.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@Glosa", x_glosa, SqlDbType.VarChar, 100, ParameterDirection.InputOutput);
               dsAsiento = DataAccessEnterpriseSQL.DAExecuteDataSet();

               if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@Glosa"].Value != null)
               { x_glosa = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@Glosa"].Value.ToString().Trim(); }

               return CompletarUAsiento(dsAsiento, x_usuario, x_glosa, TipoItem.Movimiento);
            }
            else { throw new Exception("No se ha inicializado el registro para la generación del asiento"); }
         }
         catch (Exception)
         { throw; }
         return false;
      }

      #endregion

      #region [ Asientos de STATEMENT ]

      private Boolean GAsientoStatement(String x_usuario, String x_TIPO_TipReg)
      {
         try
         {
            if (ItemNaveViaje != null)
            {
               DataSet dsAsiento = new DataSet();

               String x_glosa = "";

               DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASS_AsientoStatement");
               //DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", ItemNaveViaje.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", ItemNaveViaje.NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@Glosa", x_glosa, SqlDbType.VarChar, 100, ParameterDirection.InputOutput);
               dsAsiento = DataAccessEnterpriseSQL.DAExecuteDataSet();

               if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@Glosa"].Value != null)
               { x_glosa = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@Glosa"].Value.ToString().Trim(); }

               if (dsAsiento.Tables[0].Rows.Count > 0)
               {
                  return CompletarGAsiento(dsAsiento, x_usuario, x_TIPO_TipReg, x_glosa);
               }
               else { return false; }
            }
            else { throw new Exception("No se ha inicializado el registro para la generación del asiento"); }
         }
         catch (Exception)
         { throw; }
         return false;
      }

      #endregion

      #endregion

      /// <summary>
      /// Completar la generación de los asientos
      /// Envia el asiento en un objeto tabla, preparado con las cuentas contables, y las transfiere a la base de contabilidad, para registrar
      /// el asiento en el sistema de contabilidad
      /// </summary>
      /// <param name="dsAsiento">Objeto Tabla con el conjunto de registros de asientos.</param>
      /// <param name="x_usuario">Usuario que realiza la operación.</param>
      /// <param name="x_TIPO_TipReg">El tipo de registro de  contabilidad: Compras, Ventas, Caja, Diario.</param>
      /// <param name="x_glosa">Glosa para la cabecera del asiento.</param>
      /// <returns>Devuelve la PK del asiento para que en un siguiente proceso se puede actualizar en el documento relacionado al asiento generado</returns>
      private Boolean CompletarGAsiento(DataSet dsAsiento, String x_usuario, String x_TIPO_TipReg, String x_glosa)
      {
         try
         {
            if (dsAsiento.Tables.Count > 0)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSI_GenerarAsiento_FromDelfin");
               DataAccessEnterpriseSQL.DAAgregarParametro("@TablaPreAsientos", dsAsiento.Tables[0], SqlDbType.Structured, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_Usuario", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TipReg", x_TIPO_TipReg, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@CABA_Ano", CABA_Ano, SqlDbType.Char, 4, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@CABA_Mes", CABA_Mes, SqlDbType.Char, 2, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@TIPO_TabREG", TIPO_TabREG, SqlDbType.Char, 3, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@TIPO_CodReg", TIPO_CodReg, SqlDbType.Char, 3, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@CABA_NroVoucher", CABA_NroVoucher, SqlDbType.Char, 6, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@Glosa", x_glosa, SqlDbType.VarChar, 100, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               {
                  if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@CABA_Ano"].Value != null)
                  { CABA_Ano = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@CABA_Ano"].Value.ToString(); }
                  if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@CABA_Mes"].Value != null)
                  { CABA_Mes = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@CABA_Mes"].Value.ToString(); }
                  if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@TIPO_TabREG"].Value != null)
                  { TIPO_TabREG = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@TIPO_TabREG"].Value.ToString(); }
                  if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@TIPO_CodReg"].Value != null)
                  { TIPO_CodReg = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@TIPO_CodReg"].Value.ToString(); }
                  if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@CABA_NroVoucher"].Value != null)
                  { CABA_NroVoucher = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@CABA_NroVoucher"].Value.ToString(); }

                  return true;
               }
               else
               { return false; }
            }
         }
         catch (Exception)
         { throw; }
         return false;
      }

      /// <summary>
      /// Completar el Asiento de Caja
      /// Envia el asiento en un objeto tabla, preparado con las cuentas contables, y las transfiere a la base de contabilidad, para registrar
      /// el asiento en el sistema de contabilidad
      /// El registro de asientos se realiza en las dos bases de contabilidad que tiene la empresa, segun el tipo de cuenta bancaria configurada para el 
      /// registro de caja
      /// </summary>
      /// <param name="dsAsiento">Objeto Tabla con el conjunto de registros de asientos.</param>
      /// <param name="x_usuario">Usuario que realiza la operación.</param>
      /// <param name="x_TIPO_TipReg">El tipo de registro de  contabilidad: Compras, Ventas, Caja, Diario.</param>
      /// <param name="x_glosa">Glosa para la cabecera del asiento.</param>
      /// <returns>Devuelve la PK del asiento para que en un siguiente proceso se puede actualizar en el documento relacionado al asiento generado</returns>
      private Boolean CompletarGAsientoCaja(DataSet dsAsiento, String x_usuario, String x_TIPO_TipReg, String x_glosa)
      {
         try
         {
            if (dsAsiento.Tables.Count > 0)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_MOVISI_GenerarAsiento_FromDelfin");
               DataAccessEnterpriseSQL.DAAgregarParametro("@TablaPreAsientosDG", dsAsiento.Tables[0], SqlDbType.Structured, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@TablaPreAsientosDC", dsAsiento.Tables[1], SqlDbType.Structured, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_Usuario", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrSUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TipReg", x_TIPO_TipReg, SqlDbType.Char, 3, ParameterDirection.Input);

               DataAccessEnterpriseSQL.DAAgregarParametro("@CABA_Ano", CABA_Ano, SqlDbType.Char, 4, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@CABA_Mes", CABA_Mes, SqlDbType.Char, 2, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@TIPO_TabREG", TIPO_TabREG, SqlDbType.Char, 3, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@TIPO_CodReg", TIPO_CodReg, SqlDbType.Char, 3, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@CABA_NroVoucher", CABA_NroVoucher, SqlDbType.Char, 6, ParameterDirection.InputOutput);

               DataAccessEnterpriseSQL.DAAgregarParametro("@CABA_Ano_DC", CABA_Ano_DC, SqlDbType.Char, 4, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@CABA_Mes_DC", CABA_Mes_DC, SqlDbType.Char, 2, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@TIPO_TabREG_DC", TIPO_TabREG_DC, SqlDbType.Char, 3, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@TIPO_CodReg_DC", TIPO_CodReg_DC, SqlDbType.Char, 3, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@CABA_NroVoucher_DC", CABA_NroVoucher_DC, SqlDbType.Char, 6, ParameterDirection.InputOutput);

               DataAccessEnterpriseSQL.DAAgregarParametro("@Glosa", x_glosa, SqlDbType.VarChar, 100, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               {
                  if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@CABA_Ano"].Value != null)
                  { CABA_Ano = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@CABA_Ano"].Value.ToString(); }
                  if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@CABA_Mes"].Value != null)
                  { CABA_Mes = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@CABA_Mes"].Value.ToString(); }
                  if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@TIPO_TabREG"].Value != null)
                  { TIPO_TabREG = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@TIPO_TabREG"].Value.ToString(); }
                  if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@TIPO_CodReg"].Value != null)
                  { TIPO_CodReg = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@TIPO_CodReg"].Value.ToString(); }
                  if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@CABA_NroVoucher"].Value != null)
                  { CABA_NroVoucher = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@CABA_NroVoucher"].Value.ToString(); }

                  if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@CABA_Ano_DC"].Value != null)
                  { CABA_Ano_DC = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@CABA_Ano_DC"].Value.ToString(); }
                  if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@CABA_Mes"].Value != null)
                  { CABA_Mes_DC = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@CABA_Mes_DC"].Value.ToString(); }
                  if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@TIPO_TabREG_DC"].Value != null)
                  { TIPO_TabREG_DC = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@TIPO_TabREG_DC"].Value.ToString(); }
                  if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@TIPO_CodReg_DC"].Value != null)
                  { TIPO_CodReg_DC = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@TIPO_CodReg_DC"].Value.ToString(); }
                  if (DataAccessEnterpriseSQL.DASqlCommand.Parameters["@CABA_NroVoucher_DC"].Value != null)
                  { CABA_NroVoucher_DC = DataAccessEnterpriseSQL.DASqlCommand.Parameters["@CABA_NroVoucher_DC"].Value.ToString(); }

                  return true;
               }
               else
               { return false; }
            }
         }
         catch (Exception)
         { throw; }
         return false;
      }

      /// <summary>
      /// Completar la actualización de los asientos
      /// </summary>
      /// <param name="dsAsiento">The ds asiento.</param>
      /// <param name="x_usuario">The x usuario.</param>
      /// <param name="x_glosa">The x glosa.</param>
      /// <param name="x_TipoItem">The x tipo item.</param>
      /// <returns></returns>
      private Boolean CompletarUAsiento(DataSet dsAsiento, String x_usuario, String x_glosa, TipoItem x_TipoItem, TipoActualizar x_opcion = TipoActualizar.Auto)
      {
         try
         {
            if (dsAsiento.Tables.Count > 0)
            {
               switch (x_TipoItem)
               {
                  case TipoItem.CtaCte:
                     DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSU_GenerarAsiento_FromDelfin");
                     DataAccessEnterpriseSQL.DAAgregarParametro("@TablaPreAsientos", dsAsiento.Tables[0], SqlDbType.Structured, 2, ParameterDirection.Input);
                     DataAccessEnterpriseSQL.DAAgregarParametro("@EMPR_Codigo", ItemCtaCte.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                     DataAccessEnterpriseSQL.DAAgregarParametro("@CCCT_Codigo", ItemCtaCte.CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                     switch (x_opcion)
                     {
                        case TipoActualizar.Auto:
                           break;
                        case TipoActualizar.RegistroCompras:
                           DataAccessEnterpriseSQL.DAAgregarParametro("@TipoAsiento", "C", SqlDbType.Char, 1, ParameterDirection.Input);
                           break;
                        case TipoActualizar.DiarioGeneral:
                           break;
                        default:
                           break;
                     }
                     break;
                  case TipoItem.Movimiento:
                     DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_MOVISU_GenerarAsiento_FromDelfin");
                     DataAccessEnterpriseSQL.DAAgregarParametro("@TablaPreAsientosDG", dsAsiento.Tables[0], SqlDbType.Structured, 2, ParameterDirection.Input);

                     if (dsAsiento.Tables.Count > 1)
                     { DataAccessEnterpriseSQL.DAAgregarParametro("@TablaPreAsientosDC", dsAsiento.Tables[1], SqlDbType.Structured, 2, ParameterDirection.Input); }

                     DataAccessEnterpriseSQL.DAAgregarParametro("@EMPR_Codigo", ItemMovimiento.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                     DataAccessEnterpriseSQL.DAAgregarParametro("@MOVI_Codigo", ItemMovimiento.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                     break;
                  default:
                     break;
               }
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_Usuario", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@Glosa", x_glosa, SqlDbType.VarChar, 100, ParameterDirection.Input);

               if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               { return true; }
               else
               { return false; }
            }
         }
         catch (Exception)
         { throw; }
         return false;
      }

      #region [ Actualizar ]

      /// <summary>
      /// Actualizar los registros de la Tabla CAJ_CtaCte
      /// </summary>
      /// <param name="x_usuario">The x usuario.</param>
      /// <param name="x_opcion">The x opcion.</param>
      /// <returns></returns>
      public Boolean ActualizarCtaCte(String x_usuario, TipoActualizar x_opcion = TipoActualizar.Auto)
      {
         try
         {

            switch (x_opcion)
            {
               case TipoActualizar.RegistroCompras:
                  DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSU_UnRegCtaContableCompras");
                  break;
               case TipoActualizar.DiarioGeneral:
                  DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSU_UnRegCtaContable");
                  break;
               case TipoActualizar.Auto:
                  DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSU_UnRegCtaContable");
                  break;
               default:
                  break;
            }

            DataAccessEnterpriseSQL.DAAgregarParametro("@EMPR_Codigo", ItemCtaCte.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@CCCT_Codigo", ItemCtaCte.CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

            DataAccessEnterpriseSQL.DAAgregarParametro("@TIPO_CodFPG", ItemCtaCte.TIPO_CodFPG, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@CCCT_FechaEmision", ItemCtaCte.CCCT_FechaEmision, SqlDbType.DateTime, 8, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@CCCT_FechaVcto", ItemCtaCte.CCCT_FechaVcto, SqlDbType.DateTime, 8, ParameterDirection.Input);

            DataAccessEnterpriseSQL.DAAgregarParametro("@SUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@CABA_Ano", CABA_Ano, SqlDbType.Char, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@CABA_Mes", CABA_Mes, SqlDbType.Char, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@TIPO_TabREG", TIPO_TabREG, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@TIPO_CodReg", TIPO_CodReg, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@CABA_NroVoucher", CABA_NroVoucher, SqlDbType.Char, 6, ParameterDirection.Input);

            DataAccessEnterpriseSQL.DAAgregarParametro("@AUDI_UsrMod", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);

            if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
            { return true; }
         }
         catch (Exception)
         { throw; }
         return false;
      }

      /// <summary>
      /// Actualizar la tabla CAJ_Movimiento
      /// </summary>
      /// <param name="x_usuario">The x usuario.</param>
      /// <returns></returns>
      public Boolean ActualizarMovimiento(String x_usuario)
      {
         try
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_MOVISU_UnRegCtaContable");
            DataAccessEnterpriseSQL.DAAgregarParametro("@EMPR_Codigo", ItemMovimiento.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@MOVI_Codigo", ItemMovimiento.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

            DataAccessEnterpriseSQL.DAAgregarParametro("@SUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@CABA_Ano", CABA_Ano, SqlDbType.Char, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@CABA_Mes", CABA_Mes, SqlDbType.Char, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@TIPO_TabREG", TIPO_TabREG, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@TIPO_CodREG", TIPO_CodReg, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@CABA_NroVoucher", CABA_NroVoucher, SqlDbType.Char, 6, ParameterDirection.Input);

            DataAccessEnterpriseSQL.DAAgregarParametro("@CABA_Ano_DC", CABA_Ano_DC, SqlDbType.Char, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@CABA_Mes_DC", CABA_Mes_DC, SqlDbType.Char, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@TIPO_TabREG_DC", TIPO_TabREG_DC, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@TIPO_CodREG_DC", TIPO_CodReg_DC, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@CABA_NroVoucher_DC", CABA_NroVoucher_DC, SqlDbType.Char, 6, ParameterDirection.Input);

            DataAccessEnterpriseSQL.DAAgregarParametro("@AUDI_UsrMod", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);

            if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
            { return true; }
         }
         catch (Exception)
         { throw; }
         return false;
      }

      public Boolean ActualizarNaveViaje(String x_usuario)
      {
         try
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NVIASU_UnRegCtaContable");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintNVIA_Codigo", ItemNaveViaje.NVIA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

            DataAccessEnterpriseSQL.DAAgregarParametro("@SUCR_Codigo", SUCR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);

            DataAccessEnterpriseSQL.DAAgregarParametro("@CABA_Ano", CABA_Ano, SqlDbType.Char, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@CABA_Mes", CABA_Mes, SqlDbType.Char, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@TIPO_TabREG", TIPO_TabREG, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@TIPO_CodREG", TIPO_CodReg, SqlDbType.Char, 3, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@CABA_NroVoucher", CABA_NroVoucher, SqlDbType.Char, 6, ParameterDirection.Input);

            DataAccessEnterpriseSQL.DAAgregarParametro("@AUDI_UsrMod", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);

            if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
            { return true; }
         }
         catch (Exception)
         { throw; }
         return false;
      }

      #endregion

      #region [ Eliminar CtaCte y Asiento ]

      /// <summary>
      /// Eliminar el el asiento segun tabla CAJ_CtaCte
      /// </summary>
      /// <param name="x_usuario">The x usuario.</param>
      /// <returns></returns>
      public Boolean EliminarAsientoDeCtaCte(String x_usuario, TipoActualizar x_opcion = TipoActualizar.Auto)
      {
         try
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSD_GenerarAsiento_FromDelfin");
            DataAccessEnterpriseSQL.DAAgregarParametro("@EMPR_Codigo", ItemCtaCte.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@CCCT_Codigo", ItemCtaCte.CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_Usuario", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);
            switch (x_opcion)
            {
               case TipoActualizar.Auto:
                  break;
               case TipoActualizar.RegistroCompras:
                  DataAccessEnterpriseSQL.DAAgregarParametro("@TipoAsiento", "C", SqlDbType.Char, 1, ParameterDirection.Input);
                  break;
               case TipoActualizar.DiarioGeneral:
                  break;
               default:
                  break;
            }

            if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
            { return true; }
         }
         catch (Exception)
         { throw; }
         return false;
      }

      /// <summary>
      /// Anular registro del asiento, segun opciones indicadas
      /// </summary>
      /// <param name="x_usuario">Nombre del usuario para la tabla de auditoria.</param>
      /// <param name="x_TipoItem">Tipo de Item que se tiene que anular, para la seleccione del asiento.</param>
      /// <returns></returns>
      /// <exception cref="System.Exception">
      /// No se ha inicializado correctamente el registro
      /// or
      /// No se ha inicializado correctamente el registro
      /// or
      /// No se ha inicializado correctamente el registro
      /// or
      /// No se ha inicializado correctamente el registro
      /// </exception>
      public Boolean Anular(String x_usuario, TipoItem x_TipoItem)
      {
         try
         {
            switch (x_TipoItem)
            {
               case TipoItem.CtaCte:
                  if (ItemCtaCte == null) { throw new Exception("No se ha inicializado correctamente el registro"); }
                  DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSX_GenerarAsiento_FromDelfin");
                  DataAccessEnterpriseSQL.DAAgregarParametro("@EMPR_Codigo", ItemCtaCte.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                  DataAccessEnterpriseSQL.DAAgregarParametro("@CCCT_Codigo", ItemCtaCte.CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                  break;
               case TipoItem.Movimiento:
                  if (ItemMovimiento == null) { throw new Exception("No se ha inicializado correctamente el registro"); }
                  DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_MOVISX_GenerarAsiento_FromDelfin");
                  DataAccessEnterpriseSQL.DAAgregarParametro("@EMPR_Codigo", ItemMovimiento.EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                  DataAccessEnterpriseSQL.DAAgregarParametro("@MOVI_Codigo", ItemMovimiento.MOVI_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                  break;
               case TipoItem.DocVta:
                  if (ItemDocsVta == null) { throw new Exception("No se ha inicializado correctamente el registro"); }
                  DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_DOCVSX_GenerarAsiento_FromDelfin");
                  DataAccessEnterpriseSQL.DAAgregarParametro("@DOCV_Codigo", ItemDocsVta.DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                  break;
               case TipoItem.NaveViaje:
                  break;
               default:
                  break;
            }
            DataAccessEnterpriseSQL.DAAgregarParametro("@AUDI_Usuario", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);

            if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
            { return true; }

         }
         catch (Exception)
         { throw; }
         return false;
      }

      #endregion

      #endregion

      #region [ Eventos ]

      /// <summary>
      /// Obtener el tipo de registro para el registro en el sistema de contabilidad
      /// </summary>
      /// <param name="x_tipo">The x tipo.</param>
      /// <returns></returns>
      public static String getPTipoRegistro(TipoRegistro x_tipo)
      {
         switch (x_tipo)
         {
            case TipoRegistro.RegistroCompras:
               return "TR_RCOMPRAS";
               break;
            case TipoRegistro.RegistroVentas:
               return "TR_RVENTAS";
               break;
            case TipoRegistro.RegistroCaja:
               return "TR_RCAJA";
               break;
            case TipoRegistro.DiarioGeneral:
               return "TR_DGENERAL";
               break;
            case TipoRegistro.LibroPlanillas:
               return "TR_LPLANILLA";
               break;
            default:
               return "";
               break;
         }
      }

      #endregion

      #region [ IFormClose ]

      #endregion

   }
}
