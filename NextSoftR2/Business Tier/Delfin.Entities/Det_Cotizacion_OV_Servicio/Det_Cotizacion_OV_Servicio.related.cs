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
	public partial class Det_Cotizacion_OV_Servicio
	{
		#region [ Variables ]
		Cab_Cotizacion_OV m_itemCab_Cotizacion_OV;
		ObservableCollection<Cab_Cotizacion_OV> m_listCab_Cotizacion_OV;
		Servicio m_itemServicio;
		ObservableCollection<Servicio> m_listServicio;
		Tarifa m_itemTarifa;
		ObservableCollection<Tarifa> m_listTarifa;
		Entidad m_itemEntidad;
		ObservableCollection<Entidad> m_listEntidad;
		TiposEntidad m_itemTiposEntidad;
		ObservableCollection<TiposEntidad> m_listTiposEntidad;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Cab_Cotizacion_OV.
		/// </summary>
		[DataMember]
		public Cab_Cotizacion_OV ItemCab_Cotizacion_OV
		{
			get { return  m_itemCab_Cotizacion_OV; }
			set {  m_itemCab_Cotizacion_OV = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Cab_Cotizacion_OV.
		/// </summary>
		[DataMember]
		public ObservableCollection<Cab_Cotizacion_OV> ListCab_Cotizacion_OV
		{
			get { return  m_listCab_Cotizacion_OV; }
			set {  m_listCab_Cotizacion_OV = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Servicio.
		/// </summary>
		[DataMember]
		public Servicio ItemServicio
		{
			get { return  m_itemServicio; }
			set {  m_itemServicio = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Servicio.
		/// </summary>
		[DataMember]
		public ObservableCollection<Servicio> ListServicio
		{
			get { return  m_listServicio; }
			set {  m_listServicio = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Tarifa.
		/// </summary>
		[DataMember]
		public Tarifa ItemTarifa
		{
			get { return  m_itemTarifa; }
			set {  m_itemTarifa = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Tarifa.
		/// </summary>
		[DataMember]
		public ObservableCollection<Tarifa> ListTarifa
		{
			get { return  m_listTarifa; }
			set {  m_listTarifa = value; }
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
