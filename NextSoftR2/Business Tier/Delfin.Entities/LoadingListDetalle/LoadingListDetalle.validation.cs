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
	public partial class LoadingListDetalle
	{
		#region [ Variables Validación ]
		private Boolean m_lode_cargatipoOK;
		private String m_lode_cargatipoMSGERROR;
		private Boolean m_cntr_numeroOK;
		private String m_cntr_numeroMSGERROR;
		private Boolean m_lode_pesobrutoOK;
		private String m_lode_pesobrutoMSGERROR;
		private Boolean m_lode_volumenOK;
		private String m_lode_volumenMSGERROR;
		private Boolean m_lode_cantbultosOK;
		private String m_lode_cantbultosMSGERROR;
		private Boolean m_lode_precintoOK;
		private String m_lode_precintoMSGERROR;
		private Boolean m_lode_desccargaOK;
		private String m_lode_desccargaMSGERROR;
		private Boolean m_lode_marcasnumerosOK;
		private String m_lode_marcasnumerosMSGERROR;
		private Boolean m_lode_tipotamanioOK;
		private String m_lode_tipotamanioMSGERROR;
		private Boolean m_lode_cargapeligrosaOK;
		private String m_lode_cargapeligrosaMSGERROR;
		private Boolean m_tipo_tabimoOK;
		private String m_tipo_tabimoMSGERROR;
		private Boolean m_tipo_codimoOK;
		private String m_tipo_codimoMSGERROR;
		private Boolean m_lode_tipocntOK;
		private String m_lode_tipocntMSGERROR;
		private Boolean m_lode_tamaniocntOK;
		private String m_lode_tamaniocntMSGERROR;
		private Boolean m_load_codigoOK;
		private String m_load_codigoMSGERROR;
		private Boolean m_lode_itemOK;
		private String m_lode_itemMSGERROR;
		private Boolean m_dhbl_itemOK;
		private String m_dhbl_itemMSGERROR;
		private Boolean m_ccot_tipoOK;
		private String m_ccot_tipoMSGERROR;
		private Boolean m_ccot_numeroOK;
		private String m_ccot_numeroMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: LODE_CargaTipo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LODE_CargaTipoOK
		{
			get { return m_lode_cargatipoOK; }
			set
			{
				if (m_lode_cargatipoOK != value)
				{ m_lode_cargatipoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LODE_CargaTipo.
		/// </summary>
		[IgnoreDataMember]
		public String LODE_CargaTipoMSGERROR
		{
			get { return m_lode_cargatipoMSGERROR; }
			set
			{
				if (m_lode_cargatipoMSGERROR != value)
				{m_lode_cargatipoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CNTR_Numero.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CNTR_NumeroOK
		{
			get { return m_cntr_numeroOK; }
			set
			{
				if (m_cntr_numeroOK != value)
				{ m_cntr_numeroOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CNTR_Numero.
		/// </summary>
		[IgnoreDataMember]
		public String CNTR_NumeroMSGERROR
		{
			get { return m_cntr_numeroMSGERROR; }
			set
			{
				if (m_cntr_numeroMSGERROR != value)
				{m_cntr_numeroMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LODE_PesoBruto.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LODE_PesoBrutoOK
		{
			get { return m_lode_pesobrutoOK; }
			set
			{
				if (m_lode_pesobrutoOK != value)
				{ m_lode_pesobrutoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LODE_PesoBruto.
		/// </summary>
		[IgnoreDataMember]
		public String LODE_PesoBrutoMSGERROR
		{
			get { return m_lode_pesobrutoMSGERROR; }
			set
			{
				if (m_lode_pesobrutoMSGERROR != value)
				{m_lode_pesobrutoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LODE_Volumen.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LODE_VolumenOK
		{
			get { return m_lode_volumenOK; }
			set
			{
				if (m_lode_volumenOK != value)
				{ m_lode_volumenOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LODE_Volumen.
		/// </summary>
		[IgnoreDataMember]
		public String LODE_VolumenMSGERROR
		{
			get { return m_lode_volumenMSGERROR; }
			set
			{
				if (m_lode_volumenMSGERROR != value)
				{m_lode_volumenMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LODE_CantBultos.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LODE_CantBultosOK
		{
			get { return m_lode_cantbultosOK; }
			set
			{
				if (m_lode_cantbultosOK != value)
				{ m_lode_cantbultosOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LODE_CantBultos.
		/// </summary>
		[IgnoreDataMember]
		public String LODE_CantBultosMSGERROR
		{
			get { return m_lode_cantbultosMSGERROR; }
			set
			{
				if (m_lode_cantbultosMSGERROR != value)
				{m_lode_cantbultosMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LODE_Precinto.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LODE_PrecintoOK
		{
			get { return m_lode_precintoOK; }
			set
			{
				if (m_lode_precintoOK != value)
				{ m_lode_precintoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LODE_Precinto.
		/// </summary>
		[IgnoreDataMember]
		public String LODE_PrecintoMSGERROR
		{
			get { return m_lode_precintoMSGERROR; }
			set
			{
				if (m_lode_precintoMSGERROR != value)
				{m_lode_precintoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LODE_DescCarga.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LODE_DescCargaOK
		{
			get { return m_lode_desccargaOK; }
			set
			{
				if (m_lode_desccargaOK != value)
				{ m_lode_desccargaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LODE_DescCarga.
		/// </summary>
		[IgnoreDataMember]
		public String LODE_DescCargaMSGERROR
		{
			get { return m_lode_desccargaMSGERROR; }
			set
			{
				if (m_lode_desccargaMSGERROR != value)
				{m_lode_desccargaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LODE_MarcasNumeros.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LODE_MarcasNumerosOK
		{
			get { return m_lode_marcasnumerosOK; }
			set
			{
				if (m_lode_marcasnumerosOK != value)
				{ m_lode_marcasnumerosOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LODE_MarcasNumeros.
		/// </summary>
		[IgnoreDataMember]
		public String LODE_MarcasNumerosMSGERROR
		{
			get { return m_lode_marcasnumerosMSGERROR; }
			set
			{
				if (m_lode_marcasnumerosMSGERROR != value)
				{m_lode_marcasnumerosMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LODE_TipoTamanio.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LODE_TipoTamanioOK
		{
			get { return m_lode_tipotamanioOK; }
			set
			{
				if (m_lode_tipotamanioOK != value)
				{ m_lode_tipotamanioOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LODE_TipoTamanio.
		/// </summary>
		[IgnoreDataMember]
		public String LODE_TipoTamanioMSGERROR
		{
			get { return m_lode_tipotamanioMSGERROR; }
			set
			{
				if (m_lode_tipotamanioMSGERROR != value)
				{m_lode_tipotamanioMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LODE_CargaPeligrosa.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LODE_CargaPeligrosaOK
		{
			get { return m_lode_cargapeligrosaOK; }
			set
			{
				if (m_lode_cargapeligrosaOK != value)
				{ m_lode_cargapeligrosaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LODE_CargaPeligrosa.
		/// </summary>
		[IgnoreDataMember]
		public String LODE_CargaPeligrosaMSGERROR
		{
			get { return m_lode_cargapeligrosaMSGERROR; }
			set
			{
				if (m_lode_cargapeligrosaMSGERROR != value)
				{m_lode_cargapeligrosaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabIMO.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_TabIMOOK
		{
			get { return m_tipo_tabimoOK; }
			set
			{
				if (m_tipo_tabimoOK != value)
				{ m_tipo_tabimoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabIMO.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_TabIMOMSGERROR
		{
			get { return m_tipo_tabimoMSGERROR; }
			set
			{
				if (m_tipo_tabimoMSGERROR != value)
				{m_tipo_tabimoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodIMO.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_CodIMOOK
		{
			get { return m_tipo_codimoOK; }
			set
			{
				if (m_tipo_codimoOK != value)
				{ m_tipo_codimoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodIMO.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_CodIMOMSGERROR
		{
			get { return m_tipo_codimoMSGERROR; }
			set
			{
				if (m_tipo_codimoMSGERROR != value)
				{m_tipo_codimoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LODE_TipoCNT.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LODE_TipoCNTOK
		{
			get { return m_lode_tipocntOK; }
			set
			{
				if (m_lode_tipocntOK != value)
				{ m_lode_tipocntOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LODE_TipoCNT.
		/// </summary>
		[IgnoreDataMember]
		public String LODE_TipoCNTMSGERROR
		{
			get { return m_lode_tipocntMSGERROR; }
			set
			{
				if (m_lode_tipocntMSGERROR != value)
				{m_lode_tipocntMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LODE_TamanioCNT.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LODE_TamanioCNTOK
		{
			get { return m_lode_tamaniocntOK; }
			set
			{
				if (m_lode_tamaniocntOK != value)
				{ m_lode_tamaniocntOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LODE_TamanioCNT.
		/// </summary>
		[IgnoreDataMember]
		public String LODE_TamanioCNTMSGERROR
		{
			get { return m_lode_tamaniocntMSGERROR; }
			set
			{
				if (m_lode_tamaniocntMSGERROR != value)
				{m_lode_tamaniocntMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_CodigoOK
		{
			get { return m_load_codigoOK; }
			set
			{
				if (m_load_codigoOK != value)
				{ m_load_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_CodigoMSGERROR
		{
			get { return m_load_codigoMSGERROR; }
			set
			{
				if (m_load_codigoMSGERROR != value)
				{m_load_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LODE_Item.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LODE_ItemOK
		{
			get { return m_lode_itemOK; }
			set
			{
				if (m_lode_itemOK != value)
				{ m_lode_itemOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LODE_Item.
		/// </summary>
		[IgnoreDataMember]
		public String LODE_ItemMSGERROR
		{
			get { return m_lode_itemMSGERROR; }
			set
			{
				if (m_lode_itemMSGERROR != value)
				{m_lode_itemMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DHBL_Item.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DHBL_ItemOK
		{
			get { return m_dhbl_itemOK; }
			set
			{
				if (m_dhbl_itemOK != value)
				{ m_dhbl_itemOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DHBL_Item.
		/// </summary>
		[IgnoreDataMember]
		public String DHBL_ItemMSGERROR
		{
			get { return m_dhbl_itemMSGERROR; }
			set
			{
				if (m_dhbl_itemMSGERROR != value)
				{m_dhbl_itemMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_Tipo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CCOT_TipoOK
		{
			get { return m_ccot_tipoOK; }
			set
			{
				if (m_ccot_tipoOK != value)
				{ m_ccot_tipoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_Tipo.
		/// </summary>
		[IgnoreDataMember]
		public String CCOT_TipoMSGERROR
		{
			get { return m_ccot_tipoMSGERROR; }
			set
			{
				if (m_ccot_tipoMSGERROR != value)
				{m_ccot_tipoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_Numero.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CCOT_NumeroOK
		{
			get { return m_ccot_numeroOK; }
			set
			{
				if (m_ccot_numeroOK != value)
				{ m_ccot_numeroOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_Numero.
		/// </summary>
		[IgnoreDataMember]
		public String CCOT_NumeroMSGERROR
		{
			get { return m_ccot_numeroMSGERROR; }
			set
			{
				if (m_ccot_numeroMSGERROR != value)
				{m_ccot_numeroMSGERROR = value; }
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
				LODE_CargaTipoOK  = true;
				LODE_CargaTipoMSGERROR  = "";
				if( String.IsNullOrEmpty(LODE_CargaTipo) )
				{
					_isCorrect = false;
					LODE_CargaTipoOK  = false;
					LODE_CargaTipoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LODE_CargaTipo", "LoadingListDetalle");
					m_mensajeError += "* Debe ingresar el campo LODE_CargaTipo" + Environment.NewLine;
				}
				LODE_PrecintoOK  = true;
				LODE_PrecintoMSGERROR  = "";
				if( String.IsNullOrEmpty(LODE_Precinto) )
				{
					_isCorrect = false;
					LODE_PrecintoOK  = false;
					LODE_PrecintoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LODE_Precinto", "LoadingListDetalle");
					m_mensajeError += "* Debe ingresar el campo LODE_Precinto" + Environment.NewLine;
				}
				LODE_DescCargaOK  = true;
				LODE_DescCargaMSGERROR  = "";
				if( String.IsNullOrEmpty(LODE_DescCarga) )
				{
					_isCorrect = false;
					LODE_DescCargaOK  = false;
					LODE_DescCargaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LODE_DescCarga", "LoadingListDetalle");
					m_mensajeError += "* Debe ingresar el campo LODE_DescCarga" + Environment.NewLine;
				}
				LODE_MarcasNumerosOK  = true;
				LODE_MarcasNumerosMSGERROR  = "";
				if( String.IsNullOrEmpty(LODE_MarcasNumeros) )
				{
					_isCorrect = false;
					LODE_MarcasNumerosOK  = false;
					LODE_MarcasNumerosMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LODE_MarcasNumeros", "LoadingListDetalle");
					m_mensajeError += "* Debe ingresar el campo LODE_MarcasNumeros" + Environment.NewLine;
				}
				LODE_TipoTamanioOK  = true;
				LODE_TipoTamanioMSGERROR  = "";
				if( String.IsNullOrEmpty(LODE_TipoTamanio) )
				{
					_isCorrect = false;
					LODE_TipoTamanioOK  = false;
					LODE_TipoTamanioMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LODE_TipoTamanio", "LoadingListDetalle");
					m_mensajeError += "* Debe ingresar el campo LODE_TipoTamanio" + Environment.NewLine;
				}
				LODE_CargaPeligrosaOK  = true;
				LODE_CargaPeligrosaMSGERROR  = "";
				if( LODE_CargaPeligrosa == null)
				{
					_isCorrect = false;
					LODE_CargaPeligrosaOK  = false;
					LODE_CargaPeligrosaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LODE_CargaPeligrosa", "LoadingListDetalle");
					m_mensajeError += "* Debe ingresar el campo LODE_CargaPeligrosa" + Environment.NewLine;
				}
				LODE_TipoCNTOK  = true;
				LODE_TipoCNTMSGERROR  = "";
				if( String.IsNullOrEmpty(LODE_TipoCNT) )
				{
					_isCorrect = false;
					LODE_TipoCNTOK  = false;
					LODE_TipoCNTMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LODE_TipoCNT", "LoadingListDetalle");
					m_mensajeError += "* Debe ingresar el campo LODE_TipoCNT" + Environment.NewLine;
				}
				LODE_TamanioCNTOK  = true;
				LODE_TamanioCNTMSGERROR  = "";
				if( LODE_TamanioCNT == null)
				{
					_isCorrect = false;
					LODE_TamanioCNTOK  = false;
					LODE_TamanioCNTMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LODE_TamanioCNT", "LoadingListDetalle");
					m_mensajeError += "* Debe ingresar el campo LODE_TamanioCNT" + Environment.NewLine;
				}
				LOAD_CodigoOK  = true;
				LOAD_CodigoMSGERROR  = "";
				if( LOAD_Codigo == 0)
				{
					_isCorrect = false;
					LOAD_CodigoOK  = false;
					LOAD_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LOAD_Codigo", "LoadingListDetalle");
					m_mensajeError += "* Debe ingresar el campo LOAD_Codigo" + Environment.NewLine;
				}
				LODE_ItemOK  = true;
				LODE_ItemMSGERROR  = "";
				if( LODE_Item == null)
				{
					_isCorrect = false;
					LODE_ItemOK  = false;
					LODE_ItemMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LODE_Item", "LoadingListDetalle");
					m_mensajeError += "* Debe ingresar el campo LODE_Item" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
