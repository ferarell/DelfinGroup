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
	public partial class LiqCtaCte
	{
		#region [ Variables ]
		CtaCte m_itemCtaCte;
		ObservableCollection<CtaCte> m_listCtaCte;
		Liquidacion m_itemLiquidacion;
		ObservableCollection<Liquidacion> m_listLiquidacion;
		#endregion

		#region [ Propiedades ]
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
		/// <summary>
		/// Gets or sets el valor de: Liquidacion.
		/// </summary>
		[DataMember]
		public Liquidacion ItemLiquidacion
		{
			get { return  m_itemLiquidacion; }
			set {  m_itemLiquidacion = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Liquidacion.
		/// </summary>
		[DataMember]
		public ObservableCollection<Liquidacion> ListLiquidacion
		{
			get { return  m_listLiquidacion; }
			set {  m_listLiquidacion = value; }
		}
		#endregion
	}
}
