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
	public partial class NaveViaje
	{
		#region [ Variables ]
		Nave m_itemNave;
		ObservableCollection<Nave> m_listNave;
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: Nave.
		/// </summary>
		[DataMember]
		public Nave ItemNave
		{
			get { return  m_itemNave; }
			set {  m_itemNave = value; }
		}
		/// <summary>
		/// Gets or sets el valor de: Nave.
		/// </summary>
		[DataMember]
		public ObservableCollection<Nave> ListNave
		{
			get { return  m_listNave; }
			set {  m_listNave = value; }
		}

      private ObservableCollection<DetNaveViaje> m_itemsDetNaveViaje;

      public ObservableCollection<DetNaveViaje> ItemsDetNaveViaje
      {
         get {
            if (m_itemsDetNaveViaje == null) { m_itemsDetNaveViaje = new ObservableCollection<DetNaveViaje>(); }
            return m_itemsDetNaveViaje; 
         }
         set { m_itemsDetNaveViaje = value; }
      }

      private ObservableCollection<DetNaveViaje> m_itemsDeletedDetNaveViaje;

      public ObservableCollection<DetNaveViaje> ItemsDeletedDetNaveViaje
      {
         get
         {
            if (m_itemsDeletedDetNaveViaje == null) { m_itemsDeletedDetNaveViaje = new ObservableCollection<DetNaveViaje>(); }
            return m_itemsDeletedDetNaveViaje;
         }
         set { m_itemsDeletedDetNaveViaje = value; }
      }

        /// <summary>
        /// Trae los clientes de todas las OV pertececiente a la Nave Viaje
        /// Cristhian Jose Apaza Arhuata
        /// </summary>
      private ObservableCollection<Entidad> m_itemsnvia_clientes;
      public ObservableCollection<Entidad> ItemsNVIA_Clientes
      {
          get
          {
              if (m_itemsnvia_clientes == null) { m_itemsnvia_clientes = new ObservableCollection<Entidad>(); }
              return m_itemsnvia_clientes;
          }
          set { m_itemsnvia_clientes = value; }
      }

      /// <summary>
      /// Trae los DTE de todas las OV pertececiente a la Nave Viaje
      /// Cristhian Jose Apaza Arhuata
      /// </summary>
      private ObservableCollection<Cab_Cotizacion_OV> m_itemsnvia_deptemp;
      public ObservableCollection<Cab_Cotizacion_OV> ItemsNVIA_DepTemp
      {
          get
          {
              if (m_itemsnvia_deptemp == null) { m_itemsnvia_deptemp = new ObservableCollection<Cab_Cotizacion_OV>(); }
              return m_itemsnvia_deptemp;
          }
          set { m_itemsnvia_deptemp = value; }
      }

        /// <summary>
        /// Items para generar los eventos por nave viaje 
        /// Cristhian Jose Apaza
        /// </summary>
      private ObservableCollection<Det_Cotizacion_OV_EventosTareas> m_itemseventostareas;
      public ObservableCollection<Det_Cotizacion_OV_EventosTareas> ItemsEventosTareas
      {
          get
          {
              if (m_itemseventostareas == null) { m_itemseventostareas = new ObservableCollection<Det_Cotizacion_OV_EventosTareas>(); }
              return m_itemseventostareas;
          }
          set { m_itemseventostareas = value; }
      }
		#endregion
	}
}
