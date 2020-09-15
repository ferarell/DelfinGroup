using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLCab_Operacion : IBLCab_Operacion
	{
		#region [ Propiedades ]
        [Dependency]
        public IBLDet_Operacion BLDet_Operacion { get; set; }

        [Dependency]
        public IBLDet_Operacion_Servicio BLDet_Operacion_Servicio { get; set; }
		#endregion
		
		#region [ Consultas ]
        public ObservableCollection<Cab_Operacion> GetAllByFiltros(Int32? x_ENTC_Codigo, String x_COPE_NumDoc, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin, Int32 x_FacCliente, Int32 x_FacProveedor, Nullable<Int32> x_COPE_Codigo)
        {
            try
            {
                return SelectAllByFiltros(x_ENTC_Codigo, x_COPE_NumDoc, x_COPE_FecEmiIni, x_COPE_FecEmiFin, x_FacCliente, x_FacProveedor, x_COPE_Codigo);
            }
            catch (Exception ex)
            { throw ex; }
        }
		public Cab_Operacion GetOne(Int32 COPE_Codigo)
		{
			try
			{
				if (COPE_Codigo == null) { return null; }
				return SelectOne(COPE_Codigo);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
      public Boolean Save(ref Cab_Operacion Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                  m_isCorrect = Insert(ref Item);
                  /* Items Detalle Operación */
                  if (Item.ItemsDet_Operacion != null && Item.ItemsDet_Operacion.Count > 0)
                  {
                     foreach (var _item in Item.ItemsDet_Operacion)
                     {
                        Det_Operacion _Deta = new Det_Operacion();
                        _Deta = _item;
                        _Deta.COPE_Codigo = Item.COPE_Codigo;
                        _Deta.Trasanct = false;
                        _Deta.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added;
                        m_isCorrect = BLDet_Operacion.Save(_Deta);
                        if (!m_isCorrect) { break; }
                     }
                  }
                  /* Items Servicios Operación */
                  if (Item.ItemsDet_Operacion_Servicio != null && Item.ItemsDet_Operacion_Servicio.Count > 0)
                  {
                     foreach (var _itemServ in Item.ItemsDet_Operacion_Servicio)
                     {
                        Det_Operacion_Servicio _Servicio = new Det_Operacion_Servicio();
                        _Servicio = _itemServ;
                        _Servicio.COPE_Codigo = Item.COPE_Codigo;
                        _Servicio.Trasanct = false;
                        _Servicio.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added;
                        _Servicio.AUDI_UsrCrea = Item.AUDI_UsrCrea;
                        m_isCorrect = BLDet_Operacion_Servicio.Save(_Servicio);
                        if (!m_isCorrect) { break; }
                     }
                  }
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = Update(ref Item);
                  /* Eliminar los detalles de operacion */
                  if (Item.ItemsDet_Operacion_Eliminados != null && Item.ItemsDet_Operacion_Eliminados.Count > 0 && m_isCorrect)
                  {
                     foreach (Entities.Det_Operacion iEliminados in Item.ItemsDet_Operacion_Eliminados)
                     {
                        iEliminados.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted;
                        Det_Operacion _Deta = new Det_Operacion();
                        _Deta = iEliminados;
                        _Deta.COPE_Codigo = Item.COPE_Codigo;
                        _Deta.Trasanct = false;
                        BLDet_Operacion.Save(_Deta);
                        //if (!m_isCorrect) { break; }
                     }
                  }
                  /* Items Detalle Operación */
                  if (Item.ItemsDet_Operacion != null && Item.ItemsDet_Operacion.Count > 0 && m_isCorrect)
                  {
                     foreach (var _item in Item.ItemsDet_Operacion)
                     {
                        Det_Operacion _Deta = new Det_Operacion();
                        _Deta = _item;
                        _Deta.COPE_Codigo = Item.COPE_Codigo;
                        _Deta.Trasanct = false;
                        m_isCorrect = BLDet_Operacion.Save(_Deta);
                        if (!m_isCorrect) { break; }
                     }
                  }
                  /* Eliminar Items Servicios Operación */
                  if (Item.ItemsDet_Operacion_Servicio_Eliminados != null && Item.ItemsDet_Operacion_Servicio_Eliminados.Count > 0 && m_isCorrect)
                  {
                     foreach (Entities.Det_Operacion_Servicio _itemServ in Item.ItemsDet_Operacion_Servicio_Eliminados)
                     {
                        Det_Operacion_Servicio _Servicio = new Det_Operacion_Servicio();
                        _Servicio = _itemServ;
                        _Servicio.COPE_Codigo = Item.COPE_Codigo;
                        _Servicio.Trasanct = false;
                        _Servicio.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted;
                        _Servicio.AUDI_UsrCrea = Item.AUDI_UsrMod;
                        BLDet_Operacion_Servicio.Save(_Servicio);
                        //if (!m_isCorrect) { break; }
                     }
                  }

                  /* Items Servicios Operación */
                  if (Item.ItemsDet_Operacion_Servicio != null && Item.ItemsDet_Operacion_Servicio.Count > 0 && m_isCorrect)
                  {
                     foreach (var _itemServ in Item.ItemsDet_Operacion_Servicio)
                     {
                        Det_Operacion_Servicio _Servicio = new Det_Operacion_Servicio();
                        _Servicio = _itemServ;
                        _Servicio.COPE_Codigo = Item.COPE_Codigo;
                        _Servicio.Trasanct = false;
                        //_Servicio.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added;
                        _Servicio.AUDI_UsrCrea = Item.AUDI_UsrMod;
                        if (_Servicio.SOPE_Item == 0)
                        {
                           _Servicio.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added;
                        }
                        m_isCorrect = BLDet_Operacion_Servicio.Save(_Servicio);
                        if (!m_isCorrect) { break; }
                     }
                  }
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  m_isCorrect = Delete(ref Item); break;
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
		public Boolean Save(ref ObservableCollection<Cab_Operacion> Items)
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
