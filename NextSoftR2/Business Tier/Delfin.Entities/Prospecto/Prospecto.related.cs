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
	public partial class Prospecto
	{
		#region [ Variables ]
		Empresa m_itemEmpresa;
		ObservableCollection<Empresa> m_listEmpresa;
		Sucursales m_itemSucursales;
		ObservableCollection<Sucursales> m_listSucursales;
      GestionVentas m_itemGestionVentas;
      ObservableCollection<GestionVentas> m_listGestionVentas;
      Entidad m_itemContacto;
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
      /// Gets or sets el valor de: GestionVentas.
      /// </summary>
      [DataMember]
      public GestionVentas ItemGestionVentas
      {
         get { return m_itemGestionVentas; }
         set { m_itemGestionVentas = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: GestionVentas.
      /// </summary>
      [DataMember]
      public ObservableCollection<GestionVentas> ListGestionVentas
      {
         get { return m_listGestionVentas; }
         set { m_listGestionVentas = value; }
      }

      /// <summary>
      /// Gets or sets el valor de: ENTC_CodContacto.
      /// </summary>
      [DataMember]
      public Nullable<Int32> ENTC_CodContacto { get; set; }
      /// <summary>
      /// Gets or sets el valor de: ItemContacto.
      /// </summary>
      [DataMember]
      public Entidad ItemContacto
      {
         get { return m_itemContacto; }
         set { m_itemContacto = value; }
      }
		#endregion
	}
}
