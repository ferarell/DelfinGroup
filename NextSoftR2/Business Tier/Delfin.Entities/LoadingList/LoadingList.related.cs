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
	public partial class LoadingList
	{
		#region [ Variables ]
		Cab_Cotizacion_OV m_itemCab_Cotizacion_OV;
		ObservableCollection<Cab_Cotizacion_OV> m_listCab_Cotizacion_OV;
		NaveViaje m_itemNaveViaje;
		ObservableCollection<NaveViaje> m_listNaveViaje;
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
		/// Gets or sets el valor de: NaveViaje.
		/// </summary>
		[DataMember]
		public NaveViaje ItemNaveViaje
		{
			get { return  m_itemNaveViaje; }
			set {  m_itemNaveViaje = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: NaveViaje.
		/// </summary>
		[DataMember]
		public ObservableCollection<NaveViaje> ListNaveViaje
		{
			get { return  m_listNaveViaje; }
			set {  m_listNaveViaje = value; }
		}
		#endregion
	}
}
