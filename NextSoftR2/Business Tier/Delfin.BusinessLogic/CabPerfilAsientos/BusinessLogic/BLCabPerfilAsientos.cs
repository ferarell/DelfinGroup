using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Delfin.BusinessLogic;
using Delfin.Entities;

using Infrastructure.Aspect.DataAccess;
using Infrastructure.Aspect.BusinessEntity;

namespace Delfin.BusinessLogic
{
   public partial class BLCabPerfilAsientos : IBLCabPerfilAsientos
   {
      #region [ Propiedades ]

      [Dependency]
      public IBLDetPerfilAsientos BL_DetPerfilAsientos { get; set; }

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
      public ObservableCollection<CabPerfilAsientos> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return SelectAllByFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<CabPerfilAsientos> GetAll()
      {
         try
         {
            return SelectAll();
         }
         catch (Exception)
         { throw; }
      }
      public CabPerfilAsientos GetOne(String CABP_Ano, String CABP_Codigo)
      {
         try
         {
            if (CABP_Ano == null || CABP_Codigo == null) { return null; }
            Entities.CabPerfilAsientos _item = SelectOne(CABP_Ano, CABP_Codigo);

            ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> _listFilters = new ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL>();
            _listFilters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@pchrCABP_Ano", FilterValue = CABP_Ano, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Char, FilterSize = 4 });
            _listFilters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@pvchCABP_Codigo", FilterValue = CABP_Codigo, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Varchar, FilterSize = 3 });
            _item.ListDetPerfilAsientos = BL_DetPerfilAsientos.GetAllFilter("CON_DETPSS_TodosPorCabecera", _listFilters);
            _item.ListDetPerfilAsientosEliminados = new ObservableCollection<DetPerfilAsientos>();

            return _item;
         }
         catch (Exception)
         { throw; }
      }
      #endregion

      #region [ Metodos ]
      public Boolean Save(ref CabPerfilAsientos Item)
      {
         try
         {
            DataAccessEnterpriseSQL.DABeginTransaction();
            Boolean m_isCorrect = true;
            String x_usuario = "";
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                  m_isCorrect = Insert(ref Item);
                  x_usuario = Item.AUDI_UsrCrea;
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = Update(ref Item);
                  x_usuario = Item.AUDI_UsrMod;
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  m_isCorrect = Delete(ref Item); break;
            }

            #region Guardar Detalles

            if (Item.ListDetPerfilAsientosEliminados != null && Item.ListDetPerfilAsientosEliminados.Count > 0)
            {
               foreach (DetPerfilAsientos item in Item.ListDetPerfilAsientosEliminados)
               {
                  item.Instance = InstanceEntity.Deleted;
                  Entities.DetPerfilAsientos _item = item;
                  m_isCorrect = BL_DetPerfilAsientos.Save(ref _item);
                  if (!m_isCorrect) { throw new Exception(String.Format("No se puede eliminar el item {0}", item.DETP_Item)); }
               }
            }

            if (Item.ListDetPerfilAsientos != null && Item.ListDetPerfilAsientos.Count > 0)
            {
               foreach (DetPerfilAsientos item in Item.ListDetPerfilAsientos)
               {
                  item.CABP_Ano = Item.CABP_Ano;
                  item.CABP_Codigo = Item.CABP_Codigo;
                  switch (item.Instance)
                  {
                     case InstanceEntity.Added:
                        item.AUDI_UsrCrea = x_usuario;
                        break;
                     case InstanceEntity.Modified:
                        item.AUDI_UsrMod = x_usuario;
                        break;
                  }
                  Entities.DetPerfilAsientos _item = item;
                  m_isCorrect = BL_DetPerfilAsientos.Save(ref _item);
                  if (!m_isCorrect) { throw new Exception(String.Format("No se puede grabar el item {0}", item.DETP_Item)); }
               }
            }
            #endregion

            if (m_isCorrect)
            { DataAccessEnterpriseSQL.DACommitTransaction(); }
            else { DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         { DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }
      public Boolean Save(ref ObservableCollection<CabPerfilAsientos> Items)
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
