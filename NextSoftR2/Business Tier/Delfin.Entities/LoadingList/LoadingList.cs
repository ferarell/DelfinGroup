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
   public partial class LoadingList : MasterBusinessEntity, INotifyPropertyChanged 
	{
		#region [ Variables ]
		private String m_load_shipper;
		private String m_load_consignee;
		private String m_load_notify;
		private String m_load_carrier;
		private String m_load_booking;
		private String m_load_mbl;
		private String m_load_hbl;
		private Nullable<DateTime> m_load_eta;
		private Nullable<DateTime> m_load_etd;
		private String m_load_payment;
		private String m_load_naveviaje;
      private Nullable<Int32> m_load_codigo;
		private Nullable<Int32> m_ccot_numero;
		private Nullable<Int16> m_ccot_tipo;
		private String m_load_contractnro;
		private String m_load_primerusuario;
		private Nullable<Boolean> m_load_segundook;
		private String m_load_segundousuario;
		private String m_load_cargausuario;
		private Nullable<Boolean> m_load_primerok;
		private Nullable<Boolean> m_load_error;
		private Nullable<Boolean> m_load_enviocorreo;
		private Nullable<DateTime> m_load_enviocorreofecha;
		private String m_load_enviocorreousuario;
		private String m_load_errordescripcion;
		private Nullable<DateTime> m_load_cargafecha;
		private Nullable<Int32> m_puer_codorigen;
		private Nullable<Int32> m_puer_coddestino;
		private Nullable<DateTime> m_load_fecprimerok;
		private Nullable<DateTime> m_load_fecsegundook;
		private Int32 m_nvia_codigo;
        private Nullable<DateTime> m_load_fecdevolucion;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase LoadingList.
		/// </summary>
		public LoadingList()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: LOAD_Shipper.
		/// </summary>
		[DataMember]
		public String LOAD_Shipper
		{
			get { return m_load_shipper; }
			set
			{
				if (m_load_shipper != value)
				{
					m_load_shipper = value;
					OnPropertyChanged("LOAD_Shipper");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_Consignee.
		/// </summary>
		[DataMember]
		public String LOAD_Consignee
		{
			get { return m_load_consignee; }
			set
			{
				if (m_load_consignee != value)
				{
					m_load_consignee = value;
					OnPropertyChanged("LOAD_Consignee");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_Notify.
		/// </summary>
		[DataMember]
		public String LOAD_Notify
		{
			get { return m_load_notify; }
			set
			{
				if (m_load_notify != value)
				{
					m_load_notify = value;
					OnPropertyChanged("LOAD_Notify");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_Carrier.
		/// </summary>
		[DataMember]
		public String LOAD_Carrier
		{
			get { return m_load_carrier; }
			set
			{
				if (m_load_carrier != value)
				{
					m_load_carrier = value;
					OnPropertyChanged("LOAD_Carrier");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_Booking.
		/// </summary>
		[DataMember]
		public String LOAD_Booking
		{
			get { return m_load_booking; }
			set
			{
				if (m_load_booking != value)
				{
					m_load_booking = value;
					OnPropertyChanged("LOAD_Booking");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_MBL.
		/// </summary>
		[DataMember]
		public String LOAD_MBL
		{
			get { return m_load_mbl; }
			set
			{
				if (m_load_mbl != value)
				{
					m_load_mbl = value;
					OnPropertyChanged("LOAD_MBL");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_HBL.
		/// </summary>
		[DataMember]
		public String LOAD_HBL
		{
			get { return m_load_hbl; }
			set
			{
				if (m_load_hbl != value)
				{
					m_load_hbl = value;
					OnPropertyChanged("LOAD_HBL");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_ETA.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> LOAD_ETA
		{
			get { return m_load_eta; }
			set
			{
				if (m_load_eta != value)
				{
					m_load_eta = value;
					OnPropertyChanged("LOAD_ETA");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_ETD.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> LOAD_ETD
		{
			get { return m_load_etd; }
			set
			{
				if (m_load_etd != value)
				{
					m_load_etd = value;
					OnPropertyChanged("LOAD_ETD");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_Payment.
		/// </summary>
		[DataMember]
		public String LOAD_Payment
		{
			get { return m_load_payment; }
			set
			{
				if (m_load_payment != value)
				{
					m_load_payment = value;
					OnPropertyChanged("LOAD_Payment");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_NaveViaje.
		/// </summary>
		[DataMember]
		public String LOAD_NaveViaje
		{
			get { return m_load_naveviaje; }
			set
			{
				if (m_load_naveviaje != value)
				{
					m_load_naveviaje = value;
					OnPropertyChanged("LOAD_NaveViaje");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_Codigo.
		/// </summary>
		[DataMember]
      public Nullable<Int32> LOAD_Codigo
		{
			get { return m_load_codigo; }
			set
			{
				if (m_load_codigo != value)
				{
					m_load_codigo = value;
					OnPropertyChanged("LOAD_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_Numero.
		/// </summary>
		[DataMember]
		public Nullable<Int32> CCOT_Numero
		{
			get { return m_ccot_numero; }
			set
			{
				if (m_ccot_numero != value)
				{
					m_ccot_numero = value;
					OnPropertyChanged("CCOT_Numero");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_Tipo.
		/// </summary>
		[DataMember]
		public Nullable<Int16> CCOT_Tipo
		{
			get { return m_ccot_tipo; }
			set
			{
				if (m_ccot_tipo != value)
				{
					m_ccot_tipo = value;
					OnPropertyChanged("CCOT_Tipo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_ContractNRO.
		/// </summary>
		[DataMember]
		public String LOAD_ContractNRO
		{
			get { return m_load_contractnro; }
			set
			{
				if (m_load_contractnro != value)
				{
					m_load_contractnro = value;
					OnPropertyChanged("LOAD_ContractNRO");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_PrimerUsuario.
		/// </summary>
		[DataMember]
		public String LOAD_PrimerUsuario
		{
			get { return m_load_primerusuario; }
			set
			{
				if (m_load_primerusuario != value)
				{
					m_load_primerusuario = value;
					OnPropertyChanged("LOAD_PrimerUsuario");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_SegundoOK.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> LOAD_SegundoOK
		{
			get { return m_load_segundook; }
			set
			{
				if (m_load_segundook != value)
				{
					m_load_segundook = value;
					OnPropertyChanged("LOAD_SegundoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_SegundoUsuario.
		/// </summary>
		[DataMember]
		public String LOAD_SegundoUsuario
		{
			get { return m_load_segundousuario; }
			set
			{
				if (m_load_segundousuario != value)
				{
					m_load_segundousuario = value;
					OnPropertyChanged("LOAD_SegundoUsuario");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_CargaUsuario.
		/// </summary>
		[DataMember]
		public String LOAD_CargaUsuario
		{
			get { return m_load_cargausuario; }
			set
			{
				if (m_load_cargausuario != value)
				{
					m_load_cargausuario = value;
					OnPropertyChanged("LOAD_CargaUsuario");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_PrimerOK.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> LOAD_PrimerOK
		{
			get { return m_load_primerok; }
			set
			{
				if (m_load_primerok != value)
				{
					m_load_primerok = value;
					OnPropertyChanged("LOAD_PrimerOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_Error.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> LOAD_Error
		{
			get { return m_load_error; }
			set
			{
				if (m_load_error != value)
				{
					m_load_error = value;
					OnPropertyChanged("LOAD_Error");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_EnvioCorreo.
		/// </summary>
		[DataMember]
		public Nullable<Boolean> LOAD_EnvioCorreo
		{
			get { return m_load_enviocorreo; }
			set
			{
				if (m_load_enviocorreo != value)
				{
					m_load_enviocorreo = value;
					OnPropertyChanged("LOAD_EnvioCorreo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_EnvioCorreoFecha.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> LOAD_EnvioCorreoFecha
		{
			get { return m_load_enviocorreofecha; }
			set
			{
				if (m_load_enviocorreofecha != value)
				{
					m_load_enviocorreofecha = value;
					OnPropertyChanged("LOAD_EnvioCorreoFecha");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_EnvioCorreoUsuario.
		/// </summary>
		[DataMember]
		public String LOAD_EnvioCorreoUsuario
		{
			get { return m_load_enviocorreousuario; }
			set
			{
				if (m_load_enviocorreousuario != value)
				{
					m_load_enviocorreousuario = value;
					OnPropertyChanged("LOAD_EnvioCorreoUsuario");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_ErrorDescripcion.
		/// </summary>
		[DataMember]
		public String LOAD_ErrorDescripcion
		{
			get { return m_load_errordescripcion; }
			set
			{
				if (m_load_errordescripcion != value)
				{
					m_load_errordescripcion = value;
					OnPropertyChanged("LOAD_ErrorDescripcion");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_CargaFecha.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> LOAD_CargaFecha
		{
			get { return m_load_cargafecha; }
			set
			{
				if (m_load_cargafecha != value)
				{
					m_load_cargafecha = value;
					OnPropertyChanged("LOAD_CargaFecha");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PUER_CodOrigen.
		/// </summary>
		[DataMember]
		public Nullable<Int32> PUER_CodOrigen
		{
			get { return m_puer_codorigen; }
			set
			{
				if (m_puer_codorigen != value)
				{
					m_puer_codorigen = value;
					OnPropertyChanged("PUER_CodOrigen");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PUER_CodDestino.
		/// </summary>
		[DataMember]
		public Nullable<Int32> PUER_CodDestino
		{
			get { return m_puer_coddestino; }
			set
			{
				if (m_puer_coddestino != value)
				{
					m_puer_coddestino = value;
					OnPropertyChanged("PUER_CodDestino");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_FecPrimerOK.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> LOAD_FecPrimerOK
		{
			get { return m_load_fecprimerok; }
			set
			{
				if (m_load_fecprimerok != value)
				{
					m_load_fecprimerok = value;
					OnPropertyChanged("LOAD_FecPrimerOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: LOAD_FecSegundoOK.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> LOAD_FecSegundoOK
		{
			get { return m_load_fecsegundook; }
			set
			{
				if (m_load_fecsegundook != value)
				{
					m_load_fecsegundook = value;
					OnPropertyChanged("LOAD_FecSegundoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: NVIA_Codigo.
		/// </summary>
		[DataMember]
		public Int32 NVIA_Codigo
		{
			get { return m_nvia_codigo; }
			set
			{
				if (m_nvia_codigo != value)
				{
					m_nvia_codigo = value;
					OnPropertyChanged("NVIA_Codigo");
				}
			}
		}
        /// <summary>
        /// Gets or sets el valor de: LOAD_FecDevolucion.
        /// </summary>
        [DataMember]
        public Nullable<DateTime> LOAD_FecDevolucion
        {
            get { return m_load_fecdevolucion; }
            set
            {
                if (m_load_fecdevolucion != value)
                {
                    m_load_fecdevolucion = value;
                    OnPropertyChanged("LOAD_FecDevolucion");
                }
            }
        }
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref LoadingList Item)
		{
			try
			{
				if (Item == null) { Item = new LoadingList(); }
				Item.LOAD_Shipper = this.LOAD_Shipper;
				Item.LOAD_Consignee = this.LOAD_Consignee;
				Item.LOAD_Notify = this.LOAD_Notify;
				Item.LOAD_Carrier = this.LOAD_Carrier;
				Item.LOAD_Booking = this.LOAD_Booking;
				Item.LOAD_MBL = this.LOAD_MBL;
				Item.LOAD_HBL = this.LOAD_HBL;
				Item.LOAD_ETA = this.LOAD_ETA;
				Item.LOAD_ETD = this.LOAD_ETD;
				Item.LOAD_Payment = this.LOAD_Payment;
				Item.LOAD_NaveViaje = this.LOAD_NaveViaje;
				Item.LOAD_Codigo = this.LOAD_Codigo;
				Item.CCOT_Numero = this.CCOT_Numero;
				Item.CCOT_Tipo = this.CCOT_Tipo;
				Item.LOAD_ContractNRO = this.LOAD_ContractNRO;
				Item.LOAD_PrimerUsuario = this.LOAD_PrimerUsuario;
				Item.LOAD_SegundoOK = this.LOAD_SegundoOK;
				Item.LOAD_SegundoUsuario = this.LOAD_SegundoUsuario;
				Item.LOAD_CargaUsuario = this.LOAD_CargaUsuario;
				Item.LOAD_PrimerOK = this.LOAD_PrimerOK;
				Item.LOAD_Error = this.LOAD_Error;
				Item.LOAD_EnvioCorreo = this.LOAD_EnvioCorreo;
				Item.LOAD_EnvioCorreoFecha = this.LOAD_EnvioCorreoFecha;
				Item.LOAD_EnvioCorreoUsuario = this.LOAD_EnvioCorreoUsuario;
				Item.LOAD_ErrorDescripcion = this.LOAD_ErrorDescripcion;
				Item.LOAD_CargaFecha = this.LOAD_CargaFecha;
				Item.PUER_CodOrigen = this.PUER_CodOrigen;
				Item.PUER_CodDestino = this.PUER_CodDestino;
				Item.LOAD_FecPrimerOK = this.LOAD_FecPrimerOK;
				Item.LOAD_FecSegundoOK = this.LOAD_FecSegundoOK;
				Item.NVIA_Codigo = this.NVIA_Codigo;
                Item.LOAD_FecDevolucion = this.LOAD_FecDevolucion;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
