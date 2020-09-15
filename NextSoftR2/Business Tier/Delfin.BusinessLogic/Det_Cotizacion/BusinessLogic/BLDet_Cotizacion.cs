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
	public partial class BLDet_Cotizacion : IBLDet_Cotizacion
	{
		#region [ Propiedades ]
		#endregion
		
		#region [ Consultas ]
      public ObservableCollection<Det_Cotizacion> GetAllByCotizacion(Int32 x_CCOT_Codigo, String x_CTAR_Tipo)
		{
			try
			{
            return SelectAllByCotizacion(x_CCOT_Codigo, x_CTAR_Tipo);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Det_Cotizacion GetOne(Int32 CCOT_Codigo, Int32 DCOT_Item)
		{
			try
			{
				if (CCOT_Codigo == null || DCOT_Item == null) { return null; }
				return SelectOne(CCOT_Codigo, DCOT_Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save(ref Det_Cotizacion Item)
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
                            m_isCorrect = Insert(ref Item); break;
                        case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                            m_isCorrect = Update(ref Item); break;
                        case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                            m_isCorrect = Delete(ref Item); break;
                    }
                    if (m_isCorrect)
                    { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
                    else
                    { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); } 
                }
                else   // sin transacción
                {
                    switch (Item.Instance)
                    {
                        case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                            m_isCorrect = Insert(ref Item); break;
                        case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                            m_isCorrect = Update(ref Item); break;
                        case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                            m_isCorrect = Delete(ref Item); break;
                    }
                }
				return m_isCorrect;
			}
			catch (Exception)
			{ Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
		}
		public Boolean Save(ref ObservableCollection<Det_Cotizacion> Items)
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
