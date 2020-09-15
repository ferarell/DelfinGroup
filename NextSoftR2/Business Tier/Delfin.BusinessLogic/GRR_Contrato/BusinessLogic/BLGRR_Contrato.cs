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
	public partial class BLGRR_Contrato : IBLGRR_Contrato
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
		public ObservableCollection<GRR_Contrato> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				return SelectAllByFilter(x_procedure, x_filters);
			}
			catch (Exception)
			{ throw; }
		}
		public ObservableCollection<GRR_Contrato> GetAll()
		{
			try
			{
				return SelectAll();
			}
			catch (Exception)
			{ throw; }
		}
      public GRR_Contrato GetOne(String REBA_Tipo, Int32 REBA_Codigo, Int32 CONT_Codigo)
		{
			try
			{
				if (REBA_Tipo == null || REBA_Codigo == null) { return null; }
            return SelectOne(REBA_Tipo, REBA_Codigo, CONT_Codigo);
			}
			catch (Exception)
			{ throw; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save(ref GRR_Contrato Item)
		{
			try
			{
				Boolean m_isCorrect = true;
				m_isCorrect = Insert(ref Item);
				return m_isCorrect;
			}
			catch (Exception)
			{ throw; }
		}
		public Boolean Save(ref ObservableCollection<GRR_Contrato> Items)
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
		#endregion
	}
}
