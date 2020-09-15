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
	public partial class Ubigeos
	{
		#region [ Variables ]
		Ubigeos m_itemUbigeos;
		ObservableCollection<Ubigeos> m_listUbigeos;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Ubigeos.
		/// </summary>
		[DataMember]
		public Ubigeos ItemUbigeos
		{
			get { return  m_itemUbigeos; }
			set {  m_itemUbigeos = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Ubigeos.
		/// </summary>
		[DataMember]
		public ObservableCollection<Ubigeos> ListUbigeos
		{
			get { return  m_listUbigeos; }
			set {  m_listUbigeos = value; }
		}
		#endregion
	}
}
