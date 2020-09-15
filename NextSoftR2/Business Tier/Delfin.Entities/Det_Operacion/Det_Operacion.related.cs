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
	public partial class Det_Operacion
	{
		#region [ Variables ]
		Paquete m_itemPaquete;
		ObservableCollection<Paquete> m_listPaquete;
		Cab_Operacion m_itemCab_Operacion;
		ObservableCollection<Cab_Operacion> m_listCab_Operacion;
		Det_Tarifa m_itemDet_Tarifa;
		ObservableCollection<Det_Tarifa> m_listDet_Tarifa;
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
		/// Gets or sets el valor de: Cab_Operacion.
		/// </summary>
		[DataMember]
		public Cab_Operacion ItemCab_Operacion
		{
			get { return  m_itemCab_Operacion; }
			set {  m_itemCab_Operacion = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Cab_Operacion.
		/// </summary>
		[DataMember]
		public ObservableCollection<Cab_Operacion> ListCab_Operacion
		{
			get { return  m_listCab_Operacion; }
			set {  m_listCab_Operacion = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Det_Tarifa.
		/// </summary>
		[DataMember]
		public Det_Tarifa ItemDet_Tarifa
		{
			get { return  m_itemDet_Tarifa; }
			set {  m_itemDet_Tarifa = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Det_Tarifa.
		/// </summary>
		[DataMember]
		public ObservableCollection<Det_Tarifa> ListDet_Tarifa
		{
			get { return  m_listDet_Tarifa; }
			set {  m_listDet_Tarifa = value; }
		}
		#endregion
	}
}
