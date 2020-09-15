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
    public partial class Det_Seguimientos
	{
		#region [ Variables Validación ]
		private Boolean m_cseg_codigoOK;
		private String m_cseg_codigoMSGERROR;
		private Boolean m_dseg_itemOK;
		private String m_dseg_itemMSGERROR;
		private Boolean m_dseg_fechaarriboOK;
		private String m_dseg_fechaarriboMSGERROR;
		private Boolean m_dseg_fecingresodepOK;
		private String m_dseg_fecingresodepMSGERROR;
		private Boolean m_dseg_fecretirodepOK;
		private String m_dseg_fecretirodepMSGERROR;
		private Boolean m_dseg_fecpagoOK;
		private String m_dseg_fecpagoMSGERROR;
		private Boolean m_dseg_nrocontenedorOK;
		private String m_dseg_nrocontenedorMSGERROR;
		private Boolean m_dseg_tarjaOK;
		private String m_dseg_tarjaMSGERROR;
		private Boolean m_cons_codessOK;
		private String m_cons_codessMSGERROR;
		private Boolean m_cons_tabessOK;
		private String m_cons_tabessMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: CSEG_Codigo.
		/// </summary>
		[DataMember]
		public Boolean CSEG_CodigoOK
		{
			get { return m_cseg_codigoOK; }
			set
			{
				if (m_cseg_codigoOK != value)
				{
					m_cseg_codigoOK = value;
					OnPropertyChanged("CSEG_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CSEG_Codigo.
		/// </summary>
		[DataMember]
		public String CSEG_CodigoMSGERROR
		{
			get { return m_cseg_codigoMSGERROR; }
			set
			{
				if (m_cseg_codigoMSGERROR != value)
				{
					m_cseg_codigoMSGERROR = value;
					OnPropertyChanged("CSEG_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DSEG_Item.
		/// </summary>
		[DataMember]
		public Boolean DSEG_ItemOK
		{
			get { return m_dseg_itemOK; }
			set
			{
				if (m_dseg_itemOK != value)
				{
					m_dseg_itemOK = value;
					OnPropertyChanged("DSEG_ItemOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DSEG_Item.
		/// </summary>
		[DataMember]
		public String DSEG_ItemMSGERROR
		{
			get { return m_dseg_itemMSGERROR; }
			set
			{
				if (m_dseg_itemMSGERROR != value)
				{
					m_dseg_itemMSGERROR = value;
					OnPropertyChanged("DSEG_ItemMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DSEG_FechaArribo.
		/// </summary>
		[DataMember]
		public Boolean DSEG_FechaArriboOK
		{
			get { return m_dseg_fechaarriboOK; }
			set
			{
				if (m_dseg_fechaarriboOK != value)
				{
					m_dseg_fechaarriboOK = value;
					OnPropertyChanged("DSEG_FechaArriboOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DSEG_FechaArribo.
		/// </summary>
		[DataMember]
		public String DSEG_FechaArriboMSGERROR
		{
			get { return m_dseg_fechaarriboMSGERROR; }
			set
			{
				if (m_dseg_fechaarriboMSGERROR != value)
				{
					m_dseg_fechaarriboMSGERROR = value;
					OnPropertyChanged("DSEG_FechaArriboMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DSEG_FecIngresoDep.
		/// </summary>
		[DataMember]
		public Boolean DSEG_FecIngresoDepOK
		{
			get { return m_dseg_fecingresodepOK; }
			set
			{
				if (m_dseg_fecingresodepOK != value)
				{
					m_dseg_fecingresodepOK = value;
					OnPropertyChanged("DSEG_FecIngresoDepOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DSEG_FecIngresoDep.
		/// </summary>
		[DataMember]
		public String DSEG_FecIngresoDepMSGERROR
		{
			get { return m_dseg_fecingresodepMSGERROR; }
			set
			{
				if (m_dseg_fecingresodepMSGERROR != value)
				{
					m_dseg_fecingresodepMSGERROR = value;
					OnPropertyChanged("DSEG_FecIngresoDepMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DSEG_FecRetiroDep.
		/// </summary>
		[DataMember]
		public Boolean DSEG_FecRetiroDepOK
		{
			get { return m_dseg_fecretirodepOK; }
			set
			{
				if (m_dseg_fecretirodepOK != value)
				{
					m_dseg_fecretirodepOK = value;
					OnPropertyChanged("DSEG_FecRetiroDepOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DSEG_FecRetiroDep.
		/// </summary>
		[DataMember]
		public String DSEG_FecRetiroDepMSGERROR
		{
			get { return m_dseg_fecretirodepMSGERROR; }
			set
			{
				if (m_dseg_fecretirodepMSGERROR != value)
				{
					m_dseg_fecretirodepMSGERROR = value;
					OnPropertyChanged("DSEG_FecRetiroDepMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DSEG_FecPago.
		/// </summary>
		[DataMember]
		public Boolean DSEG_FecPagoOK
		{
			get { return m_dseg_fecpagoOK; }
			set
			{
				if (m_dseg_fecpagoOK != value)
				{
					m_dseg_fecpagoOK = value;
					OnPropertyChanged("DSEG_FecPagoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DSEG_FecPago.
		/// </summary>
		[DataMember]
		public String DSEG_FecPagoMSGERROR
		{
			get { return m_dseg_fecpagoMSGERROR; }
			set
			{
				if (m_dseg_fecpagoMSGERROR != value)
				{
					m_dseg_fecpagoMSGERROR = value;
					OnPropertyChanged("DSEG_FecPagoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DSEG_NroContenedor.
		/// </summary>
		[DataMember]
		public Boolean DSEG_NroContenedorOK
		{
			get { return m_dseg_nrocontenedorOK; }
			set
			{
				if (m_dseg_nrocontenedorOK != value)
				{
					m_dseg_nrocontenedorOK = value;
					OnPropertyChanged("DSEG_NroContenedorOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DSEG_NroContenedor.
		/// </summary>
		[DataMember]
		public String DSEG_NroContenedorMSGERROR
		{
			get { return m_dseg_nrocontenedorMSGERROR; }
			set
			{
				if (m_dseg_nrocontenedorMSGERROR != value)
				{
					m_dseg_nrocontenedorMSGERROR = value;
					OnPropertyChanged("DSEG_NroContenedorMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DSEG_Tarja.
		/// </summary>
		[DataMember]
		public Boolean DSEG_TarjaOK
		{
			get { return m_dseg_tarjaOK; }
			set
			{
				if (m_dseg_tarjaOK != value)
				{
					m_dseg_tarjaOK = value;
					OnPropertyChanged("DSEG_TarjaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DSEG_Tarja.
		/// </summary>
		[DataMember]
		public String DSEG_TarjaMSGERROR
		{
			get { return m_dseg_tarjaMSGERROR; }
			set
			{
				if (m_dseg_tarjaMSGERROR != value)
				{
					m_dseg_tarjaMSGERROR = value;
					OnPropertyChanged("DSEG_TarjaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodESS.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodESSOK
		{
			get { return m_cons_codessOK; }
			set
			{
				if (m_cons_codessOK != value)
				{
					m_cons_codessOK = value;
					OnPropertyChanged("CONS_CodESSOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodESS.
		/// </summary>
		[DataMember]
		public String CONS_CodESSMSGERROR
		{
			get { return m_cons_codessMSGERROR; }
			set
			{
				if (m_cons_codessMSGERROR != value)
				{
					m_cons_codessMSGERROR = value;
					OnPropertyChanged("CONS_CodESSMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_TabESS.
		/// </summary>
		[DataMember]
		public Boolean CONS_TabESSOK
		{
			get { return m_cons_tabessOK; }
			set
			{
				if (m_cons_tabessOK != value)
				{
					m_cons_tabessOK = value;
					OnPropertyChanged("CONS_TabESSOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TabESS.
		/// </summary>
		[DataMember]
		public String CONS_TabESSMSGERROR
		{
			get { return m_cons_tabessMSGERROR; }
			set
			{
				if (m_cons_tabessMSGERROR != value)
				{
					m_cons_tabessMSGERROR = value;
					OnPropertyChanged("CONS_TabESSMSGERROR");
				}
			}
		}

        [DataMember]
        public String PACK_CodigoMSGERROR { get; set; }

		#endregion

		#region [ Validacion ]
		private String m_mensajeError;
		
		[DataMember]
		public String MensajeError
		{
			get { return m_mensajeError; }
		}
		public Boolean Validar()
		{
			try
			{
				Boolean _isCorrect = true;
				m_mensajeError = "";
				CSEG_CodigoMSGERROR  = "";
                //if( CSEG_Codigo == null)
                //{
                //    _isCorrect = false;
                //    CSEG_CodigoOK  = false;
                //    CSEG_CodigoMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "CSEG_Codigo", "Detalle Seguimiento");
                //    m_mensajeError += "* Debe ingresar el campo CSEG_Codigo" + Environment.NewLine;
                //}
				DSEG_ItemMSGERROR  = "";
                //if( DSEG_Item == null)
                //{
                //    _isCorrect = false;
                //    DSEG_ItemOK  = false;
                //    DSEG_ItemMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DSEG_Item", "Detalle Seguimiento");
                //    m_mensajeError += "* Debe ingresar el campo DSEG_Item" + Environment.NewLine;
                //}
				
				DSEG_FechaArriboMSGERROR  = "";
                if (DSEG_FechaArribo == null)
                {
                    _isCorrect = false;
                    
                    DSEG_FechaArriboMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Fecha de Arribo", "Detalle Seguimiento");
                    m_mensajeError += "* Debe ingresar el campo Fecha de Arriboo" + Environment.NewLine;
                }
				DSEG_FecIngresoDepOK  = true;
				DSEG_FecIngresoDepMSGERROR  = "";
                if (DSEG_FecIngresoDep == null)
                {
                    _isCorrect = false;
                    DSEG_FecIngresoDepOK = false;
                    DSEG_FecIngresoDepMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Fecha de Ingreso Deposito", "Detalle Seguimiento");
                    m_mensajeError += "* Debe ingresar el campo Fecha de Ingreso Deposito" + Environment.NewLine;
                }
				
				DSEG_NroContenedorMSGERROR  = "";
				if( String.IsNullOrEmpty(DSEG_NroContenedor) )
				{
					_isCorrect = false;
					DSEG_NroContenedorOK  = false;
					DSEG_NroContenedorMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "Nro. de Contenedor", "Detalle Seguimiento");
                    m_mensajeError += "* Debe ingresar el campo Nro. de Contenedor" + Environment.NewLine;
				}
			    CONS_CodESSMSGERROR = "";
                if (String.IsNullOrEmpty(CONS_CodESS))
			    {
                    _isCorrect = false;
                    CONS_CodESSMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Estado", "Detalle Seguimiento");
                    m_mensajeError += "* Debe seleccionar el campo Estado" + Environment.NewLine;  
			    }
                PACK_CodigoMSGERROR = "";
                if (PACK_Codigo == 0)
                {
                    _isCorrect = false;
                    PACK_CodigoMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "contenedor", "Detalle Seguimiento");
                    m_mensajeError += "* Debe seleccionar el campo Contenedor" + Environment.NewLine;
                }
				//DSEG_TarjaMSGERROR  = "";
                //if( DSEG_Tarja == null)
                //{
                //    _isCorrect = false;
                //    DSEG_TarjaOK  = false;
                //    DSEG_TarjaMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DSEG_Tarja", "Detalle Seguimiento");
                //    m_mensajeError += "* Debe ingresar el campo DSEG_Tarja" + Environment.NewLine;
                //}
				OnPropertyChanged("MensajeError");
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
