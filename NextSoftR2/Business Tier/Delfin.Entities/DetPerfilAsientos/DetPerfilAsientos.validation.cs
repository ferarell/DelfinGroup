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
	public partial class DetPerfilAsientos
	{
		#region [ Variables Validación ]
		private Boolean m_cabp_anoOK;
		private String m_cabp_anoMSGERROR;
		private Boolean m_cabp_codigoOK;
		private String m_cabp_codigoMSGERROR;
		private Boolean m_detp_itemOK;
		private String m_detp_itemMSGERROR;
		private Boolean m_cuen_codigoOK;
		private String m_cuen_codigoMSGERROR;
		private Boolean m_detp_glosaOK;
		private String m_detp_glosaMSGERROR;
		private Boolean m_cent_codigoOK;
		private String m_cent_codigoMSGERROR;
		private Boolean m_detp_debeporcOK;
		private String m_detp_debeporcMSGERROR;
		private Boolean m_detp_haberporcOK;
		private String m_detp_haberporcMSGERROR;
		private Boolean m_part_codigoOK;
		private String m_part_codigoMSGERROR;
		private Boolean m_pper_numeroOK;
		private String m_pper_numeroMSGERROR;
		private Boolean m_tiga_codigoOK;
		private String m_tiga_codigoMSGERROR;
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
		/// Gets or sets el valor de validación de: CABP_Ano.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CABP_AnoOK
		{
			get { return m_cabp_anoOK; }
			set
			{
				if (m_cabp_anoOK != value)
				{ m_cabp_anoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CABP_Ano.
		/// </summary>
		[IgnoreDataMember]
		public String CABP_AnoMSGERROR
		{
			get { return m_cabp_anoMSGERROR; }
			set
			{
				if (m_cabp_anoMSGERROR != value)
				{m_cabp_anoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CABP_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CABP_CodigoOK
		{
			get { return m_cabp_codigoOK; }
			set
			{
				if (m_cabp_codigoOK != value)
				{ m_cabp_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CABP_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String CABP_CodigoMSGERROR
		{
			get { return m_cabp_codigoMSGERROR; }
			set
			{
				if (m_cabp_codigoMSGERROR != value)
				{m_cabp_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DETP_Item.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DETP_ItemOK
		{
			get { return m_detp_itemOK; }
			set
			{
				if (m_detp_itemOK != value)
				{ m_detp_itemOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DETP_Item.
		/// </summary>
		[IgnoreDataMember]
		public String DETP_ItemMSGERROR
		{
			get { return m_detp_itemMSGERROR; }
			set
			{
				if (m_detp_itemMSGERROR != value)
				{m_detp_itemMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CUEN_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CUEN_CodigoOK
		{
			get { return m_cuen_codigoOK; }
			set
			{
				if (m_cuen_codigoOK != value)
				{ m_cuen_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CUEN_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String CUEN_CodigoMSGERROR
		{
			get { return m_cuen_codigoMSGERROR; }
			set
			{
				if (m_cuen_codigoMSGERROR != value)
				{m_cuen_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DETP_Glosa.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DETP_GlosaOK
		{
			get { return m_detp_glosaOK; }
			set
			{
				if (m_detp_glosaOK != value)
				{ m_detp_glosaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DETP_Glosa.
		/// </summary>
		[IgnoreDataMember]
		public String DETP_GlosaMSGERROR
		{
			get { return m_detp_glosaMSGERROR; }
			set
			{
				if (m_detp_glosaMSGERROR != value)
				{m_detp_glosaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CENT_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CENT_CodigoOK
		{
			get { return m_cent_codigoOK; }
			set
			{
				if (m_cent_codigoOK != value)
				{ m_cent_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CENT_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String CENT_CodigoMSGERROR
		{
			get { return m_cent_codigoMSGERROR; }
			set
			{
				if (m_cent_codigoMSGERROR != value)
				{m_cent_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DETP_DebePorc.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DETP_DebePorcOK
		{
			get { return m_detp_debeporcOK; }
			set
			{
				if (m_detp_debeporcOK != value)
				{ m_detp_debeporcOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DETP_DebePorc.
		/// </summary>
		[IgnoreDataMember]
		public String DETP_DebePorcMSGERROR
		{
			get { return m_detp_debeporcMSGERROR; }
			set
			{
				if (m_detp_debeporcMSGERROR != value)
				{m_detp_debeporcMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DETP_HaberPorc.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DETP_HaberPorcOK
		{
			get { return m_detp_haberporcOK; }
			set
			{
				if (m_detp_haberporcOK != value)
				{ m_detp_haberporcOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DETP_HaberPorc.
		/// </summary>
		[IgnoreDataMember]
		public String DETP_HaberPorcMSGERROR
		{
			get { return m_detp_haberporcMSGERROR; }
			set
			{
				if (m_detp_haberporcMSGERROR != value)
				{m_detp_haberporcMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PART_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean PART_CodigoOK
		{
			get { return m_part_codigoOK; }
			set
			{
				if (m_part_codigoOK != value)
				{ m_part_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PART_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String PART_CodigoMSGERROR
		{
			get { return m_part_codigoMSGERROR; }
			set
			{
				if (m_part_codigoMSGERROR != value)
				{m_part_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PPER_Numero.
		/// </summary>
		[IgnoreDataMember]
		public Boolean PPER_NumeroOK
		{
			get { return m_pper_numeroOK; }
			set
			{
				if (m_pper_numeroOK != value)
				{ m_pper_numeroOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PPER_Numero.
		/// </summary>
		[IgnoreDataMember]
		public String PPER_NumeroMSGERROR
		{
			get { return m_pper_numeroMSGERROR; }
			set
			{
				if (m_pper_numeroMSGERROR != value)
				{m_pper_numeroMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIGA_codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIGA_codigoOK
		{
			get { return m_tiga_codigoOK; }
			set
			{
				if (m_tiga_codigoOK != value)
				{ m_tiga_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIGA_codigo.
		/// </summary>
		[IgnoreDataMember]
		public String TIGA_codigoMSGERROR
		{
			get { return m_tiga_codigoMSGERROR; }
			set
			{
				if (m_tiga_codigoMSGERROR != value)
				{m_tiga_codigoMSGERROR = value; }
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
				CABP_AnoOK  = true;
				CABP_AnoMSGERROR  = "";
				if( String.IsNullOrEmpty(CABP_Ano) )
				{
					_isCorrect = false;
					CABP_AnoOK  = false;
					CABP_AnoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CABP_Ano", "DetPerfilAsientos");
					m_mensajeError += "* Debe ingresar el campo CABP_Ano" + Environment.NewLine;
				}
				CABP_CodigoOK  = true;
				CABP_CodigoMSGERROR  = "";
				if( String.IsNullOrEmpty(CABP_Codigo) )
				{
					_isCorrect = false;
					CABP_CodigoOK  = false;
					CABP_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CABP_Codigo", "DetPerfilAsientos");
					m_mensajeError += "* Debe ingresar el campo CABP_Codigo" + Environment.NewLine;
				}
				DETP_ItemOK  = true;
				DETP_ItemMSGERROR  = "";
				if( DETP_Item == null)
				{
					_isCorrect = false;
					DETP_ItemOK  = false;
					DETP_ItemMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DETP_Item", "DetPerfilAsientos");
					m_mensajeError += "* Debe ingresar el campo DETP_Item" + Environment.NewLine;
				}
				DETP_DebePorcOK  = true;
				DETP_DebePorcMSGERROR  = "";
				if( DETP_DebePorc == 0)
				{
					_isCorrect = false;
					DETP_DebePorcOK  = false;
					DETP_DebePorcMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DETP_DebePorc", "DetPerfilAsientos");
					m_mensajeError += "* Debe ingresar el campo DETP_DebePorc" + Environment.NewLine;
				}
				DETP_HaberPorcOK  = true;
				DETP_HaberPorcMSGERROR  = "";
				if( DETP_HaberPorc == 0)
				{
					_isCorrect = false;
					DETP_HaberPorcOK  = false;
					DETP_HaberPorcMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DETP_HaberPorc", "DetPerfilAsientos");
					m_mensajeError += "* Debe ingresar el campo DETP_HaberPorc" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
