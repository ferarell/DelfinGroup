using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;
using NextAdmin.BusinessLogic;

namespace Delfin.BusinessLogic
{
	public partial class BLCab_Cotizacion_OV : IBLCab_Cotizacion_OV
	{
		#region [ Propiedades ]
      [Dependency]
      public IBLContrato BL_Contrato { get; set; }
      [Dependency]
      public IBLDet_Cotizacion_OV_Flete BL_Det_Cotizacion_OV_Flete { get; set; }
      [Dependency]
      public IBLDet_Cotizacion_OV_Servicio BL_Det_Cotizacion_OV_Servicio { get; set; }
      [Dependency]
      public IBLDet_Cotizacion_OV_Novedad BL_Det_Cotizacion_OV_Novedad { get; set; }
      [Dependency]
      public IBLDet_Cotizacion_OV_Archivo BL_Det_Cotizacion_OV_Archivo { get; set; }
      [Dependency]
      public IBLNaveViaje BL_NaveViaje { get; set; }
      [Dependency]
      public IBLDetNaveViaje BL_DetNaveViaje { get; set; }
      [Dependency]
      public IBLParametros BL_Parametros { get; set; }
      [Dependency]
      public IBLUsuarios BL_Usuario { get; set; }

      [Dependency]
      public IBLDet_Cotizacion_OV_EventosTareas BL_EventosTareas { get; set; }
		#endregion
		
		#region [ Consultas ]
		public ObservableCollection<Cab_Cotizacion_OV> GetAll(Int16 EMPR_Codigo, Int16 SUCR_Codigo)
		{
			try
			{
				return SelectAll(EMPR_Codigo, SUCR_Codigo);
			}
			catch (Exception ex)
			{ throw ex; }
		}
      public Cab_Cotizacion_OV GetOne(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo)
		{
			try
			{
				if (CCOT_Numero == null || CCOT_Tipo == null) { return null; }

            Cab_Cotizacion_OV Item = SelectOneRelated(EMPR_Codigo, SUCR_Codigo, CCOT_Numero, CCOT_Tipo);
            //Item.ItemsFlete = BL_Det_Cotizacion_OV_Flete.GetAllByCab_Cotizacion_OV(CCOT_Numero, CCOT_Tipo);
            //Item.ItemsServicio = BL_Det_Cotizacion_OV_Servicio.GetAllByCab_Cotizacion_OV(CCOT_Tipo, CCOT_Numero);

            //if (Item.CCOT_Tipo == 2)
            //{
            //   if (Item.NVIA_Codigo.HasValue && Item.PUER_CodOrigen.HasValue && Item.PUER_CodDestino.HasValue) { Item.ItemNaveViaje = BL_DetNaveViaje.GetOneByOV(Item.CONS_TabRGM, Item.CONS_CodRGM, Item.CONS_TabVia, Item.CONS_CodVia, Item.PUER_CodOrigen.Value, Item.PUER_CodDestino.Value, Item.NVIA_Codigo.Value); } else { Item.ItemNaveViaje = null; }
            //   Item.ItemsArchivo = BL_Det_Cotizacion_OV_Archivo.GetAllByCab_Cotizacion_OV(CCOT_Numero, CCOT_Tipo);
            //   Item.ItemsNovedad = BL_Det_Cotizacion_OV_Novedad.GetAllByCab_Cotizacion_OV(CCOT_Numero, CCOT_Tipo);
            //}

            //if (Item.EMPR_Codigo.HasValue && Item.CONT_Codigo.HasValue)
            //{ Item.ItemContrato = BL_Contrato.GetOne(Item.EMPR_Codigo.Value,  Item.CONT_Codigo.Value); }
            return Item;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]



      public Cab_Cotizacion_OV Save(ref Cab_Cotizacion_OV Item, ref String CCOT_MensajeError, Cab_Cotizacion_OV.TipoInterfaz x_opcion)
      {
         try
         {
            switch (x_opcion)
            {
               case Cab_Cotizacion_OV.TipoInterfaz.OVC_Normal:
                  return Save(ref Item, ref CCOT_MensajeError);
                  break;
               case Cab_Cotizacion_OV.TipoInterfaz.OVC_Prefacturada:
                  return SavePrefacturados(ref Item, ref CCOT_MensajeError);
                  break;
               default:
                  break;
            }
         }
         catch (Exception)
         { throw; }
         return null;
      }

      public Cab_Cotizacion_OV SavePrefacturados(ref Cab_Cotizacion_OV Item, ref String CCOT_MensajeError)
      {
         Boolean m_isCorrect = true;
         Boolean m_isAdded = true;
         String m_usuario = "";
         try
         {
            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isAdded = false; 
                  m_usuario = Item.AUDI_UsrMod; 
                  break; 
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  
               default:
                  break;
            }

            if (m_isCorrect)
            {
               for (int indexServicio = 0; indexServicio < Item.ItemsServicio.Count; indexServicio++)
               {
                  Det_Cotizacion_OV_Servicio _itemServicio = Item.ItemsServicio[indexServicio];
                  _itemServicio.CCOT_Tipo = Item.CCOT_Tipo;
                  _itemServicio.CCOT_Numero = Item.CCOT_Numero;
                  m_isCorrect = BL_Det_Cotizacion_OV_Servicio.Save(ref _itemServicio, false);
                  if (!m_isCorrect) { break; }
               }
            }
            if (m_isCorrect)
            {
               Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction();

               if (Item.EMPR_Codigo.HasValue && Item.SUCR_Codigo.HasValue)
               { return GetOne(Item.EMPR_Codigo.Value, Item.SUCR_Codigo.Value, Item.CCOT_Numero, Item.CCOT_Tipo); }
               else
               { return null; }
            }
            else
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); return null; }
         }
         catch (Exception)
         { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
         return null;
      }

