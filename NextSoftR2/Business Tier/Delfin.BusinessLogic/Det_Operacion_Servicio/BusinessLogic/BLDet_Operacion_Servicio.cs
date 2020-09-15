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
	public partial class BLDet_Operacion_Servicio : IBLDet_Operacion_Servicio
	{
		#region [ Propiedades ]
		#endregion
		
		#region [ Consultas ]
        public ObservableCollection<Det_Operacion_Servicio> GetAllByOperacion(Int32 x_COPE_Codigo)
		{
			try
			{
                return SelectAllByOperacion(x_COPE_Codigo);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Det_Operacion_Servicio GetOne(Int32 SOPE_Item, Int32 COPE_Codigo)
		{
			try
			{
				if (SOPE_Item == null || COPE_Codigo == null) { return null; }
				return SelectOne(SOPE_Item, COPE_Codigo);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save( Det_Operacion_Servicio Item)
		{
			try
			{
				Boolean m_isCorrect = true;
                if (Item.Trasanct)
                {
                    Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
                    switch (Item.Instance)
                    {
                        case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                            m_isCorrect = Insert(Item); break;
                        case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                            m_isCorrect = Update(Item); break;
                        case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                            m_isCorrect = Delete(Item); break;
                    }
                    if (m_isCorrect)
                    { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
                    else
                    { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
                    return m_isCorrect;
                }
                else
                {
                    switch (Item.Instance)
                    {
                        case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                            m_isCorrect = Insert(Item); break;
                        case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                            m_isCorrect = Update(Item); break;
                        case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                            m_isCorrect = Delete(Item); break;
                    }
                    return m_isCorrect;
                }
			}
			catch (Exception)
			{ Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
		}
		public Boolean Save(ref ObservableCollection<Det_Operacion_Servicio> Items)
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
							m_isCorrect = Insert( Item); break;
						case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
							m_isCorrect = Update( Item); break;
						case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
							m_isCorrect = Delete( Item); break;
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
