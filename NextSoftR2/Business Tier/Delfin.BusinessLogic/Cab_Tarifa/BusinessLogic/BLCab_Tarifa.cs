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
	public partial class BLCab_Tarifa : IBLCab_Tarifa
	{
		#region [ Propiedades ]
        [Dependency]
        public IBLDet_Tarifa BLDet_Tarifa { get; set; }

        [Dependency]
        public IBLDet_Tarifa_Servicio BLDet_Tarifa_Servicio { get; set; }
		#endregion
		
		#region [ Consultas ]
		public ObservableCollection<Cab_Tarifa> GetAll()
		{
			try
			{
				return SelectAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Cab_Tarifa GetOne(String CTAR_Tipo, Int32 CTAR_Codigo)
		{
			try
			{
				if (CTAR_Tipo == null || CTAR_Codigo == null) { return null; }
				return SelectOne(CTAR_Tipo, CTAR_Codigo);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save(ref Cab_Tarifa Item)
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
                            /* Items Detalle Tarifa */
                            if (Item.ItemsDet_Tarifa != null && Item.ItemsDet_Tarifa.Count > 0 )
                            {
                                foreach (var _item in Item.ItemsDet_Tarifa)
                                {
                                    Det_Tarifa _Deta = new Det_Tarifa();
                                    _Deta = _item;
                                    _Deta.CTAR_Codigo = Item.CTAR_Codigo;
                                    _Deta.CTAR_Tipo = Item.CTAR_Tipo;
                                    _Deta.Trasanct = false;
                                    m_isCorrect = BLDet_Tarifa.Save(ref  _Deta);
                                    if (!m_isCorrect) { break; }
                                } 
                            }
                            /* Items Servicios */
                            if (Item.ItemsDet_Tarifa_Servicio != null && Item.ItemsDet_Tarifa_Servicio.Count > 0)
                            {
                                foreach (var _itemServ in Item.ItemsDet_Tarifa_Servicio)
                                {
                                    Det_Tarifa_Servicio _Servicio = new Det_Tarifa_Servicio();
                                    _Servicio = _itemServ;
                                    _Servicio.CTAR_Codigo = Item.CTAR_Codigo;
                                    _Servicio.CTAR_Tipo = Item.CTAR_Tipo;
                                    _Servicio.Trasanct = false;
                                    m_isCorrect = BLDet_Tarifa_Servicio.Save(ref _Servicio);
                                    if (!m_isCorrect) { break; }
                                }
                            }
                        }
                        break;
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
						m_isCorrect = Update(ref Item);
                        if (m_isCorrect)
                        {
                            /* Items Detalle Tarifa */
                            if (Item.ItemsDet_Tarifa != null && Item.ItemsDet_Tarifa.Count > 0)
                            {
                                foreach (var _item in Item.ItemsDet_Tarifa)
                                {
                                    Det_Tarifa _Deta = new Det_Tarifa();
                                    _Deta = _item;
                                    _Deta.CTAR_Codigo = Item.CTAR_Codigo;
                                    _Deta.CTAR_Tipo = Item.CTAR_Tipo;
                                    _Deta.Trasanct = false;
                                    m_isCorrect = BLDet_Tarifa.Save(ref  _Deta);
                                    if (!m_isCorrect) { break; }
                                }
                            }
                            /* Items Servicios */
                            if (Item.ItemsDet_Tarifa_Servicio != null && Item.ItemsDet_Tarifa_Servicio.Count > 0)
                            {
                                foreach (var _itemServ in Item.ItemsDet_Tarifa_Servicio)
                                {
                                    Det_Tarifa_Servicio _Servicio = new Det_Tarifa_Servicio();
                                    _Servicio = _itemServ;
                                    _Servicio.CTAR_Codigo = Item.CTAR_Codigo;
                                    _Servicio.CTAR_Tipo = Item.CTAR_Tipo;
                                    _Servicio.Trasanct = false;
                                    m_isCorrect = BLDet_Tarifa_Servicio.Save(ref _Servicio);
                                    if (!m_isCorrect) { break; }
                                }
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
		public Boolean Save(ref ObservableCollection<Cab_Tarifa> Items)
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
