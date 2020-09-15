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
	public partial class Det_Operacion_Servicio
	{
		#region [ Variables ]
		Servicio m_itemServicio;
		ObservableCollection<Servicio> m_listServicio;
		FuncionEntidad m_itemFuncionEntidad;
		ObservableCollection<FuncionEntidad> m_listFuncionEntidad;
		Cab_Operacion m_itemCab_Operacion;
		ObservableCollection<Cab_Operacion> m_listCab_Operacion;
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
		/// <summary>
		/// Gets or sets el valor de: FuncionEntidad.
		/// </summary>
		[DataMember]
		public FuncionEntidad ItemFuncionEntidad
		{
			get { return  m_itemFuncionEntidad; }
			set {  m_itemFuncionEntidad = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: FuncionEntidad.
		/// </summary>
		[DataMember]
		public ObservableCollection<FuncionEntidad> ListFuncionEntidad
		{
			get { return  m_listFuncionEntidad; }
			set {  m_listFuncionEntidad = value; }
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
		#endregion
	}
}
