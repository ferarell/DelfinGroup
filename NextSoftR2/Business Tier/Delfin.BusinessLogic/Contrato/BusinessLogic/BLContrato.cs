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
	public partial class BLContrato : IBLContrato
	{
		#region [ Propiedades ]
      [Dependency]
      public IBLTarifa BL_Tarifa { get; set; }
		#endregion
		
		#region [ Consultas ]
		public ObservableCollection<Contrato> GetAll(Int16 EMPR_Codigo)
		{
			try
			{
            return SelectAll(EMPR_Codigo);
			}
			catch (Exception ex)
			{ throw ex; }
		}
      public Contrato GetOne(Int16 EMPR_Codigo, Int32 CONT_Codigo)
		{
			try
			{
            //if (CONT_Codigo == null) { return null; }
            Entities.Contrato Item = SelectOne(EMPR_Codigo, CONT_Codigo);
            if (Item != null && Item.CONT_Codigo.HasValue)
            { Item.ListTarifa = BL_Tarifa.GetAllByContrato(Item.CONT_Codigo.Value); }
            return Item;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
      public Int32 Save(ref Contrato Item, Boolean Tarifario)
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
               if (Tarifario)
               {
                  for (int i = 0; i < Item.ListTarifa.Count; i++)
                  {
                     Tarifa itemTarifa = Item.ListTarifa[i];
                     if (itemTarifa.TARI_Costo.HasValue && itemTarifa.TARI_Costo.Value > (Decimal)0.00)
                     {
                        itemTarifa.CONT_Codigo = Item.CONT_Codigo;
                        m_isCorrect = BL_Tarifa.Save(ref itemTarifa, false);
                        if (!m_isCorrect) { break; }
                     }
                  }
                  if (m_isCorrect)
                  { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
                  else
                  { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
               }
               else
               { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
            }
            else
				{ Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
            
            if (m_isCorrect && Item.CONT_Codigo.HasValue)
            { return Item.CONT_Codigo.Value; }
            else
            { return -1; }
			}
			catch (Exception)
			{ Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
		}
		public Boolean Save(ref ObservableCollection<Contrato> Items)
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
