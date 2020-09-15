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
	public partial class Det_Cotizacion_OV_Flete
	{
		#region [ Variables ]
		Cab_Cotizacion_OV m_itemCab_Cotizacion_OV;
		ObservableCollection<Cab_Cotizacion_OV> m_listCab_Cotizacion_OV;
		Paquete m_itemPaquete;
		ObservableCollection<Paquete> m_listPaquete;
		Servicio m_itemServicio;
		ObservableCollection<Servicio> m_listServicio;
		Tarifa m_itemTarifa;
		ObservableCollection<Tarifa> m_listTarifa;
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
		#endregion
	}
}
