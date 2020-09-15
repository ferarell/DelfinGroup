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
	public partial class GRR_Paquetes
	{
		#region [ Variables ]
		GRR m_itemGRR;
		ObservableCollection<GRR> m_listGRR;
		Paquete m_itemPaquete;
		ObservableCollection<Paquete> m_listPaquete;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: GRR.
		/// </summary>
		[DataMember]
		public GRR ItemGRR
		{
			get { return  m_itemGRR; }
			set {  m_itemGRR = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: GRR.
		/// </summary>
		[DataMember]
		public ObservableCollection<GRR> ListGRR
		{
			get { return  m_listGRR; }
			set {  m_listGRR = value; }
		}
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
		#endregion
	}
}
