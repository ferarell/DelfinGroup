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
   public partial class BLDet_Cotizacion_OV_EventosTareas : IBLDet_Cotizacion_OV_EventosTareas
	{
		#region [ Propiedades ]
		#endregion
		
		#region [ Consultas ]
      public ObservableCollection<Det_Cotizacion_OV_EventosTareas> GetAll()
		{
			try
			{
				return SelectAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
      public Det_Cotizacion_OV_EventosTareas GetOne(Int32 CCOT_Numero, Int16 CCOT_Tipo, Int16 EVEN_Item)
		{
			try
			{
				if (CCOT_Numero == null || CCOT_Tipo == null || EVEN_Item == null) { return null; }
				return SelectOne(CCOT_Numero, CCOT_Tipo, EVEN_Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
      public Boolean Save(ref Det_Cotizacion_OV_EventosTareas Item, Boolean Tran)
		{
			try
			{
				Boolean m_isCorrect = true;
            if (Tran) { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction(); }
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
            { if (Tran) { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); } }
				else
            { if (Tran) { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); } }
				return m_isCorrect;
			}
			catch (Exception)
         { if (Tran) { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); } throw; }
		}
      public Boolean Save(ref ObservableCollection<Det_Cotizacion_OV_EventosTareas> Items)
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
