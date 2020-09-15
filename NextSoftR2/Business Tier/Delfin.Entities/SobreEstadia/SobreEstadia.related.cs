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
	public partial class SobreEstadia
	{
		#region [ Variables ]
		Contrato m_itemContrato;
		ObservableCollection<Contrato> m_listContrato;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Contrato.
		/// </summary>
		[DataMember]
		public Contrato ItemContrato
		{
			get { return  m_itemContrato; }
			set {  m_itemContrato = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Contrato.
		/// </summary>
		[DataMember]
		public ObservableCollection<Contrato> ListContrato
		{
			get { return  m_listContrato; }
			set {  m_listContrato = value; }
		}
		#endregion
	}
}
