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
	public partial class Det_Direccionamiento
	{
		#region [ Variables ]
		Paquete m_itemPaquete;
		ObservableCollection<Paquete> m_listPaquete;
		Cab_Direccionamiento m_itemCab_Direccionamiento;
		ObservableCollection<Cab_Direccionamiento> m_listCab_Direccionamiento;
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
		/// Gets or sets el valor de: Cab_Direccionamiento.
		/// </summary>
		[DataMember]
		public Cab_Direccionamiento ItemCab_Direccionamiento
		{
			get { return  m_itemCab_Direccionamiento; }
			set {  m_itemCab_Direccionamiento = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Cab_Direccionamiento.
		/// </summary>
		[DataMember]
		public ObservableCollection<Cab_Direccionamiento> ListCab_Direccionamiento
		{
			get { return  m_listCab_Direccionamiento; }
			set {  m_listCab_Direccionamiento = value; }
		}
		#endregion
	}
}
