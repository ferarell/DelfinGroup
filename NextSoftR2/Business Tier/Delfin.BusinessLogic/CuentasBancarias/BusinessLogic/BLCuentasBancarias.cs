using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Delfin.BusinessLogic;
using Delfin.Entities;
using Infrastructure.Aspect.BusinessEntity;

namespace Delfin.BusinessLogic
{
   public partial class BLCuentasBancarias : IBLCuentasBancarias
   {
      #region [ Propiedades ]

      [Dependency]
      public IBLChequera BL_Chequera { get; set; }
      [Dependency]
      public IBLCuentasBancariasUsuarios Bl_CuentaBancosUsuarios { get; set; }
      [Dependency]
      public IBLFirmas Bl_Firmas { get; set; }
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
      public ObservableCollection<CuentasBancarias> GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return SelectAllByFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<CuentasBancarias> GetAll()
      {
         try
         {
            return SelectAll();
         }
         catch (Exception)
         { throw; }
      }
      public CuentasBancarias GetOne(Int16 EMPR_Codigo, String CUBA_Codigo)
      {
         try
         {
            if (EMPR_Codigo == null || CUBA_Codigo == null) { return null; }
            Entities.CuentasBancarias _cuentasBancarias = SelectOne(EMPR_Codigo, CUBA_Codigo);
            if (_cuentasBancarias != null)
            {
               ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> _listFilters = new ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL>();
               _listFilters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@psinEMPR_Codigo", FilterValue = EMPR_Codigo, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Int16, FilterSize = 22 });
               _listFilters.Add(new Infrastructure.Aspect.DataAccess.DataAccessFilterSQL() { FilterName = "@pchrCUBA_Codigo", FilterValue = CUBA_Codigo, FilterType = Infrastructure.Aspect.DataAccess.DataAccessFilterTypes.Varchar, FilterSize = 20 });
               
               _cuentasBancarias.ListChequera = BL_Chequera.GetAllFilter("CAJ_CHEQSS_PorCUBA", _listFilters);
               _cuentasBancarias.ListCuentasBancariasUsuarios = Bl_CuentaBancosUsuarios.GetAllFilter("CAJ_CBUSSS_TodosByFilters", _listFilters);
               _cuentasBancarias.ListFirmas = Bl_Firmas.GetAllFilter("CAJ_FIRMSS_TodosByFilters", _listFilters);

            }
            return _cuentasBancarias;
         }
         catch (Exception)
         { throw; }
      }
      #endregion

