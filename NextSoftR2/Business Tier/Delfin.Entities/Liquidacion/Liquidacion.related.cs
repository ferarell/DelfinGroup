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
	public partial class Liquidacion
	{
		#region [ Variables ]
		Empresa m_itemEmpresa;
		ObservableCollection<Empresa> m_listEmpresa;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Empresa.
		/// </summary>
		[DataMember]
		public Empresa ItemEmpresa
		{
			get { return  m_itemEmpresa; }
			set {  m_itemEmpresa = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Empresa.
		/// </summary>
		[DataMember]
		public ObservableCollection<Empresa> ListEmpresa
		{
			get { return  m_listEmpresa; }
			set {  m_listEmpresa = value; }
		}
		#endregion
	}
}
