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
	public partial class BLGRR : IBLGRR
	{
		#region [ Propiedades ]
      [Dependency]
      public IBLGRR_Paquetes BL_GRR_Paquetes { get; set; }
      [Dependency]
      public IBLGRR_Contrato BL_GRR_Contrato { get; set; }
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
		public ObservableCollection<GRR> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
		{
			try
			{
				return SelectAllByFilter(x_procedure, x_filters);
			}
			catch (Exception)
			{ throw; }
		}
		public ObservableCollection<GRR> GetAll()
		{
			try
			{
				return SelectAll();
			}
			catch (Exception)
			{ throw; }
		}
		public GRR GetOne(String REBA_Tipo, Int32 REBA_Codigo)
		{
			try
			{
				if (REBA_Tipo == null || REBA_Codigo == null) { return null; }
				GRR Item = SelectOne(REBA_Tipo, REBA_Codigo);

            ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> _filters = new ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL>();
            _filters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@pchrREBA_Tipo", FilterValue = Item.REBA_Tipo, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Char, FilterSize = 1 });
            _filters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@pintREBA_Codigo", FilterValue = Item.REBA_Codigo, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Int32, FilterSize = 4 });

            Item.ListGRR_Paquetes = BL_GRR_Paquetes.GetAllFilter("COM_GPACSS_Todos", _filters);

            Item.ListGRR_Contratos = BL_GRR_Contrato.GetAllFilter("COM_GCONSS_Todos", _filters);
            
            return Item;
			}
			catch (Exception)
			{ throw; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save(ref GRR Item)
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
						m_isCorrect = Delete(ref Item);
                  if (m_isCorrect) { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
                  else { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
                  return m_isCorrect;
				}

            if (m_isCorrect)
            {
               if (m_isCorrect)
               {
                  for (int i = 0; i < Item.ListGRR_Paquetes.Count; i++)
                  {
                     GRR_Paquetes _itemGRR_Paquetes = Item.ListGRR_Paquetes[i];
                     _itemGRR_Paquetes.REBA_Tipo = Item.REBA_Tipo;
                     _itemGRR_Paquetes.REBA_Codigo = Item.REBA_Codigo;
                     m_isCorrect = BL_GRR_Paquetes.Save(ref _itemGRR_Paquetes);
                     if (!m_isCorrect) { break; }
                  }
               }
               //if (m_isCorrect)
               //{
               //   for (int i = 0; i < Item.ListGRR_PaquetesDeleted.Count; i++)
               //   {
               //      GRR_Paquetes _itemGRR_Paquetes = Item.ListGRR_PaquetesDeleted[i];
               //      m_isCorrect = BL_GRR_Paquetes.Save(ref _itemGRR_Paquetes);
               //      if (!m_isCorrect) { break; }
               //   }
               //}

               if (m_isCorrect)
               {
                  for (int i = 0; i < Item.ListGRR_Contratos.Count; i++)
                  {
                     GRR_Contrato _itemGRR_Contrato = Item.ListGRR_Contratos[i];
                     _itemGRR_Contrato.REBA_Tipo = Item.REBA_Tipo;
                     _itemGRR_Contrato.REBA_Codigo = Item.REBA_Codigo;
                     m_isCorrect = BL_GRR_Contrato.Save(ref _itemGRR_Contrato);
                     if (!m_isCorrect) { break; }
                  }
               }
               //if (m_isCorrect)
               //{
               //   for (int i = 0; i < Item.ListGRR_ContratosDeleted.Count; i++)
               //   {
               //      GRR_Contrato _itemGRR_Contrato = Item.ListGRR_ContratosDeleted[i];
               //      m_isCorrect = BL_GRR_Contrato.Save(ref _itemGRR_Contrato);
               //      if (!m_isCorrect) { break; }
               //   }
               //}
            }

            if (m_isCorrect) { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
            else { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }

            return m_isCorrect;
			}
			catch (Exception)
         { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
		}
		public Boolean Save(ref ObservableCollection<GRR> Items)
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
