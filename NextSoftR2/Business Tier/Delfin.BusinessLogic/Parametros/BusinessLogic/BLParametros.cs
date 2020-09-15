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
   public partial class BLParametros : IBLParametros
   {
      #region [ Propiedades ]
      #endregion

      #region [ Consultas ]

      public String UsuarioParametros { get; set; }

      private ObservableCollection<Parametros> CargarTablaXML()
      {
         try
         {
            Infrastructure.Aspect.CheckSUM.GenerarChekSum x_CargarTabla = new Infrastructure.Aspect.CheckSUM.GenerarChekSum(Infrastructure.Aspect.CheckSUM.GenerarChekSum.PathAppPublic, UsuarioParametros);
            System.Data.DataTable dtTabla = x_CargarTabla.CargarXML(new Infrastructure.Aspect.CheckSUM.CHKS_Tablas() { CHKS_Tabla = "Parametros" });
            ObservableCollection<Parametros> ListParametros = new ObservableCollection<Parametros>();

            if (dtTabla != null)
            {
               ListParametros = new ObservableCollection<Entities.Parametros>();
               foreach (System.Data.DataRow iRow in dtTabla.Rows)
               {
                  Entities.Parametros _tipos = new Entities.Parametros();
                  Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Entities.Parametros> Loader = new Infrastructure.Aspect.BusinessEntity.BusinessEntityLoader<Entities.Parametros>();
                  Loader.LoadEntity(iRow, _tipos);
                  ListParametros.Add(_tipos);
               }
            }
            else
            {
               return SelectAll();
            }
            return ListParametros;
         }
         catch (Exception)
         { throw; }
      }

      public ObservableCollection<Parametros> GetAll()
      {
         try
         {
            return CargarTablaXML();
         }
         catch (Exception ex)
         { throw ex; }
      }
      public Parametros GetOne(Int32 PARA_Codigo)
      {
         try
         {
            if (PARA_Codigo == null) { return null; }
            return SelectOne(PARA_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public System.Data.DataTable GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return SelectAllByFilterDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public System.Data.DataSet GetDS(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return SelectAllByFilterDS(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      #endregion

      #region [ Metodos ]
      public Boolean Save(ref Parametros Item)
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
            { GenerarXML(); Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }
      public Boolean Save(ref ObservableCollection<Parametros> Items)
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
            { GenerarXML(); Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DACommitTransaction(); }
            else
            { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); }
            return m_isCorrect;
         }
         catch (Exception)
         { Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DARollbackTransaction(); throw; }
      }
      private void GenerarXML()
      {
         try
         {
            System.Data.DataTable dt_xml = new System.Data.DataTable();
            ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> _listFilters = new ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL>();
            dt_xml = GetDT("CHKSSS_ObtenerTablas", _listFilters);

            Infrastructure.Aspect.CheckSUM.GenerarChekSum x_generar = new Infrastructure.Aspect.CheckSUM.GenerarChekSum("", UsuarioParametros);
            if (x_generar.CompararObjetos(dt_xml))
            {
               Boolean IfCambio = false;
               foreach (Infrastructure.Aspect.CheckSUM.CHKS_Tablas iTablas in x_generar.ListTablas)
               {
                  _listFilters = new ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL>();
                  if (iTablas.Cambio)
                  {
                     System.Data.DataSet ds_xml = GetDS(iTablas.CHKS_Procedure, _listFilters);
                     x_generar.GenerarXML(iTablas, ds_xml);
                     IfCambio = true;
                  }
               }
               if (IfCambio)
               { x_generar.GenerarTablaCheckSUM(); }
            }
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
