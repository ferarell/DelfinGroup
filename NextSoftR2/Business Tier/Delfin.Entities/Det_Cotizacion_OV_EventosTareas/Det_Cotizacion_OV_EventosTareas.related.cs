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
	public partial class Det_Cotizacion_OV_EventosTareas
	{
		#region [ Variables ]
		Cab_Cotizacion_OV m_itemCab_Cotizacion_OV;
		ObservableCollection<Cab_Cotizacion_OV> m_listCab_Cotizacion_OV;
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
		#endregion
	}
}
