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
	public partial class DetDocsVta_Det_Operacion
	{
		#region [ Variables ]
		Det_Operacion m_itemDet_Operacion;
		ObservableCollection<Det_Operacion> m_listDet_Operacion;
		Det_Operacion_Servicio m_itemDet_Operacion_Servicio;
		ObservableCollection<Det_Operacion_Servicio> m_listDet_Operacion_Servicio;
		DetDocsVta m_itemDetDocsVta;
		ObservableCollection<DetDocsVta> m_listDetDocsVta;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Det_Operacion.
		/// </summary>
		[DataMember]
		public Det_Operacion ItemDet_Operacion
		{
			get { return  m_itemDet_Operacion; }
			set {  m_itemDet_Operacion = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Det_Operacion.
		/// </summary>
		[DataMember]
		public ObservableCollection<Det_Operacion> ListDet_Operacion
		{
			get { return  m_listDet_Operacion; }
			set {  m_listDet_Operacion = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Det_Operacion_Servicio.
		/// </summary>
		[DataMember]
		public Det_Operacion_Servicio ItemDet_Operacion_Servicio
		{
			get { return  m_itemDet_Operacion_Servicio; }
			set {  m_itemDet_Operacion_Servicio = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Det_Operacion_Servicio.
		/// </summary>
		[DataMember]
		public ObservableCollection<Det_Operacion_Servicio> ListDet_Operacion_Servicio
		{
			get { return  m_listDet_Operacion_Servicio; }
			set {  m_listDet_Operacion_Servicio = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: DetDocsVta.
		/// </summary>
		[DataMember]
		public DetDocsVta ItemDetDocsVta
		{
			get { return  m_itemDetDocsVta; }
			set {  m_itemDetDocsVta = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: DetDocsVta.
		/// </summary>
		[DataMember]
		public ObservableCollection<DetDocsVta> ListDetDocsVta
		{
			get { return  m_listDetDocsVta; }
			set {  m_listDetDocsVta = value; }
		}
		#endregion
	}
}
