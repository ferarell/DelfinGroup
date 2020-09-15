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
	public partial class LoadingListDetalle
	{
		#region [ Variables ]
		Det_CNTR m_itemDet_CNTR;
		ObservableCollection<Det_CNTR> m_listDet_CNTR;
		LoadingList m_itemLoadingList;
		ObservableCollection<LoadingList> m_listLoadingList;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Det_CNTR.
		/// </summary>
		[DataMember]
		public Det_CNTR ItemDet_CNTR
		{
			get { return  m_itemDet_CNTR; }
			set {  m_itemDet_CNTR = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Det_CNTR.
		/// </summary>
		[DataMember]
		public ObservableCollection<Det_CNTR> ListDet_CNTR
		{
			get { return  m_listDet_CNTR; }
			set {  m_listDet_CNTR = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: LoadingList.
		/// </summary>
		[DataMember]
		public LoadingList ItemLoadingList
		{
			get { return  m_itemLoadingList; }
			set {  m_itemLoadingList = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: LoadingList.
		/// </summary>
		[DataMember]
		public ObservableCollection<LoadingList> ListLoadingList
		{
			get { return  m_listLoadingList; }
			set {  m_listLoadingList = value; }
		}
		#endregion
	}
}
