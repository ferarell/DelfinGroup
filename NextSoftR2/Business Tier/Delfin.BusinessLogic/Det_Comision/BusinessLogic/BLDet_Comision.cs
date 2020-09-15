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
	public partial class BLDet_Comision : IBLDet_Comision
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
		public ObservableCollection<Det_Comision> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				return SelectAllByFilter(x_procedure, x_filters);
			}
			catch (Exception)
			{ throw; }
		}
		public ObservableCollection<Det_Comision> GetAll()
		{
			try
			{
				return SelectAll();
			}
			catch (Exception)
			{ throw; }
		}
		public Det_Comision GetOne(Int32 COMI_Codigo, Int32 DCOM_Item)
		{
			try
			{
				if (COMI_Codigo == null || DCOM_Item == null) { return null; }
				return SelectOne(COMI_Codigo, DCOM_Item);
			}
			catch (Exception)
			{ throw; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save(ref Det_Comision Item)
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
		public Boolean Save(ref ObservableCollection<Det_Comision> Items)
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
