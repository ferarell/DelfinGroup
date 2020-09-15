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
	public partial class EntidadCuentaBancaria
	{
		#region [ Variables ]
		Entidad m_itemEntidad;
		ObservableCollection<Entidad> m_listEntidad;
		#endregion

		#region [ Propiedades ]
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
		#endregion
	}
}
