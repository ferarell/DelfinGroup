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
	public partial class Det_Seguimientos
	{
		#region [ Variables ]
		Cab_Seguimientos m_itemCab_Seguimientos;
		ObservableCollection<Cab_Seguimientos> m_listCab_Seguimientos;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Cab_Seguimientos.
		/// </summary>
		[DataMember]
		public Cab_Seguimientos ItemCab_Seguimientos
		{
			get { return  m_itemCab_Seguimientos; }
			set {  m_itemCab_Seguimientos = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Cab_Seguimientos.
		/// </summary>
		[DataMember]
		public ObservableCollection<Cab_Seguimientos> ListCab_Seguimientos
		{
			get { return  m_listCab_Seguimientos; }
			set {  m_listCab_Seguimientos = value; }
		}
		#endregion
	}
}
