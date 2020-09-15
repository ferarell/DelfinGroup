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
	public partial class Det_CNTR
	{
		#region [ Variables ]
		Cab_Cotizacion_OV m_itemCab_Cotizacion_OV;
		ObservableCollection<Cab_Cotizacion_OV> m_listCab_Cotizacion_OV;
		Paquete m_itemPaquete;
		ObservableCollection<Paquete> m_listPaquete;
		Cab_MBL m_itemCab_MBL;
		ObservableCollection<Cab_MBL> m_listCab_MBL;
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
		/// Gets or sets el valor de: Cab_MBL.
		/// </summary>
		[DataMember]
		public Cab_MBL ItemCab_MBL
		{
			get { return  m_itemCab_MBL; }
			set {  m_itemCab_MBL = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Cab_MBL.
		/// </summary>
		[DataMember]
		public ObservableCollection<Cab_MBL> ListCab_MBL
		{
			get { return  m_listCab_MBL; }
			set {  m_listCab_MBL = value; }
		}
		#endregion
	}
}
