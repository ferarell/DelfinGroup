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
	public partial class BLEntidad_Acuerdo : IBLEntidad_Acuerdo
	{
		#region [ Propiedades ]
		#endregion
		
		#region [ Consultas ]
		public ObservableCollection<Entidad_Acuerdo> GetAll()
		{
			try
			{
				return SelectAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
        public Entidad_Acuerdo GetOne(Int32 ENTC_Codigo)
		{
			try
			{
                if (ENTC_Codigo == 0) { return null; }
                return SelectOne(ENTC_Codigo);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save(ref Entidad_Acuerdo Item)
		{
			try
			{
				Boolean m_isCorrect = true;
				//Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
				switch (Item.Instance)
				{
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
						m_isCorrect = Insert(ref Item); break;
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
						m_isCorrect = Update(ref Item); break;
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
						m_isCorrect = Delete(ref Item); break;
				}
                //if (m_isCorrect)
                //{ Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
                //else
                //{ Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
				return m_isCorrect;
			}
			catch (Exception)
            { throw;   }
		}
		public Boolean Save(ref ObservableCollection<Entidad_Acuerdo> Items)
		{
         try
         {
            Boolean m_isCorrect = true;
            //Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
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
               { 
                  //Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); 
                  return m_isCorrect; 
               }
            }
            //if (m_isCorrect)
            //{ Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
            //else
            //{ Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         { 
            //Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); 
            throw; 
         }
		}
		#endregion

       
    }
}
