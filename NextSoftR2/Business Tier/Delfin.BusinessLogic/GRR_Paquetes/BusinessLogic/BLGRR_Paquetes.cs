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
	public partial class BLGRR_Paquetes : IBLGRR_Paquetes
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
		public ObservableCollection<GRR_Paquetes> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				return SelectAllByFilter(x_procedure, x_filters);
			}
			catch (Exception)
			{ throw; }
		}
		public ObservableCollection<GRR_Paquetes> GetAll()
		{
			try
			{
				return SelectAll();
			}
			catch (Exception)
			{ throw; }
		}
		public GRR_Paquetes GetOne(String REBA_Tipo, Int32 REBA_Codigo, Int32 PACK_Codigo)
		{
			try
			{
				if (REBA_Tipo == null || REBA_Codigo == null || PACK_Codigo == null) { return null; }
				return SelectOne(REBA_Tipo, REBA_Codigo, PACK_Codigo);
			}
			catch (Exception)
			{ throw; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save(ref GRR_Paquetes Item)
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
		public Boolean Save(ref ObservableCollection<GRR_Paquetes> Items)
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
