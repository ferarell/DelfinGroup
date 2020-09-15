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
	public partial class CierresChangeControl
	{
		#region [ Variables ]
		Empresa m_itemEmpresa;
		ObservableCollection<Empresa> m_listEmpresa;
		Sucursales m_itemSucursales;
		ObservableCollection<Sucursales> m_listSucursales;
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
		#endregion
	}
}
