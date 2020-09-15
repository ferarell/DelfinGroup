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
	public partial class Det_Cotizacion_Servicio : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_ccot_codigo;
		private Int32 m_scot_item;
		private Nullable<Int32> m_serv_codigo;
		private Int16 m_scot_cantidad;
		private Decimal m_scot_preciouni;
		private String m_scot_ingresogasto;
		private Decimal m_scot_importeingreso;
		private Decimal m_scot_importeegreso;
		private String m_cons_codbas;
		private String m_cons_tabbas;
		private String m_tipo_tabmnd;
		private String m_tipo_codmnd;
		private Nullable<Int32> m_entc_codigo;
		private Nullable<Int16> m_tipe_codigo;
		private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
      private String m_scot_tipo;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Det_Cotizacion_Servicio.
		/// </summary>
		public Det_Cotizacion_Servicio()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CCOT_Codigo.
		/// </summary>
		[DataMember]
		public Int32 CCOT_Codigo
		{
			get { return m_ccot_codigo; }
			set
			{
				if (m_ccot_codigo != value)
				{
					m_ccot_codigo = value;
					OnPropertyChanged("CCOT_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SCOT_Item.
		/// </summary>
		[DataMember]
		public Int32 SCOT_Item
		{
			get { return m_scot_item; }
			set
			{
				if (m_scot_item != value)
				{
					m_scot_item = value;
					OnPropertyChanged("SCOT_Item");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de: SCOT_Tipo.
      /// </summary>
      [DataMember]
      public String SCOT_Tipo
      {
         get { return m_scot_tipo; }
         set
         {
            if (m_scot_tipo != value)
            {
               m_scot_tipo = value;
               OnPropertyChanged("SCOT_Tipo");
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
		/// Gets or sets el valor de: SCOT_Cantidad.
		/// </summary>
		[DataMember]
		public Int16 SCOT_Cantidad
		{
			get { return m_scot_cantidad; }
			set
			{
				if (m_scot_cantidad != value)
				{
					m_scot_cantidad = value;
					OnPropertyChanged("SCOT_Cantidad");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SCOT_PrecioUni.
		/// </summary>
		[DataMember]
		public Decimal SCOT_PrecioUni
		{
			get { return m_scot_preciouni; }
			set
			{
				if (m_scot_preciouni != value)
				{
					m_scot_preciouni = value;
					OnPropertyChanged("SCOT_PrecioUni");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SCOT_IngresoGasto.
		/// </summary>
		[DataMember]
		public String SCOT_IngresoGasto
		{
			get { return m_scot_ingresogasto; }
			set
			{
				if (m_scot_ingresogasto != value)
				{
					m_scot_ingresogasto = value;
					OnPropertyChanged("SCOT_IngresoGasto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SCOT_ImporteIngreso.
		/// </summary>
		[DataMember]
		public Decimal SCOT_ImporteIngreso
		{
			get { return m_scot_importeingreso; }
			set
			{
				if (m_scot_importeingreso != value)
				{
					m_scot_importeingreso = value;
					OnPropertyChanged("SCOT_ImporteIngreso");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SCOT_ImporteEgreso.
		/// </summary>
		[DataMember]
		public Decimal SCOT_ImporteEgreso
		{
			get { return m_scot_importeegreso; }
			set
			{
				if (m_scot_importeegreso != value)
				{
					m_scot_importeegreso = value;
					OnPropertyChanged("SCOT_ImporteEgreso");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodBas.
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
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Det_Cotizacion_Servicio Item)
		{
			try
			{
				if (Item == null) { Item = new Det_Cotizacion_Servicio(); }
				Item.CCOT_Codigo = this.CCOT_Codigo;
				Item.SCOT_Item = this.SCOT_Item;
            Item.SCOT_Tipo = this.SCOT_Tipo;  
				Item.SERV_Codigo = this.SERV_Codigo;
				Item.SCOT_Cantidad = this.SCOT_Cantidad;
				Item.SCOT_PrecioUni = this.SCOT_PrecioUni;
				Item.SCOT_IngresoGasto = this.SCOT_IngresoGasto;
				Item.SCOT_ImporteIngreso = this.SCOT_ImporteIngreso;
				Item.SCOT_ImporteEgreso = this.SCOT_ImporteEgreso;
				Item.CONS_CodBas = this.CONS_CodBas;
				Item.CONS_TabBas = this.CONS_TabBas;
				Item.TIPO_TabMnd = this.TIPO_TabMnd;
				Item.TIPO_CodMnd = this.TIPO_CodMnd;
				Item.ENTC_Codigo = this.ENTC_Codigo;
				Item.TIPE_Codigo = this.TIPE_Codigo;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
