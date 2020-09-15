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
	public partial class Cab_Seguimientos
	{
		#region [ Variables ]
		Cab_Direccionamiento m_itemCab_Direccionamiento;
		ObservableCollection<Cab_Direccionamiento> m_listCab_Direccionamiento;
		Cab_Operacion m_itemCab_Operacion;
		ObservableCollection<Cab_Operacion> m_listCab_Operacion;
		#endregion

		#region [ Propiedades ]
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
