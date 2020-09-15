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
	public partial class Cab_MBL
	{
		#region [ Variables ]
		Puerto m_itemPuerto;
		ObservableCollection<Puerto> m_listPuerto;

      private ObservableCollection<Cab_Cotizacion_OV> m_listCab_Cotizacion_OV;
      private ObservableCollection<Det_CNTR> m_listDet_CNTR;
      #endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Puerto.
		/// </summary>
		[DataMember]
		public Puerto ItemPuerto
		{
			get { return  m_itemPuerto; }
			set {  m_itemPuerto = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Puerto.
		/// </summary>
		[DataMember]
		public ObservableCollection<Puerto> ListPuerto
		{
			get { return  m_listPuerto; }
			set {  m_listPuerto = value; }
		}


      /// <summary>
      /// Gets or sets el valor de: ListCab_Cotizacion_OV.
      /// </summary>
      public ObservableCollection<Cab_Cotizacion_OV> ListCab_Cotizacion_OV
      {
         get
         {
            if (m_listCab_Cotizacion_OV == null) { m_listCab_Cotizacion_OV = new ObservableCollection<Cab_Cotizacion_OV>(); }
            return m_listCab_Cotizacion_OV;
         }
         set { m_listCab_Cotizacion_OV = value; }
      }

      /// <summary>
      /// Gets or sets el valor de: ListDet_CNTR.
      /// </summary>
      public ObservableCollection<Det_CNTR> ListDet_CNTR
      {
         get {
            if (m_listDet_CNTR == null) { m_listDet_CNTR = new ObservableCollection<Det_CNTR>(); }
            return m_listDet_CNTR; }
         set { m_listDet_CNTR = value; }
      }
      
      #endregion
	}
}
