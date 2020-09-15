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
	public partial class Tarifa
	{
		#region [ Variables Validación ]
		private Boolean m_tari_codigoOK;
		private String m_tari_codigoMSGERROR;
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_tari_costoOK;
		private String m_tari_costoMSGERROR;
		private Boolean m_tari_profit1OK;
		private String m_tari_profit1MSGERROR;
      private Boolean m_tari_profit2OK;
      private String m_tari_profit2MSGERROR;
      private Boolean m_tari_profit3OK;
      private String m_tari_profit3MSGERROR;
      private Boolean m_tari_profit4OK;
      private String m_tari_profit4MSGERROR;
		private Boolean m_tari_pventa1OK;
		private String m_tari_pventa1MSGERROR;
		private Boolean m_tari_pventa2OK;
		private String m_tari_pventa2MSGERROR;
		private Boolean m_tari_pventa3OK;
		private String m_tari_pventa3MSGERROR;
		private Boolean m_tari_pventa4OK;
		private String m_tari_pventa4MSGERROR;
		private Boolean m_tari_pesoOK;
		private String m_tari_pesoMSGERROR;
		private Boolean m_tari_volumOK;
		private String m_tari_volumMSGERROR;
		private Boolean m_tipo_tabmndOK;
		private String m_tipo_tabmndMSGERROR;
		private Boolean m_tipo_codmndOK;
		private String m_tipo_codmndMSGERROR;
		private Boolean m_cont_codigoOK;
		private String m_cont_codigoMSGERROR;
		private Boolean m_cons_tabbasOK;
		private String m_cons_tabbasMSGERROR;
		private Boolean m_cons_codbasOK;
		private String m_cons_codbasMSGERROR;
		private Boolean m_puer_codorigenOK;
		private String m_puer_codorigenMSGERROR;
		private Boolean m_puer_coddestinoOK;
		private String m_puer_coddestinoMSGERROR;
		private Boolean m_pack_codigoOK;
		private String m_pack_codigoMSGERROR;

		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: TARI_Codigo.
		/// </summary>
		[DataMember]
		public Boolean TARI_CodigoOK
		{
			get { return m_tari_codigoOK; }
			set
			{
				if (m_tari_codigoOK != value)
				{
					m_tari_codigoOK = value;
					OnPropertyChanged("TARI_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TARI_Codigo.
		/// </summary>
		[DataMember]
		public String TARI_CodigoMSGERROR
		{
			get { return m_tari_codigoMSGERROR; }
			set
			{
				if (m_tari_codigoMSGERROR != value)
				{
					m_tari_codigoMSGERROR = value;
					OnPropertyChanged("TARI_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: EMPR_Codigo.
		/// </summary>
		[DataMember]
		public Boolean EMPR_CodigoOK
		{
			get { return m_empr_codigoOK; }
			set
			{
				if (m_empr_codigoOK != value)
				{
					m_empr_codigoOK = value;
					OnPropertyChanged("EMPR_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EMPR_Codigo.
		/// </summary>
		[DataMember]
		public String EMPR_CodigoMSGERROR
		{
			get { return m_empr_codigoMSGERROR; }
			set
			{
				if (m_empr_codigoMSGERROR != value)
				{
					m_empr_codigoMSGERROR = value;
					OnPropertyChanged("EMPR_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TARI_Costo.
		/// </summary>
		[DataMember]
		public Boolean TARI_CostoOK
		{
			get { return m_tari_costoOK; }
			set
			{
				if (m_tari_costoOK != value)
				{
					m_tari_costoOK = value;
					OnPropertyChanged("TARI_CostoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TARI_Costo.
		/// </summary>
		[DataMember]
		public String TARI_CostoMSGERROR
		{
			get { return m_tari_costoMSGERROR; }
			set
			{
				if (m_tari_costoMSGERROR != value)
				{
					m_tari_costoMSGERROR = value;
					OnPropertyChanged("TARI_CostoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TARI_Profit1.
		/// </summary>
		[DataMember]
		public Boolean TARI_Profit1OK
		{
			get { return m_tari_profit1OK; }
			set
			{
				if (m_tari_profit1OK != value)
				{
					m_tari_profit1OK = value;
					OnPropertyChanged("TARI_Profit1OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TARI_Profit1.
		/// </summary>
		[DataMember]
		public String TARI_Profit1MSGERROR
		{
			get { return m_tari_profit1MSGERROR; }
			set
			{
				if (m_tari_profit1MSGERROR != value)
				{
					m_tari_profit1MSGERROR = value;
					OnPropertyChanged("TARI_Profit1MSGERROR");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de validación de: TARI_Profit2.
      /// </summary>
      [DataMember]
      public Boolean TARI_Profit2OK
      {
         get { return m_tari_profit2OK; }
         set
         {
            if (m_tari_profit2OK != value)
            {
               m_tari_profit2OK = value;
               OnPropertyChanged("TARI_Profit2OK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TARI_Profit2.
      /// </summary>
      [DataMember]
      public String TARI_Profit2MSGERROR
      {
         get { return m_tari_profit2MSGERROR; }
         set
         {
            if (m_tari_profit2MSGERROR != value)
            {
               m_tari_profit2MSGERROR = value;
               OnPropertyChanged("TARI_Profit2MSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TARI_Profit3.
      /// </summary>
      [DataMember]
      public Boolean TARI_Profit3OK
      {
         get { return m_tari_profit3OK; }
         set
         {
            if (m_tari_profit3OK != value)
            {
               m_tari_profit3OK = value;
               OnPropertyChanged("TARI_Profit3OK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TARI_Profit3.
      /// </summary>
      [DataMember]
      public String TARI_Profit3MSGERROR
      {
         get { return m_tari_profit3MSGERROR; }
         set
         {
            if (m_tari_profit3MSGERROR != value)
            {
               m_tari_profit3MSGERROR = value;
               OnPropertyChanged("TARI_Profit3MSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TARI_Profit4.
      /// </summary>
      [DataMember]
      public Boolean TARI_Profit4OK
      {
         get { return m_tari_profit4OK; }
         set
         {
            if (m_tari_profit4OK != value)
            {
               m_tari_profit4OK = value;
               OnPropertyChanged("TARI_Profit4OK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TARI_Profit4.
      /// </summary>
      [DataMember]
      public String TARI_Profit4MSGERROR
      {
         get { return m_tari_profit4MSGERROR; }
         set
         {
            if (m_tari_profit4MSGERROR != value)
            {
               m_tari_profit4MSGERROR = value;
               OnPropertyChanged("TARI_Profit4MSGERROR");
            }
         }
      }
		/// <summary>
		/// Gets or sets el valor de validación de: TARI_PVenta1.
		/// </summary>
		[DataMember]
		public Boolean TARI_PVenta1OK
		{
			get { return m_tari_pventa1OK; }
			set
			{
				if (m_tari_pventa1OK != value)
				{
					m_tari_pventa1OK = value;
					OnPropertyChanged("TARI_PVenta1OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TARI_PVenta1.
		/// </summary>
		[DataMember]
		public String TARI_PVenta1MSGERROR
		{
			get { return m_tari_pventa1MSGERROR; }
			set
			{
				if (m_tari_pventa1MSGERROR != value)
				{
					m_tari_pventa1MSGERROR = value;
					OnPropertyChanged("TARI_PVenta1MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TARI_PVenta2.
		/// </summary>
		[DataMember]
		public Boolean TARI_PVenta2OK
		{
			get { return m_tari_pventa2OK; }
			set
			{
				if (m_tari_pventa2OK != value)
				{
					m_tari_pventa2OK = value;
					OnPropertyChanged("TARI_PVenta2OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TARI_PVenta2.
		/// </summary>
		[DataMember]
		public String TARI_PVenta2MSGERROR
		{
			get { return m_tari_pventa2MSGERROR; }
			set
			{
				if (m_tari_pventa2MSGERROR != value)
				{
					m_tari_pventa2MSGERROR = value;
					OnPropertyChanged("TARI_PVenta2MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TARI_PVenta3.
		/// </summary>
		[DataMember]
		public Boolean TARI_PVenta3OK
		{
			get { return m_tari_pventa3OK; }
			set
			{
				if (m_tari_pventa3OK != value)
				{
					m_tari_pventa3OK = value;
					OnPropertyChanged("TARI_PVenta3OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TARI_PVenta3.
		/// </summary>
		[DataMember]
		public String TARI_PVenta3MSGERROR
		{
			get { return m_tari_pventa3MSGERROR; }
			set
			{
				if (m_tari_pventa3MSGERROR != value)
				{
					m_tari_pventa3MSGERROR = value;
					OnPropertyChanged("TARI_PVenta3MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TARI_PVenta4.
		/// </summary>
		[DataMember]
		public Boolean TARI_PVenta4OK
		{
			get { return m_tari_pventa4OK; }
			set
			{
				if (m_tari_pventa4OK != value)
				{
					m_tari_pventa4OK = value;
					OnPropertyChanged("TARI_PVenta4OK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TARI_PVenta4.
		/// </summary>
		[DataMember]
		public String TARI_PVenta4MSGERROR
		{
			get { return m_tari_pventa4MSGERROR; }
			set
			{
				if (m_tari_pventa4MSGERROR != value)
				{
					m_tari_pventa4MSGERROR = value;
					OnPropertyChanged("TARI_PVenta4MSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TARI_Peso.
		/// </summary>
		[DataMember]
		public Boolean TARI_PesoOK
		{
			get { return m_tari_pesoOK; }
			set
			{
				if (m_tari_pesoOK != value)
				{
					m_tari_pesoOK = value;
					OnPropertyChanged("TARI_PesoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TARI_Peso.
		/// </summary>
		[DataMember]
		public String TARI_PesoMSGERROR
		{
			get { return m_tari_pesoMSGERROR; }
			set
			{
				if (m_tari_pesoMSGERROR != value)
				{
					m_tari_pesoMSGERROR = value;
					OnPropertyChanged("TARI_PesoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TARI_Volum.
		/// </summary>
		[DataMember]
		public Boolean TARI_VolumOK
		{
			get { return m_tari_volumOK; }
			set
			{
				if (m_tari_volumOK != value)
				{
					m_tari_volumOK = value;
					OnPropertyChanged("TARI_VolumOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TARI_Volum.
		/// </summary>
		[DataMember]
		public String TARI_VolumMSGERROR
		{
			get { return m_tari_volumMSGERROR; }
			set
			{
				if (m_tari_volumMSGERROR != value)
				{
					m_tari_volumMSGERROR = value;
					OnPropertyChanged("TARI_VolumMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabMnd.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabMndOK
		{
			get { return m_tipo_tabmndOK; }
			set
			{
				if (m_tipo_tabmndOK != value)
				{
					m_tipo_tabmndOK = value;
					OnPropertyChanged("TIPO_TabMndOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabMnd.
		/// </summary>
		[DataMember]
		public String TIPO_TabMndMSGERROR
		{
			get { return m_tipo_tabmndMSGERROR; }
			set
			{
				if (m_tipo_tabmndMSGERROR != value)
				{
					m_tipo_tabmndMSGERROR = value;
					OnPropertyChanged("TIPO_TabMndMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodMnd.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodMndOK
		{
			get { return m_tipo_codmndOK; }
			set
			{
				if (m_tipo_codmndOK != value)
				{
					m_tipo_codmndOK = value;
					OnPropertyChanged("TIPO_CodMndOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodMnd.
		/// </summary>
		[DataMember]
		public String TIPO_CodMndMSGERROR
		{
			get { return m_tipo_codmndMSGERROR; }
			set
			{
				if (m_tipo_codmndMSGERROR != value)
				{
					m_tipo_codmndMSGERROR = value;
					OnPropertyChanged("TIPO_CodMndMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONT_Codigo.
		/// </summary>
		[DataMember]
		public Boolean CONT_CodigoOK
		{
			get { return m_cont_codigoOK; }
			set
			{
				if (m_cont_codigoOK != value)
				{
					m_cont_codigoOK = value;
					OnPropertyChanged("CONT_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONT_Codigo.
		/// </summary>
		[DataMember]
		public String CONT_CodigoMSGERROR
		{
			get { return m_cont_codigoMSGERROR; }
			set
			{
				if (m_cont_codigoMSGERROR != value)
				{
					m_cont_codigoMSGERROR = value;
					OnPropertyChanged("CONT_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_TabBas.
		/// </summary>
		[DataMember]
		public Boolean CONS_TabBasOK
		{
			get { return m_cons_tabbasOK; }
			set
			{
				if (m_cons_tabbasOK != value)
				{
					m_cons_tabbasOK = value;
					OnPropertyChanged("CONS_TabBasOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TabBas.
		/// </summary>
		[DataMember]
		public String CONS_TabBasMSGERROR
		{
			get { return m_cons_tabbasMSGERROR; }
			set
			{
				if (m_cons_tabbasMSGERROR != value)
				{
					m_cons_tabbasMSGERROR = value;
					OnPropertyChanged("CONS_TabBasMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodBas.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodBasOK
		{
			get { return m_cons_codbasOK; }
			set
			{
				if (m_cons_codbasOK != value)
				{
					m_cons_codbasOK = value;
					OnPropertyChanged("CONS_CodBasOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodBas.
		/// </summary>
		[DataMember]
		public String CONS_CodBasMSGERROR
		{
			get { return m_cons_codbasMSGERROR; }
			set
			{
				if (m_cons_codbasMSGERROR != value)
				{
					m_cons_codbasMSGERROR = value;
					OnPropertyChanged("CONS_CodBasMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PUER_CodOrigen.
		/// </summary>
		[DataMember]
		public Boolean PUER_CodOrigenOK
		{
			get { return m_puer_codorigenOK; }
			set
			{
				if (m_puer_codorigenOK != value)
				{
					m_puer_codorigenOK = value;
					OnPropertyChanged("PUER_CodOrigenOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PUER_CodOrigen.
		/// </summary>
		[DataMember]
		public String PUER_CodOrigenMSGERROR
		{
			get { return m_puer_codorigenMSGERROR; }
			set
			{
				if (m_puer_codorigenMSGERROR != value)
				{
					m_puer_codorigenMSGERROR = value;
					OnPropertyChanged("PUER_CodOrigenMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PUER_CodDestino.
		/// </summary>
		[DataMember]
		public Boolean PUER_CodDestinoOK
		{
			get { return m_puer_coddestinoOK; }
			set
			{
				if (m_puer_coddestinoOK != value)
				{
					m_puer_coddestinoOK = value;
					OnPropertyChanged("PUER_CodDestinoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PUER_CodDestino.
		/// </summary>
		[DataMember]
		public String PUER_CodDestinoMSGERROR
		{
			get { return m_puer_coddestinoMSGERROR; }
			set
			{
				if (m_puer_coddestinoMSGERROR != value)
				{
					m_puer_coddestinoMSGERROR = value;
					OnPropertyChanged("PUER_CodDestinoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PACK_Codigo.
		/// </summary>
		[DataMember]
		public Boolean PACK_CodigoOK
		{
			get { return m_pack_codigoOK; }
			set
			{
				if (m_pack_codigoOK != value)
				{
					m_pack_codigoOK = value;
					OnPropertyChanged("PACK_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PACK_Codigo.
		/// </summary>
		[DataMember]
		public String PACK_CodigoMSGERROR
		{
			get { return m_pack_codigoMSGERROR; }
			set
			{
				if (m_pack_codigoMSGERROR != value)
				{
					m_pack_codigoMSGERROR = value;
					OnPropertyChanged("PACK_CodigoMSGERROR");
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
				TARI_CodigoOK  = true;
				TARI_CodigoMSGERROR  = "";
				if( TARI_Codigo == null)
				{
					_isCorrect = false;
					TARI_CodigoOK  = false;
					TARI_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TARI_Codigo", "Tarifa");
					m_mensajeError += "* Debe ingresar el campo TARI_Codigo" + Environment.NewLine;
				}
				PACK_CodigoOK  = true;
				PACK_CodigoMSGERROR  = "";
				if( PACK_Codigo == null)
				{
					_isCorrect = false;
					PACK_CodigoOK  = false;
					PACK_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PACK_Codigo", "Tarifa");
					m_mensajeError += "* Debe ingresar el campo PACK_Codigo" + Environment.NewLine;
				}
				OnPropertyChanged("MensajeError");
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
      public Boolean ValidarProfit()
      {
         try
         {
            Boolean _isCorrect = true;
            m_mensajeError = "";
            
            TARI_Profit1OK = true;
            TARI_Profit1MSGERROR = "";
            if (!TARI_Profit1.HasValue || TARI_Profit1.Value <= (Decimal)0.00)
            {
               _isCorrect = false;
               TARI_Profit1OK = false;
               TARI_Profit1MSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Profit 1", "Tarifa");
               m_mensajeError += "* Debe ingresar el campo Profit 1" + Environment.NewLine;
            }
            else
            {
               TARI_Profit2OK = true;
               TARI_Profit2MSGERROR = "";
               if (TARI_Profit2.HasValue && TARI_Profit2.Value > (Decimal)0.0 && TARI_Profit1.Value > (Decimal)0.0 && TARI_Profit1.Value <= TARI_Profit2.Value)
               {
                  _isCorrect = false;
                  TARI_Profit2OK = false;
                  TARI_Profit2MSGERROR = String.Format("El valor del campo {0} no debe ser mayor al campo {1}.", "Profit 2", "Profit 1");
                  m_mensajeError += "* El campo Profit 2 no debe ser mayor a Profit 1" + Environment.NewLine;
               }

               TARI_Profit3OK = true;
               TARI_Profit3MSGERROR = "";
               if (TARI_Profit3.HasValue && TARI_Profit3.Value > (Decimal)0.0 && TARI_Profit1.Value > (Decimal)0.0 && TARI_Profit1.Value <= TARI_Profit3.Value)
               {
                  _isCorrect = false;
                  TARI_Profit3OK = false;
                  TARI_Profit3MSGERROR = String.Format("El valor del campo {0} no debe ser mayor al campo {1}.", "Profit 3", "Profit 1");
                  m_mensajeError += "* El campo Profit 3 no debe ser mayor a Profit 1" + Environment.NewLine;
               }
               TARI_Profit3OK = true;
               TARI_Profit3MSGERROR = "";
               if (TARI_Profit3.HasValue && TARI_Profit3.Value > (Decimal)0.0 && TARI_Profit2.Value > (Decimal)0.0 && TARI_Profit2.Value <= TARI_Profit3.Value)
               {
                  _isCorrect = false;
                  TARI_Profit3OK = false;
                  TARI_Profit3MSGERROR = String.Format("El valor del campo {0} no debe ser mayor al campo {1}.", "Profit 3", "Profit 2");
                  m_mensajeError += "* El campo Profit 3 no debe ser mayor a Profit 2" + Environment.NewLine;
               }
               
               TARI_Profit4OK = true;
               TARI_Profit4MSGERROR = "";
               if (TARI_Profit4.HasValue && TARI_Profit4.Value > (Decimal)0.0 && TARI_Profit1.Value > (Decimal)0.0 && TARI_Profit1.Value <= TARI_Profit4.Value)
               {
                  _isCorrect = false;
                  TARI_Profit4OK = false;
                  TARI_Profit4MSGERROR = String.Format("El valor del campo {0} no debe ser mayor al campo {1}.", "Profit 4", "Profit 1");
                  m_mensajeError += "* El campo Profit 4 no debe ser mayor a Profit 1" + Environment.NewLine;
               }
               TARI_Profit4OK = true;
               TARI_Profit4MSGERROR = "";
               if (TARI_Profit4.HasValue && TARI_Profit4.Value > (Decimal)0.0 && TARI_Profit2.Value > (Decimal)0.0 && TARI_Profit2.Value <= TARI_Profit4.Value)
               {
                  _isCorrect = false;
                  TARI_Profit4OK = false;
                  TARI_Profit4MSGERROR = String.Format("El valor del campo {0} no debe ser mayor al campo {1}.", "Profit 4", "Profit 2");
                  m_mensajeError += "* El campo Profit 4 no debe ser mayor a Profit 2" + Environment.NewLine;
               }
               TARI_Profit4OK = true;
               TARI_Profit4MSGERROR = "";
               if (TARI_Profit4.HasValue && TARI_Profit4.Value > (Decimal)0.0 && TARI_Profit3.Value > (Decimal)0.0 && TARI_Profit3.Value <= TARI_Profit4.Value)
               {
                  _isCorrect = false;
                  TARI_Profit4OK = false;
                  TARI_Profit4MSGERROR = String.Format("El valor del campo {0} no debe ser mayor al campo {1}.", "Profit 4", "Profit 3");
                  m_mensajeError += "* El campo Profit 4 no debe ser mayor a Profit 3" + Environment.NewLine;
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
