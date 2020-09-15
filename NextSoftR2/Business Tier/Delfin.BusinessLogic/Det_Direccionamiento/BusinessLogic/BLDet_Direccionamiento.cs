using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.BusinessLogic;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLDet_Direccionamiento : IBLDet_Direccionamiento
	{
		#region [ Propiedades ]
		#endregion
		
		#region [ Consultas ]
		public ObservableCollection<Det_Direccionamiento> GetAll()
		{
			try
			{
				return SelectAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public DataTable GetOne(Int32 DDIR_Item, Int32 CDIR_Codigo)
		{
			try
			{
				return SelectOne(DDIR_Item, CDIR_Codigo);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save( Det_Direccionamiento Item)
		{
			try
			{
				Boolean m_isCorrect = true;
				Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
				switch (Item.Instance)
				{
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
						m_isCorrect = Insert( Item); break;
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
						m_isCorrect = Update( Item); break;
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
						m_isCorrect = Delete( Item); break;
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
		public Boolean Save( ObservableCollection<Det_Direccionamiento> Items)
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
