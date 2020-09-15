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
	public partial class BLServicio_Via : IBLServicio_Via
	{
		#region [ Propiedades ]
		#endregion
		
		#region [ Consultas ]
		public ObservableCollection<Servicio_Via> GetAll()
		{
			try
			{
				return SelectAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Servicio_Via GetOne(String CONS_TabVIA, String CONS_CodVIA, Int32 SERV_Codigo)
		{
			try
			{
				if (CONS_TabVIA == null || CONS_CodVIA == null || SERV_Codigo == null) { return null; }
				return SelectOne(CONS_TabVIA, CONS_CodVIA, SERV_Codigo);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save(ref Servicio_Via Item)
		{
			try
			{
				Boolean m_isCorrect = true;
				switch (Item.Instance)
				{
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
						m_isCorrect = Insert(ref Item); break;
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
						m_isCorrect = Delete(ref Item); break;
				}
				return m_isCorrect;
			}
			catch (Exception)
			{ throw; }
		}
		public Boolean Save(ref ObservableCollection<Servicio_Via> Items)
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
                  case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                     m_isCorrect = Delete(ref Item); break;
               }
            }
				return m_isCorrect;
			}
			catch (Exception)
			{ throw; }
		}
		#endregion
	}
}
