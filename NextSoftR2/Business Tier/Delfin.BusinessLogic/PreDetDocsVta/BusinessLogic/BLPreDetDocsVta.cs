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
	public partial class BLPreDetDocsVta : IBLPreDetDocsVta
	{
		#region [ Propiedades ]
		#endregion
		
		#region [ Consultas ]
        public ObservableCollection<PreDetDocsVta> GetAllPorDOCV_Codigo(Int32 x_DOCV_Codigo)
		{
			try
			{
				return SelectAllPorDOCV_Codigo(x_DOCV_Codigo);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public PreDetDocsVta GetOne(Int16 PDDO_Item, Int32 DOCV_Codigo)
		{
			try
			{
				if (PDDO_Item == null || DOCV_Codigo == null) { return null; }
				return SelectOne(PDDO_Item, DOCV_Codigo);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save(ref PreDetDocsVta Item)
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
                else
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
                    return m_isCorrect;
                }
				return m_isCorrect;
			}
			catch (Exception)
			{ Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
		}
		public Boolean Save(ref ObservableCollection<PreDetDocsVta> Items)
		{
		    try
		    {
		        Boolean m_isCorrect = true;
		        //Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
		        //for (int i = 0; i < Items.Count; i++)
		        //{
		        //    var Item = Items.ElementAt(i);
		        //    switch (Item.Instance)
		        //    {
		        //        case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
		        //            m_isCorrect = Insert(ref Item); break;
		        //        case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
		        //            m_isCorrect = Update(ref Item); break;
		        //        case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
		        //            m_isCorrect = Delete(ref Item); break;
		        //    }
		        //    if (!m_isCorrect)
		        //    { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); return m_isCorrect; }
		        //}
		        //if (m_isCorrect)
		        //{ Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
		        //else
		        //{ Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }


		        for (int i = 0; i < Items.Count; i++)
		        {
		            var Item = Items.ElementAt(i);
		            switch (Item.Instance)
		            {
		                case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
		                    m_isCorrect = Insert(ref Item);
		                    break;
		                case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
		                    m_isCorrect = Update(ref Item);
		                    break;
		                case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
		                    m_isCorrect = Delete(ref Item);
		                    break;
		            }
		            if (!m_isCorrect)
		            {
		                return m_isCorrect;
		            }
		        }
		        return m_isCorrect;
		    }
		    catch (Exception) { return false; }
		}
		#endregion
	}
}
