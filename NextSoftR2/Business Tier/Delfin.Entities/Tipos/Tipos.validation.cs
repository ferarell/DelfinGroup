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
	public partial class Tipos
	{
		#region [ Variables Validación ]
		private Boolean m_tipo_codtablaOK;
		private String m_tipo_codtablaMSGERROR;
        private Boolean m_tipo_codtablahijoOK;
        private String m_tipo_codtablahijoMSGERROR;
		private Boolean m_tipo_codtipoOK;
		private String m_tipo_codtipoMSGERROR;
        private Boolean m_tipo_codtipohijoOK;
        private String m_tipo_codtipohijoMSGERROR;
		private Boolean m_tipo_desc1OK;
		private String m_tipo_desc1MSGERROR;
		private Boolean m_tipo_desc2OK;
		private String m_tipo_desc2MSGERROR;
		private Boolean m_tipo_desccOK;
		private String m_tipo_desccMSGERROR;
		private Boolean m_tipo_num1OK;
		private String m_tipo_num1MSGERROR;
		private Boolean m_tipo_num2OK;
		private String m_tipo_num2MSGERROR;
		private Boolean m_tipo_num3OK;
		private String m_tipo_num3MSGERROR;
		private Boolean m_tipo_num4OK;
		private String m_tipo_num4MSGERROR;
		private Boolean m_tipo_activoOK;
		private String m_tipo_activoMSGERROR;
		private Boolean m_tipo_mascaraOK;
		private String m_tipo_mascaraMSGERROR;
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
		/// Gets or sets el valor de validación de: TIPO_CodTabla.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodTablaOK
		{
			get { return m_tipo_codtablaOK; }
			set
			{
				if (m_tipo_codtablaOK != value)
				{
					m_tipo_codtablaOK = value;
					OnPropertyChanged("TIPO_CodTablaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodTabla.
		/// </summary>
		[DataMember]
		public String TIPO_CodTablaMSGERROR
		{
			get { return m_tipo_codtablaMSGERROR; }
			set
			{
				if (m_tipo_codtablaMSGERROR != value)
				{
					m_tipo_codtablaMSGERROR = value;
					OnPropertyChanged("TIPO_CodTablaMSGERROR");
				}
			}
		}
        /// <summary>
        /// Gets or sets el valor de validación de: TIPO_CodTablaHijo.
        /// </summary>
        [DataMember]
        public Boolean TIPO_CodTablaHijoOK
        {
            get { return m_tipo_codtablahijoOK; }
            set
            {
                if (m_tipo_codtablahijoOK != value)
                {
                    m_tipo_codtablahijoOK = value;
                    OnPropertyChanged("TIPO_CodTablaHijoOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: TIPO_CodTablaHijo.
        /// </summary>
        [DataMember]
        public String TIPO_CodTablaHijoMSGERROR
        {
            get { return m_tipo_codtablahijoMSGERROR; }
            set
            {
                if (m_tipo_codtablahijoMSGERROR != value)
                {
                    m_tipo_codtablahijoMSGERROR = value;
                    OnPropertyChanged("TIPO_CodTablaHijoMSGERROR");
                }
            }
        }
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodTipo.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodTipoOK
		{
			get { return m_tipo_codtipoOK; }
			set
			{
				if (m_tipo_codtipoOK != value)
				{
					m_tipo_codtipoOK = value;
					OnPropertyChanged("TIPO_CodTipoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodTipo.
		/// </summary>
		[DataMember]
		public String TIPO_CodTipoMSGERROR
		{
			get { return m_tipo_codtipoMSGERROR; }
			set
			{
				if (m_tipo_codtipoMSGERROR != value)
				{
					m_tipo_codtipoMSGERROR = value;
					OnPropertyChanged("TIPO_CodTipoMSGERROR");
				}
			}
		}
        /// <summary>
        /// Gets or sets el valor de validación de: TIPO_CodTipoHijo.
        /// </summary>
        [DataMember]
        public Boolean TIPO_CodTipoHijoOK
        {
            get { return m_tipo_codtipohijoOK; }
            set
            {
                if (m_tipo_codtipohijoOK != value)
                {
                    m_tipo_codtipohijoOK = value;
                    OnPropertyChanged("TIPO_CodTipoHijoOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: TIPO_CodTipoHijo.
        /// </summary>
        [DataMember]
        public String TIPO_CodTipoHijoMSGERROR
        {
            get { return m_tipo_codtipohijoMSGERROR; }
            set
            {
                if (m_tipo_codtipohijoMSGERROR != value)
                {
                    m_tipo_codtipohijoMSGERROR = value;
                    OnPropertyChanged("TIPO_CodTipoHijoMSGERROR");
                }
            }
        }
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_Desc1.
		/// </summary>
		[DataMember]
		public Boolean TIPO_Desc1OK
		{
			get { return m_tipo_desc1OK; }
			set
			{
				if (m_tipo_desc1OK != value)
				{
					m_tipo_desc1OK = value;
					OnPropertyChanged("TIPO_Desc1OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_Desc1.
		/// </summary>
		[DataMember]
		public String TIPO_Desc1MSGERROR
		{
			get { return m_tipo_desc1MSGERROR; }
			set
			{
				if (m_tipo_desc1MSGERROR != value)
				{
					m_tipo_desc1MSGERROR = value;
					OnPropertyChanged("TIPO_Desc1MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_Desc2.
		/// </summary>
		[DataMember]
		public Boolean TIPO_Desc2OK
		{
			get { return m_tipo_desc2OK; }
			set
			{
				if (m_tipo_desc2OK != value)
				{
					m_tipo_desc2OK = value;
					OnPropertyChanged("TIPO_Desc2OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_Desc2.
		/// </summary>
		[DataMember]
		public String TIPO_Desc2MSGERROR
		{
			get { return m_tipo_desc2MSGERROR; }
			set
			{
				if (m_tipo_desc2MSGERROR != value)
				{
					m_tipo_desc2MSGERROR = value;
					OnPropertyChanged("TIPO_Desc2MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_DescC.
		/// </summary>
		[DataMember]
		public Boolean TIPO_DescCOK
		{
			get { return m_tipo_desccOK; }
			set
			{
				if (m_tipo_desccOK != value)
				{
					m_tipo_desccOK = value;
					OnPropertyChanged("TIPO_DescCOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_DescC.
		/// </summary>
		[DataMember]
		public String TIPO_DescCMSGERROR
		{
			get { return m_tipo_desccMSGERROR; }
			set
			{
				if (m_tipo_desccMSGERROR != value)
				{
					m_tipo_desccMSGERROR = value;
					OnPropertyChanged("TIPO_DescCMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_Num1.
		/// </summary>
		[DataMember]
		public Boolean TIPO_Num1OK
		{
			get { return m_tipo_num1OK; }
			set
			{
				if (m_tipo_num1OK != value)
				{
					m_tipo_num1OK = value;
					OnPropertyChanged("TIPO_Num1OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_Num1.
		/// </summary>
		[DataMember]
		public String TIPO_Num1MSGERROR
		{
			get { return m_tipo_num1MSGERROR; }
			set
			{
				if (m_tipo_num1MSGERROR != value)
				{
					m_tipo_num1MSGERROR = value;
					OnPropertyChanged("TIPO_Num1MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_Num2.
		/// </summary>
		[DataMember]
		public Boolean TIPO_Num2OK
		{
			get { return m_tipo_num2OK; }
			set
			{
				if (m_tipo_num2OK != value)
				{
					m_tipo_num2OK = value;
					OnPropertyChanged("TIPO_Num2OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_Num2.
		/// </summary>
		[DataMember]
		public String TIPO_Num2MSGERROR
		{
			get { return m_tipo_num2MSGERROR; }
			set
			{
				if (m_tipo_num2MSGERROR != value)
				{
					m_tipo_num2MSGERROR = value;
					OnPropertyChanged("TIPO_Num2MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_Num3.
		/// </summary>
		[DataMember]
		public Boolean TIPO_Num3OK
		{
			get { return m_tipo_num3OK; }
			set
			{
				if (m_tipo_num3OK != value)
				{
					m_tipo_num3OK = value;
					OnPropertyChanged("TIPO_Num3OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_Num3.
		/// </summary>
		[DataMember]
		public String TIPO_Num3MSGERROR
		{
			get { return m_tipo_num3MSGERROR; }
			set
			{
				if (m_tipo_num3MSGERROR != value)
				{
					m_tipo_num3MSGERROR = value;
					OnPropertyChanged("TIPO_Num3MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_Num4.
		/// </summary>
		[DataMember]
		public Boolean TIPO_Num4OK
		{
			get { return m_tipo_num4OK; }
			set
			{
				if (m_tipo_num4OK != value)
				{
					m_tipo_num4OK = value;
					OnPropertyChanged("TIPO_Num4OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_Num4.
		/// </summary>
		[DataMember]
		public String TIPO_Num4MSGERROR
		{
			get { return m_tipo_num4MSGERROR; }
			set
			{
				if (m_tipo_num4MSGERROR != value)
				{
					m_tipo_num4MSGERROR = value;
					OnPropertyChanged("TIPO_Num4MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_Activo.
		/// </summary>
		[DataMember]
		public Boolean TIPO_ActivoOK
		{
			get { return m_tipo_activoOK; }
			set
			{
				if (m_tipo_activoOK != value)
				{
					m_tipo_activoOK = value;
					OnPropertyChanged("TIPO_ActivoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_Activo.
		/// </summary>
		[DataMember]
		public String TIPO_ActivoMSGERROR
		{
			get { return m_tipo_activoMSGERROR; }
			set
			{
				if (m_tipo_activoMSGERROR != value)
				{
					m_tipo_activoMSGERROR = value;
					OnPropertyChanged("TIPO_ActivoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_Mascara.
		/// </summary>
		[DataMember]
		public Boolean TIPO_MascaraOK
		{
			get { return m_tipo_mascaraOK; }
			set
			{
				if (m_tipo_mascaraOK != value)
				{
					m_tipo_mascaraOK = value;
					OnPropertyChanged("TIPO_MascaraOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_Mascara.
		/// </summary>
		[DataMember]
		public String TIPO_MascaraMSGERROR
		{
			get { return m_tipo_mascaraMSGERROR; }
			set
			{
				if (m_tipo_mascaraMSGERROR != value)
				{
					m_tipo_mascaraMSGERROR = value;
					OnPropertyChanged("TIPO_MascaraMSGERROR");
				}
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
				TIPO_CodTablaOK  = true;
				TIPO_CodTablaMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_CodTabla) )
				{
					_isCorrect = false;
					TIPO_CodTablaOK  = false;
					TIPO_CodTablaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPO_CodTabla", "Tipos");
					m_mensajeError += "* Debe ingresar el campo TIPO_CodTabla" + Environment.NewLine;
				}
				TIPO_CodTipoOK  = true;
				TIPO_CodTipoMSGERROR  = "";
            if (String.IsNullOrEmpty(TIPO_CodTipo))
            {
               _isCorrect = false;
               TIPO_CodTipoOK = false;
               TIPO_CodTipoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Código", "Tipos");
               m_mensajeError += "* Debe ingresar el campo Código" + Environment.NewLine;
            }
				TIPO_Desc1OK  = true;
				TIPO_Desc1MSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_Desc1) )
				{
					_isCorrect = false;
					TIPO_Desc1OK  = false;
					TIPO_Desc1MSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPO_Desc1", "Tipos");
					m_mensajeError += "* Debe ingresar el campo TIPO_Desc1" + Environment.NewLine;
				}

                if (TIPO_CodTabla == "PAI")
                {
                    TIPO_CodTablaHijoOK = true;
                    TIPO_CodTablaHijoMSGERROR = "";
                    TIPO_CodTipoHijoOK = true;
                    TIPO_CodTipoHijoMSGERROR = "";
                    if (String.IsNullOrEmpty(TIPO_CodTablaHijo) || String.IsNullOrEmpty(TIPO_CodTipoHijo))
                    {
                        _isCorrect = false;
                        TIPO_CodTablaHijoOK = false;
                        TIPO_CodTipoHijoOK = false;
                        TIPO_CodTablaHijoMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tráfico", "País");
                        TIPO_CodTipoHijoMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tráfico", "País");
                        m_mensajeError += "* Debe seleccionar el Tráfico del Paía" + Environment.NewLine;
                    }
                }

				OnPropertyChanged("MensajeError");
				return _isCorrect;

			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
