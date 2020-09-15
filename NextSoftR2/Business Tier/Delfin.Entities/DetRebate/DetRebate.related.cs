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
	public partial class DetRebate
	{
		#region [ Variables ]
		Paquete m_itemPaquete;
		ObservableCollection<Paquete> m_listPaquete;
		Rebate m_itemRebate;
		ObservableCollection<Rebate> m_listRebate;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Paquete.
		/// </summary>
		[DataMember]
		public Paquete ItemPaquete
		{
			get { return  m_itemPaquete; }
			set {  m_itemPaquete = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Paquete.
		/// </summary>
		[DataMember]
		public ObservableCollection<Paquete> ListPaquete
		{
			get { return  m_listPaquete; }
			set {  m_listPaquete = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Rebate.
		/// </summary>
		[DataMember]
		public Rebate ItemRebate
		{
			get { return  m_itemRebate; }
			set {  m_itemRebate = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Rebate.
		/// </summary>
		[DataMember]
		public ObservableCollection<Rebate> ListRebate
		{
			get { return  m_listRebate; }
			set {  m_listRebate = value; }
		}
		#endregion
	}
}
