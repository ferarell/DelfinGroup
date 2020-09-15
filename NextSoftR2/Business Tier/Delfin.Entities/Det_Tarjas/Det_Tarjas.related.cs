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
	public partial class Det_Tarjas
	{
		#region [ Variables ]
		Paquete m_itemPaquete;
		ObservableCollection<Paquete> m_listPaquete;
		Cab_Tarjas m_itemCab_Tarjas;
		ObservableCollection<Cab_Tarjas> m_listCab_Tarjas;
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
		/// Gets or sets el valor de: Cab_Tarjas.
		/// </summary>
		[DataMember]
		public Cab_Tarjas ItemCab_Tarjas
		{
			get { return  m_itemCab_Tarjas; }
			set {  m_itemCab_Tarjas = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Cab_Tarjas.
		/// </summary>
		[DataMember]
		public ObservableCollection<Cab_Tarjas> ListCab_Tarjas
		{
			get { return  m_listCab_Tarjas; }
			set {  m_listCab_Tarjas = value; }
		}
		#endregion
	}
}
