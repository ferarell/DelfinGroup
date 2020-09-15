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
	public partial class TiposCambio
	{
		#region [ Variables Validación ]
		private Boolean m_tipc_fechaOK;
		private String m_tipc_fechaMSGERROR;
		private Boolean m_tipc_compraOK;
		private String m_tipc_compraMSGERROR;
		private Boolean m_tipc_ventaOK;
		private String m_tipc_ventaMSGERROR;
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
		/// Gets or sets el valor de validación de: TIPC_Fecha.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPC_FechaOK
		{
			get { return m_tipc_fechaOK; }
			set
			{
				if (m_tipc_fechaOK != value)
				{ m_tipc_fechaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPC_Fecha.
		/// </summary>
		[IgnoreDataMember]
		public String TIPC_FechaMSGERROR
		{
			get { return m_tipc_fechaMSGERROR; }
			set
			{
				if (m_tipc_fechaMSGERROR != value)
				{m_tipc_fechaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPC_Compra.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPC_CompraOK
		{
			get { return m_tipc_compraOK; }
			set
			{
				if (m_tipc_compraOK != value)
				{ m_tipc_compraOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPC_Compra.
		/// </summary>
		[IgnoreDataMember]
		public String TIPC_CompraMSGERROR
		{
			get { return m_tipc_compraMSGERROR; }
			set
			{
				if (m_tipc_compraMSGERROR != value)
				{m_tipc_compraMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPC_Venta.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPC_VentaOK
		{
			get { return m_tipc_ventaOK; }
			set
			{
				if (m_tipc_ventaOK != value)
				{ m_tipc_ventaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPC_Venta.
		/// </summary>
		[IgnoreDataMember]
		public String TIPC_VentaMSGERROR
		{
			get { return m_tipc_ventaMSGERROR; }
			set
			{
				if (m_tipc_ventaMSGERROR != value)
				{m_tipc_ventaMSGERROR = value; }
			}
		}
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
				TIPC_FechaOK  = true;
				TIPC_FechaMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPC_Fecha) )
				{
					_isCorrect = false;
					TIPC_FechaOK  = false;
					TIPC_FechaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPC_Fecha", "TiposCambio");
					m_mensajeError += "* Debe ingresar el campo TIPC_Fecha" + Environment.NewLine;
				}
				TIPC_CompraOK  = true;
				TIPC_CompraMSGERROR  = "";
				if( TIPC_Compra == 0)
				{
					_isCorrect = false;
					TIPC_CompraOK  = false;
					TIPC_CompraMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPC_Compra", "TiposCambio");
					m_mensajeError += "* Debe ingresar el campo TIPC_Compra" + Environment.NewLine;
				}
				TIPC_VentaOK  = true;
				TIPC_VentaMSGERROR  = "";
				if( TIPC_Venta == 0)
				{
					_isCorrect = false;
					TIPC_VentaOK  = false;
					TIPC_VentaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPC_Venta", "TiposCambio");
					m_mensajeError += "* Debe ingresar el campo TIPC_Venta" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
