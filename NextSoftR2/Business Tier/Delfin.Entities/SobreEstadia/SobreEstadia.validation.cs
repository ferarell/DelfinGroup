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
	public partial class SobreEstadia
	{
		#region [ Variables Validación ]
		private Boolean m_soes_diassobrestadialineaOK;
		private String m_soes_diassobrestadialineaMSGERROR;
		private Boolean m_soes_diassobrestadiaclienteOK;
		private String m_soes_diassobrestadiaclienteMSGERROR;
		private Boolean m_soes_fecinicioOK;
		private String m_soes_fecinicioMSGERROR;
		private Boolean m_tipo_tabtrfOK;
		private String m_tipo_tabtrfMSGERROR;
		private Boolean m_tipo_codtrfOK;
		private String m_tipo_codtrfMSGERROR;
		private Boolean m_soes_fecfinOK;
		private String m_soes_fecfinMSGERROR;
		private Boolean m_soes_itemOK;
		private String m_soes_itemMSGERROR;
		private Boolean m_tipo_tabcntOK;
		private String m_tipo_tabcntMSGERROR;
		private Boolean m_tipo_codcntOK;
		private String m_tipo_codcntMSGERROR;
		private Boolean m_soes_obsfecinicioOK;
		private String m_soes_obsfecinicioMSGERROR;
		private Boolean m_soes_observacionesOK;
		private String m_soes_observacionesMSGERROR;
		private Boolean m_puer_coddestinoOK;
		private String m_puer_coddestinoMSGERROR;
		private Boolean m_soes_ofertaOK;
		private String m_soes_ofertaMSGERROR;
		private Boolean m_cont_codigoOK;
		private String m_cont_codigoMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: SOES_DiasSobrestadiaLinea.
		/// </summary>
		[IgnoreDataMember]
		public Boolean SOES_DiasSobrestadiaLineaOK
		{
			get { return m_soes_diassobrestadialineaOK; }
			set
			{
				if (m_soes_diassobrestadialineaOK != value)
				{ m_soes_diassobrestadialineaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SOES_DiasSobrestadiaLinea.
		/// </summary>
		[IgnoreDataMember]
		public String SOES_DiasSobrestadiaLineaMSGERROR
		{
			get { return m_soes_diassobrestadialineaMSGERROR; }
			set
			{
				if (m_soes_diassobrestadialineaMSGERROR != value)
				{m_soes_diassobrestadialineaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SOES_DiasSobrestadiaCliente.
		/// </summary>
		[IgnoreDataMember]
		public Boolean SOES_DiasSobrestadiaClienteOK
		{
			get { return m_soes_diassobrestadiaclienteOK; }
			set
			{
				if (m_soes_diassobrestadiaclienteOK != value)
				{ m_soes_diassobrestadiaclienteOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SOES_DiasSobrestadiaCliente.
		/// </summary>
		[IgnoreDataMember]
		public String SOES_DiasSobrestadiaClienteMSGERROR
		{
			get { return m_soes_diassobrestadiaclienteMSGERROR; }
			set
			{
				if (m_soes_diassobrestadiaclienteMSGERROR != value)
				{m_soes_diassobrestadiaclienteMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SOES_FecInicio.
		/// </summary>
		[IgnoreDataMember]
		public Boolean SOES_FecInicioOK
		{
			get { return m_soes_fecinicioOK; }
			set
			{
				if (m_soes_fecinicioOK != value)
				{ m_soes_fecinicioOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SOES_FecInicio.
		/// </summary>
		[IgnoreDataMember]
		public String SOES_FecInicioMSGERROR
		{
			get { return m_soes_fecinicioMSGERROR; }
			set
			{
				if (m_soes_fecinicioMSGERROR != value)
				{m_soes_fecinicioMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabTRF.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_TabTRFOK
		{
			get { return m_tipo_tabtrfOK; }
			set
			{
				if (m_tipo_tabtrfOK != value)
				{ m_tipo_tabtrfOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabTRF.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_TabTRFMSGERROR
		{
			get { return m_tipo_tabtrfMSGERROR; }
			set
			{
				if (m_tipo_tabtrfMSGERROR != value)
				{m_tipo_tabtrfMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodTRF.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_CodTRFOK
		{
			get { return m_tipo_codtrfOK; }
			set
			{
				if (m_tipo_codtrfOK != value)
				{ m_tipo_codtrfOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodTRF.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_CodTRFMSGERROR
		{
			get { return m_tipo_codtrfMSGERROR; }
			set
			{
				if (m_tipo_codtrfMSGERROR != value)
				{m_tipo_codtrfMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SOES_FecFin.
		/// </summary>
		[IgnoreDataMember]
		public Boolean SOES_FecFinOK
		{
			get { return m_soes_fecfinOK; }
			set
			{
				if (m_soes_fecfinOK != value)
				{ m_soes_fecfinOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SOES_FecFin.
		/// </summary>
		[IgnoreDataMember]
		public String SOES_FecFinMSGERROR
		{
			get { return m_soes_fecfinMSGERROR; }
			set
			{
				if (m_soes_fecfinMSGERROR != value)
				{m_soes_fecfinMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SOES_Item.
		/// </summary>
		[IgnoreDataMember]
		public Boolean SOES_ItemOK
		{
			get { return m_soes_itemOK; }
			set
			{
				if (m_soes_itemOK != value)
				{ m_soes_itemOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SOES_Item.
		/// </summary>
		[IgnoreDataMember]
		public String SOES_ItemMSGERROR
		{
			get { return m_soes_itemMSGERROR; }
			set
			{
				if (m_soes_itemMSGERROR != value)
				{m_soes_itemMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabCNT.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_TabCNTOK
		{
			get { return m_tipo_tabcntOK; }
			set
			{
				if (m_tipo_tabcntOK != value)
				{ m_tipo_tabcntOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabCNT.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_TabCNTMSGERROR
		{
			get { return m_tipo_tabcntMSGERROR; }
			set
			{
				if (m_tipo_tabcntMSGERROR != value)
				{m_tipo_tabcntMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodCNT.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_CodCNTOK
		{
			get { return m_tipo_codcntOK; }
			set
			{
				if (m_tipo_codcntOK != value)
				{ m_tipo_codcntOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodCNT.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_CodCNTMSGERROR
		{
			get { return m_tipo_codcntMSGERROR; }
			set
			{
				if (m_tipo_codcntMSGERROR != value)
				{m_tipo_codcntMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SOES_ObsFecInicio.
		/// </summary>
		[IgnoreDataMember]
		public Boolean SOES_ObsFecInicioOK
		{
			get { return m_soes_obsfecinicioOK; }
			set
			{
				if (m_soes_obsfecinicioOK != value)
				{ m_soes_obsfecinicioOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SOES_ObsFecInicio.
		/// </summary>
		[IgnoreDataMember]
		public String SOES_ObsFecInicioMSGERROR
		{
			get { return m_soes_obsfecinicioMSGERROR; }
			set
			{
				if (m_soes_obsfecinicioMSGERROR != value)
				{m_soes_obsfecinicioMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SOES_Observaciones.
		/// </summary>
		[IgnoreDataMember]
		public Boolean SOES_ObservacionesOK
		{
			get { return m_soes_observacionesOK; }
			set
			{
				if (m_soes_observacionesOK != value)
				{ m_soes_observacionesOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SOES_Observaciones.
		/// </summary>
		[IgnoreDataMember]
		public String SOES_ObservacionesMSGERROR
		{
			get { return m_soes_observacionesMSGERROR; }
			set
			{
				if (m_soes_observacionesMSGERROR != value)
				{m_soes_observacionesMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PUER_CodDestino.
		/// </summary>
		[IgnoreDataMember]
		public Boolean PUER_CodDestinoOK
		{
			get { return m_puer_coddestinoOK; }
			set
			{
				if (m_puer_coddestinoOK != value)
				{ m_puer_coddestinoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PUER_CodDestino.
		/// </summary>
		[IgnoreDataMember]
		public String PUER_CodDestinoMSGERROR
		{
			get { return m_puer_coddestinoMSGERROR; }
			set
			{
				if (m_puer_coddestinoMSGERROR != value)
				{m_puer_coddestinoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SOES_Oferta.
		/// </summary>
		[IgnoreDataMember]
		public Boolean SOES_OfertaOK
		{
			get { return m_soes_ofertaOK; }
			set
			{
				if (m_soes_ofertaOK != value)
				{ m_soes_ofertaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SOES_Oferta.
		/// </summary>
		[IgnoreDataMember]
		public String SOES_OfertaMSGERROR
		{
			get { return m_soes_ofertaMSGERROR; }
			set
			{
				if (m_soes_ofertaMSGERROR != value)
				{m_soes_ofertaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONT_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CONT_CodigoOK
		{
			get { return m_cont_codigoOK; }
			set
			{
				if (m_cont_codigoOK != value)
				{ m_cont_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONT_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String CONT_CodigoMSGERROR
		{
			get { return m_cont_codigoMSGERROR; }
			set
			{
				if (m_cont_codigoMSGERROR != value)
				{m_cont_codigoMSGERROR = value; }
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
				SOES_DiasSobrestadiaLineaOK  = true;
				SOES_DiasSobrestadiaLineaMSGERROR  = "";
				if( SOES_DiasSobrestadiaLinea == null)
				{
					_isCorrect = false;
					SOES_DiasSobrestadiaLineaOK  = false;
					SOES_DiasSobrestadiaLineaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "SOES_DiasSobrestadiaLinea", "SobreEstadia");
					m_mensajeError += "* Debe ingresar el campo SOES_DiasSobrestadiaLinea" + Environment.NewLine;
				}
				SOES_DiasSobrestadiaClienteOK  = true;
				SOES_DiasSobrestadiaClienteMSGERROR  = "";
				if( SOES_DiasSobrestadiaCliente == null)
				{
					_isCorrect = false;
					SOES_DiasSobrestadiaClienteOK  = false;
					SOES_DiasSobrestadiaClienteMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "SOES_DiasSobrestadiaCliente", "SobreEstadia");
					m_mensajeError += "* Debe ingresar el campo SOES_DiasSobrestadiaCliente" + Environment.NewLine;
				}
				SOES_FecInicioOK  = true;
				SOES_FecInicioMSGERROR  = "";
				if( SOES_FecInicio == null)
				{
					_isCorrect = false;
					SOES_FecInicioOK  = false;
					SOES_FecInicioMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "SOES_FecInicio", "SobreEstadia");
					m_mensajeError += "* Debe ingresar el campo SOES_FecInicio" + Environment.NewLine;
				}
				TIPO_TabTRFOK  = true;
				TIPO_TabTRFMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_TabTRF) )
				{
					_isCorrect = false;
					TIPO_TabTRFOK  = false;
					TIPO_TabTRFMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPO_TabTRF", "SobreEstadia");
					m_mensajeError += "* Debe ingresar el campo TIPO_TabTRF" + Environment.NewLine;
				}
				TIPO_CodTRFOK  = true;
				TIPO_CodTRFMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_CodTRF) )
				{
					_isCorrect = false;
					TIPO_CodTRFOK  = false;
					TIPO_CodTRFMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPO_CodTRF", "SobreEstadia");
					m_mensajeError += "* Debe ingresar el campo TIPO_CodTRF" + Environment.NewLine;
				}
				SOES_ItemOK  = true;
				SOES_ItemMSGERROR  = "";
				if( SOES_Item == null)
				{
					_isCorrect = false;
					SOES_ItemOK  = false;
					SOES_ItemMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "SOES_Item", "SobreEstadia");
					m_mensajeError += "* Debe ingresar el campo SOES_Item" + Environment.NewLine;
				}
				SOES_ObsFecInicioOK  = true;
				SOES_ObsFecInicioMSGERROR  = "";
				if( String.IsNullOrEmpty(SOES_ObsFecInicio) )
				{
					_isCorrect = false;
					SOES_ObsFecInicioOK  = false;
					SOES_ObsFecInicioMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "SOES_ObsFecInicio", "SobreEstadia");
					m_mensajeError += "* Debe ingresar el campo SOES_ObsFecInicio" + Environment.NewLine;
				}
				SOES_ObservacionesOK  = true;
				SOES_ObservacionesMSGERROR  = "";
				if( String.IsNullOrEmpty(SOES_Observaciones) )
				{
					_isCorrect = false;
					SOES_ObservacionesOK  = false;
					SOES_ObservacionesMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "SOES_Observaciones", "SobreEstadia");
					m_mensajeError += "* Debe ingresar el campo SOES_Observaciones" + Environment.NewLine;
				}
				CONT_CodigoOK  = true;
				CONT_CodigoMSGERROR  = "";
				if( CONT_Codigo == 0)
				{
					_isCorrect = false;
					CONT_CodigoOK  = false;
					CONT_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CONT_Codigo", "SobreEstadia");
					m_mensajeError += "* Debe ingresar el campo CONT_Codigo" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
