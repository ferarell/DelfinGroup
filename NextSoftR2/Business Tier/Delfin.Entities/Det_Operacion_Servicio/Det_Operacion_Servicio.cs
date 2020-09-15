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
	[Serializable()]
	public partial class Det_Operacion_Servicio : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_sope_item;
		private Int32 m_cope_codigo;
      private Int16 m_pddo_item;
      private Int32 m_docv_codigo;
		private String m_cons_codbas;
		private String m_cons_tabbas;
		private String m_tipo_tabmnd;
		private String m_tipo_codmnd;
      private String m_sope_tipo;
		private Nullable<Int32> m_serv_codigo;
		private Nullable<Int32> m_entc_codigo;
		private Nullable<Int16> m_tipe_codigo;
		private String m_sope_ingresogasto;
		private Int16 m_sope_cantidad;
		private Decimal m_sope_preciouni;
		private Decimal m_sope_importeingreso;
		private Decimal m_sope_importeegreso;
      private Decimal m_sope_costo;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
        private String m_cons_codlng;
        private String m_cons_tablng;
        #endregion

        #region [ Constructores ]
        /// <summary>
        /// Inicializar una nueva instancia de la clase Det_Operacion_Servicio.
        /// </summary>
        public Det_Operacion_Servicio()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: SOPE_Item.
		/// </summary>
		[DataMember]
		public Int32 SOPE_Item
		{
			get { return m_sope_item; }
			set
			{
				if (m_sope_item != value)
				{
					m_sope_item = value;
					OnPropertyChanged("SOPE_Item");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: COPE_Codigo.
		/// </summary>
		[DataMember]
		public Int32 COPE_Codigo
		{
			get { return m_cope_codigo; }
			set
			{
				if (m_cope_codigo != value)
				{
					m_cope_codigo = value;
					OnPropertyChanged("COPE_Codigo");
				}
			}
		}
		/// <summary>
      /// Gets or sets el valor de: SOPE_Tipo.
      /// </summary>
      [DataMember]
      public String SOPE_Tipo
      {
         get { return m_sope_tipo; }
         set
         {
            if (m_sope_tipo != value)
            {
               m_sope_tipo = value;
               OnPropertyChanged("SOPE_Tipo");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: COPE_Codigo.
      /// </summary>
		[DataMember]
		public String CONS_CodBas
		{
			get { return m_cons_codbas; }
			set
			{
				if (m_cons_codbas != value)
				{
					m_cons_codbas = value;
					OnPropertyChanged("CONS_CodBas");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabBas.
		/// </summary>
		[DataMember]
		public String CONS_TabBas
		{
			get { return m_cons_tabbas; }
			set
			{
				if (m_cons_tabbas != value)
				{
					m_cons_tabbas = value;
					OnPropertyChanged("CONS_TabBas");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabMnd.
		/// </summary>
		[DataMember]
		public String TIPO_TabMnd
		{
			get { return m_tipo_tabmnd; }
			set
			{
				if (m_tipo_tabmnd != value)
				{
					m_tipo_tabmnd = value;
					OnPropertyChanged("TIPO_TabMnd");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodMnd.
		/// </summary>
		[DataMember]
		public String TIPO_CodMnd
		{
			get { return m_tipo_codmnd; }
			set
			{
				if (m_tipo_codmnd != value)
				{
					m_tipo_codmnd = value;
					OnPropertyChanged("TIPO_CodMnd");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SERV_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> SERV_Codigo
		{
			get { return m_serv_codigo; }
			set
			{
				if (m_serv_codigo != value)
				{
					m_serv_codigo = value;
					OnPropertyChanged("SERV_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_Codigo
		{
			get { return m_entc_codigo; }
			set
			{
				if (m_entc_codigo != value)
				{
					m_entc_codigo = value;
					OnPropertyChanged("ENTC_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPE_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int16> TIPE_Codigo
		{
			get { return m_tipe_codigo; }
			set
			{
				if (m_tipe_codigo != value)
				{
					m_tipe_codigo = value;
					OnPropertyChanged("TIPE_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SOPE_IngresoGasto.
		/// </summary>
		[DataMember]
		public String SOPE_IngresoGasto
		{
			get { return m_sope_ingresogasto; }
			set
			{
				if (m_sope_ingresogasto != value)
				{
					m_sope_ingresogasto = value;
					OnPropertyChanged("SOPE_IngresoGasto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SOPE_Cantidad.
		/// </summary>
		[DataMember]
		public Int16 SOPE_Cantidad
		{
			get { return m_sope_cantidad; }
			set
			{
				if (m_sope_cantidad != value)
				{
					m_sope_cantidad = value;
					OnPropertyChanged("SOPE_Cantidad");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SOPE_PrecioUni.
		/// </summary>
		[DataMember]
		public Decimal SOPE_PrecioUni
		{
			get { return m_sope_preciouni; }
			set
			{
				if (m_sope_preciouni != value)
				{
					m_sope_preciouni = value;
					OnPropertyChanged("SOPE_PrecioUni");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SOPE_ImporteIngreso.
		/// </summary>
		[DataMember]
		public Decimal SOPE_ImporteIngreso
		{
			get { return m_sope_importeingreso; }
			set
			{
				if (m_sope_importeingreso != value)
				{
					m_sope_importeingreso = value;
					OnPropertyChanged("SOPE_ImporteIngreso");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de: SOPE_Costo.
      /// </summary>
      [DataMember]
      public Decimal SOPE_Costo
      {
         get { return m_sope_costo; }
         set
         {
            if (m_sope_costo != value)
            {
               m_sope_costo = value;
               OnPropertyChanged("SOPE_Costo");
            }
         }
      }
		/// <summary>
		/// Gets or sets el valor de: SOPE_ImporteEgreso.
		/// </summary>
		[DataMember]
		public Decimal SOPE_ImporteEgreso
		{
			get { return m_sope_importeegreso; }
			set
			{
				if (m_sope_importeegreso != value)
				{
					m_sope_importeegreso = value;
					OnPropertyChanged("SOPE_ImporteEgreso");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de: DOCV_Codigo.
      /// </summary>
      [DataMember]
      public Int32 DOCV_Codigo
      {
         get { return m_docv_codigo; }
         set
         {
            if (m_docv_codigo != value)
            {
               m_docv_codigo = value;
               OnPropertyChanged("DOCV_Codigo");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: PDDO_Item.
      /// </summary>
      [DataMember]
      public Int16 PDDO_Item
      {
         get { return m_pddo_item; }
         set
         {
            if (m_pddo_item != value)
            {
               m_pddo_item = value;
               OnPropertyChanged("PDDO_Item");
            }
         }
      }
		/// <summary>
		/// Gets or sets el valor de: AUDI_UsrCrea.
		/// </summary>
		[DataMember]
		public String AUDI_UsrCrea
		{
			get { return m_audi_usrcrea; }
			set
			{
				if (m_audi_usrcrea != value)
				{
					m_audi_usrcrea = value;
					OnPropertyChanged("AUDI_UsrCrea");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUDI_FecCrea.
		/// </summary>
		[DataMember]
		public DateTime AUDI_FecCrea
		{
			get { return m_audi_feccrea; }
			set
			{
				if (m_audi_feccrea != value)
				{
					m_audi_feccrea = value;
					OnPropertyChanged("AUDI_FecCrea");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUDI_UsrMod.
		/// </summary>
		[DataMember]
		public String AUDI_UsrMod
		{
			get { return m_audi_usrmod; }
			set
			{
				if (m_audi_usrmod != value)
				{
					m_audi_usrmod = value;
					OnPropertyChanged("AUDI_UsrMod");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUDI_FecMod.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> AUDI_FecMod
		{
			get { return m_audi_fecmod; }
			set
			{
				if (m_audi_fecmod != value)
				{
					m_audi_fecmod = value;
					OnPropertyChanged("AUDI_FecMod");
				}
			}
		}
        /// <summary>
        /// Gets or sets el valor de: CONS_CodLNG.
        /// </summary>
        [DataMember]
        public String CONS_CodLNG
        {
            get { return m_cons_codlng; }
            set
            {
                if (m_cons_codlng != value)
                {
                    m_cons_codlng = value;
                    OnPropertyChanged("CONS_CodLNG");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: CONS_TabLNG.
        /// </summary>
        [DataMember]
        public String CONS_TabLNG
        {
            get { return m_cons_tablng; }
            set
            {
                if (m_cons_tablng != value)
                {
                    m_cons_tablng = value;
                    OnPropertyChanged("CONS_TabLNG");
                }
            }
        }
        #endregion

        #region [ CopyTo ]
        public void CopyTo(ref Det_Operacion_Servicio Item)
		{
			try
			{
				if (Item == null) { Item = new Det_Operacion_Servicio(); }
				Item.SOPE_Item = this.SOPE_Item;
				Item.COPE_Codigo = this.COPE_Codigo;
            Item.SOPE_Tipo = this.SOPE_Tipo;  
				Item.CONS_CodBas = this.CONS_CodBas;
				Item.CONS_TabBas = this.CONS_TabBas;
				Item.TIPO_TabMnd = this.TIPO_TabMnd;
				Item.TIPO_CodMnd = this.TIPO_CodMnd;
				Item.SERV_Codigo = this.SERV_Codigo;
				Item.ENTC_Codigo = this.ENTC_Codigo;
				Item.TIPE_Codigo = this.TIPE_Codigo;
				Item.SOPE_IngresoGasto = this.SOPE_IngresoGasto;
				Item.SOPE_Cantidad = this.SOPE_Cantidad;
				Item.SOPE_PrecioUni = this.SOPE_PrecioUni;
				Item.SOPE_ImporteIngreso = this.SOPE_ImporteIngreso;
				Item.SOPE_ImporteEgreso = this.SOPE_ImporteEgreso;
                Item.CONS_CodLNG = this.CONS_CodLNG;
                Item.CONS_TabLNG = this.CONS_TabLNG;
            }
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
