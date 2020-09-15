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
using Infrastructure.Aspect.BusinessEntity;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial class BLEntidad
   {
      #region [ Propiedades ]
      public IUnityContainer ContainerService { get; set; }
      public Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Entidad> Loader { get; set; }
      #endregion

      #region [ Constructores ]
      public BLEntidad(IUnityContainer container)
      {
         this.ContainerService = container;
         Loader = new BusinessEntityLoader<Entidad>();
         Entidad item = new Entidad();
         Loader.EntityType = item.GetType();
      }
      #endregion

      #region [ Consultas ]
      private ObservableCollection<Entidad> SelectAll(Nullable<Int16> x_TIPE_Codigo = null, string x_ENTC_NomCompleto = null)
      {
         try
         {
            ObservableCollection<Entidad> items = new ObservableCollection<Entidad>();
            Entidad item = new Entidad();
            //DataAccessEnterpriseSQL.DAAsignarProcedure("ENTCSS_Todos");
            DataAccessEnterpriseSQL.DAAsignarProcedure("ENTCSS_Todos");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchTIPE_Codigo", x_TIPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_NomCompleto", x_ENTC_NomCompleto, SqlDbType.VarChar, 150, ParameterDirection.Input);

            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Entidad();
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
      private Entidad SelectOne(Int32 ENTC_Codigo, Nullable<Int16> x_TIPE_Codigo = null)
      {
         try
         {
            Entidad item = new Entidad();
            //DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_CONSULTAR_Entidad");
            DataAccessEnterpriseSQL.DAAsignarProcedure("ENTCSS_Todos");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchTIPE_Codigo", x_TIPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               if (reader.Read())
               {
                  Loader.LoadEntity(reader, item);
                  item.Instance = InstanceEntity.Unchanged;
                  //DESOSITO TEMPORAL
                  
                  //CONTACTOS DEL CLIENTE
                  //item.Contactos = GetAllEntidadRelacionadosByCliente(item.ENTC_Codigo, ValidarDocIden);
               }
               else
               { return null; }
            }
            return item;
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion

      #region [ Metodos ]
      private bool Insert(ref Entidad Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
            {
               if (Item.TIPO_CodHol == "" || Item.TIPO_CodHol == null) { Item.TIPO_TabHol = null; Item.TIPO_CodHol = null; }
               if (Item.CONS_CodTFT == "" || Item.CONS_CodTFT == null) { Item.CONS_TabTFT = null; Item.CONS_CodTFT = null; }
               if (Item.TIPO_CodCiu == "" || Item.TIPO_CodCiu == null) { Item.TIPO_TabCiu = null; Item.TIPO_CodCiu = null; }
               if (Item.TIPO_CodDTM == "" || Item.TIPO_CodDTM == null) { Item.TIPO_TabDTM = null; Item.TIPO_CodDTM = null; }
               if (Item.TIPO_CodPai == "" || Item.TIPO_CodPai == null) { Item.TIPO_TabPai = null; Item.TIPO_CodPai = null; }

               //DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_INSERTAR_Entidad");
               DataAccessEnterpriseSQL.DAAsignarProcedure("ENTCSI_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", Item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTDI", Item.TIPO_TabTDI, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTDI", Item.TIPO_CodTDI, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrENTC_TipEnt", Item.ENTC_TipEnt, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_DocIden", Item.ENTC_DocIden, SqlDbType.VarChar, 25, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_Domiciliado", Item.ENTC_Domiciliado, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Nombres", Item.ENTC_Nombres, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_ApePat", Item.ENTC_ApePat, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_ApeMat", Item.ENTC_ApeMat, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_NomCompleto", Item.ENTC_NomCompleto, SqlDbType.VarChar, 150, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_NomComercial", Item.ENTC_NomComercial, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_RazonSocial", Item.ENTC_RazonSocial, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_Activo", Item.ENTC_Activo, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmENTC_FecNac", Item.ENTC_FecNac, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmENTC_FecIng", Item.ENTC_FecIng, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_VIP", Item.ENTC_VIP, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Notas", Item.ENTC_Notas, SqlDbType.VarChar, 1024, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrENTC_Sexo", Item.ENTC_Sexo, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_EMail", Item.ENTC_EMail, SqlDbType.VarChar, 500, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Web", Item.ENTC_Web, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_Propio", Item.ENTC_Propio, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Telef1", Item.ENTC_Telef1, SqlDbType.VarChar, 25, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Telef2", Item.ENTC_Telef2, SqlDbType.VarChar, 25, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Telef3", Item.ENTC_Telef3, SqlDbType.VarChar, 25, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Telef4", Item.ENTC_Telef4, SqlDbType.VarChar, 25, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Beneficiario", Item.ENTC_Beneficiario, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Area", Item.ENTC_Area, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Cargo", Item.ENTC_Cargo, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUSER_CodUsr", Item.USER_CodUsr, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabPai", Item.TIPO_TabPai, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodPai", Item.TIPO_CodPai, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabHol", Item.TIPO_TabHol, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodHol", Item.TIPO_CodHol, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTFT", Item.CONS_CodTFT, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabTFT", Item.CONS_TabTFT, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabCiu", Item.TIPO_TabCiu, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodCiu", Item.TIPO_CodCiu, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_Prospecto", Item.ENTC_Prospecto, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabDTM", Item.TIPO_TabDTM, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodDTM", Item.TIPO_CodDTM, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecENTC_ValRebate", Item.ENTC_ValRebate, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMnd", Item.TIPO_TabMnd, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMnd", Item.TIPO_CodMnd, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecENTC_ValTarja", Item.ENTC_ValTarja, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinENTC_DiasCredito", Item.ENTC_DiasCredito, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmENTC_FechaCredito", Item.ENTC_FechaCredito, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_Tarja", Item.ENTC_Tarja, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_CodAduana", Item.ENTC_CodAduana, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodCre", Item.CONS_CodCre, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabCre", Item.CONS_TabCre, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_EMail2", Item.ENTC_EMail2, SqlDbType.VarChar, 250, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Obser", Item.ENTC_Obser, SqlDbType.VarChar, 1024, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_InterbancarioSol", Item.ENTC_InterbancarioSol, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_InterbancarioDol", Item.ENTC_InterbancarioDol, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_CuentaDetraccion", Item.ENTC_CuentaDetraccion, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_ServicioLogistico", Item.ENTC_ServicioLogistico, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_OcultarShipper", Item.ENTC_OcultarShipper, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_ObsFinanzasCliente", Item.ENTC_ObsFinanzasCliente, SqlDbType.VarChar, 1024, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_BloqueoFinanzasCliente", Item.ENTC_BloqueoFinanzasCliente, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_UsrBloqueoCliente", Item.ENTC_UsrBloqueoCliente, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmENTC_FecBloqueoCliente", Item.ENTC_FecBloqueoCliente, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_EmailFinanzas", Item.ENTC_EmailFinanzas, SqlDbType.VarChar, 250, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_ObsBloqueoCliente", Item.ENTC_ObsBloqueoCliente, SqlDbType.VarChar, 1000, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_OtrosTraficos", Item.ENTC_OtrosTraficos, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_Mandato", Item.ENTC_Mandato, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_SLI", Item.ENTC_SLI, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_Exportacion", Item.ENTC_Exportacion, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_UsrBloqueoProveedor", Item.ENTC_UsrBloqueoProveedor, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmENTC_FecBloqueoProveedor", Item.ENTC_FecBloqueoProveedor, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_BloqueoFinanzasProveedor", Item.ENTC_BloqueoFinanzasProveedor, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_ObsFinanzasProveedor", Item.ENTC_ObsFinanzasProveedor, SqlDbType.VarChar, 1024, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_ObsBloqueoProveedor", Item.ENTC_ObsBloqueoProveedor, SqlDbType.VarChar, 1000, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_ProvAsumeDetraccion", Item.ENTC_ProvAsumeDetraccion, SqlDbType.Bit, 1, ParameterDirection.Input);
               //otras tablas
               DataAccessEnterpriseSQL.DAAgregarParametro("@psmlTIPE_Codigo", Item.TIPE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinDIRE_Codigo", Item.DIRE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDIRE_Direccion", Item.DIRE_Direccion, SqlDbType.VarChar, 250, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUBIG_Codigo", Item.UBIG_CodigoFiscal, SqlDbType.VarChar, 10, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabPais", Item.TIPO_TabPaisComercial, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodPais", Item.TIPO_CodPaisComercial, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinDIRE_CodigoComercial", Item.Dire_CodigoComercial, SqlDbType.SmallInt, 2, ParameterDirection.InputOutput);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchDIRE_DireccionComercial", Item.DIRE_DireccionComercial, SqlDbType.VarChar, 250, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUBIG_CodigoComercial", Item.UBIG_CodigoComercial, SqlDbType.VarChar, 10, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_ToOrder", Item.ENTC_ToOrder, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrCrea", Item.AUDI_UsrCrea, SqlDbType.VarChar, 20, ParameterDirection.Input);

                    //SEGMENTACION 21/06/2020
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodSEG", Item.TIPO_CodSEG, SqlDbType.Char, 3, ParameterDirection.Input);


                    if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
               {
                  Int32 _ENTC_Codigo;
                  if (Int32.TryParse(DataAccessEnterpriseSQL.DASqlCommand.Parameters["@pintENTC_Codigo"].Value.ToString(), out _ENTC_Codigo))
                  { Item.ENTC_Codigo = _ENTC_Codigo; }
                  //ahora verificamos si tiene hijos(contactos)


                  return true;
               }
               else
               { return false; }
            }
            else
            { return true; }
         }
         catch (Exception ex)
         { throw ex; }
      }
      private bool Update(ref Entidad Item)
      {
         try
         {
            if (Item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
            {
               if (Item.TIPO_CodHol == "" || Item.TIPO_CodHol == null) { Item.TIPO_TabHol = null; Item.TIPO_CodHol = null; }
               if (Item.CONS_CodTFT == "" || Item.CONS_CodTFT == null) { Item.CONS_TabTFT = null; Item.CONS_CodTFT = null; }
               if (Item.TIPO_CodCiu == "" || Item.TIPO_CodCiu == null) { Item.TIPO_TabCiu = null; Item.TIPO_CodCiu = null; }
               if (Item.TIPO_CodDTM == "" || Item.TIPO_CodDTM == null) { Item.TIPO_TabDTM = null; Item.TIPO_CodDTM = null; }
               if (Item.TIPO_CodPai == "" || Item.TIPO_CodPai == null) { Item.TIPO_TabPai = null; Item.TIPO_CodPai = null; }


               //DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_ACTUALIZAR_Entidad");
               DataAccessEnterpriseSQL.DAAsignarProcedure("ENTCSU_UnReg");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", Item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabTDI", Item.TIPO_TabTDI, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodTDI", Item.TIPO_CodTDI, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrENTC_TipEnt", Item.ENTC_TipEnt, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_DocIden", Item.ENTC_DocIden, SqlDbType.VarChar, 25, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_Domiciliado", Item.ENTC_Domiciliado, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Nombres", Item.ENTC_Nombres, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_ApePat", Item.ENTC_ApePat, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_ApeMat", Item.ENTC_ApeMat, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_NomCompleto", Item.ENTC_NomCompleto, SqlDbType.VarChar, 150, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_NomComercial", Item.ENTC_NomComercial, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_RazonSocial", Item.ENTC_RazonSocial, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_Activo", Item.ENTC_Activo, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmENTC_FecNac", Item.ENTC_FecNac, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmENTC_FecIng", Item.ENTC_FecIng, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_VIP", Item.ENTC_VIP, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Notas", Item.ENTC_Notas, SqlDbType.VarChar, 1024, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrENTC_Sexo", Item.ENTC_Sexo, SqlDbType.Char, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_EMail", Item.ENTC_EMail, SqlDbType.VarChar, 500, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_EmailReceptorFE", Item.ENTC_EmailReceptorFE, SqlDbType.VarChar, 500, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Web", Item.ENTC_Web, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_Propio", Item.ENTC_Propio, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Telef1", Item.ENTC_Telef1, SqlDbType.VarChar, 25, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Telef2", Item.ENTC_Telef2, SqlDbType.VarChar, 25, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Telef3", Item.ENTC_Telef3, SqlDbType.VarChar, 25, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Telef4", Item.ENTC_Telef4, SqlDbType.VarChar, 25, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Beneficiario", Item.ENTC_Beneficiario, SqlDbType.VarChar, 100, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Area", Item.ENTC_Area, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Cargo", Item.ENTC_Cargo, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchUSER_CodUsr", Item.USER_CodUsr, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabPai", Item.TIPO_TabPai, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodPai", Item.TIPO_CodPai, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabHol", Item.TIPO_TabHol, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodHol", Item.TIPO_CodHol, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTFT", Item.CONS_CodTFT, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabTFT", Item.CONS_TabTFT, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabCiu", Item.TIPO_TabCiu, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodCiu", Item.TIPO_CodCiu, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_Prospecto", Item.ENTC_Prospecto, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabDTM", Item.TIPO_TabDTM, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodDTM", Item.TIPO_CodDTM, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecENTC_ValRebate", Item.ENTC_ValRebate, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_TabMnd", Item.TIPO_TabMnd, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMnd", Item.TIPO_CodMnd, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdecENTC_ValTarja", Item.ENTC_ValTarja, SqlDbType.Decimal, 15, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@psinENTC_DiasCredito", Item.ENTC_DiasCredito, SqlDbType.SmallInt, 2, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmENTC_FechaCredito", Item.ENTC_FechaCredito, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_Tarja", Item.ENTC_Tarja, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_CodAduana", Item.ENTC_CodAduana, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodCre", Item.CONS_CodCre, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabCre", Item.CONS_TabCre, SqlDbType.Char, 3, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_EMail2", Item.ENTC_EMail2, SqlDbType.VarChar, 250, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_Obser", Item.ENTC_Obser, SqlDbType.VarChar, 1024, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_InterbancarioSol", Item.ENTC_InterbancarioSol, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_InterbancarioDol", Item.ENTC_InterbancarioDol, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_CuentaDetraccion", Item.ENTC_CuentaDetraccion, SqlDbType.VarChar, 50, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_ServicioLogistico", Item.ENTC_ServicioLogistico, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_OcultarShipper", Item.ENTC_OcultarShipper, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_ObsFinanzasCliente", Item.ENTC_ObsFinanzasCliente, SqlDbType.VarChar, 1024, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_BloqueoFinanzasCliente", Item.ENTC_BloqueoFinanzasCliente, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_UsrBloqueoCliente", Item.ENTC_UsrBloqueoCliente, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmENTC_FecBloqueoCliente", Item.ENTC_FecBloqueoCliente, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_EmailFinanzas", Item.ENTC_EmailFinanzas, SqlDbType.VarChar, 250, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_ObsBloqueoCliente", Item.ENTC_ObsBloqueoCliente, SqlDbType.VarChar, 1000, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_OtrosTraficos", Item.ENTC_OtrosTraficos, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_Mandato", Item.ENTC_Mandato, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_SLI", Item.ENTC_SLI, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_Exportacion", Item.ENTC_Exportacion, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_UsrBloqueoProveedor", Item.ENTC_UsrBloqueoProveedor, SqlDbType.VarChar, 20, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmENTC_FecBloqueoProveedor", Item.ENTC_FecBloqueoProveedor, SqlDbType.DateTime, 8, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_BloqueoFinanzasProveedor", Item.ENTC_BloqueoFinanzasProveedor, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_ObsFinanzasProveedor", Item.ENTC_ObsFinanzasProveedor, SqlDbType.VarChar, 1024, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchENTC_ObsBloqueoProveedor", Item.ENTC_ObsBloqueoProveedor, SqlDbType.VarChar, 1000, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_ProvAsumeDetraccion", Item.ENTC_ProvAsumeDetraccion, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pbitENTC_ToOrder", Item.ENTC_ToOrder, SqlDbType.Bit, 1, ParameterDirection.Input);
               DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", Item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);
               //otras tablas
               DataAccessEnterpriseSQL.DAAgregarParametro("@psmlTIPE_Codigo", Item.TIPE_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);

                    //SEGMENTACION 21/06/2020
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodSEG", Item.TIPO_CodSEG, SqlDbType.Char, 3, ParameterDirection.Input);


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
      private bool Delete(ref Entidad item)
      {
         try
         {
            if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
            {
               DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_ELIMINAR_Entidad");
               DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", item.ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

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