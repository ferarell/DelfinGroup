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
	public partial class BLCab_Seguimientos : IBLCab_Seguimientos
	{
		#region [ Propiedades ]
        [Dependency]
        public IBLDet_Seguimientos BLDet_Seguimientos { get; set; }
		#endregion
		
		#region [ Consultas ]
        public ObservableCollection<Cab_Seguimientos> GetAllByCabSeguimientoByFiltros(DateTime x_CSEG_FechaEmisionIni, DateTime x_CSEG_FechaEmisionFin, String x_Nave)
		{
			try
			{
			    return SelectAllByFiltros(x_CSEG_FechaEmisionIni, x_CSEG_FechaEmisionFin, x_Nave);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Cab_Seguimientos GetOne(Int32 CSEG_Codigo)
		{
			try
			{
				if (CSEG_Codigo == null) { return null; }
				return SelectOne(CSEG_Codigo);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save(ref Cab_Seguimientos Item)
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
                        if (Item.ItemsDetSeguimientos != null && Item.ItemsDetSeguimientos.Count > 0)
                        {
                            foreach (var item in Item.ItemsDetSeguimientos)
                            {
                                Det_Seguimientos _Deta = new Det_Seguimientos();
                                _Deta = item;
                                _Deta.CSEG_Codigo = Item.CSEG_Codigo;
                                _Deta.Tranct = false;
                                m_isCorrect = BLDet_Seguimientos.Save(_Deta);
                                if (!m_isCorrect) { break; }
                            }
                        }
                        break;
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
						m_isCorrect = Update(ref Item);
                        if (Item.ItemsDetSeguimientos != null && Item.ItemsDetSeguimientos.Count > 0)
                        {
                            foreach (var item in Item.ItemsDetSeguimientos)
                            {
                                Det_Seguimientos _Deta = new Det_Seguimientos();
                                _Deta = item;
                                _Deta.CSEG_Codigo = Item.CSEG_Codigo;
                                _Deta.Tranct = false;
                                m_isCorrect = BLDet_Seguimientos.Save(_Deta);
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
		public Boolean Save(ref ObservableCollection<Cab_Seguimientos> Items)
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
