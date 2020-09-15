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
	public partial class DetCtaCte
	{
		#region [ Variables ]
		Movimiento m_itemMovimiento;
      ObservableCollection<Movimiento> m_listMovimiento;
		CtaCte m_itemCtaCte;
		ObservableCollection<CtaCte> m_listCtaCte;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Caja.
		/// </summary>
		[DataMember]
		public Movimiento ItemMovimiento
		{
			get { return  m_itemMovimiento; }
			set {  m_itemMovimiento = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Caja.
		/// </summary>
		[DataMember]
		public ObservableCollection<Movimiento> ListMovimiento
		{
			get { return  m_listMovimiento; }
			set {  m_listMovimiento = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: CtaCte.
		/// </summary>
		[DataMember]
		public CtaCte ItemCtaCte
		{
			get { return  m_itemCtaCte; }
			set {  m_itemCtaCte = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: CtaCte.
		/// </summary>
		[DataMember]
		public ObservableCollection<CtaCte> ListCtaCte
		{
			get { return  m_listCtaCte; }
			set {  m_listCtaCte = value; }
		}
		#endregion
	}
}
