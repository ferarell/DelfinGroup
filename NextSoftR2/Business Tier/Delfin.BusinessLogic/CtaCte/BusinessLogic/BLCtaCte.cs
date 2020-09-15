using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLCtaCte : IBLCtaCte
	{
		#region [ Propiedades ]
		#endregion
		
		#region [ Consultas ]
		public System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				return SelectAllByFilterDT(x_procedure, x_filters);
			}
			catch (Exception)
			{ throw; }
		}
		public ObservableCollection<CtaCte> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				return SelectAllByFilter(x_procedure, x_filters);
			}
			catch (Exception)
			{ throw; }
		}
		public ObservableCollection<CtaCte> GetAll()
		{
			try
			{
				return SelectAll();
			}
			catch (Exception)
			{ throw; }
		}
		public CtaCte GetOne(Int16 EMPR_Codigo, Int32 CCCT_Codigo)
		{
			try
			{
				if (EMPR_Codigo == null || CCCT_Codigo == null) { return null; }
				return SelectOne(EMPR_Codigo, CCCT_Codigo);
			}
			catch (Exception)
			{ throw; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save(ref CtaCte Item)
		{
			try
			{
				Boolean m_isCorrect = true;
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
			catch (Exception)
			{ throw; }
		}

		public Boolean Save(ref ObservableCollection<CtaCte> Items)
		{
			try
			{
				Boolean m_isCorrect = true;
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
				{ return m_isCorrect; }
				}
				return m_isCorrect;
			}
			catch (Exception)
			{ throw; }
		}

        public String SaveILD(ref CtaCte Item)
        {
            try
            {
                Boolean m_isCorrect = true;
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
                {return "OK";}
                else
                {return "";}
                
            }
            catch (Exception)
            { throw; }
        }
		#endregion
	}
}
