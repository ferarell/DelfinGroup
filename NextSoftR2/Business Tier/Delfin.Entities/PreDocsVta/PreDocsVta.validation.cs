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
    public partial class PreDocsVta
	{
		#region [ Variables Validación ]
		private Boolean m_pdoc_codigoOK;
		private String m_pdoc_codigoMSGERROR;
		private Boolean m_docv_numeroOK;
		private String m_docv_numeroMSGERROR;
		private Boolean m_docv_tipocambioOK;
		private String m_docv_tipocambioMSGERROR;
		private Boolean m_docv_fechaemisionOK;
		private String m_docv_fechaemisionMSGERROR;
		private Boolean m_docv_fechavcmtoOK;
		private String m_docv_fechavcmtoMSGERROR;
		private Boolean m_docv_estadoOK;
		private String m_docv_estadoMSGERROR;
		private Boolean m_docv_precvtatotalOK;
		private String m_docv_precvtatotalMSGERROR;
		private Boolean m_docv_precvtatotaldOK;
		private String m_docv_precvtatotaldMSGERROR;
		private Boolean m_docv_valortotalOK;
		private String m_docv_valortotalMSGERROR;
		private Boolean m_docv_valortotaldOK;
		private String m_docv_valortotaldMSGERROR;
		private Boolean m_docv_valorvtatotalOK;
		private String m_docv_valorvtatotalMSGERROR;
		private Boolean m_docv_valorvtatotaldOK;
		private String m_docv_valorvtatotaldMSGERROR;
		private Boolean m_docv_descuentoOK;
		private String m_docv_descuentoMSGERROR;
		private Boolean m_docv_descuentodOK;
		private String m_docv_descuentodMSGERROR;
		private Boolean m_docv_observacionesOK;
		private String m_docv_observacionesMSGERROR;
		private Boolean m_docv_impuesto1OK;
		private String m_docv_impuesto1MSGERROR;
		private Boolean m_docv_impuesto1dOK;
		private String m_docv_impuesto1dMSGERROR;
		private Boolean m_docv_impuesto2OK;
		private String m_docv_impuesto2MSGERROR;
		private Boolean m_docv_impuesto2dOK;
		private String m_docv_impuesto2dMSGERROR;
		private Boolean m_docv_impuesto3OK;
		private String m_docv_impuesto3MSGERROR;
		private Boolean m_docv_impuesto3dOK;
		private String m_docv_impuesto3dMSGERROR;
		private Boolean m_docv_impuesto4OK;
		private String m_docv_impuesto4MSGERROR;
		private Boolean m_docv_impuesto4dOK;
		private String m_docv_impuesto4dMSGERROR;
		private Boolean m_docv_porcimp1OK;
		private String m_docv_porcimp1MSGERROR;
		private Boolean m_docv_porcimp2OK;
		private String m_docv_porcimp2MSGERROR;
		private Boolean m_docv_porcimp3OK;
		private String m_docv_porcimp3MSGERROR;
		private Boolean m_docv_porcimp4OK;
		private String m_docv_porcimp4MSGERROR;
		private Boolean m_docv_notasOK;
		private String m_docv_notasMSGERROR;
		private Boolean m_docv_serieOK;
		private String m_docv_serieMSGERROR;
		private Boolean m_tipo_tabfpgOK;
		private String m_tipo_tabfpgMSGERROR;
		private Boolean m_tipo_codfpgOK;
		private String m_tipo_codfpgMSGERROR;
		private Boolean m_tipo_tabtdoOK;
		private String m_tipo_tabtdoMSGERROR;
		private Boolean m_tipo_codtdoOK;
		private String m_tipo_codtdoMSGERROR;
		private Boolean m_tipo_tabmndOK;
		private String m_tipo_tabmndMSGERROR;
		private Boolean m_tipo_codmndOK;
		private String m_tipo_codmndMSGERROR;
		private Boolean m_cons_codanuOK;
		private String m_cons_codanuMSGERROR;
		private Boolean m_cons_tabanuOK;
		private String m_cons_tabanuMSGERROR;
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
		/// Gets or sets el valor de validación de: PDOC_Codigo.
		/// </summary>
		[DataMember]
		public Boolean PDOC_CodigoOK
		{
			get { return m_pdoc_codigoOK; }
			set
			{
				if (m_pdoc_codigoOK != value)
				{
					m_pdoc_codigoOK = value;
					OnPropertyChanged("PDOC_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PDOC_Codigo.
		/// </summary>
		[DataMember]
		public String PDOC_CodigoMSGERROR
		{
			get { return m_pdoc_codigoMSGERROR; }
			set
			{
				if (m_pdoc_codigoMSGERROR != value)
				{
					m_pdoc_codigoMSGERROR = value;
					OnPropertyChanged("PDOC_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_Numero.
		/// </summary>
		[DataMember]
		public Boolean DOCV_NumeroOK
		{
			get { return m_docv_numeroOK; }
			set
			{
				if (m_docv_numeroOK != value)
				{
					m_docv_numeroOK = value;
					OnPropertyChanged("DOCV_NumeroOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_Numero.
		/// </summary>
		[DataMember]
		public String DOCV_NumeroMSGERROR
		{
			get { return m_docv_numeroMSGERROR; }
			set
			{
				if (m_docv_numeroMSGERROR != value)
				{
					m_docv_numeroMSGERROR = value;
					OnPropertyChanged("DOCV_NumeroMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_TipoCambio.
		/// </summary>
		[DataMember]
		public Boolean DOCV_TipoCambioOK
		{
			get { return m_docv_tipocambioOK; }
			set
			{
				if (m_docv_tipocambioOK != value)
				{
					m_docv_tipocambioOK = value;
					OnPropertyChanged("DOCV_TipoCambioOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_TipoCambio.
		/// </summary>
		[DataMember]
		public String DOCV_TipoCambioMSGERROR
		{
			get { return m_docv_tipocambioMSGERROR; }
			set
			{
				if (m_docv_tipocambioMSGERROR != value)
				{
					m_docv_tipocambioMSGERROR = value;
					OnPropertyChanged("DOCV_TipoCambioMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_FechaEmision.
		/// </summary>
		[DataMember]
		public Boolean DOCV_FechaEmisionOK
		{
			get { return m_docv_fechaemisionOK; }
			set
			{
				if (m_docv_fechaemisionOK != value)
				{
					m_docv_fechaemisionOK = value;
					OnPropertyChanged("DOCV_FechaEmisionOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_FechaEmision.
		/// </summary>
		[DataMember]
		public String DOCV_FechaEmisionMSGERROR
		{
			get { return m_docv_fechaemisionMSGERROR; }
			set
			{
				if (m_docv_fechaemisionMSGERROR != value)
				{
					m_docv_fechaemisionMSGERROR = value;
					OnPropertyChanged("DOCV_FechaEmisionMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_FechaVcmto.
		/// </summary>
		[DataMember]
		public Boolean DOCV_FechaVcmtoOK
		{
			get { return m_docv_fechavcmtoOK; }
			set
			{
				if (m_docv_fechavcmtoOK != value)
				{
					m_docv_fechavcmtoOK = value;
					OnPropertyChanged("DOCV_FechaVcmtoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_FechaVcmto.
		/// </summary>
		[DataMember]
		public String DOCV_FechaVcmtoMSGERROR
		{
			get { return m_docv_fechavcmtoMSGERROR; }
			set
			{
				if (m_docv_fechavcmtoMSGERROR != value)
				{
					m_docv_fechavcmtoMSGERROR = value;
					OnPropertyChanged("DOCV_FechaVcmtoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_Estado.
		/// </summary>
		[DataMember]
		public Boolean DOCV_EstadoOK
		{
			get { return m_docv_estadoOK; }
			set
			{
				if (m_docv_estadoOK != value)
				{
					m_docv_estadoOK = value;
					OnPropertyChanged("DOCV_EstadoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_Estado.
		/// </summary>
		[DataMember]
		public String DOCV_EstadoMSGERROR
		{
			get { return m_docv_estadoMSGERROR; }
			set
			{
				if (m_docv_estadoMSGERROR != value)
				{
					m_docv_estadoMSGERROR = value;
					OnPropertyChanged("DOCV_EstadoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_PrecVtaTotal.
		/// </summary>
		[DataMember]
		public Boolean DOCV_PrecVtaTotalOK
		{
			get { return m_docv_precvtatotalOK; }
			set
			{
				if (m_docv_precvtatotalOK != value)
				{
					m_docv_precvtatotalOK = value;
					OnPropertyChanged("DOCV_PrecVtaTotalOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_PrecVtaTotal.
		/// </summary>
		[DataMember]
		public String DOCV_PrecVtaTotalMSGERROR
		{
			get { return m_docv_precvtatotalMSGERROR; }
			set
			{
				if (m_docv_precvtatotalMSGERROR != value)
				{
					m_docv_precvtatotalMSGERROR = value;
					OnPropertyChanged("DOCV_PrecVtaTotalMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_PrecVtaTotalD.
		/// </summary>
		[DataMember]
		public Boolean DOCV_PrecVtaTotalDOK
		{
			get { return m_docv_precvtatotaldOK; }
			set
			{
				if (m_docv_precvtatotaldOK != value)
				{
					m_docv_precvtatotaldOK = value;
					OnPropertyChanged("DOCV_PrecVtaTotalDOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_PrecVtaTotalD.
		/// </summary>
		[DataMember]
		public String DOCV_PrecVtaTotalDMSGERROR
		{
			get { return m_docv_precvtatotaldMSGERROR; }
			set
			{
				if (m_docv_precvtatotaldMSGERROR != value)
				{
					m_docv_precvtatotaldMSGERROR = value;
					OnPropertyChanged("DOCV_PrecVtaTotalDMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_ValorTotal.
		/// </summary>
		[DataMember]
		public Boolean DOCV_ValorTotalOK
		{
			get { return m_docv_valortotalOK; }
			set
			{
				if (m_docv_valortotalOK != value)
				{
					m_docv_valortotalOK = value;
					OnPropertyChanged("DOCV_ValorTotalOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_ValorTotal.
		/// </summary>
		[DataMember]
		public String DOCV_ValorTotalMSGERROR
		{
			get { return m_docv_valortotalMSGERROR; }
			set
			{
				if (m_docv_valortotalMSGERROR != value)
				{
					m_docv_valortotalMSGERROR = value;
					OnPropertyChanged("DOCV_ValorTotalMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_ValorTotalD.
		/// </summary>
		[DataMember]
		public Boolean DOCV_ValorTotalDOK
		{
			get { return m_docv_valortotaldOK; }
			set
			{
				if (m_docv_valortotaldOK != value)
				{
					m_docv_valortotaldOK = value;
					OnPropertyChanged("DOCV_ValorTotalDOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_ValorTotalD.
		/// </summary>
		[DataMember]
		public String DOCV_ValorTotalDMSGERROR
		{
			get { return m_docv_valortotaldMSGERROR; }
			set
			{
				if (m_docv_valortotaldMSGERROR != value)
				{
					m_docv_valortotaldMSGERROR = value;
					OnPropertyChanged("DOCV_ValorTotalDMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_ValorVtaTotal.
		/// </summary>
		[DataMember]
		public Boolean DOCV_ValorVtaTotalOK
		{
			get { return m_docv_valorvtatotalOK; }
			set
			{
				if (m_docv_valorvtatotalOK != value)
				{
					m_docv_valorvtatotalOK = value;
					OnPropertyChanged("DOCV_ValorVtaTotalOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_ValorVtaTotal.
		/// </summary>
		[DataMember]
		public String DOCV_ValorVtaTotalMSGERROR
		{
			get { return m_docv_valorvtatotalMSGERROR; }
			set
			{
				if (m_docv_valorvtatotalMSGERROR != value)
				{
					m_docv_valorvtatotalMSGERROR = value;
					OnPropertyChanged("DOCV_ValorVtaTotalMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_ValorVtaTotalD.
		/// </summary>
		[DataMember]
		public Boolean DOCV_ValorVtaTotalDOK
		{
			get { return m_docv_valorvtatotaldOK; }
			set
			{
				if (m_docv_valorvtatotaldOK != value)
				{
					m_docv_valorvtatotaldOK = value;
					OnPropertyChanged("DOCV_ValorVtaTotalDOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_ValorVtaTotalD.
		/// </summary>
		[DataMember]
		public String DOCV_ValorVtaTotalDMSGERROR
		{
			get { return m_docv_valorvtatotaldMSGERROR; }
			set
			{
				if (m_docv_valorvtatotaldMSGERROR != value)
				{
					m_docv_valorvtatotaldMSGERROR = value;
					OnPropertyChanged("DOCV_ValorVtaTotalDMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_Descuento.
		/// </summary>
		[DataMember]
		public Boolean DOCV_DescuentoOK
		{
			get { return m_docv_descuentoOK; }
			set
			{
				if (m_docv_descuentoOK != value)
				{
					m_docv_descuentoOK = value;
					OnPropertyChanged("DOCV_DescuentoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_Descuento.
		/// </summary>
		[DataMember]
		public String DOCV_DescuentoMSGERROR
		{
			get { return m_docv_descuentoMSGERROR; }
			set
			{
				if (m_docv_descuentoMSGERROR != value)
				{
					m_docv_descuentoMSGERROR = value;
					OnPropertyChanged("DOCV_DescuentoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_DescuentoD.
		/// </summary>
		[DataMember]
		public Boolean DOCV_DescuentoDOK
		{
			get { return m_docv_descuentodOK; }
			set
			{
				if (m_docv_descuentodOK != value)
				{
					m_docv_descuentodOK = value;
					OnPropertyChanged("DOCV_DescuentoDOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_DescuentoD.
		/// </summary>
		[DataMember]
		public String DOCV_DescuentoDMSGERROR
		{
			get { return m_docv_descuentodMSGERROR; }
			set
			{
				if (m_docv_descuentodMSGERROR != value)
				{
					m_docv_descuentodMSGERROR = value;
					OnPropertyChanged("DOCV_DescuentoDMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_Observaciones.
		/// </summary>
		[DataMember]
		public Boolean DOCV_ObservacionesOK
		{
			get { return m_docv_observacionesOK; }
			set
			{
				if (m_docv_observacionesOK != value)
				{
					m_docv_observacionesOK = value;
					OnPropertyChanged("DOCV_ObservacionesOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_Observaciones.
		/// </summary>
		[DataMember]
		public String DOCV_ObservacionesMSGERROR
		{
			get { return m_docv_observacionesMSGERROR; }
			set
			{
				if (m_docv_observacionesMSGERROR != value)
				{
					m_docv_observacionesMSGERROR = value;
					OnPropertyChanged("DOCV_ObservacionesMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_Impuesto1.
		/// </summary>
		[DataMember]
		public Boolean DOCV_Impuesto1OK
		{
			get { return m_docv_impuesto1OK; }
			set
			{
				if (m_docv_impuesto1OK != value)
				{
					m_docv_impuesto1OK = value;
					OnPropertyChanged("DOCV_Impuesto1OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_Impuesto1.
		/// </summary>
		[DataMember]
		public String DOCV_Impuesto1MSGERROR
		{
			get { return m_docv_impuesto1MSGERROR; }
			set
			{
				if (m_docv_impuesto1MSGERROR != value)
				{
					m_docv_impuesto1MSGERROR = value;
					OnPropertyChanged("DOCV_Impuesto1MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_Impuesto1D.
		/// </summary>
		[DataMember]
		public Boolean DOCV_Impuesto1DOK
		{
			get { return m_docv_impuesto1dOK; }
			set
			{
				if (m_docv_impuesto1dOK != value)
				{
					m_docv_impuesto1dOK = value;
					OnPropertyChanged("DOCV_Impuesto1DOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_Impuesto1D.
		/// </summary>
		[DataMember]
		public String DOCV_Impuesto1DMSGERROR
		{
			get { return m_docv_impuesto1dMSGERROR; }
			set
			{
				if (m_docv_impuesto1dMSGERROR != value)
				{
					m_docv_impuesto1dMSGERROR = value;
					OnPropertyChanged("DOCV_Impuesto1DMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_Impuesto2.
		/// </summary>
		[DataMember]
		public Boolean DOCV_Impuesto2OK
		{
			get { return m_docv_impuesto2OK; }
			set
			{
				if (m_docv_impuesto2OK != value)
				{
					m_docv_impuesto2OK = value;
					OnPropertyChanged("DOCV_Impuesto2OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_Impuesto2.
		/// </summary>
		[DataMember]
		public String DOCV_Impuesto2MSGERROR
		{
			get { return m_docv_impuesto2MSGERROR; }
			set
			{
				if (m_docv_impuesto2MSGERROR != value)
				{
					m_docv_impuesto2MSGERROR = value;
					OnPropertyChanged("DOCV_Impuesto2MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_Impuesto2D.
		/// </summary>
		[DataMember]
		public Boolean DOCV_Impuesto2DOK
		{
			get { return m_docv_impuesto2dOK; }
			set
			{
				if (m_docv_impuesto2dOK != value)
				{
					m_docv_impuesto2dOK = value;
					OnPropertyChanged("DOCV_Impuesto2DOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_Impuesto2D.
		/// </summary>
		[DataMember]
		public String DOCV_Impuesto2DMSGERROR
		{
			get { return m_docv_impuesto2dMSGERROR; }
			set
			{
				if (m_docv_impuesto2dMSGERROR != value)
				{
					m_docv_impuesto2dMSGERROR = value;
					OnPropertyChanged("DOCV_Impuesto2DMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_Impuesto3.
		/// </summary>
		[DataMember]
		public Boolean DOCV_Impuesto3OK
		{
			get { return m_docv_impuesto3OK; }
			set
			{
				if (m_docv_impuesto3OK != value)
				{
					m_docv_impuesto3OK = value;
					OnPropertyChanged("DOCV_Impuesto3OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_Impuesto3.
		/// </summary>
		[DataMember]
		public String DOCV_Impuesto3MSGERROR
		{
			get { return m_docv_impuesto3MSGERROR; }
			set
			{
				if (m_docv_impuesto3MSGERROR != value)
				{
					m_docv_impuesto3MSGERROR = value;
					OnPropertyChanged("DOCV_Impuesto3MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_Impuesto3D.
		/// </summary>
		[DataMember]
		public Boolean DOCV_Impuesto3DOK
		{
			get { return m_docv_impuesto3dOK; }
			set
			{
				if (m_docv_impuesto3dOK != value)
				{
					m_docv_impuesto3dOK = value;
					OnPropertyChanged("DOCV_Impuesto3DOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_Impuesto3D.
		/// </summary>
		[DataMember]
		public String DOCV_Impuesto3DMSGERROR
		{
			get { return m_docv_impuesto3dMSGERROR; }
			set
			{
				if (m_docv_impuesto3dMSGERROR != value)
				{
					m_docv_impuesto3dMSGERROR = value;
					OnPropertyChanged("DOCV_Impuesto3DMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_Impuesto4.
		/// </summary>
		[DataMember]
		public Boolean DOCV_Impuesto4OK
		{
			get { return m_docv_impuesto4OK; }
			set
			{
				if (m_docv_impuesto4OK != value)
				{
					m_docv_impuesto4OK = value;
					OnPropertyChanged("DOCV_Impuesto4OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_Impuesto4.
		/// </summary>
		[DataMember]
		public String DOCV_Impuesto4MSGERROR
		{
			get { return m_docv_impuesto4MSGERROR; }
			set
			{
				if (m_docv_impuesto4MSGERROR != value)
				{
					m_docv_impuesto4MSGERROR = value;
					OnPropertyChanged("DOCV_Impuesto4MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_Impuesto4D.
		/// </summary>
		[DataMember]
		public Boolean DOCV_Impuesto4DOK
		{
			get { return m_docv_impuesto4dOK; }
			set
			{
				if (m_docv_impuesto4dOK != value)
				{
					m_docv_impuesto4dOK = value;
					OnPropertyChanged("DOCV_Impuesto4DOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_Impuesto4D.
		/// </summary>
		[DataMember]
		public String DOCV_Impuesto4DMSGERROR
		{
			get { return m_docv_impuesto4dMSGERROR; }
			set
			{
				if (m_docv_impuesto4dMSGERROR != value)
				{
					m_docv_impuesto4dMSGERROR = value;
					OnPropertyChanged("DOCV_Impuesto4DMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_PorcImp1.
		/// </summary>
		[DataMember]
		public Boolean DOCV_PorcImp1OK
		{
			get { return m_docv_porcimp1OK; }
			set
			{
				if (m_docv_porcimp1OK != value)
				{
					m_docv_porcimp1OK = value;
					OnPropertyChanged("DOCV_PorcImp1OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_PorcImp1.
		/// </summary>
		[DataMember]
		public String DOCV_PorcImp1MSGERROR
		{
			get { return m_docv_porcimp1MSGERROR; }
			set
			{
				if (m_docv_porcimp1MSGERROR != value)
				{
					m_docv_porcimp1MSGERROR = value;
					OnPropertyChanged("DOCV_PorcImp1MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_PorcImp2.
		/// </summary>
		[DataMember]
		public Boolean DOCV_PorcImp2OK
		{
			get { return m_docv_porcimp2OK; }
			set
			{
				if (m_docv_porcimp2OK != value)
				{
					m_docv_porcimp2OK = value;
					OnPropertyChanged("DOCV_PorcImp2OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_PorcImp2.
		/// </summary>
		[DataMember]
		public String DOCV_PorcImp2MSGERROR
		{
			get { return m_docv_porcimp2MSGERROR; }
			set
			{
				if (m_docv_porcimp2MSGERROR != value)
				{
					m_docv_porcimp2MSGERROR = value;
					OnPropertyChanged("DOCV_PorcImp2MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_PorcImp3.
		/// </summary>
		[DataMember]
		public Boolean DOCV_PorcImp3OK
		{
			get { return m_docv_porcimp3OK; }
			set
			{
				if (m_docv_porcimp3OK != value)
				{
					m_docv_porcimp3OK = value;
					OnPropertyChanged("DOCV_PorcImp3OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_PorcImp3.
		/// </summary>
		[DataMember]
		public String DOCV_PorcImp3MSGERROR
		{
			get { return m_docv_porcimp3MSGERROR; }
			set
			{
				if (m_docv_porcimp3MSGERROR != value)
				{
					m_docv_porcimp3MSGERROR = value;
					OnPropertyChanged("DOCV_PorcImp3MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_PorcImp4.
		/// </summary>
		[DataMember]
		public Boolean DOCV_PorcImp4OK
		{
			get { return m_docv_porcimp4OK; }
			set
			{
				if (m_docv_porcimp4OK != value)
				{
					m_docv_porcimp4OK = value;
					OnPropertyChanged("DOCV_PorcImp4OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_PorcImp4.
		/// </summary>
		[DataMember]
		public String DOCV_PorcImp4MSGERROR
		{
			get { return m_docv_porcimp4MSGERROR; }
			set
			{
				if (m_docv_porcimp4MSGERROR != value)
				{
					m_docv_porcimp4MSGERROR = value;
					OnPropertyChanged("DOCV_PorcImp4MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_Notas.
		/// </summary>
		[DataMember]
		public Boolean DOCV_NotasOK
		{
			get { return m_docv_notasOK; }
			set
			{
				if (m_docv_notasOK != value)
				{
					m_docv_notasOK = value;
					OnPropertyChanged("DOCV_NotasOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_Notas.
		/// </summary>
		[DataMember]
		public String DOCV_NotasMSGERROR
		{
			get { return m_docv_notasMSGERROR; }
			set
			{
				if (m_docv_notasMSGERROR != value)
				{
					m_docv_notasMSGERROR = value;
					OnPropertyChanged("DOCV_NotasMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_Serie.
		/// </summary>
		[DataMember]
		public Boolean DOCV_SerieOK
		{
			get { return m_docv_serieOK; }
			set
			{
				if (m_docv_serieOK != value)
				{
					m_docv_serieOK = value;
					OnPropertyChanged("DOCV_SerieOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_Serie.
		/// </summary>
		[DataMember]
		public String DOCV_SerieMSGERROR
		{
			get { return m_docv_serieMSGERROR; }
			set
			{
				if (m_docv_serieMSGERROR != value)
				{
					m_docv_serieMSGERROR = value;
					OnPropertyChanged("DOCV_SerieMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabFPG.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabFPGOK
		{
			get { return m_tipo_tabfpgOK; }
			set
			{
				if (m_tipo_tabfpgOK != value)
				{
					m_tipo_tabfpgOK = value;
					OnPropertyChanged("TIPO_TabFPGOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabFPG.
		/// </summary>
		[DataMember]
		public String TIPO_TabFPGMSGERROR
		{
			get { return m_tipo_tabfpgMSGERROR; }
			set
			{
				if (m_tipo_tabfpgMSGERROR != value)
				{
					m_tipo_tabfpgMSGERROR = value;
					OnPropertyChanged("TIPO_TabFPGMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodFPG.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodFPGOK
		{
			get { return m_tipo_codfpgOK; }
			set
			{
				if (m_tipo_codfpgOK != value)
				{
					m_tipo_codfpgOK = value;
					OnPropertyChanged("TIPO_CodFPGOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodFPG.
		/// </summary>
		[DataMember]
		public String TIPO_CodFPGMSGERROR
		{
			get { return m_tipo_codfpgMSGERROR; }
			set
			{
				if (m_tipo_codfpgMSGERROR != value)
				{
					m_tipo_codfpgMSGERROR = value;
					OnPropertyChanged("TIPO_CodFPGMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabTDO.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabTDOOK
		{
			get { return m_tipo_tabtdoOK; }
			set
			{
				if (m_tipo_tabtdoOK != value)
				{
					m_tipo_tabtdoOK = value;
					OnPropertyChanged("TIPO_TabTDOOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabTDO.
		/// </summary>
		[DataMember]
		public String TIPO_TabTDOMSGERROR
		{
			get { return m_tipo_tabtdoMSGERROR; }
			set
			{
				if (m_tipo_tabtdoMSGERROR != value)
				{
					m_tipo_tabtdoMSGERROR = value;
					OnPropertyChanged("TIPO_TabTDOMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodTDO.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodTDOOK
		{
			get { return m_tipo_codtdoOK; }
			set
			{
				if (m_tipo_codtdoOK != value)
				{
					m_tipo_codtdoOK = value;
					OnPropertyChanged("TIPO_CodTDOOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodTDO.
		/// </summary>
		[DataMember]
		public String TIPO_CodTDOMSGERROR
		{
			get { return m_tipo_codtdoMSGERROR; }
			set
			{
				if (m_tipo_codtdoMSGERROR != value)
				{
					m_tipo_codtdoMSGERROR = value;
					OnPropertyChanged("TIPO_CodTDOMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabMND.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabMNDOK
		{
			get { return m_tipo_tabmndOK; }
			set
			{
				if (m_tipo_tabmndOK != value)
				{
					m_tipo_tabmndOK = value;
					OnPropertyChanged("TIPO_TabMNDOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabMND.
		/// </summary>
		[DataMember]
		public String TIPO_TabMNDMSGERROR
		{
			get { return m_tipo_tabmndMSGERROR; }
			set
			{
				if (m_tipo_tabmndMSGERROR != value)
				{
					m_tipo_tabmndMSGERROR = value;
					OnPropertyChanged("TIPO_TabMNDMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodMND.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodMNDOK
		{
			get { return m_tipo_codmndOK; }
			set
			{
				if (m_tipo_codmndOK != value)
				{
					m_tipo_codmndOK = value;
					OnPropertyChanged("TIPO_CodMNDOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodMND.
		/// </summary>
		[DataMember]
		public String TIPO_CodMNDMSGERROR
		{
			get { return m_tipo_codmndMSGERROR; }
			set
			{
				if (m_tipo_codmndMSGERROR != value)
				{
					m_tipo_codmndMSGERROR = value;
					OnPropertyChanged("TIPO_CodMNDMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodANU.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodANUOK
		{
			get { return m_cons_codanuOK; }
			set
			{
				if (m_cons_codanuOK != value)
				{
					m_cons_codanuOK = value;
					OnPropertyChanged("CONS_CodANUOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodANU.
		/// </summary>
		[DataMember]
		public String CONS_CodANUMSGERROR
		{
			get { return m_cons_codanuMSGERROR; }
			set
			{
				if (m_cons_codanuMSGERROR != value)
				{
					m_cons_codanuMSGERROR = value;
					OnPropertyChanged("CONS_CodANUMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_TabANU.
		/// </summary>
		[DataMember]
		public Boolean CONS_TabANUOK
		{
			get { return m_cons_tabanuOK; }
			set
			{
				if (m_cons_tabanuOK != value)
				{
					m_cons_tabanuOK = value;
					OnPropertyChanged("CONS_TabANUOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TabANU.
		/// </summary>
		[DataMember]
		public String CONS_TabANUMSGERROR
		{
			get { return m_cons_tabanuMSGERROR; }
			set
			{
				if (m_cons_tabanuMSGERROR != value)
				{
					m_cons_tabanuMSGERROR = value;
					OnPropertyChanged("CONS_TabANUMSGERROR");
				}
			}
		}

        public String ENTC_CodigoMSGERROR { set; get; }
        public String TIPE_CodigoMSGERROR { set; get; }
		#endregion

		#region [ Validacion ]
		private String m_mensajeError;
        public bool IsDate(object Value)
        {
            bool bValid;
            try
            {
                DateTime MyDate = DateTime.Parse(Value.ToString());
                bValid = true;
            }
            catch (Exception)
            {
                bValid = false;
            }
            return bValid;
        }
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
				PDOC_CodigoOK  = true;
				PDOC_CodigoMSGERROR  = "";
                DOCV_FechaEmisionMSGERROR = "";
                if (DOCV_FechaEmision == null)
                {
                    _isCorrect = false;
                    DOCV_FechaEmisionMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Fecha Emisión", "Documento de Venta");
                    m_mensajeError += "* Debe ingresar el campo Fecha Emisión" + Environment.NewLine;
                }
                else
                {
                    if (!IsDate(DOCV_FechaEmision))
                    {
                        _isCorrect = false;
                        DOCV_FechaEmisionMSGERROR = String.Format("Debe ingresar la {0}  en formato correcto del {1}.", "Fecha Emisión", "Documento de Venta");
                        m_mensajeError += "* Debe ingresar el campo fecha emisión en formato correcto" + Environment.NewLine;
                    }
                }
                
                DOCV_EstadoMSGERROR = "";
                if (String.IsNullOrEmpty(DOCV_Estado))
                {
                    _isCorrect = false;
                    
                    DOCV_EstadoMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Estado", "Documento de Venta");
                    m_mensajeError += "* Debe seleccionar el campo estado" + Environment.NewLine;
                }

                TIPE_CodigoMSGERROR = "";
                if (TIPE_Codigo == 0)
                {
                    _isCorrect = false;

                    TIPE_CodigoMSGERROR = String.Format("Debe ingresar el {0} de {1}.", "Tipo", "Entidad");
                    m_mensajeError += "* Debe seleccionar un Tipo de Entidad" + Environment.NewLine;
                }

                ENTC_CodigoMSGERROR = "";
                if (ENTC_Codigo==0)
                {
                    _isCorrect = false;
                
                    ENTC_CodigoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Cliente", "Documento de Venta");
                    m_mensajeError += "* Debe seleccionar una Entidad" + Environment.NewLine;
                }
                //if( PDOC_Codigo == null)
                //{
                //    _isCorrect = false;
                //    PDOC_CodigoOK  = false;
                //    PDOC_CodigoMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "PDOC_Codigo", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo PDOC_Codigo" + Environment.NewLine;
                //}
				DOCV_NumeroOK  = true;
				DOCV_NumeroMSGERROR  = "";
                //if( String.IsNullOrEmpty(DOCV_Numero) )
                //{
                //    _isCorrect = false;
                //    DOCV_NumeroOK  = false;
                //    DOCV_NumeroMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DOCV_Numero", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DOCV_Numero" + Environment.NewLine;
                //}
				DOCV_TipoCambioOK  = true;
				DOCV_TipoCambioMSGERROR  = "";
                if (DOCV_TipoCambio == 0)
                {
                    _isCorrect = false;
                    DOCV_TipoCambioOK = false;
                    DOCV_TipoCambioMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Tipo de Cambio", "Documento de Venta");
                    m_mensajeError += "* Debe ingresar el campo Tipo de Cambio" + Environment.NewLine;
                }
                //DOCV_PrecVtaTotalOK  = true;
                //DOCV_PrecVtaTotalMSGERROR  = "";
                //if( DOCV_PrecVtaTotal == 0)
                //{
                //    _isCorrect = false;
                //    DOCV_PrecVtaTotalMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "Precio Venta Total", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo Precio Venta Total" + Environment.NewLine;
                //}
                //DOCV_PrecVtaTotalDOK  = true;
                //DOCV_PrecVtaTotalDMSGERROR  = "";
                //if( DOCV_PrecVtaTotalD == 0)
                //{
                //    _isCorrect = false;
                //    DOCV_PrecVtaTotalDOK  = false;
                //    DOCV_PrecVtaTotalDMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Precio Venta Total Dólares", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo Precio Venta Total Dólares" + Environment.NewLine;
                //}
                //DOCV_ValorTotalOK  = true;
                //DOCV_ValorTotalMSGERROR  = "";
                //if( DOCV_ValorTotal == 0)
                //{
                //    _isCorrect = false;
                //    DOCV_ValorTotalOK  = false;
                //    DOCV_ValorTotalMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Venta Total", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo Valor de Venta" + Environment.NewLine;
                //}
                //DOCV_ValorTotalDOK  = true;
                //DOCV_ValorTotalDMSGERROR  = "";
                //if( DOCV_ValorTotalD == 0)
                //{
                //    _isCorrect = false;
                //    DOCV_ValorTotalDOK  = false;
                //    DOCV_ValorTotalDMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Valor de Venta Dólares", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo Valor de Venta Dólares" + Environment.NewLine;
                //}
                //DOCV_ValorVtaTotalOK  = true;
                //DOCV_ValorVtaTotalMSGERROR  = "";
                //if( DOCV_ValorVtaTotal == 0)
                //{
                //    _isCorrect = false;
                //    DOCV_ValorVtaTotalOK  = false;
                //    DOCV_ValorVtaTotalMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DOCV_ValorVtaTotal", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DOCV_ValorVtaTotal" + Environment.NewLine;
                //}
                //DOCV_ValorVtaTotalDOK  = true;
                //DOCV_ValorVtaTotalDMSGERROR  = "";
                //if( DOCV_ValorVtaTotalD == 0)
                //{
                //    _isCorrect = false;
                //    DOCV_ValorVtaTotalDOK  = false;
                //    DOCV_ValorVtaTotalDMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DOCV_ValorVtaTotalD", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DOCV_ValorVtaTotalD" + Environment.NewLine;
                //}
                //DOCV_DescuentoOK  = true;
                //DOCV_DescuentoMSGERROR  = "";
                //if( DOCV_Descuento == null)
                //{
                //    _isCorrect = false;
                //    DOCV_DescuentoOK  = false;
                //    DOCV_DescuentoMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DOCV_Descuento", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DOCV_Descuento" + Environment.NewLine;
                //}
				DOCV_DescuentoDOK  = true;
				DOCV_DescuentoDMSGERROR  = "";
                //if( DOCV_DescuentoD == null)
                //{
                //    _isCorrect = false;
                //    DOCV_DescuentoDOK  = false;
                //    DOCV_DescuentoDMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DOCV_DescuentoD", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DOCV_DescuentoD" + Environment.NewLine;
                //}
				DOCV_ObservacionesOK  = true;
				DOCV_ObservacionesMSGERROR  = "";
                //if( String.IsNullOrEmpty(DOCV_Observaciones) )
                //{
                //    _isCorrect = false;
                //    DOCV_ObservacionesOK  = false;
                //    DOCV_ObservacionesMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "Observaciones", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo Observaciones" + Environment.NewLine;
                //}
                //DOCV_Impuesto1OK  = true;
                //DOCV_Impuesto1MSGERROR  = "";
                //if( DOCV_Impuesto1 == 0)
                //{
                //    _isCorrect = false;
                //    DOCV_Impuesto1OK  = false;
                //    DOCV_Impuesto1MSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "Impuesto", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo Impuesto" + Environment.NewLine;
                //}
                //DOCV_Impuesto1DOK  = true;
                //DOCV_Impuesto1DMSGERROR  = "";
                //if (DOCV_Impuesto1D == 0)
                //{
                //    _isCorrect = false;
                //    DOCV_Impuesto1DOK = false;
                //    DOCV_Impuesto1DMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "DOCV_Impuesto1D", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DOCV_Impuesto1D" + Environment.NewLine;
                //}
                //DOCV_Impuesto2OK  = true;
                //DOCV_Impuesto2MSGERROR  = "";
                //if( DOCV_Impuesto2 == null)
                //{
                //    _isCorrect = false;
                //    DOCV_Impuesto2OK  = false;
                //    DOCV_Impuesto2MSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DOCV_Impuesto2", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DOCV_Impuesto2" + Environment.NewLine;
                //}
				DOCV_Impuesto2DOK  = true;
				DOCV_Impuesto2DMSGERROR  = "";
                //if( DOCV_Impuesto2D == null)
                //{
                //    _isCorrect = false;
                //    DOCV_Impuesto2DOK  = false;
                //    DOCV_Impuesto2DMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DOCV_Impuesto2D", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DOCV_Impuesto2D" + Environment.NewLine;
                //}
				DOCV_Impuesto3OK  = true;
				DOCV_Impuesto3MSGERROR  = "";
                //if( DOCV_Impuesto3 == null)
                //{
                //    _isCorrect = false;
                //    DOCV_Impuesto3OK  = false;
                //    DOCV_Impuesto3MSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DOCV_Impuesto3", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DOCV_Impuesto3" + Environment.NewLine;
                //}
				DOCV_Impuesto3DOK  = true;
				DOCV_Impuesto3DMSGERROR  = "";
                //if( DOCV_Impuesto3D == null)
                //{
                //    _isCorrect = false;
                //    DOCV_Impuesto3DOK  = false;
                //    DOCV_Impuesto3DMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DOCV_Impuesto3D", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DOCV_Impuesto3D" + Environment.NewLine;
                //}
				DOCV_Impuesto4OK  = true;
				DOCV_Impuesto4MSGERROR  = "";
                //if( DOCV_Impuesto4 == null)
                //{
                //    _isCorrect = false;
                //    DOCV_Impuesto4OK  = false;
                //    DOCV_Impuesto4MSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DOCV_Impuesto4", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DOCV_Impuesto4" + Environment.NewLine;
                //}
				DOCV_Impuesto4DOK  = true;
				DOCV_Impuesto4DMSGERROR  = "";
                //if( DOCV_Impuesto4D == null)
                //{
                //    _isCorrect = false;
                //    DOCV_Impuesto4DOK  = false;
                //    DOCV_Impuesto4DMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DOCV_Impuesto4D", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DOCV_Impuesto4D" + Environment.NewLine;
                //}
				DOCV_PorcImp1OK  = true;
				DOCV_PorcImp1MSGERROR  = "";
                //if( DOCV_PorcImp1 == null)
                //{
                //    _isCorrect = false;
                //    DOCV_PorcImp1OK  = false;
                //    DOCV_PorcImp1MSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DOCV_PorcImp1", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DOCV_PorcImp1" + Environment.NewLine;
                //}
				DOCV_PorcImp2OK  = true;
				DOCV_PorcImp2MSGERROR  = "";
                //if( DOCV_PorcImp2 == null)
                //{
                //    _isCorrect = false;
                //    DOCV_PorcImp2OK  = false;
                //    DOCV_PorcImp2MSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DOCV_PorcImp2", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DOCV_PorcImp2" + Environment.NewLine;
                //}
                //DOCV_PorcImp3OK  = true;
                //DOCV_PorcImp3MSGERROR  = "";
                //if( DOCV_PorcImp3 == null)
                //{
                //    _isCorrect = false;
                //    DOCV_PorcImp3OK  = false;
                //    DOCV_PorcImp3MSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DOCV_PorcImp3", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DOCV_PorcImp3" + Environment.NewLine;
                //}
                //DOCV_PorcImp4OK  = true;
                //DOCV_PorcImp4MSGERROR  = "";
                //if( DOCV_PorcImp4 == null)
                //{
                //    _isCorrect = false;
                //    DOCV_PorcImp4OK  = false;
                //    DOCV_PorcImp4MSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "DOCV_PorcImp4", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo DOCV_PorcImp4" + Environment.NewLine;
                //}
                //DOCV_SerieOK  = true;
                //DOCV_SerieMSGERROR  = "";
                //if( String.IsNullOrEmpty(DOCV_Serie) )
                //{
                //    _isCorrect = false;
                //    DOCV_SerieOK  = false;
                //    DOCV_SerieMSGERROR  = String.Format("Debe ingresar la {0} del {1}.", "Serie", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo Serie" + Environment.NewLine;
                //}
                //TIPO_TabFPGOK  = true;
                //TIPO_TabFPGMSGERROR  = "";
                //if( String.IsNullOrEmpty(TIPO_TabFPG) )
                //{
                //    _isCorrect = false;
                //    TIPO_TabFPGOK  = false;
                //    TIPO_TabFPGMSGERROR  = String.Format("Debe seleccionar la {0} del {1}.", "Forma de Pago", "Documento de Venta");
                //    m_mensajeError += "* Debe seleccionar el campo Forma de Pago" + Environment.NewLine;
                //}
				TIPO_CodFPGOK  = true;
				TIPO_CodFPGMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_CodFPG) )
				{
					_isCorrect = false;
					TIPO_CodFPGOK  = false;
                    TIPO_CodFPGMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Forma de Pago", "Documento de Venta");
                    m_mensajeError += "* Debe seleccionar el campo Forma de Pago" + Environment.NewLine;
				}
                //TIPO_TabTDOOK  = true;
                //TIPO_TabTDOMSGERROR  = "";
                //if( String.IsNullOrEmpty(TIPO_TabTDO) )
                //{
                //    _isCorrect = false;
                //    TIPO_TabTDOOK  = false;
                //    TIPO_TabTDOMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tipo Documento", "Documento de Venta");
                //    m_mensajeError += "* Debe seleccionar el campo Tipo Documento" + Environment.NewLine;
                //}
                //TIPO_CodTDOOK  = true;
				TIPO_CodTDOMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_CodTDO) )
				{
					_isCorrect = false;
					TIPO_CodTDOOK  = false;
                    TIPO_CodTDOMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tipo Documento", "Documento de Venta");
                    m_mensajeError += "* Debe seleccionar el campo Tipo Documento" + Environment.NewLine;
				}
                //TIPO_TabMNDOK  = true;
                //TIPO_TabMNDMSGERROR  = "";
                //if( String.IsNullOrEmpty(TIPO_TabMND) )
                //{
                //    _isCorrect = false;
                //    TIPO_TabMNDOK  = false;
                //    TIPO_TabMNDMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "TIPO_TabMND", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo TIPO_TabMND" + Environment.NewLine;
                //}
                //TIPO_CodMNDOK  = true;
				TIPO_CodMNDMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_CodMND) )
				{
					_isCorrect = false;
					TIPO_CodMNDOK  = false;
                    TIPO_CodMNDMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tipo Moneda", "Documento de Venta");
                    m_mensajeError += "* Debe seleccionar el campo Tipo Moneda" + Environment.NewLine;
				}
                //CONS_CodANUOK  = true;
                //CONS_CodANUMSGERROR  = "";
                //if( String.IsNullOrEmpty(CONS_CodANU) )
                //{
                //    _isCorrect = false;
                //    CONS_CodANUOK  = false;
                //    CONS_CodANUMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "CONS_CodANU", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo CONS_CodANU" + Environment.NewLine;
                //}
                //CONS_TabANUOK  = true;
                //CONS_TabANUMSGERROR  = "";
                //if( String.IsNullOrEmpty(CONS_TabANU) )
                //{
                //    _isCorrect = false;
                //    CONS_TabANUOK  = false;
                //    CONS_TabANUMSGERROR  = String.Format("Debe ingresar el {0} del {1}.", "CONS_TabANU", "Documento de Venta");
                //    m_mensajeError += "* Debe ingresar el campo CONS_TabANU" + Environment.NewLine;
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
