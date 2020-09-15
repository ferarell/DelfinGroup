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
	public partial class BLCierresChangeControl : IBLCierresChangeControl
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
		public ObservableCollection<CierresChangeControl> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				return SelectAllByFilter(x_procedure, x_filters);
			}
			catch (Exception)
			{ throw; }
		}
		public ObservableCollection<CierresChangeControl> GetAll()
		{
			try
			{
				return SelectAll();
			}
			catch (Exception)
			{ throw; }
		}
		public CierresChangeControl GetOne(Int16 EMPR_Codigo, Int16 SUCR_Codigo, String CHAN_Anio, String CHAN_Mes)
		{
			try
			{
				if (EMPR_Codigo == null || SUCR_Codigo == null || CHAN_Anio == null || CHAN_Mes == null) { return null; }
				return SelectOne(EMPR_Codigo, SUCR_Codigo, CHAN_Anio, CHAN_Mes);
			}
			catch (Exception)
			{ throw; }
		}
		#endregion
		
		#region [ Metodos ]
      public Boolean Save(ref CierresChangeControl Item, ref String MensajeError)
		{
			try
			{
				Boolean m_isCorrect = true;
            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
				switch (Item.Instance)
				{
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
						m_isCorrect = Cerrar(ref Item, ref MensajeError); break;
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
						m_isCorrect = Aperturar(ref Item, ref MensajeError); break;
               //case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
               //   m_isCorrect = Delete(ref Item); break;
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
      public Boolean Save(ref ObservableCollection<CierresChangeControl> Items, ref String MensajeError)
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
							m_isCorrect = Cerrar(ref Item, ref MensajeError); break;
						case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
							m_isCorrect = Aperturar(ref Item, ref MensajeError); break;
                  //case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  //   m_isCorrect = Delete(ref Item); break;
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
