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
	public partial class Cab_Operacion
	{
		#region [ Variables ]
		Cab_Cotizacion m_itemCab_Cotizacion;
		ObservableCollection<Cab_Cotizacion> m_listCab_Cotizacion;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Cab_Cotizacion.
		/// </summary>
		[DataMember]
		public Cab_Cotizacion ItemCab_Cotizacion
		{
			get { return  m_itemCab_Cotizacion; }
			set {  m_itemCab_Cotizacion = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Cab_Cotizacion.
		/// </summary>
		[DataMember]
		public ObservableCollection<Cab_Cotizacion> ListCab_Cotizacion
		{
			get { return  m_listCab_Cotizacion; }
			set {  m_listCab_Cotizacion = value; }
		}
		#endregion
	}
}
