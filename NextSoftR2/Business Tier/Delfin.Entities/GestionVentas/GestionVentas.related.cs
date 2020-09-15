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
	public partial class GestionVentas
	{
		#region [ Variables ]
		Prospecto m_itemProspecto;
		ObservableCollection<Prospecto> m_listProspecto;
		ResultGestion m_itemResultGestion;
		ObservableCollection<ResultGestion> m_listResultGestion;
		Empresa m_itemEmpresa;
		ObservableCollection<Empresa> m_listEmpresa;
		Sucursales m_itemSucursales;
		ObservableCollection<Sucursales> m_listSucursales;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Prospecto.
		/// </summary>
		[DataMember]
		public Prospecto ItemProspecto
		{
			get { return  m_itemProspecto; }
			set {  m_itemProspecto = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Prospecto.
		/// </summary>
		[DataMember]
		public ObservableCollection<Prospecto> ListProspecto
		{
			get { return  m_listProspecto; }
			set {  m_listProspecto = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: ResultGestion.
		/// </summary>
		[DataMember]
		public ResultGestion ItemResultGestion
		{
			get { return  m_itemResultGestion; }
			set {  m_itemResultGestion = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: ResultGestion.
		/// </summary>
		[DataMember]
		public ObservableCollection<ResultGestion> ListResultGestion
		{
			get { return  m_listResultGestion; }
			set {  m_listResultGestion = value; }
		}
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
