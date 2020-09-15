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
   public partial class GastosBancarios : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		Transferencia m_itemTransferencia;
		ObservableCollection<Transferencia> m_listTransferencia;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Transferencia.
		/// </summary>
		[DataMember]
		public Transferencia ItemTransferencia
		{
			get { return  m_itemTransferencia; }
			set {  m_itemTransferencia = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Transferencia.
		/// </summary>
		[DataMember]
		public ObservableCollection<Transferencia> ListTransferencia
		{
			get { return  m_listTransferencia; }
			set {  m_listTransferencia = value; }
		}
		#endregion
	}
}