      public Cab_Cotizacion_OV Save(ref Cab_Cotizacion_OV Item, ref String CCOT_MensajeError)
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

               Item = SelectOneRelated(Item.EMPR_Codigo.Value, Item.SUCR_Codigo.Value, Item.CCOT_Numero, Item.CCOT_Tipo);
               CCOT_MensajeError = String.Format("El registro que esta editando ha sido modificado(Usuario: {0} - Fecha: {1}), el sistema cargará el registro con los valores actualizados, sus cambios no se han guardado.", (!String.IsNullOrEmpty(Item.AUDI_UsrMod) ? Item.AUDI_UsrMod : ""), (Item.AUDI_FecMod.HasValue ? Item.AUDI_FecMod.Value.ToLongDateString() : ""));
               
               return Item;
            }
            else
            {
               switch (Item.Instance)
               {
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                     m_isCorrect = Insert(ref Item); m_isAdded = true; m_usuario = Item.AUDI_UsrCrea; break;
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                     m_isCorrect = Update(ref Item); m_isAdded = false; m_usuario = Item.AUDI_UsrMod; break; break;
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                     m_isCorrect = Delete(ref Item);

                     if (m_isCorrect)
                     { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); return Item; }
                     else
                     { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); return null; }

                  default:
                     m_usuario = Item.AUDI_UsrMod; break;
               }
               if (m_isCorrect)
               {
                  for (int indexFlete = 0; indexFlete < Item.ItemsFlete.Count; indexFlete++)
                  {
                     Det_Cotizacion_OV_Flete _itemFlete = Item.ItemsFlete[indexFlete];
                     _itemFlete.CCOT_Tipo = Item.CCOT_Tipo;
                     _itemFlete.CCOT_Numero = Item.CCOT_Numero;
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
                     for (int indexEventoServicio = 0; indexEventoServicio < Item.ItemsEventosTareas.Count; indexEventoServicio++)
                     {
                        Det_Cotizacion_OV_EventosTareas _itemEventoTarea = Item.ItemsEventosTareas[indexEventoServicio];
                        _itemEventoTarea.CCOT_Tipo = Item.CCOT_Tipo;
                        _itemEventoTarea.CCOT_Numero = Item.CCOT_Numero;
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
               }
               if (m_isCorrect)
               {
                  Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction();

                  if (Item.EMPR_Codigo.HasValue && Item.SUCR_Codigo.HasValue)
                  { return GetOne(Item.EMPR_Codigo.Value, Item.SUCR_Codigo.Value, Item.CCOT_Numero, Item.CCOT_Tipo); }
                  else
                  { return null; }
               }
               else
               { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); return null; }
            }
			}
			catch (Exception)
			{ Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
		}
		public Boolean Save(ref ObservableCollection<Cab_Cotizacion_OV> Items)
		{
			try
			{
				Boolean m_isCorrect = true;
				Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
				for (int i = 0; i < Items.Count; i++)
				{
					var Item = Items.ElementAt(i);
					switch (Item.Instance)
					{
						case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
							m_isCorrect = Insert(ref Item); break;
						case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
							m_isCorrect = Update(ref Item); break;
						case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
							m_isCorrect = Delete(ref Item); break;
					}
				if (!m_isCorrect)
				{ Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); return m_isCorrect; }
				}
				if (m_isCorrect)
				{ Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
				else
				{ Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
				return m_isCorrect;
			}
			catch (Exception)
			{ Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
		}
		#endregion
   }
}
