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
	public partial class BLCab_Tarjas : IBLCab_Tarjas
	{
		#region [ Propiedades ]
        [Dependency]
        public IBLDet_Tarjas BLDet_Tarjas { get; set; }
		#endregion
		
		#region [ Consultas ]
		public ObservableCollection<Cab_Tarjas> GetAll()
		{
			try
			{
				return SelectAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Cab_Tarjas GetOne(Int32 TARJ_Codigo)
		{
			try
			{
				if (TARJ_Codigo == null) { return null; }
				return SelectOne(TARJ_Codigo);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save(ref Cab_Tarjas Item)
		{
			try
			{
				Boolean m_isCorrect = true;
				Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
				switch (Item.Instance)
				{
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
						m_isCorrect = Insert(ref Item);
                        /* Items Detalle Tarja */
                        if (Item.ItemsDet_Tarjas != null && Item.ItemsDet_Tarjas.Count > 0)
                        {
                            foreach (var _item in Item.ItemsDet_Tarjas)
                            {
                                Det_Tarjas _Deta = new Det_Tarjas();
                                _Deta = _item;
                                _Deta.TARJ_Codigo = Item.TARJ_Codigo;
                                _Deta.Trasanct = false;
                                m_isCorrect = BLDet_Tarjas.Save(_Deta);
                                if (!m_isCorrect) { break; }
                            }
                        }
                        break;
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
						m_isCorrect = Update(ref Item);
                        /* Items Detalle Tarja */
                        if (Item.ItemsDet_Tarjas != null && Item.ItemsDet_Tarjas.Count > 0)
                        {
                            foreach (var _item in Item.ItemsDet_Tarjas)
                            {
                                Det_Tarjas _Deta = new Det_Tarjas();
                                _Deta = _item;
                                _Deta.TARJ_Codigo = Item.TARJ_Codigo;
                                _Deta.Trasanct = false;
                                m_isCorrect = BLDet_Tarjas.Save(_Deta);
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
		public Boolean Save(ref ObservableCollection<Cab_Tarjas> Items)
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
