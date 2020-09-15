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
	public partial class Chequera
	{
		#region [ Variables ]
		CuentasBancarias m_itemCuentasBancarias;
		ObservableCollection<CuentasBancarias> m_listCuentasBancarias;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CuentasBancarias.
		/// </summary>
		[DataMember]
		public CuentasBancarias ItemCuentasBancarias
		{
			get { return  m_itemCuentasBancarias; }
			set {  m_itemCuentasBancarias = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: CuentasBancarias.
		/// </summary>
		[DataMember]
		public ObservableCollection<CuentasBancarias> ListCuentasBancarias
		{
			get { return  m_listCuentasBancarias; }
			set {  m_listCuentasBancarias = value; }
		}
		#endregion
	}
}
