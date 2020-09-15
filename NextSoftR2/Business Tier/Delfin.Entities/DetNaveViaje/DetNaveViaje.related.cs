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
	public partial class DetNaveViaje
	{
		#region [ Variables ]
		NaveViaje m_itemNaveViaje;
		ObservableCollection<NaveViaje> m_listNaveViaje;
		Puerto m_itemPuerto;
		ObservableCollection<Puerto> m_listPuerto;
		#endregion

		#region [ Propiedades ]
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
		/// <summary>
		/// Gets or sets el valor de: Puerto.
		/// </summary>
		[DataMember]
		public Puerto ItemPuerto
		{
			get { return  m_itemPuerto; }
			set {  m_itemPuerto = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Puerto.
		/// </summary>
		[DataMember]
		public ObservableCollection<Puerto> ListPuerto
		{
			get { return  m_listPuerto; }
			set {  m_listPuerto = value; }
		}
		#endregion
	}
}
