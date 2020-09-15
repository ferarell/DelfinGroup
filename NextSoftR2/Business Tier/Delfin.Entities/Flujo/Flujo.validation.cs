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
	public partial class Flujo
	{
		#region [ Variables Validación ]
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_fluj_codigoOK;
		private String m_fluj_codigoMSGERROR;
		private Boolean m_fluj_glosaOK;
		private String m_fluj_glosaMSGERROR;
		private Boolean m_fluj_tipoflujoOK;
		private String m_fluj_tipoflujoMSGERROR;
		private Boolean m_fluj_tipomovimientoOK;
		private String m_fluj_tipomovimientoMSGERROR;
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
		/// Gets or sets el valor de validación de: EMPR_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean EMPR_CodigoOK
		{
			get { return m_empr_codigoOK; }
			set
			{
				if (m_empr_codigoOK != value)
				{ m_empr_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EMPR_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String EMPR_CodigoMSGERROR
		{
			get { return m_empr_codigoMSGERROR; }
			set
			{
				if (m_empr_codigoMSGERROR != value)
				{m_empr_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: FLUJ_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean FLUJ_CodigoOK
		{
			get { return m_fluj_codigoOK; }
			set
			{
				if (m_fluj_codigoOK != value)
				{ m_fluj_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: FLUJ_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String FLUJ_CodigoMSGERROR
		{
			get { return m_fluj_codigoMSGERROR; }
			set
			{
				if (m_fluj_codigoMSGERROR != value)
				{m_fluj_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: FLUJ_Glosa.
		/// </summary>
		[IgnoreDataMember]
		public Boolean FLUJ_GlosaOK
		{
			get { return m_fluj_glosaOK; }
			set
			{
				if (m_fluj_glosaOK != value)
				{ m_fluj_glosaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: FLUJ_Glosa.
		/// </summary>
		[IgnoreDataMember]
		public String FLUJ_GlosaMSGERROR
		{
			get { return m_fluj_glosaMSGERROR; }
			set
			{
				if (m_fluj_glosaMSGERROR != value)
				{m_fluj_glosaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: FLUJ_TipoFlujo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean FLUJ_TipoFlujoOK
		{
			get { return m_fluj_tipoflujoOK; }
			set
			{
				if (m_fluj_tipoflujoOK != value)
				{ m_fluj_tipoflujoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: FLUJ_TipoFlujo.
		/// </summary>
		[IgnoreDataMember]
		public String FLUJ_TipoFlujoMSGERROR
		{
			get { return m_fluj_tipoflujoMSGERROR; }
			set
			{
				if (m_fluj_tipoflujoMSGERROR != value)
				{m_fluj_tipoflujoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: FLUJ_TipoMovimiento.
		/// </summary>
		[IgnoreDataMember]
		public Boolean FLUJ_TipoMovimientoOK
		{
			get { return m_fluj_tipomovimientoOK; }
			set
			{
				if (m_fluj_tipomovimientoOK != value)
				{ m_fluj_tipomovimientoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: FLUJ_TipoMovimiento.
		/// </summary>
		[IgnoreDataMember]
		public String FLUJ_TipoMovimientoMSGERROR
		{
			get { return m_fluj_tipomovimientoMSGERROR; }
			set
			{
				if (m_fluj_tipomovimientoMSGERROR != value)
				{m_fluj_tipomovimientoMSGERROR = value; }
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
				EMPR_CodigoOK  = true;
				EMPR_CodigoMSGERROR  = "";
				if( EMPR_Codigo == null)
				{
					_isCorrect = false;
					EMPR_CodigoOK  = false;
					EMPR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_Codigo", "Flujo");
					m_mensajeError += "* Debe ingresar el campo EMPR_Codigo" + Environment.NewLine;
				}
                //FLUJ_CodigoOK  = true;
                //FLUJ_CodigoMSGERROR  = "";
                //if( String.IsNullOrEmpty(FLUJ_Codigo) )
                //{
                //    _isCorrect = false;
                //    FLUJ_CodigoOK  = false;
                //    FLUJ_CodigoMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "campo Código", "Flujo");
                //    m_mensajeError += "* Debe ingresar el campo Código" + Environment.NewLine;
                //}
                FLUJ_GlosaOK = true;
                FLUJ_GlosaMSGERROR = "";
                if (String.IsNullOrEmpty(FLUJ_Glosa))
                {
                    _isCorrect = false;
                    FLUJ_GlosaOK = false;
                    FLUJ_GlosaMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "campo Glosa", "Flujo");
                    m_mensajeError += "* Debe ingresar el campo Glosa" + Environment.NewLine;
                }
				FLUJ_TipoFlujoOK  = true;
				FLUJ_TipoFlujoMSGERROR  = "";
				if( String.IsNullOrEmpty(FLUJ_TipoFlujo) )
				{
					_isCorrect = false;
					FLUJ_TipoFlujoOK  = false;
					FLUJ_TipoFlujoMSGERROR  = String.Format("Debe seleccionar el {0} del {1}.", "campo Tipo Flujo", "Flujo");
					m_mensajeError += "* Debe seleccionar el campo Tipo Flujo" + Environment.NewLine;
				}
				FLUJ_TipoMovimientoOK  = true;
				FLUJ_TipoMovimientoMSGERROR  = "";
				if( String.IsNullOrEmpty(FLUJ_TipoMovimiento) )
				{
					_isCorrect = false;
					FLUJ_TipoMovimientoOK  = false;
					FLUJ_TipoMovimientoMSGERROR  = String.Format("Debe seleccionar el {0} del {1}.", "campo Tipo Movimiento", "Flujo");
					m_mensajeError += "* Debe seleccionar el campo Tipo Movimiento" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
