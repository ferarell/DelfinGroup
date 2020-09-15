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
	public partial class BLRebate : IBLRebate
	{
		#region [ Propiedades ]
      [Dependency]
      public IBLDetRebate BL_DetRebate { get; set; }
		#endregion
		
		#region [ Consultas ]
        public ObservableCollection<Rebate> GetAll(string x_CONC_TabReb, string x_CONC_CodReb, string x_ENTC_CodTransportista, DateTime x_REBA_FecIni)
		{
			try
			{
				return SelectAll(x_CONC_TabReb,x_CONC_CodReb ,x_ENTC_CodTransportista ,x_REBA_FecIni );
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Rebate GetOne(Int32 REBA_Codigo)
		{
			try
			{
				if (REBA_Codigo == null) { return null; }
				Rebate Item = SelectOne(REBA_Codigo);
            Item.ListDetRebate = BL_DetRebate.GetAllByRebate(REBA_Codigo);
            return Item;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save(ref Rebate Item)
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
						m_isCorrect = Update(ref Item); break;
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
						m_isCorrect = Delete(ref Item); break;
				}
				if (m_isCorrect)
				{
               for (int i = 0; i < Item.ListDetRebate.Count; i++)
               {
                  DetRebate ItemDetRebate = Item.ListDetRebate[i];
                  ItemDetRebate.REBA_Codigo = Item.REBA_Codigo;
                  if (ItemDetRebate.DREB_Valor <= 0)
                  { ItemDetRebate.Instance = Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted; }

                  m_isCorrect = BL_DetRebate.Save(ref ItemDetRebate);
                  if (!m_isCorrect && ItemDetRebate.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted) { break; } else { m_isCorrect = true; }
               }

               if (m_isCorrect)
               { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
               else
               { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
            }
				else
				{ Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
				return m_isCorrect;
			}
			catch (Exception)
			{ Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
		}
		public Boolean Save(ref ObservableCollection<Rebate> Items)
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
