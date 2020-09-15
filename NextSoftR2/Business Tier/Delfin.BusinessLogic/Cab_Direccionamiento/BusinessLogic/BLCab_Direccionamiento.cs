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
	public partial class BLCab_Direccionamiento : IBLCab_Direccionamiento
	{
		#region [ Propiedades ]
		#endregion
		
		#region [ Consultas ]
      public DataTable GetAll(DateTime CDIR_FecEmisionInicio, DateTime CDIR_FecEmisionFin, Nullable<DateTime> CDIR_FecArriboInicio, Nullable<DateTime> CDIR_FecArriboFin, String CDIR_HBL, String CDIR_MBL, Int32 ENTC_CodCliente, Int32 ENTC_CodLinea, Int32 ENTC_CodTemporal, Int16 NAVE_Codigo)
		{
			try
			{
				return SelectAll(CDIR_FecEmisionInicio, CDIR_FecEmisionFin, CDIR_FecArriboInicio, CDIR_FecArriboFin, CDIR_HBL, CDIR_MBL, ENTC_CodCliente, ENTC_CodLinea, ENTC_CodTemporal, NAVE_Codigo);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Cab_Direccionamiento GetOne(Int32 CDIR_Codigo)
		{
			try
			{
				if (CDIR_Codigo == null) { return null; }
				return SelectOne(CDIR_Codigo);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save( ref Cab_Direccionamiento Item)
		{
			try
			{
				Boolean m_isCorrect = true;
				Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
				switch (Item.Instance)
				{
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
						m_isCorrect = Insert(ref Item); break;
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
		public Boolean Save( ObservableCollection<Cab_Direccionamiento> Items)
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
							m_isCorrect = Insert( ref Item); break;
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
