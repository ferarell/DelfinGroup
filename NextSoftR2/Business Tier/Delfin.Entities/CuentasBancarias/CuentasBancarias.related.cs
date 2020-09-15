using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using Infrastructure.Aspect;
using Infrastructure.Aspect.BusinessEntity;

namespace Delfin.Entities
{
   public partial class CuentasBancarias
   {
      #region [ Variables ]
      Empresa m_itemEmpresa;
      ObservableCollection<Empresa> m_listEmpresa;
      Sucursales m_itemSucursales;
      ObservableCollection<Sucursales> m_listSucursales;

      ObservableCollection<Chequera> m_listChequera;
      ObservableCollection<CuentasBancariasUsuarios> m_listCuentaBancosUsuarios;
      ObservableCollection<CuentasBancariasUsuarios> m_listCuentaBancosUsuariosDeleted;
      ObservableCollection<Firmas> m_listFirmas;
      ObservableCollection<Firmas> m_listFirmasDeleted;
      #endregion

      #region [ Propiedades ]
      /// <summary>
      /// Gets or sets el valor de: Empresa.
      /// </summary>
      [DataMember]
      public Empresa ItemEmpresa
      {
         get { return m_itemEmpresa; }
         set { m_itemEmpresa = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: Empresa.
      /// </summary>
      [DataMember]
      public ObservableCollection<Empresa> ListEmpresa
      {
         get { return m_listEmpresa; }
         set { m_listEmpresa = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: Sucursales.
      /// </summary>
      [DataMember]
      public Sucursales ItemSucursales
      {
         get { return m_itemSucursales; }
         set { m_itemSucursales = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: Sucursales.
      /// </summary>
      [DataMember]
      public ObservableCollection<Sucursales> ListSucursales
      {
         get { return m_listSucursales; }
         set { m_listSucursales = value; }
      }

      [DataMember]
      public ObservableCollection<Chequera> ListChequeraEliminados { get; set; }

      [DataMember]
      public ObservableCollection<Chequera> ListChequera
      {
         get { return m_listChequera; }
         set { m_listChequera = value; }
      }

      [DataMember]
      public ObservableCollection<CuentasBancariasUsuarios> ListCuentasBancariasUsuarios
      {
         get { if (m_listCuentaBancosUsuarios == null) { m_listCuentaBancosUsuarios = new ObservableCollection<CuentasBancariasUsuarios>(); } return m_listCuentaBancosUsuarios; }
         set { m_listCuentaBancosUsuarios = value; }
      }

      [DataMember]
      public ObservableCollection<CuentasBancariasUsuarios> ListCuentaBancosUsuariosEliminados
      {
         get { if (m_listCuentaBancosUsuariosDeleted == null) { m_listCuentaBancosUsuariosDeleted = new ObservableCollection<CuentasBancariasUsuarios>(); } return m_listCuentaBancosUsuariosDeleted; }
         set { m_listCuentaBancosUsuariosDeleted = value; }
      }
      [DataMember]
      public ObservableCollection<Firmas> ListFirmas
      {
          get { if (m_listFirmas == null) { m_listFirmas = new ObservableCollection<Firmas>(); } return m_listFirmas; }
          set { m_listFirmas = value; }
      }

      [DataMember]
      public ObservableCollection<Firmas> ListFirmasEliminadas
      {
          get { if (m_listFirmasDeleted == null) { m_listFirmasDeleted = new ObservableCollection<Firmas>(); } return m_listFirmasDeleted; }
          set { m_listFirmasDeleted = value; }
      }
      #endregion
   }
}
