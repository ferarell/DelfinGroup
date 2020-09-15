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

namespace Delfin.BusinessLogic
{
   public partial class BLCtaCte
   {

      #region [ Propiedades ]

      [Dependency]
      public IBLDetCtaCte BL_DetCtaCte { get; set; }
      [Dependency]
      public IBLDetPerfilAsientos BL_DetPerfilAsientos { get; set; }
      [Dependency]
      public IBLParametros BL_Parametros { get; set; }
      [Dependency]
      public IBLDetCtaCteAsientos BL_DetCtaCteAsientos { get; set; }

      DetCtaCte m_ItemDetCtaCte;
      public DetCtaCte ItemDetCtaCte
      {
         get { return m_ItemDetCtaCte; }
         set { m_ItemDetCtaCte = value; }
      }

      [Dependency]
      public IBLDet_Operacion _BLDetOperacion { get; set; }


      #endregion

      #region [ Consultas ]


      public DataTable GetCtaCteFiltros(DateTime x_Desde, DateTime x_Hasta, Int32 x_ENTC_Codigo, Boolean x_FiltroFechas)
      {
         try
         {
            return SelectCtaCteFiltros(x_Desde, x_Hasta, x_ENTC_Codigo, x_FiltroFechas);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public DataTable GetCtaCteDetalles(Int32 x_COPE_Codigo)
      {
         try
         {
            return SelectCtaCteDetalles(x_COPE_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public DataTable GetCtaCtePendientes(Int16 x_TIPE_Codigo, Int32 x_ENTC_Codigo)
      {
         try
         {
            return SelectCtaCtePendientes(x_TIPE_Codigo, x_ENTC_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public CtaCte GetOne(Int16 EMPR_Codigo, Int32 CCCT_Codigo, Entities.CtaCte.TInterfazCtaCte x_opcion)
      {
         try
         {
            if (EMPR_Codigo == null || CCCT_Codigo == null) { return null; }
            switch (x_opcion)
            {
               case CtaCte.TInterfazCtaCte.IngresoLibre:
                  return GetOneIngresoLibre(EMPR_Codigo, CCCT_Codigo);
               case CtaCte.TInterfazCtaCte.RegistroSLI:
                  return SelectOneSLI(EMPR_Codigo, CCCT_Codigo);
            }
            return null;
         }
         catch (Exception)
         { throw; }
      }
      public DataTable GetOneCtaCteDT(Int16 EMPR_Codigo, Int32 x_CCCT_Codigo)
      {
         try { return SelectOneCtaCteDT(EMPR_Codigo, x_CCCT_Codigo); }
         catch (Exception ex)
         { throw ex; }
      }
      #region [ Obtener el registro segun opción de Interfaz ]

      /// <summary>
      /// Obtener el registro de Ingreso Libre de Documentos para su respectiva edición
      /// </summary>
      /// <param name="EMPR_Codigo">Codigo de Empresa.</param>
      /// <param name="CCCT_Codigo">Código de CtaCte.</param>
      /// <returns></returns>
      public CtaCte GetOneIngresoLibre(Int16 EMPR_Codigo, Int32 CCCT_Codigo)
      {
         try
         {

            Entities.CtaCte _ctacte = SelectOne(EMPR_Codigo, CCCT_Codigo);
            if (_ctacte != null)
            {
               ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> listFilters = new ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL>();
               listFilters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@psinEMPR_Codigo", FilterValue = EMPR_Codigo, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Int16, FilterSize = 2 });
               listFilters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@pintCCCT_Codigo", FilterValue = CCCT_Codigo, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Int32, FilterSize = 4 });

               _ctacte.ListDetCtaCte = BL_DetCtaCte.GetAllFilter("CAJ_DCCTSS_TodosPorCtaCte", listFilters);
               _ctacte.ListDetCtaCteAsientos = BL_DetCtaCteAsientos.GetAllFilter("CAJ_DCCASS_TodosPorCtaCte", listFilters);
               if (_ctacte.ListDetCtaCteAsientos == null) { _ctacte.ListDetCtaCteAsientos = new ObservableCollection<DetCtaCteAsientos>(); }

               if (!String.IsNullOrEmpty(_ctacte.CABP_Ano) && !String.IsNullOrEmpty(_ctacte.CABP_Codigo))
               {
                  listFilters = new ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL>();
                  listFilters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@pchrCABP_Ano", FilterValue = _ctacte.CABP_Ano, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Char, FilterSize = 4 });
                  listFilters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@pvchCABP_Codigo", FilterValue = _ctacte.CABP_Codigo, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Varchar, FilterSize = 3 });
                  _ctacte.ItemCabPerfilAsientos = new CabPerfilAsientos() { CABP_Ano = _ctacte.CABP_Ano, CABP_Codigo = _ctacte.CABP_Codigo };
                  _ctacte.ItemCabPerfilAsientos.ListDetPerfilAsientos = BL_DetPerfilAsientos.GetAllFilter("CON_DETPSS_TodosPorCabecera", listFilters);
               }


            }
            return _ctacte;
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #endregion

      #region [ Metodos ]

      public Boolean Save(ref CtaCte Item, Entities.CtaCte.TInterfazCtaCte x_opcion)
      {
         try
         {
            Boolean m_isCorrect = true;
            switch (x_opcion)
            {
               case CtaCte.TInterfazCtaCte.IngresoLibre:
                  m_isCorrect = SaveIngresoLibre(ref Item);
                  break;
               case CtaCte.TInterfazCtaCte.RegistroDescuadre:
                  m_isCorrect = SaveDescuadre(ref Item);
                  break;
               case CtaCte.TInterfazCtaCte.RegistroLiquidacion:
                  m_isCorrect = SaveLiquidacion(ref Item);
                  break;
               case CtaCte.TInterfazCtaCte.Facturar:
                  m_isCorrect = SaveFacturar(ref Item);
                  break;
               case CtaCte.TInterfazCtaCte.RegistroSLI:
                  m_isCorrect = SaveSLI(ref Item);
                  break;
               case CtaCte.TInterfazCtaCte.EnviarAsientoADiario:
                  m_isCorrect = SaveAsientoADiario(ref Item);
                  break;
               case CtaCte.TInterfazCtaCte.RegenerarAsientoReversionCompras:
                  m_isCorrect = SaveRegAsientoRevCompras(ref Item);
                  break;
            }
            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }

      /// <summary>
      /// Guardar el Registro desde el Modulo de Servicio Logistico SLI
      /// </summary>
      /// <param name="Item">Objeto de CtaCte con los datos de grabacion.</param>
      /// <param name="x_DOPE_Items">The x dope items.</param>
      /// <returns></returns>
      public String SaveCCCTSLI(ref CtaCte Item, String x_DOPE_Items)
      {
         try
         {
            GAsientos GenAsientos;
            Boolean m_isCorrect = true;
            String _NroVoucher = "";
            DataAccessEnterpriseSQL.DABeginTransaction();
            String x_usuario = "";
            Item.CCCT_Origen = "S";
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                  m_isCorrect = Insert(ref Item);
                  if (m_isCorrect)
                  {
                     #region [ Registro de Detalle CtaCte]

                     x_usuario = Item.AUDI_UsrCrea;
                     Item.TMovimiento = CtaCte.TipoMovimiento.Egreso;
                     ItemDetCtaCte = new DetCtaCte
                     {
                        CCCT_Codigo = Item.CCCT_Codigo,
                        EMPR_Codigo = Item.EMPR_Codigo,
                        DCCT_FechaTrans = Item.CCCT_FechaRecepcion.Value,
                        DCCT_TipoCambio = Item.CCCT_TipoCambio.Value,

                        TIPO_CodMND = Item.TIPO_CodMND,
                        TIPO_TabMND = "MND",
                        Trasanct = true,
                        AUDI_UsrCrea = Item.AUDI_UsrCrea,
                        Instance = Item.Instance
                     };

                     if (Item.TIPO_CodTDO.Equals("007"))
                     {
                        ItemDetCtaCte.DCCT_MontoHaber = Item.TMovimiento == CtaCte.TipoMovimiento.Ingreso ? Item.TIPO_CodMND == "001" ? Item.CCCT_Monto.Value : Math.Round(Item.CCCT_Monto.Value * Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                        ItemDetCtaCte.DCCT_MontoHaberD = Item.TMovimiento == CtaCte.TipoMovimiento.Ingreso ? Item.TIPO_CodMND == "002" ? Item.CCCT_Monto.Value : System.Math.Round(Item.CCCT_Monto.Value / Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                        ItemDetCtaCte.DCCT_MontoDebe = Item.TMovimiento == CtaCte.TipoMovimiento.Egreso ? Item.TIPO_CodMND == "001" ? Item.CCCT_Monto.Value : System.Math.Round(Item.CCCT_Monto.Value * Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                        ItemDetCtaCte.DCCT_MontoDebeD = Item.TMovimiento == CtaCte.TipoMovimiento.Egreso ? Item.TIPO_CodMND == "002" ? Item.CCCT_Monto.Value : System.Math.Round(Item.CCCT_Monto.Value / Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                     }
                     else
                     {
                        ItemDetCtaCte.DCCT_MontoDebe = Item.TMovimiento == CtaCte.TipoMovimiento.Ingreso ? Item.TIPO_CodMND == "001" ? Item.CCCT_Monto.Value : Math.Round(Item.CCCT_Monto.Value * Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                        ItemDetCtaCte.DCCT_MontoDebeD = Item.TMovimiento == CtaCte.TipoMovimiento.Ingreso ? Item.TIPO_CodMND == "002" ? Item.CCCT_Monto.Value : System.Math.Round(Item.CCCT_Monto.Value / Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                        ItemDetCtaCte.DCCT_MontoHaber = Item.TMovimiento == CtaCte.TipoMovimiento.Egreso ? Item.TIPO_CodMND == "001" ? Item.CCCT_Monto.Value : System.Math.Round(Item.CCCT_Monto.Value * Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                        ItemDetCtaCte.DCCT_MontoHaberD = Item.TMovimiento == CtaCte.TipoMovimiento.Egreso ? Item.TIPO_CodMND == "002" ? Item.CCCT_Monto.Value : System.Math.Round(Item.CCCT_Monto.Value / Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                     }


                     if (Item.ListDet_Operacion != null)
                     {
                        foreach (Det_Operacion _Item_Det_Ope in Item.ListDet_Operacion)
                        {
                           if (m_isCorrect)
                           {
                              m_isCorrect = _BLDetOperacion.UpdateEstado(Item.COPE_Codigo, _Item_Det_Ope.CTAR_Tipo, Item.CCCT_Codigo
                                                                       , Convert.ToInt16(_Item_Det_Ope.TIPE_Codigo.Value)
                                                                       , Convert.ToInt32(_Item_Det_Ope.ENTC_Codigo.Value)
                                                                       , _Item_Det_Ope.DOPE_Costo
                                                                       , _Item_Det_Ope.DTAR_Item.Value == 1 ? true : false
                                                                       , Item.AUDI_UsrCrea, x_DOPE_Items);
                           }
                           else
                           {
                              m_isCorrect = false;
                              break;
                           }
                        }
                        if (!BL_DetCtaCte.Save(ref m_ItemDetCtaCte))
                        {
                           m_isCorrect = false;
                        }
                     }
                     #endregion

                     #region [ Generar el Detalle de Asiento ]

                     Entities.DetCtaCteAsientos _itemDeta = Item.DetCtaCteAsientos;
                     _itemDeta.EMPR_Codigo = Item.EMPR_Codigo;
                     _itemDeta.CCCT_Codigo = Item.CCCT_Codigo;
                     _itemDeta.AUDI_UsrCrea = Item.AUDI_UsrCrea;
                     m_isCorrect = BL_DetCtaCteAsientos.Save(ref _itemDeta);

                     #endregion

                     #region [ Generar Asiento ]

                     if (m_isCorrect)
                     {
                        // Optimizacion en Base de datos - Ysaacx - 13/02/2017 
                        GenAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoCompra_SLI);
                        GenAsientos.ItemCtaCte = Item;
                        _NroVoucher = GenAsientos.GenerarVoucherBD(x_usuario);
                         if (String.IsNullOrEmpty(_NroVoucher))
                         { m_isCorrect = false; }                         
                     }

                     #endregion
                  }
                  else
                  {
                     m_isCorrect = false;
                  }
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = Update(ref Item);
                  #region [ Actualizar Detalle de CtaCte]
                  if (m_isCorrect)
                  {
                     if (Item.ListDet_Operacion != null)
                     {
                        /* Inicializar Servicio */
                        _BLDetOperacion.DeleteServicioCtaCte(Item);
                        /* Agregar el Servicio */
                        foreach (Det_Operacion _Item_Det_Ope in Item.ListDet_Operacion)
                        {
                           if (m_isCorrect)
                           {
                              m_isCorrect = _BLDetOperacion.UpdateEstado(Item.COPE_Codigo, _Item_Det_Ope.CTAR_Tipo, Item.CCCT_Codigo
                                                                       , Convert.ToInt16(_Item_Det_Ope.TIPE_Codigo.Value)
                                                                       , Convert.ToInt32(_Item_Det_Ope.ENTC_Codigo.Value)
                                                                       , _Item_Det_Ope.DOPE_Costo
                                                                       , _Item_Det_Ope.DTAR_Item.Value == 1 ? true : false
                                                                       , Item.AUDI_UsrCrea, x_DOPE_Items);
                           }
                           else
                           {
                              m_isCorrect = false;
                              break;
                           }
                        }
                     }

                     Item.TMovimiento = CtaCte.TipoMovimiento.Egreso;
                     DetCtaCte x_detctacte = BL_DetCtaCte.GetOne(Item.EMPR_Codigo, Item.CCCT_Codigo, 1);
                     if (x_detctacte != null)
                     {
                        x_detctacte.DCCT_TipoCambio = Item.CCCT_TipoCambio.Value;
                        if (Item.TIPO_CodMND.Equals(Infrastructure.Aspect.Constants.Util.getMoneda(Infrastructure.Aspect.Constants.TMoneda.Soles)))
                        {
                           x_detctacte.DCCT_MontoDebe = Item.TMovimiento == CtaCte.TipoMovimiento.Ingreso ? Item.CCCT_TipoCambio.Value : 0;
                           x_detctacte.DCCT_MontoDebeD = Item.TMovimiento == CtaCte.TipoMovimiento.Ingreso ? Math.Round(Item.CCCT_Monto.Value / Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                           x_detctacte.DCCT_MontoHaber = Item.TMovimiento == CtaCte.TipoMovimiento.Egreso ? Item.CCCT_Monto.Value : 0;
                           x_detctacte.DCCT_MontoHaberD = Item.TMovimiento == CtaCte.TipoMovimiento.Egreso ? Math.Round(Item.CCCT_Monto.Value / Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                        }
                        else
                        {
                           x_detctacte.DCCT_MontoDebe = Item.TMovimiento == CtaCte.TipoMovimiento.Ingreso ? Math.Round(Item.CCCT_Monto.Value * Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                           x_detctacte.DCCT_MontoDebeD = Item.TMovimiento == CtaCte.TipoMovimiento.Ingreso ? Item.CCCT_Monto.Value : 0;
                           x_detctacte.DCCT_MontoHaber = Item.TMovimiento == CtaCte.TipoMovimiento.Egreso ? Math.Round(Item.CCCT_Monto.Value * Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                           x_detctacte.DCCT_MontoHaberD = Item.TMovimiento == CtaCte.TipoMovimiento.Egreso ? Item.CCCT_Monto.Value : 0;
                        }
                        m_isCorrect = BL_DetCtaCte.Save(ref x_detctacte);
                     }
                  }

                  #region [ Generar el Detalle de Asiento ]

                  Entities.DetCtaCteAsientos _item = Item.DetCtaCteAsientos;
                  _item.EMPR_Codigo = Item.EMPR_Codigo;
                  _item.CCCT_Codigo = Item.CCCT_Codigo;
                  _item.AUDI_UsrCrea = Item.AUDI_UsrCrea;
                  _item.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified;
                  m_isCorrect = BL_DetCtaCteAsientos.Save(ref _item);

                  #endregion

                  #region [ Generar Asiento ]

                  if (m_isCorrect)
                  {
                     // Optimizacion en Base de datos - Ysaacx - 13/02/2017 
                     GenAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoCompra_SLI);
                     GenAsientos.ItemCtaCte = Item;
                     GenAsientos.GenerarAsientoBD(x_usuario);
                  }

                  #endregion
                  #endregion
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  //GenAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoCompra_SLI);
                  //GenAsientos.ItemCtaCte = Item;
                  //x_TIPO_TipReg = "001";
                  //if (GenAsientos.EliminarCtaCte(x_usuario))
                  m_isCorrect = Delete(ref Item);
                  break;
            }
            if (m_isCorrect)
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return _NroVoucher;
         }
         catch (Exception)
         { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }

      public String SaveCCCTILD(ref CtaCte Item, String x_DOPE_Items)
      {
          try
          {
              GAsientos GenAsientos;
              Boolean m_isCorrect = true;
              String _NroVoucher = "";
              DataAccessEnterpriseSQL.DABeginTransaction();
              String x_usuario = "";
              Item.CCCT_Origen = "S";
              switch (Item.Instance)
              {
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                      m_isCorrect = Insert(ref Item);
                      if (m_isCorrect)
                      {
                          #region [ Registro de Detalle CtaCte]

                          x_usuario = Item.AUDI_UsrCrea;
                          Item.TMovimiento = CtaCte.TipoMovimiento.Egreso;
                          ItemDetCtaCte = new DetCtaCte
                          {
                              CCCT_Codigo = Item.CCCT_Codigo,
                              EMPR_Codigo = Item.EMPR_Codigo,
                              DCCT_FechaTrans = Item.CCCT_FechaRecepcion.Value,
                              DCCT_TipoCambio = Item.CCCT_TipoCambio.Value,

                              TIPO_CodMND = Item.TIPO_CodMND,
                              TIPO_TabMND = "MND",
                              Trasanct = true,
                              AUDI_UsrCrea = Item.AUDI_UsrCrea,
                              Instance = Item.Instance
                          };

                          if (Item.TIPO_CodTDO.Equals("007"))
                          {
                              ItemDetCtaCte.DCCT_MontoHaber = Item.TMovimiento == CtaCte.TipoMovimiento.Ingreso ? Item.TIPO_CodMND == "001" ? Item.CCCT_Monto.Value : Math.Round(Item.CCCT_Monto.Value * Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                              ItemDetCtaCte.DCCT_MontoHaberD = Item.TMovimiento == CtaCte.TipoMovimiento.Ingreso ? Item.TIPO_CodMND == "002" ? Item.CCCT_Monto.Value : System.Math.Round(Item.CCCT_Monto.Value / Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                              ItemDetCtaCte.DCCT_MontoDebe = Item.TMovimiento == CtaCte.TipoMovimiento.Egreso ? Item.TIPO_CodMND == "001" ? Item.CCCT_Monto.Value : System.Math.Round(Item.CCCT_Monto.Value * Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                              ItemDetCtaCte.DCCT_MontoDebeD = Item.TMovimiento == CtaCte.TipoMovimiento.Egreso ? Item.TIPO_CodMND == "002" ? Item.CCCT_Monto.Value : System.Math.Round(Item.CCCT_Monto.Value / Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                          }
                          else
                          {
                              ItemDetCtaCte.DCCT_MontoDebe = Item.TMovimiento == CtaCte.TipoMovimiento.Ingreso ? Item.TIPO_CodMND == "001" ? Item.CCCT_Monto.Value : Math.Round(Item.CCCT_Monto.Value * Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                              ItemDetCtaCte.DCCT_MontoDebeD = Item.TMovimiento == CtaCte.TipoMovimiento.Ingreso ? Item.TIPO_CodMND == "002" ? Item.CCCT_Monto.Value : System.Math.Round(Item.CCCT_Monto.Value / Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                              ItemDetCtaCte.DCCT_MontoHaber = Item.TMovimiento == CtaCte.TipoMovimiento.Egreso ? Item.TIPO_CodMND == "001" ? Item.CCCT_Monto.Value : System.Math.Round(Item.CCCT_Monto.Value * Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                              ItemDetCtaCte.DCCT_MontoHaberD = Item.TMovimiento == CtaCte.TipoMovimiento.Egreso ? Item.TIPO_CodMND == "002" ? Item.CCCT_Monto.Value : System.Math.Round(Item.CCCT_Monto.Value / Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                          }


                          if (Item.ListDet_Operacion != null)
                          {
                              foreach (Det_Operacion _Item_Det_Ope in Item.ListDet_Operacion)
                              {
                                  if (m_isCorrect)
                                  {
                                      m_isCorrect = _BLDetOperacion.UpdateEstado(Item.COPE_Codigo, _Item_Det_Ope.CTAR_Tipo, Item.CCCT_Codigo
                                                                               , Convert.ToInt16(_Item_Det_Ope.TIPE_Codigo.Value)
                                                                               , Convert.ToInt32(_Item_Det_Ope.ENTC_Codigo.Value)
                                                                               , _Item_Det_Ope.DOPE_Costo
                                                                               , _Item_Det_Ope.DTAR_Item.Value == 1 ? true : false
                                                                               , Item.AUDI_UsrCrea, x_DOPE_Items);
                                  }
                                  else
                                  {
                                      m_isCorrect = false;
                                      break;
                                  }
                              }
                              if (!BL_DetCtaCte.Save(ref m_ItemDetCtaCte))
                              {
                                  m_isCorrect = false;
                              }
                          }
                          #endregion

                          #region [ Generar el Detalle de Asiento ]

                          Entities.DetCtaCteAsientos _itemDeta = Item.DetCtaCteAsientos;
                          _itemDeta.EMPR_Codigo = Item.EMPR_Codigo;
                          _itemDeta.CCCT_Codigo = Item.CCCT_Codigo;
                          _itemDeta.AUDI_UsrCrea = Item.AUDI_UsrCrea;
                          m_isCorrect = BL_DetCtaCteAsientos.Save(ref _itemDeta);

                          #endregion

                          #region [ Generar Asiento ]

                          if (m_isCorrect)
                          {
                              // Optimizacion en Base de datos - Ysaacx - 13/02/2017 
                              GenAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoCompra_ILD);
                              GenAsientos.ItemCtaCte = Item;
                              _NroVoucher = GenAsientos.GenerarVoucherBD(x_usuario);
                              if (String.IsNullOrEmpty(_NroVoucher))
                              { m_isCorrect = false; }
                          }

                          #endregion
                      }
                      else
                      {
                          m_isCorrect = false;
                      }
                      break;
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                      m_isCorrect = Update(ref Item);
                      #region [ Actualizar Detalle de CtaCte]
                      if (m_isCorrect)
                      {
                          if (Item.ListDet_Operacion != null)
                          {
                              /* Inicializar Servicio */
                              _BLDetOperacion.DeleteServicioCtaCte(Item);
                              /* Agregar el Servicio */
                              foreach (Det_Operacion _Item_Det_Ope in Item.ListDet_Operacion)
                              {
                                  if (m_isCorrect)
                                  {
                                      m_isCorrect = _BLDetOperacion.UpdateEstado(Item.COPE_Codigo, _Item_Det_Ope.CTAR_Tipo, Item.CCCT_Codigo
                                                                               , Convert.ToInt16(_Item_Det_Ope.TIPE_Codigo.Value)
                                                                               , Convert.ToInt32(_Item_Det_Ope.ENTC_Codigo.Value)
                                                                               , _Item_Det_Ope.DOPE_Costo
                                                                               , _Item_Det_Ope.DTAR_Item.Value == 1 ? true : false
                                                                               , Item.AUDI_UsrCrea, x_DOPE_Items);
                                  }
                                  else
                                  {
                                      m_isCorrect = false;
                                      break;
                                  }
                              }
                          }

                          Item.TMovimiento = CtaCte.TipoMovimiento.Egreso;
                          DetCtaCte x_detctacte = BL_DetCtaCte.GetOne(Item.EMPR_Codigo, Item.CCCT_Codigo, 1);
                          if (x_detctacte != null)
                          {
                              x_detctacte.DCCT_TipoCambio = Item.CCCT_TipoCambio.Value;
                              if (Item.TIPO_CodMND.Equals(Infrastructure.Aspect.Constants.Util.getMoneda(Infrastructure.Aspect.Constants.TMoneda.Soles)))
                              {
                                  x_detctacte.DCCT_MontoDebe = Item.TMovimiento == CtaCte.TipoMovimiento.Ingreso ? Item.CCCT_TipoCambio.Value : 0;
                                  x_detctacte.DCCT_MontoDebeD = Item.TMovimiento == CtaCte.TipoMovimiento.Ingreso ? Math.Round(Item.CCCT_Monto.Value / Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                                  x_detctacte.DCCT_MontoHaber = Item.TMovimiento == CtaCte.TipoMovimiento.Egreso ? Item.CCCT_Monto.Value : 0;
                                  x_detctacte.DCCT_MontoHaberD = Item.TMovimiento == CtaCte.TipoMovimiento.Egreso ? Math.Round(Item.CCCT_Monto.Value / Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                              }
                              else
                              {
                                  x_detctacte.DCCT_MontoDebe = Item.TMovimiento == CtaCte.TipoMovimiento.Ingreso ? Math.Round(Item.CCCT_Monto.Value * Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                                  x_detctacte.DCCT_MontoDebeD = Item.TMovimiento == CtaCte.TipoMovimiento.Ingreso ? Item.CCCT_Monto.Value : 0;
                                  x_detctacte.DCCT_MontoHaber = Item.TMovimiento == CtaCte.TipoMovimiento.Egreso ? Math.Round(Item.CCCT_Monto.Value * Item.CCCT_TipoCambio.Value, 2, MidpointRounding.AwayFromZero) : 0;
                                  x_detctacte.DCCT_MontoHaberD = Item.TMovimiento == CtaCte.TipoMovimiento.Egreso ? Item.CCCT_Monto.Value : 0;
                              }
                              m_isCorrect = BL_DetCtaCte.Save(ref x_detctacte);
                          }
                      }

                      #region [ Generar el Detalle de Asiento ]

                      Entities.DetCtaCteAsientos _item = Item.DetCtaCteAsientos;
                      _item.EMPR_Codigo = Item.EMPR_Codigo;
                      _item.CCCT_Codigo = Item.CCCT_Codigo;
                      _item.AUDI_UsrCrea = Item.AUDI_UsrCrea;
                      _item.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified;
                      m_isCorrect = BL_DetCtaCteAsientos.Save(ref _item);

                      #endregion

                      #region [ Generar Asiento ]

                      if (m_isCorrect)
                      {
                          // Optimizacion en Base de datos - Ysaacx - 13/02/2017 
                          GenAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoCompra_ILD);
                          GenAsientos.ItemCtaCte = Item;
                          GenAsientos.GenerarAsientoBD(x_usuario);
                      }

                      #endregion
                      #endregion
                      break;
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                      //GenAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoCompra_SLI);
                      //GenAsientos.ItemCtaCte = Item;
                      //x_TIPO_TipReg = "001";
                      //if (GenAsientos.EliminarCtaCte(x_usuario))
                      m_isCorrect = Delete(ref Item);
                      break;
              }
              if (m_isCorrect)
              { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
              else
              { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
              return _NroVoucher;
          }
          catch (Exception)
          { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }

      #region [ Procesos para Guardar segun Opción de Interfaz ]

      /// <summary>
      /// Guardar el registro desde el módulo de Ingreso Libre
      /// </summary>
      /// <param name="Item">Objeto con los datos de grabación.</param>
      /// <returns></returns>
      public Boolean SaveIngresoLibre(ref CtaCte Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            DataAccessEnterpriseSQL.DABeginTransaction();
            GAsientos genAsientos;
            Int16 i = 0;
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                  m_isCorrect = InsertIngresoLibre(ref Item);
                  #region [ Actualizar Asientos - Usando Plantillas ]
                  /* Actualizar la Tabla Asientos */
                  if (m_isCorrect)
                  {
                     if (Item.ListDetCtaCteAsientos != null && Item.ListDetCtaCteAsientos.Count > 0)
                     {
                        i = 1;
                        foreach (DetCtaCteAsientos iCta in Item.ListDetCtaCteAsientos)
                        {
                           iCta.EMPR_Codigo = Item.EMPR_Codigo;
                           iCta.CCCT_Codigo = Item.CCCT_Codigo;
                           iCta.AUDI_UsrCrea = Item.AUDI_UsrCrea;
                           iCta.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added;
                           iCta.DCCA_Item = i++;
                           Entities.DetCtaCteAsientos _item = iCta;
                           BL_DetCtaCteAsientos.Save(ref _item);
                        }
                     }
                     else if (!String.IsNullOrEmpty(Item.CCCT_CuentaBI))
                     {
                        Entities.DetCtaCteAsientos _item = new DetCtaCteAsientos();
                        _item.EMPR_Codigo = Item.EMPR_Codigo;
                        _item.CCCT_Codigo = Item.CCCT_Codigo;
                        _item.DCCA_Cuenta = Item.CCCT_CuentaBI;
                        _item.DCCA_DebePorc = 100;
                        _item.DCCA_DebeMonto = Item.CCCT_ValVta.Value;
                        _item.DCCA_Item = 1;
                        _item.DCCA_Glosa = Item.CCCT_Glosa;
                        _item.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added;
                        _item.AUDI_UsrCrea = Item.AUDI_UsrCrea;
                        BL_DetCtaCteAsientos.Save(ref _item);
                     }

                     genAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoCompra_ILD);
                     genAsientos.ItemCtaCte = Item;
                     genAsientos.GenerarAsientoBD(Item.AUDI_UsrCrea);

                     //genAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoCompra_ILD);
                     //genAsientos.ItemCtaCte = Item;

                     //m_isCorrect = genAsientos.GenerarAsiento(Item.AUDI_UsrCrea, Item.SUCR_Codigo.Value);
                     //if (m_isCorrect)
                     //{ m_isCorrect = genAsientos.ActualizarCtaCte(Item.AUDI_UsrCrea); }
                  }
                  #endregion
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = UpdateIngresoLibre(ref Item);

                  #region [ Editar Asientos ]
                  if (m_isCorrect && !String.IsNullOrEmpty(Item.CABA_Ano) && !String.IsNullOrEmpty(Item.CABA_Mes)
                                  && !String.IsNullOrEmpty(Item.CABA_NroVoucher) && Item.TMovimiento == CtaCte.TipoMovimiento.Egreso)
                  {

                     BL_DetCtaCteAsientos.DeleteForCtaCte(Item.EMPR_Codigo, Item.CCCT_Codigo);
                     if (Item.ListDetCtaCteAsientos != null && Item.ListDetCtaCteAsientos.Count > 0)
                     {
                        i = 1;
                        foreach (DetCtaCteAsientos iCta in Item.ListDetCtaCteAsientos)
                        {
                           iCta.EMPR_Codigo = Item.EMPR_Codigo;
                           iCta.CCCT_Codigo = Item.CCCT_Codigo;
                           iCta.AUDI_UsrCrea = Item.AUDI_UsrMod;
                           iCta.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added;
                           iCta.DCCA_Item = i++;
                           Entities.DetCtaCteAsientos _item = iCta;
                           BL_DetCtaCteAsientos.Save(ref _item);
                        }
                     }
                     else if (!String.IsNullOrEmpty(Item.CCCT_CuentaBI))
                     {
                        Entities.DetCtaCteAsientos _item = new DetCtaCteAsientos();
                        _item.EMPR_Codigo = Item.EMPR_Codigo;
                        _item.CCCT_Codigo = Item.CCCT_Codigo;
                        _item.DCCA_Cuenta = Item.CCCT_CuentaBI;
                        _item.DCCA_DebePorc = 100;
                        _item.DCCA_DebeMonto = Item.CCCT_ValVta.Value;
                        _item.DCCA_Item = 1;
                        _item.DCCA_Glosa = Item.CCCT_Glosa;
                        _item.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added;
                        _item.AUDI_UsrCrea = Item.AUDI_UsrCrea;
                        BL_DetCtaCteAsientos.Save(ref _item);
                     }

                     genAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoCompra_ILD);
                     genAsientos.ItemCtaCte = Item;
                     genAsientos.GenerarAsientoBD(Item.AUDI_UsrMod);

                     // Consultar
                     //   if (!String.IsNullOrEmpty(Item.TIPO_CodREG) && !String.IsNullOrEmpty(Item.CABA_Ano) && !String.IsNullOrEmpty(Item.CABA_Mes))
                     //   {
                     //      if (!String.IsNullOrEmpty(Item.CCCT_NroDetraccion) && Item.CCCT_FecDetraccion.HasValue)
                     //      {
                     //         if (!String.IsNullOrEmpty(Item.TIPO_CodREG_LCompras) && Item.TIPO_CodREG_LCompras.Equals(genAsientos.getTipoRegistro(GAsientos.getPTipoRegistro(GAsientos.TipoRegistro.RegistroCompras))))
                     //         {
                     //            if (String.Format("{0}{1}", Item.CABA_Ano_LCompras, Item.CABA_Mes_LCompras) != Item.CCCT_FecDetraccion.Value.ToString("yyyyMM"))
                     //            {
                     //               // Eliminar el Asiento de Compras
                     //               m_isCorrect = genAsientos.EliminarAsientoDeCtaCte(Item.AUDI_UsrMod, GAsientos.TipoActualizarCtaCte.RegistroCompras);
                     //               // generar el nuevo asiento de compras en el nuevo periodo segun la fecha de detracción
                     //               if (m_isCorrect)
                     //               {
                     //                  m_isCorrect = genAsientos.GenerarAsiento(Item.AUDI_UsrMod, Item.SUCR_Codigo.Value, GAsientos.TipoActualizarCtaCte.RegistroCompras);
                     //                  if (m_isCorrect)
                     //                  { m_isCorrect = genAsientos.ActualizarCtaCte(Item.AUDI_UsrCrea, GAsientos.TipoActualizarCtaCte.RegistroCompras); }
                     //               }
                     //            }
                     //            else
                     //            { m_isCorrect = genAsientos.ActualizarAsiento(Item.AUDI_UsrMod, Item.SUCR_Codigo.Value, GAsientos.TipoActualizarCtaCte.RegistroCompras); }
                     //         }
                     //         else if (!String.IsNullOrEmpty(Item.TIPO_CodREG) && Item.TIPO_CodREG.Equals(genAsientos.getTipoRegistro(GAsientos.getPTipoRegistro(GAsientos.TipoRegistro.DiarioGeneral))))
                     //         {
                     //            m_isCorrect = genAsientos.GenerarAsiento(Item.AUDI_UsrMod, Item.SUCR_Codigo.Value, GAsientos.TipoActualizarCtaCte.RegistroCompras);
                     //            if (m_isCorrect)
                     //            { m_isCorrect = genAsientos.ActualizarCtaCte(Item.AUDI_UsrMod, GAsientos.TipoActualizarCtaCte.RegistroCompras); }
                     //         }
                     //         else if (!String.IsNullOrEmpty(Item.TIPO_CodREG) && Item.TIPO_CodREG.Equals(genAsientos.getTipoRegistro(GAsientos.getPTipoRegistro(GAsientos.TipoRegistro.RegistroCompras))))
                     //         {
                     //            m_isCorrect = genAsientos.ActualizarAsiento(Item.AUDI_UsrMod, Item.SUCR_Codigo.Value);
                     //         }
                     //      }
                     //      else
                     //      { m_isCorrect = genAsientos.ActualizarAsiento(Item.AUDI_UsrMod, Item.SUCR_Codigo.Value); }
                  }
                  else
                  {
                     genAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoCompra_ILD);
                     genAsientos.ItemCtaCte = Item;
                     genAsientos.GenerarAsientoBD(Item.AUDI_UsrMod);

                     //      if (!String.IsNullOrEmpty(Item.CCCT_NroDetraccion) && Item.CCCT_FecDetraccion.HasValue
                     //       && Item.CCCT_FecReg.Value.ToString("yyyyMM") != Item.CCCT_FecDetraccion.Value.ToString("yyyyMM"))
                     //      {
                     //         m_isCorrect = genAsientos.GenerarAsiento(Item.AUDI_UsrMod, Item.SUCR_Codigo.Value, GAsientos.TipoActualizarCtaCte.RegistroCompras);
                     //         if (m_isCorrect)
                     //         { m_isCorrect = genAsientos.ActualizarCtaCte(Item.AUDI_UsrMod, GAsientos.TipoActualizarCtaCte.RegistroCompras); }
                     //      }
                     //      else
                     //      {
                     //         m_isCorrect = genAsientos.GenerarAsiento(Item.AUDI_UsrMod, Item.SUCR_Codigo.Value);
                     //         if (m_isCorrect)
                     //         { m_isCorrect = genAsientos.ActualizarCtaCte(Item.AUDI_UsrMod); }
                     //      }
                     //   }
                     //}
                     //else
                     //{
                     //   if (Item.TMovimiento == CtaCte.TipoMovimiento.Egreso)
                     //   {
                     //      genAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoCompra_ILD);
                     //      genAsientos.ItemCtaCte = Item;

                     //      if (!String.IsNullOrEmpty(Item.TIPO_CodREG_LCompras) && Item.TIPO_CodREG_LCompras.Equals(genAsientos.getTipoRegistro(GAsientos.getPTipoRegistro(GAsientos.TipoRegistro.RegistroCompras))))
                     //      {
                     //         if (!String.IsNullOrEmpty(Item.CCCT_NroDetraccion) && Item.CCCT_FecDetraccion.HasValue
                     //          && Item.CCCT_FecReg.Value.ToString("yyyyMM") != Item.CCCT_FecDetraccion.Value.ToString("yyyyMM"))
                     //         {
                     //            m_isCorrect = genAsientos.ActualizarAsiento(Item.AUDI_UsrMod, Item.SUCR_Codigo.Value, GAsientos.TipoActualizarCtaCte.RegistroCompras);
                     //         }
                     //      }
                     //      else
                     //      {
                     //         if (!String.IsNullOrEmpty(Item.CCCT_NroDetraccion) && Item.CCCT_FecDetraccion.HasValue
                     //             && Item.CCCT_FecReg.Value.ToString("yyyyMM") != Item.CCCT_FecDetraccion.Value.ToString("yyyyMM"))
                     //         {
                     //            m_isCorrect = genAsientos.GenerarAsiento(Item.AUDI_UsrMod, Item.SUCR_Codigo.Value, GAsientos.TipoActualizarCtaCte.RegistroCompras);
                     //            if (m_isCorrect)
                     //            { m_isCorrect = genAsientos.ActualizarCtaCte(Item.AUDI_UsrMod, GAsientos.TipoActualizarCtaCte.RegistroCompras); }
                     //         }
                     //      }
                     //}
                  }
                  #endregion
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  m_isCorrect = DeleteIngresoLibre(ref Item);
                  if (m_isCorrect)
                  {
                     genAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoCompra_ILD);
                     genAsientos.ItemCtaCte = Item;

                     m_isCorrect = genAsientos.EliminarAsientoDeCtaCte(Item.AUDI_UsrMod);
                  }
                  break;
            }
            if (m_isCorrect) { DataAccessEnterpriseSQL.DACommitTransaction(); }
            else { DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         { DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }

      public Boolean SaveDescuadre(ref CtaCte Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                  m_isCorrect = InsertDescuadre(ref Item); break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = UpdateDescuadre(ref Item); break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  m_isCorrect = DeleteDescuadre(ref Item); break;
            }
            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }

      public Boolean SaveLiquidacion(ref CtaCte Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = UpdateLiquidacion(ref Item); break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  m_isCorrect = DeleteLiquidacion(ref Item); break;
            }
            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }

      public Boolean SaveFacturar(ref CtaCte Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            m_isCorrect = CrearFacturar(ref Item);
            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }

      public Boolean SaveSLI(ref CtaCte Item)
      {
         try
         {
            DataAccessEnterpriseSQL.DABeginTransaction();
            Boolean m_isCorrect = true;
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged:
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  m_isCorrect = DeleteSLI(ref Item);
                  //if (m_isCorrect)
                  //{
                  //   GAsientos GenAsientos = new GAsientos(GAsientos.TipoAsiento.AsientoCompra_SLI);
                  //   GenAsientos.ItemCtaCte = Item;
                  //   m_isCorrect = GenAsientos.EliminarAsientoDeCtaCte(Item.AUDI_UsrMod);
                  //}
                  break;
               default:
                  break;
            }
            if (m_isCorrect)
            { DataAccessEnterpriseSQL.DACommitTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         {
            DataAccessEnterpriseSQL.DARollbackTransaction();
            throw;
         }
      }

      public Boolean SaveAsientoADiario(ref CtaCte Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            DataAccessEnterpriseSQL.DABeginTransaction();

            m_isCorrect = UpdateEnviarADiario(ref Item);
            
            if (m_isCorrect) { DataAccessEnterpriseSQL.DACommitTransaction(); }
            else { DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         { DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }

      public Boolean SaveRegAsientoRevCompras(ref CtaCte Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            DataAccessEnterpriseSQL.DABeginTransaction();

            m_isCorrect = UpdateRegenerarAsientoReversionCompras(ref Item);

            if (m_isCorrect) { DataAccessEnterpriseSQL.DACommitTransaction(); }
            else { DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         { DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }

      #endregion

      #region [ Procedimientos para Desvinculacion ]

      public Boolean SaveDesvinculacion(Int16 x_EMPR_Codigo, Int32 x_CCCT_Codigo, Entities.CtaCte.TipoDesvinculacion x_opcion, Entities.CtaCte.TipoDesvAsiento x_destino, String x_usuario)
      {
         try
         {
            Boolean x_iscorrect = true;

            DataAccessEnterpriseSQL.DABeginTransaction();
            DataAccessEnterpriseSQL.DAAsignarProcedure("CAJ_CCCTSX_DesvincularAsiento");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinEMPR_Codigo", x_EMPR_Codigo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCCT_Codigo", x_CCCT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_Usuario", x_usuario, SqlDbType.VarChar, 20, ParameterDirection.Input);

            switch (x_opcion)
            {
               case CtaCte.TipoDesvinculacion.AsientoProvision:
                  DataAccessEnterpriseSQL.DAAgregarParametro("@Asiento", "P", SqlDbType.Char, 1, ParameterDirection.Input);
                  break;
               case CtaCte.TipoDesvinculacion.AsientoCompRev:
                  DataAccessEnterpriseSQL.DAAgregarParametro("@Asiento", "C", SqlDbType.Char, 1, ParameterDirection.Input);
                  break;
               case CtaCte.TipoDesvinculacion.AsientoORevComp:
                  DataAccessEnterpriseSQL.DAAgregarParametro("@Asiento", "R", SqlDbType.Char, 1, ParameterDirection.Input);
                  break;
               default:
                  break;
            }
            switch (x_destino)
            {
               case CtaCte.TipoDesvAsiento.Anular:
                  DataAccessEnterpriseSQL.DAAgregarParametro("@Opcion", "X", SqlDbType.Char, 1, ParameterDirection.Input);
                  break;
               case CtaCte.TipoDesvAsiento.Eliminar:
                  DataAccessEnterpriseSQL.DAAgregarParametro("@Opcion", "D", SqlDbType.Char, 1, ParameterDirection.Input);
                  break;
            }

            if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
            { x_iscorrect = true; DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { x_iscorrect = false; DataAccessEnterpriseSQL.DARollbackTransaction(); }

            return x_iscorrect;
         }
         catch (Exception)
         { DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }

      #endregion

      public Boolean GetBuscarDoc_Detraccion(String x_TipoDoc, String x_Serie, String x_NroDoc, Int32 x_CodProve)
      {
         return BuscarDoc_Detraccion(x_TipoDoc, x_Serie, x_NroDoc, x_CodProve);
      }

      public Boolean SaveGenerarAsientosByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters, ref String x_mensaje)
      {
         try
         {
            return GenerarAsientosByFilter(x_procedure, x_filters, ref x_mensaje);
         }
         catch (Exception)
         { throw; }
      }

      #endregion
   }
}
