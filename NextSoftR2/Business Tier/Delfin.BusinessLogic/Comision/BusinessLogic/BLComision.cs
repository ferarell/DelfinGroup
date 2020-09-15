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
	public partial class BLComision : IBLComision
	{
		#region [ Propiedades ]
      [Dependency]
      public IBLDet_Comision BL_Det_Comision { get; set; }
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
		public ObservableCollection<Comision> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				return SelectAllByFilter(x_procedure, x_filters);
			}
			catch (Exception)
			{ throw; }
		}
		public ObservableCollection<Comision> GetAll()
		{
			try
			{
				return SelectAll();
			}
			catch (Exception)
			{ throw; }
		}
		public Comision GetOne(Int32 COMI_Codigo)
		{
         try
         {
            if (COMI_Codigo == null) { return null; }

            Comision Item = SelectOne(COMI_Codigo);
            if (Item != null)
            {
               ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> _filters = new ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL>();
               _filters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@pintCOMI_Codigo", FilterValue = COMI_Codigo, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Int32, FilterSize = 4 });
               Item.ListDet_Comision = BL_Det_Comision.GetAllFilter("COM_DCOMSS_Todos", _filters); 
            }
            return Item;
         }
         catch (Exception)
         { throw; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save(ref Comision Item)
		{
			try
			{
				Boolean m_isCorrect = true;

            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
            String _usuario = "";
            
            switch (Item.Instance)
				{
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
						m_isCorrect = Insert(ref Item); 
                  _usuario = Item.AUDI_UsrCrea;
                  break;
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
						m_isCorrect = Update(ref Item); 
                  _usuario = Item.AUDI_UsrMod;
                  break;
					case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
						m_isCorrect = Delete(ref Item); break;
				}

            if (m_isCorrect && Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
            {
               for (int i = 0; i < Item.ListDet_ComisionDeleted.Count; i++)
               {
                  Det_Comision _itemDet_Comision = Item.ListDet_ComisionDeleted[i];
                  m_isCorrect = BL_Det_Comision.Save(ref _itemDet_Comision);
                  if (!m_isCorrect) { break; }
               }
            }

            if (m_isCorrect && Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
            {
               for (int i = 0; i < Item.ListDet_Comision.Count; i++)
               {
                  Det_Comision _itemDet_Comision = Item.ListDet_Comision[i];
                  _itemDet_Comision.COMI_Codigo = Item.COMI_Codigo;

                  if (_itemDet_Comision.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added)
                  { 
                     _itemDet_Comision.AUDI_UsrCrea = _usuario;
                     _itemDet_Comision.AUDI_FecCrea = DateTime.Now;
                  }
                  else if (_itemDet_Comision.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
                  { 
                     _itemDet_Comision.AUDI_UsrMod = _usuario;
                     _itemDet_Comision.AUDI_FecMod = DateTime.Now;
                  }
                  
                  m_isCorrect = BL_Det_Comision.Save(ref _itemDet_Comision);
                  if (!m_isCorrect) { break; }
               }
            }

            if (m_isCorrect)
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction(); }

				return m_isCorrect;
			}
			catch (Exception)
         { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
		}
		public Boolean Save(ref ObservableCollection<Comision> Items)
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
