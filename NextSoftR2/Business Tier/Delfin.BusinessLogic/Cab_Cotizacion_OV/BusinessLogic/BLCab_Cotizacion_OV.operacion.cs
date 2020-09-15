using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial class BLCab_Cotizacion_OV : IBLCab_Cotizacion_OV
   {
      #region [ Propiedades ]
      [Dependency]
      public IBLAnexos BL_Anexos { get; set; }
      [Dependency]
      public IBLDet_CNTR BL_Det_CNTR { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable OPE_GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return OPE_SelectAllByFilterDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Cab_Cotizacion_OV> OPE_GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return OPE_SelectAllByFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Cab_Cotizacion_OV> OPE_GetAll()
      {
         try
         {
            return OPE_SelectAll();
         }
         catch (Exception)
         { throw; }
      }
      public Cab_Cotizacion_OV OPE_GetOne(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int16 CCOT_Tipo, Int32 CCOT_Numero)
      {
         try
         {
            if (CCOT_Tipo == null || CCOT_Numero == null) { return null; }
            return OPE_SelectOne(EMPR_Codigo, SUCR_Codigo, CCOT_Tipo, CCOT_Numero);
         }
         catch (Exception)
         { throw; }
      }

      public System.Data.DataSet OPE_GetOneImpresionHBL(Int16 CCOT_Tipo, Int32 CCOT_Numero)
      {
         try
         {
            return OPE_SelectOneImpresionHBL(CCOT_Tipo, CCOT_Numero);
         }
         catch (Exception)
         { throw; }
      }
      public System.Data.DataTable OPE_GetOneImpresionEtiqueta(Int16 CCOT_Tipo, Int32 CCOT_Numero)
      {
         try
         {
            return OPE_SelectOneImpresionEtiqueta(CCOT_Tipo, CCOT_Numero);
         }
         catch (Exception)
         { throw; }
      }
      #endregion

      #region [ Metodos ]
      public Boolean OPE_ValidateVersion(ref Cab_Cotizacion_OV Item)
      {
         try
         {
            if (Item.EMPR_Codigo.HasValue && Item.SUCR_Codigo.HasValue)
            {

               Int64 _versionEdicion = BitConverter.ToInt64(Item.AUDI_Version, 0);

               Byte[] _version = OPE_SelectOneVersion(Item.EMPR_Codigo.Value, Item.SUCR_Codigo.Value, Item.CCOT_Tipo, Item.CCOT_Numero);
               Int64 _versionActual = BitConverter.ToInt64(_version, 0);

               return _versionActual == _versionEdicion;
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }

      public Boolean OPE_Save(ref Cab_Cotizacion_OV Item, ref String CCOT_MensajeError)
      {
         Boolean m_isCorrect = true;
         Boolean m_isAdded = true;
         String m_usuario = "";
         try
         {
            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added && !OPE_ValidateVersion(ref Item))
            {
               Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction();

               Item = OPE_SelectOne(Item.EMPR_Codigo.Value, Item.SUCR_Codigo.Value, Item.CCOT_Tipo, Item.CCOT_Numero);
               CCOT_MensajeError = String.Format("El registro que esta editando ha sido modificado(Usuario: {0} - Fecha: {1}), el sistema cargará el registro con los valores actualizados, sus cambios no se han guardado.", (!String.IsNullOrEmpty(Item.AUDI_UsrMod) ? Item.AUDI_UsrMod : ""), (Item.AUDI_FecMod.HasValue ? Item.AUDI_FecMod.Value.ToLongDateString() : ""));

               return false;
            }
            else
            {
               switch (Item.Instance)
               {
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                     m_isCorrect = OPE_Insert(ref Item); m_isAdded = true; m_usuario = Item.AUDI_UsrCrea; break;
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                     m_isCorrect = OPE_Update(ref Item); m_isAdded = false; m_usuario = Item.AUDI_UsrMod; break;
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                     m_isCorrect = OPE_Delete(ref Item);

                     if (m_isCorrect)
                     { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); return true; }
                     else
                     { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); return false; }
               }
               if (m_isCorrect)
               {
                  for (int indexFlete = 0; indexFlete < Item.ItemsFlete.Count; indexFlete++)
                  {
                     Det_Cotizacion_OV_Flete _itemFlete = Item.ItemsFlete[indexFlete];
                     _itemFlete.CCOT_Tipo = Item.CCOT_Tipo;
                     _itemFlete.CCOT_Numero = Item.CCOT_Numero;

                     if (_itemFlete.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
                     { _itemFlete.AUDI_UsrCrea = m_usuario; }
                     else if (_itemFlete.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
                     { _itemFlete.AUDI_UsrMod = m_usuario; }

                     m_isCorrect = BL_Det_Cotizacion_OV_Flete.Save(ref _itemFlete, false);
                     if (!m_isCorrect) { break; }
                  }
                  if (m_isCorrect)
                  {
                     for (int indexFlete = 0; indexFlete < Item.ItemsFleteDeleted.Count; indexFlete++)
                     {
                        Det_Cotizacion_OV_Flete _itemFlete = Item.ItemsFleteDeleted[indexFlete];
                        _itemFlete.CCOT_Tipo = Item.CCOT_Tipo;
                        _itemFlete.CCOT_Numero = Item.CCOT_Numero;
                        m_isCorrect = BL_Det_Cotizacion_OV_Flete.Save(ref _itemFlete, false);
                        if (!m_isCorrect) { break; }
                     }
                  }
                  if (m_isCorrect)
                  {
                     for (int indexServicio = 0; indexServicio < Item.ItemsServicio.Count; indexServicio++)
                     {
                        Det_Cotizacion_OV_Servicio _itemServicio = Item.ItemsServicio[indexServicio];
                        _itemServicio.CCOT_Tipo = Item.CCOT_Tipo;
                        _itemServicio.CCOT_Numero = Item.CCOT_Numero;

                        if (_itemServicio.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
                        { _itemServicio.AUDI_UsrCrea = m_usuario; }
                        else if (_itemServicio.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
                        { _itemServicio.AUDI_UsrMod = m_usuario; }

                        m_isCorrect = BL_Det_Cotizacion_OV_Servicio.Save(ref _itemServicio, false);
                        if (!m_isCorrect) { break; }
                     }
                  }
                  if (m_isCorrect)
                  {
                     for (int indexServicio = 0; indexServicio < Item.ItemsServicioDeleted.Count; indexServicio++)
                     {
                        Det_Cotizacion_OV_Servicio _itemServicio = Item.ItemsServicioDeleted[indexServicio];
                        _itemServicio.CCOT_Tipo = Item.CCOT_Tipo;
                        _itemServicio.CCOT_Numero = Item.CCOT_Numero;
                        m_isCorrect = BL_Det_Cotizacion_OV_Servicio.Save(ref _itemServicio, false);
                        if (!m_isCorrect) { break; }
                     }
                  }

                  if (m_isCorrect)
                  {
                     for (int indexServicioChangeControl = 0; indexServicioChangeControl < Item.ItemsServicioChangeControl.Count; indexServicioChangeControl++)
                     {
                        Det_Cotizacion_OV_Servicio _itemServicioChangeControl = Item.ItemsServicioChangeControl[indexServicioChangeControl];
                        _itemServicioChangeControl.CCOT_Tipo = Item.CCOT_Tipo;
                        _itemServicioChangeControl.CCOT_Numero = Item.CCOT_Numero;

                        if (_itemServicioChangeControl.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
                        { _itemServicioChangeControl.AUDI_UsrCrea = m_usuario; }
                        else if (_itemServicioChangeControl.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
                        { _itemServicioChangeControl.AUDI_UsrMod = m_usuario; }

                        m_isCorrect = BL_Det_Cotizacion_OV_Servicio.Save(ref _itemServicioChangeControl, false);
                        if (!m_isCorrect) { break; }
                     }
                  }
                  if (m_isCorrect)
                  {
                     for (int indexServicioChangeControl = 0; indexServicioChangeControl < Item.ItemsServicioChangeControlDeleted.Count; indexServicioChangeControl++)
                     {
                        Det_Cotizacion_OV_Servicio _itemServicioChangeControl = Item.ItemsServicioChangeControlDeleted[indexServicioChangeControl];
                        _itemServicioChangeControl.CCOT_Tipo = Item.CCOT_Tipo;
                        _itemServicioChangeControl.CCOT_Numero = Item.CCOT_Numero;
                        m_isCorrect = BL_Det_Cotizacion_OV_Servicio.Save(ref _itemServicioChangeControl, false);
                        if (!m_isCorrect) { break; }
                     }
                  }

                  if (m_isCorrect)
                  {
                     for (int indexEventoServicio = 0; indexEventoServicio < Item.ItemsEventosTareas.Count; indexEventoServicio++)
                     {
                        Det_Cotizacion_OV_EventosTareas _itemEventoTarea = Item.ItemsEventosTareas[indexEventoServicio];
                        _itemEventoTarea.CCOT_Tipo = Item.CCOT_Tipo;
                        _itemEventoTarea.CCOT_Numero = Item.CCOT_Numero;

                        if (_itemEventoTarea.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
                        { _itemEventoTarea.AUDI_UsrCrea = m_usuario; }
                        else if (_itemEventoTarea.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
                        { _itemEventoTarea.AUDI_UsrMod = m_usuario; }

                        m_isCorrect = BL_EventosTareas.Save(ref _itemEventoTarea, false);
                        if (!m_isCorrect) { break; }
                     }
                  }
                  if (m_isCorrect)
                  {
                     for (int indexEventoServicio = 0; indexEventoServicio < Item.ItemsEventosTareasDeleted.Count; indexEventoServicio++)
                     {
                        Det_Cotizacion_OV_EventosTareas _itemEventoTarea = Item.ItemsEventosTareasDeleted[indexEventoServicio];
                        _itemEventoTarea.CCOT_Tipo = Item.CCOT_Tipo;
                        _itemEventoTarea.CCOT_Numero = Item.CCOT_Numero;
                        _itemEventoTarea.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted;
                        m_isCorrect = BL_EventosTareas.Save(ref _itemEventoTarea, false);
                        if (!m_isCorrect) { break; }
                     }
                  }

                  if (m_isCorrect)
                  {
                     for (int indexAnexos = 0; indexAnexos < Item.ItemsAnexos.Count; indexAnexos++)
                     {
                        Anexos _itemAnexo = Item.ItemsAnexos[indexAnexos];
                        _itemAnexo.CCOT_Tipo = Item.CCOT_Tipo;
                        _itemAnexo.CCOT_Numero = Item.CCOT_Numero;

                        if (_itemAnexo.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
                        { _itemAnexo.AUDI_UsrCrea = m_usuario; }
                        else if (_itemAnexo.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
                        { _itemAnexo.AUDI_UsrMod = m_usuario; }

                        m_isCorrect = BL_Anexos.Save(ref _itemAnexo);
                        if (!m_isCorrect) { break; }
                     }
                  }
                  if (m_isCorrect)
                  {
                     for (int indexAnexos = 0; indexAnexos < Item.ItemsAnexosDeleted.Count; indexAnexos++)
                     {
                        Anexos _itemAnexo = Item.ItemsAnexosDeleted[indexAnexos];
                        _itemAnexo.CCOT_Tipo = Item.CCOT_Tipo;
                        _itemAnexo.CCOT_Numero = Item.CCOT_Numero;
                        m_isCorrect = BL_Anexos.Save(ref _itemAnexo);
                        if (!m_isCorrect) { break; }
                     }
                  }


                  if (m_isCorrect)
                  {
                     for (int indexArchivos = 0; indexArchivos < Item.ItemsArchivo.Count; indexArchivos++)
                     {
                        Det_Cotizacion_OV_Archivo _itemArchivo = Item.ItemsArchivo[indexArchivos];

                        if (_itemArchivo.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
                        { _itemArchivo.AUDI_UsrCrea = m_usuario; }
                        else if (_itemArchivo.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
                        { _itemArchivo.AUDI_UsrMod = m_usuario; }

                        if (_itemArchivo.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
                        { m_isCorrect = BL_Det_Cotizacion_OV_Archivo.Save(ref _itemArchivo); }
                        if (!m_isCorrect) { break; }
                     }
                  }

                  if (m_isCorrect)
                  {
                     for (int indexDet_CNTR = 0; indexDet_CNTR < Item.ItemsDet_CNTR.Count; indexDet_CNTR++)
                     {
                        Det_CNTR _itemDet_CNTR = Item.ItemsDet_CNTR[indexDet_CNTR];
                        _itemDet_CNTR.CCOT_Tipo = Item.CCOT_Tipo;
                        _itemDet_CNTR.CCOT_Numero = Item.CCOT_Numero;

                        if (_itemDet_CNTR.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
                        { _itemDet_CNTR.AUDI_UsrCrea = m_usuario; }
                        else if (_itemDet_CNTR.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
                        { _itemDet_CNTR.AUDI_UsrMod = m_usuario; }

                        m_isCorrect = BL_Det_CNTR.Save(ref _itemDet_CNTR);
                        if (!m_isCorrect) { break; }
                     }
                  }
                  if (m_isCorrect)
                  {
                     for (int indexDet_CNTR = 0; indexDet_CNTR < Item.ItemsDet_CNTRDeleted.Count; indexDet_CNTR++)
                     {
                        Det_CNTR _itemDet_CNTR = Item.ItemsDet_CNTRDeleted[indexDet_CNTR];
                        _itemDet_CNTR.CCOT_Tipo = Item.CCOT_Tipo;
                        _itemDet_CNTR.CCOT_Numero = Item.CCOT_Numero;
                        m_isCorrect = BL_Det_CNTR.Save(ref _itemDet_CNTR);
                        if (!m_isCorrect) { break; }
                     }
                  }

                  if (m_isCorrect)
                  {
                     m_isCorrect = InsertDetalleViaje(Item.CCOT_Tipo, Item.CCOT_Numero, m_usuario, ref CCOT_MensajeError);
                  }
               }
               if (m_isCorrect)
               {
                  Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction();

                  if (Item.EMPR_Codigo.HasValue && Item.SUCR_Codigo.HasValue)
                  { return true; }
                  else
                  { return false; }
               }
               else
               {
                  Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction();
                  return false;
               }
            }
         }
         catch (Exception)
         { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }
      public Boolean OPE_Save(ref ObservableCollection<Cab_Cotizacion_OV> Items)
      {
         try
         {
            Boolean m_isCorrect = true;
            for (int i = 0; i < Items.Count; i++)
            {
               var Item = Items.ElementAt(i);
               switch (Item.Instance)
               {
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                     m_isCorrect = OPE_Insert(ref Item); break;
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                     m_isCorrect = OPE_Update(ref Item); break;
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                     m_isCorrect = OPE_Delete(ref Item); break;
               }
               if (!m_isCorrect)
               { return m_isCorrect; }
            }
            return m_isCorrect;
         }
         catch (Exception)
         { throw; }
      }
      public Boolean OPE_Save_NumerarHBL(ref Cab_Cotizacion_OV Item, ref String NumeroHBL, String Usuario)
      {
         try
         {
            return OPE_UpdateNumerarHBL(ref Item, ref NumeroHBL, Usuario);
         }
         catch (Exception)
         { throw; }
      }
      public Boolean OPE_Save_ValidarCuentasCorrientes(Int16 x_EMPR_Codigo, Int16 x_SUCR_Codigo, Int32 x_NVIA_Codigo, Nullable<Int16> x_CCOT_Tipo, Nullable<Int32> x_CCOT_Numero, ref String x_mensaje)
      {
         try
         {
            Boolean _isCorrect = true;
            _isCorrect = OPE_Validate_GenerarCuentasCorrientes(x_EMPR_Codigo, x_SUCR_Codigo, x_NVIA_Codigo, x_CCOT_Tipo, x_CCOT_Numero, ref x_mensaje);
            return _isCorrect;
         }
         catch (Exception)
         { throw; }
      }
      public Boolean OPE_Save_GenerarCuentasCorrientes(Int16 x_EMPR_Codigo, Int16 x_SUCR_Codigo, Int32 x_NVIA_Codigo, Nullable<Int16> x_CCOT_Tipo, Nullable<Int32> x_CCOT_Numero, Decimal x_CCCT_TipoCambio, DateTime x_CCCT_FecEmision, String x_AUDI_Usuario, Boolean AprobarViaje, ref String x_mensaje)
      {
         try
         {
            Boolean _isCorrect = true;

            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();

            _isCorrect = OPE_Validate_GenerarCuentasCorrientes(x_EMPR_Codigo, x_SUCR_Codigo, x_NVIA_Codigo, x_CCOT_Tipo, x_CCOT_Numero, ref x_mensaje);

            if (_isCorrect)
            { _isCorrect = OPE_Insert_GenerarCuentasCorrientes(x_EMPR_Codigo, x_SUCR_Codigo, x_NVIA_Codigo, x_CCOT_Tipo, x_CCOT_Numero, x_CCCT_TipoCambio, x_CCCT_FecEmision, x_AUDI_Usuario, ref x_mensaje); }

            if (_isCorrect && AprobarViaje)
            { _isCorrect = BL_NaveViaje.SaveAprobarStatment(x_NVIA_Codigo, x_AUDI_Usuario, ref x_mensaje); }

            if (_isCorrect)
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }

            return _isCorrect;
         }
         catch (Exception)
         { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }
      public Boolean OPE_Update_CalculaRebateGRR(String x_REBA_Tipo, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters) //(Nullable<Int32> x_ENTC_CodTransportista, Nullable<Int32> x_ENTC_CodCliente, Nullable<DateTime> x_FEC_IniEmbarque, Nullable<DateTime> x_FEC_FinEmbarque, Nullable<DateTime> x_FEC_IniLlegada, Nullable<DateTime> x_FEC_FinLlegada, String x_NRO_HBL, String x_NRO_OV)         
      {
         try
         {
            return OPE_Update_CalculaRebateSave(x_REBA_Tipo, x_filters);//(x_ENTC_CodTransportista, x_ENTC_CodCliente, x_FEC_IniEmbarque, x_FEC_FinEmbarque, x_FEC_IniLlegada, x_FEC_FinLlegada, x_NRO_HBL, x_NRO_OV);
         }
         catch (Exception)
         { throw; }
      }
      #endregion

      #region [ Reportes ]
      public System.Data.DataTable OPE_GetStatment(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 NVIA_Codigo, Nullable<Int16> CCOT_Tipo, Nullable<Int32> CCOT_Numero, String Usuario, Decimal TIPC_TipoCambio, Boolean SCOT_ChangeControl, Boolean CCOT_ServicioTransmision)
      {
         try
         {
            return SelectStatment(EMPR_Codigo, SUCR_Codigo, NVIA_Codigo, CCOT_Tipo, CCOT_Numero, Usuario, TIPC_TipoCambio, SCOT_ChangeControl, CCOT_ServicioTransmision);
         }
         catch (Exception)
         { throw; }
      }
      public System.Data.DataSet OPE_GetReporteGerencia(String REPO_StoredProcedure, Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime REPO_FechaInicio, DateTime REPO_FechaTermino, Decimal TIPC_TipoCambio)
      {
         try
         {
            return SelectReporteGerencia(REPO_StoredProcedure, EMPR_Codigo, SUCR_Codigo, REPO_FechaInicio, REPO_FechaTermino, TIPC_TipoCambio);
         }
         catch (Exception)
         { throw; }
      }
      public System.Data.DataSet OPE_GetReporteGerencia(String REPO_StoredProcedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return SelectReporteGerencia(REPO_StoredProcedure, x_filters);
         }
         catch (Exception) { throw; }
      }

      public System.Data.DataTable OPE_GetStatmentChange(String REPO_StoredProcedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return SelectStatmentChange(REPO_StoredProcedure, x_filters);
         }
         catch (Exception) { throw; }
      }
      #endregion
   }
}
