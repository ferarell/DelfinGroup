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
	public partial class Comision
	{
		#region [ Variables ]
		Empresa m_itemEmpresa;
		ObservableCollection<Empresa> m_listEmpresa;
		Sucursales m_itemSucursales;
		ObservableCollection<Sucursales> m_listSucursales;
      Det_Comision m_itemDet_Comision;
      ObservableCollection<Det_Comision> m_listDet_Comision;
      ObservableCollection<Det_Comision> m_listDet_ComisionDeleted;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Empresa.
		/// </summary>
		[DataMember]
		public Empresa ItemEmpresa
		{
			get { return  m_itemEmpresa; }
			set {  m_itemEmpresa = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Empresa.
		/// </summary>
		[DataMember]
		public ObservableCollection<Empresa> ListEmpresa
		{
			get { return  m_listEmpresa; }
			set {  m_listEmpresa = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Sucursales.
		/// </summary>
		[DataMember]
		public Sucursales ItemSucursales
		{
			get { return  m_itemSucursales; }
			set {  m_itemSucursales = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Sucursales.
		/// </summary>
		[DataMember]
		public ObservableCollection<Sucursales> ListSucursales
		{
			get { return  m_listSucursales; }
			set {  m_listSucursales = value; }
		}

      /// <summary>
      /// Gets or sets el valor de: ItemDet_Comision.
      /// </summary>
      [DataMember]
      public Det_Comision ItemDet_Comision
      {
         get { return m_itemDet_Comision; }
         set { m_itemDet_Comision = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: ListDet_Comision.
      /// </summary>
      [DataMember]
      public ObservableCollection<Det_Comision> ListDet_Comision
      {
         get {
            if (m_listDet_Comision == null) { m_listDet_Comision = new ObservableCollection<Det_Comision>(); }
            return m_listDet_Comision; 
         }
         set { m_listDet_Comision = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: ListDet_ComisionDeleted.
      /// </summary>
      [DataMember]
      public ObservableCollection<Det_Comision> ListDet_ComisionDeleted
      {
         get {
            if (m_listDet_ComisionDeleted == null) { m_listDet_ComisionDeleted = new ObservableCollection<Det_Comision>(); }
            return m_listDet_ComisionDeleted; 
         }
         set { m_listDet_ComisionDeleted = value; }
      }
		#endregion
	}
}