      #region [ Metodos ]
      public Boolean Save(ref CuentasBancarias Item)
      {
         try
         {
            Boolean m_isCorrect = true;
            String _AUDI_Usuario = "";
            DateTime _AUDI_Fecha = DateTime.Now;

            Infrastructure.Aspect.DataAccess.DataAccessEnterpriseSQL.DABeginTransaction();
            switch (Item.Instance)
            {
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Added:
                  m_isCorrect = Insert(ref Item);
                  _AUDI_Usuario = Item.AUDI_UsrCrea;
                  _AUDI_Fecha = Item.AUDI_FecCrea;
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified:
                  m_isCorrect = Update(ref Item);
                  _AUDI_Usuario = Item.AUDI_UsrMod;
                  if (Item.AUDI_FecMod.HasValue)
                  {_AUDI_Fecha = Item.AUDI_FecMod.Value; }
                  break;
               case Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted:
                  m_isCorrect = Delete(ref Item); break;
            }
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Deleted)
            {
               if (m_isCorrect)
               {
                  if (Item.ListChequeraEliminados != null && Item.ListChequeraEliminados.Count > 0)
                  {
                     foreach (Entities.Chequera iChequera in Item.ListChequeraEliminados)
                     {
                        Chequera _iChequera = iChequera;
                        _iChequera.Instance = InstanceEntity.Deleted;
                        m_isCorrect = BL_Chequera.Save(ref _iChequera);
                        if (!m_isCorrect) { Item.SetMensajeError(String.Format("* No se puede eliminar la Chequera Numero {0}.", _iChequera.CHEQ_Codigo)); break; }
                     }
                  }
               }

               if (m_isCorrect)
               {
                  if (Item.ListChequera != null && Item.ListChequera.Count > 0)
                  {
                     foreach (Entities.Chequera iChequera in Item.ListChequera)
                     {
                        Chequera _iChequera = iChequera;
                        _iChequera.EMPR_Codigo = Item.EMPR_Codigo;
                        _iChequera.CUBA_Codigo = Item.CUBA_Codigo;

                        if (_iChequera.Instance == InstanceEntity.Added)
                        {
                           _iChequera.AUDI_UsrCrea = _AUDI_Usuario;
                           _iChequera.AUDI_FecCrea = _AUDI_Fecha;
                        }
                        else if (_iChequera.Instance == InstanceEntity.Modified)
                        {
                           _iChequera.AUDI_UsrMod = _AUDI_Usuario;
                           _iChequera.AUDI_FecMod = _AUDI_Fecha;
                        }
                        
                        
                        //_iChequera.Instance = InstanceEntity.Added;
                        m_isCorrect = BL_Chequera.Save(ref _iChequera);
                        if (!m_isCorrect)
                        { Item.SetMensajeError(String.Format("* No se puede grabar la Chequera Numero {0}.", _iChequera.CHEQ_Codigo)); break; }
                     }
                  }
               }

               if (m_isCorrect)
               {
                  if (Item.ListCuentaBancosUsuariosEliminados != null && Item.ListCuentaBancosUsuariosEliminados.Count > 0 && m_isCorrect)
                  {
                     foreach (Entities.CuentasBancariasUsuarios iCuentas in Item.ListCuentaBancosUsuariosEliminados)
                     {
                        Entities.CuentasBancariasUsuarios _cuentasCuentaBancosUsuarios = iCuentas;
                        _cuentasCuentaBancosUsuarios.Instance = InstanceEntity.Deleted;
                        m_isCorrect = Bl_CuentaBancosUsuarios.Save(ref _cuentasCuentaBancosUsuarios);
                        if (!m_isCorrect) { Item.SetMensajeError(String.Format("* No se puede grabar la Cuentas Bancarias Usuario: {0}.", _cuentasCuentaBancosUsuarios.USER_Codigo)); break; }
                     }
                  }
               }

               if (m_isCorrect)
               {
                  if (Item.ListCuentasBancariasUsuarios != null && Item.ListCuentasBancariasUsuarios.Count > 0 && m_isCorrect)
                  {
                     foreach (Entities.CuentasBancariasUsuarios iCuentas in Item.ListCuentasBancariasUsuarios)
                     {
                        Entities.CuentasBancariasUsuarios _cuentasCuentaBancosUsuarios = iCuentas;
                        _cuentasCuentaBancosUsuarios.EMPR_Codigo = Item.EMPR_Codigo;
                        _cuentasCuentaBancosUsuarios.AUDI_UsrCrea = Item.AUDI_UsrCrea;
                        _cuentasCuentaBancosUsuarios.CUBA_Codigo = Item.CUBA_Codigo;
                        if (_cuentasCuentaBancosUsuarios.Instance == InstanceEntity.Added)
                        {
                           _cuentasCuentaBancosUsuarios.AUDI_UsrCrea = _AUDI_Usuario;
                           _cuentasCuentaBancosUsuarios.AUDI_FecCrea = _AUDI_Fecha;
                        }
                        else if (_cuentasCuentaBancosUsuarios.Instance == InstanceEntity.Modified)
                        {
                           _cuentasCuentaBancosUsuarios.AUDI_UsrMod = _AUDI_Usuario;
                           _cuentasCuentaBancosUsuarios.AUDI_FecMod = _AUDI_Fecha;
                        }
                        m_isCorrect = Bl_CuentaBancosUsuarios.Save(ref _cuentasCuentaBancosUsuarios);
                        if (!m_isCorrect) { Item.SetMensajeError(String.Format("* No se puede grabar la Cuentas Bancarias Usuario: {0}.", _cuentasCuentaBancosUsuarios.USER_Codigo)); break; }
                     }
                  }

               }
               if (m_isCorrect)
               {
                   if (Item.ListFirmasEliminadas != null && Item.ListFirmasEliminadas.Count > 0 && m_isCorrect)
                   {
                       foreach (Entities.Firmas iFirmas in Item.ListFirmasEliminadas)
                       {
                           Entities.Firmas _firma = iFirmas;
                           _firma.Instance = InstanceEntity.Deleted;
                           m_isCorrect = Bl_Firmas.Save(ref _firma);
                           if (!m_isCorrect) { Item.SetMensajeError(String.Format("* No se puede grabar la Firma: {0}.", _firma.FIRM_Codigo)); break; }
                       }
                   }
               }
               if (m_isCorrect)
               {
                   if (Item.ListFirmas != null && Item.ListFirmas.Count > 0 && m_isCorrect)
                   {
                       foreach (Entities.Firmas iFirmas in Item.ListFirmas)
                       {
                           Entities.Firmas _firma= iFirmas;
                           _firma.EMPR_Codigo = Item.EMPR_Codigo;
                           _firma.AUDI_UsrCrea = Item.AUDI_UsrCrea;
                           _firma.CUBA_Codigo = Item.CUBA_Codigo;
                           if (_firma.Instance == InstanceEntity.Added)
                           {
                               _firma.AUDI_UsrCrea = _AUDI_Usuario;
                               _firma.AUDI_FecCrea = _AUDI_Fecha;
                           }
                           else if (_firma.Instance == InstanceEntity.Modified)
                           {
                               _firma.AUDI_UsrMod = _AUDI_Usuario;
                               _firma.AUDI_FecMod = _AUDI_Fecha;
                           }
                           m_isCorrect =Bl_Firmas.Save(ref _firma);
                           if (!m_isCorrect) { Item.SetMensajeError(String.Format("* No se puede grabar la Firma: {0}.", _firma.FIRM_Codigo )); break; }
                       }
                   }

               }
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
      public Boolean Save(ref ObservableCollection<CuentasBancarias> Items)
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
