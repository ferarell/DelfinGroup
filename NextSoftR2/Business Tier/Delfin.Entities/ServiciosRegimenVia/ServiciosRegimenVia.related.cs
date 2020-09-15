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
	public partial class ServiciosRegimenVia
    {
		#region [ Variables ]
		Servicio m_itemServicio;
		ObservableCollection<Servicio> m_listServicio;
		#endregion

		#region [ Propiedades ]
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
		#endregion
	}
}
