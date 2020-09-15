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
	public partial class Conciliacion
	{
		#region [ Variables ]
		Movimiento m_itemMovimiento;
		ObservableCollection<Movimiento> m_listMovimiento;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Movimiento.
		/// </summary>
		[DataMember]
		public Movimiento ItemMovimiento
		{
			get { return  m_itemMovimiento; }
			set {  m_itemMovimiento = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Movimiento.
		/// </summary>
		[DataMember]
		public ObservableCollection<Movimiento> ListMovimiento
		{
			get { return  m_listMovimiento; }
			set {  m_listMovimiento = value; }
		}
		#endregion
	}
}
