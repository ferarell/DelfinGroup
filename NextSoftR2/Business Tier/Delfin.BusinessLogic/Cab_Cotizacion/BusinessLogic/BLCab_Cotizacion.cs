using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.BusinessEntity;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLCab_Cotizacion : IBLCab_Cotizacion
	{
		#region [ Propiedades ]
        [Dependency]
        public IBLDet_Cotizacion BLDet_Cotizacion { get; set; }

        [Dependency]
        public IBLDet_Cotizacion_Servicio BLDet_Cotizacion_Servicio { get; set; }
		#endregion
		
		#region [ Consultas ]
        public ObservableCollection<Cab_Cotizacion> GetAllByFiltros(Int32? x_ENTC_Codigo, String x_CCOT_NumDoc, DateTime x_CCOT_FecEmiIni, DateTime x_CCOT_FecEmiFin)
		{
			try
			{
				return SelectAllByFiltros(x_ENTC_Codigo,x_CCOT_NumDoc,x_CCOT_FecEmiIni,x_CCOT_FecEmiFin);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Cab_Cotizacion GetOne(Int32 CCOT_Codigo)
		{
			try
			{
				if (CCOT_Codigo == null) { return null; }
				return SelectOne(CCOT_Codigo);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save(ref Cab_Cotizacion Item)
		{
			try
			{
				Boolean m_isCorrect = true;
				Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
				switch (Item.Instance)
				{
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
						m_isCorrect = Insert(ref Item);
                        if (m_isCorrect)
                        {
                            /* Items Detalle Cotización */
                            if (Item.ItemsDet_Cotizacion != null && Item.ItemsDet_Cotizacion.Count > 0)
                            {
                                foreach (var _item in Item.ItemsDet_Cotizacion)
                                {
                                    Det_Cotizacion _Deta = new Det_Cotizacion();
                                    _Deta = _item;
                                    _Deta.CCOT_Codigo = Item.CCOT_Codigo;
                                    _Deta.Trasanct = false;
                                    m_isCorrect = BLDet_Cotizacion.Save(ref _Deta);
                                    if (!m_isCorrect) { break; }
                                }
                            }
                            /* Items Servicios Cotización */
                            if (Item.ItemsDet_Cotizacion_Servicio != null && Item.ItemsDet_Cotizacion_Servicio.Count > 0)
                            {
                                foreach (var _itemServ in Item.ItemsDet_Cotizacion_Servicio)
                                {
                                    Det_Cotizacion_Servicio _Servicio = new Det_Cotizacion_Servicio();
                                    _Servicio = _itemServ;
                                    _Servicio.CCOT_Codigo = Item.CCOT_Codigo;
                                    _Servicio.Trasanct = false;
                                    m_isCorrect = BLDet_Cotizacion_Servicio.Save(ref _Servicio);
                                    if (!m_isCorrect) { break; }
                                }
                            }
                        }
                        break;
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
						m_isCorrect = Update(ref Item);
                        /* Items Detalle Cotización */
                        if (Item.ItemsDet_Cotizacion != null && Item.ItemsDet_Cotizacion.Count > 0)
                        {
                            foreach (var _item in Item.ItemsDet_Cotizacion)
                            {
                                Det_Cotizacion _Deta = new Det_Cotizacion();
                                _Deta = _item;
                                _Deta.CCOT_Codigo = Item.CCOT_Codigo;
                                _Deta.Trasanct = false;
                                m_isCorrect = BLDet_Cotizacion.Save(ref _Deta);
                                if (!m_isCorrect) { break; }
                            }
                        }
                        /* Items Servicios Cotización */
                        if (Item.ItemsDet_Cotizacion_Servicio != null && Item.ItemsDet_Cotizacion_Servicio.Count > 0)
                        {
                            foreach (var _itemServ in Item.ItemsDet_Cotizacion_Servicio)
                            {
                                Det_Cotizacion_Servicio _Servicio = new Det_Cotizacion_Servicio();
                                _Servicio = _itemServ;
                                _Servicio.CCOT_Codigo = Item.CCOT_Codigo;
                                _Servicio.Trasanct = false;
                                m_isCorrect = BLDet_Cotizacion_Servicio.Save(ref _Servicio);
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
		public Boolean Save(ref ObservableCollection<Cab_Cotizacion> Items)
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
