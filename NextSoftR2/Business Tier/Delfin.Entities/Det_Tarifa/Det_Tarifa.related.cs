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
	public partial class Det_Tarifa
	{
		#region [ Variables ]
		Paquete m_itemPaquete;
		ObservableCollection<Paquete> m_listPaquete;
		Entidad m_itemEntidad;
		ObservableCollection<Entidad> m_listEntidad;
		Cab_Tarifa m_itemCab_Tarifa;
		ObservableCollection<Cab_Tarifa> m_listCab_Tarifa;
		TiposEntidad m_itemTiposEntidad;
		ObservableCollection<TiposEntidad> m_listTiposEntidad;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Paquete.
		/// </summary>
		[DataMember]
		public Paquete ItemPaquete
		{
			get { return  m_itemPaquete; }
			set {  m_itemPaquete = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Paquete.
		/// </summary>
		[DataMember]
		public ObservableCollection<Paquete> ListPaquete
		{
			get { return  m_listPaquete; }
			set {  m_listPaquete = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Entidad.
		/// </summary>
		[DataMember]
		public Entidad ItemEntidad
		{
			get { return  m_itemEntidad; }
			set {  m_itemEntidad = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Entidad.
		/// </summary>
		[DataMember]
		public ObservableCollection<Entidad> ListEntidad
		{
			get { return  m_listEntidad; }
			set {  m_listEntidad = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Cab_Tarifa.
		/// </summary>
		[DataMember]
		public Cab_Tarifa ItemCab_Tarifa
		{
			get { return  m_itemCab_Tarifa; }
			set {  m_itemCab_Tarifa = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Cab_Tarifa.
		/// </summary>
		[DataMember]
		public ObservableCollection<Cab_Tarifa> ListCab_Tarifa
		{
			get { return  m_listCab_Tarifa; }
			set {  m_listCab_Tarifa = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: TiposEntidad.
		/// </summary>
		[DataMember]
		public TiposEntidad ItemTiposEntidad
		{
			get { return  m_itemTiposEntidad; }
			set {  m_itemTiposEntidad = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: TiposEntidad.
		/// </summary>
		[DataMember]
		public ObservableCollection<TiposEntidad> ListTiposEntidad
		{
			get { return  m_listTiposEntidad; }
			set {  m_listTiposEntidad = value; }
		}
		#endregion
	}
}
