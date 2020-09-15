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
	public partial class Det_Comision
	{
		#region [ Variables ]
		Comision m_itemComision;
		ObservableCollection<Comision> m_listComision;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Comision.
		/// </summary>
		[DataMember]
		public Comision ItemComision
		{
			get { return  m_itemComision; }
			set {  m_itemComision = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Comision.
		/// </summary>
		[DataMember]
		public ObservableCollection<Comision> ListComision
		{
			get { return  m_listComision; }
			set {  m_listComision = value; }
		}
		#endregion
	}
}
