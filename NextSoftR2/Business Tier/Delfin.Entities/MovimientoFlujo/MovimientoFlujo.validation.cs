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
	public partial class MovimientoFlujo
	{
		#region [ Variables Validación ]
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_movi_codigoOK;
		private String m_movi_codigoMSGERROR;
		private Boolean m_mflu_itemOK;
		private String m_mflu_itemMSGERROR;
		private Boolean m_fluj_codigoOK;
		private String m_fluj_codigoMSGERROR;
		private Boolean m_mflu_flujoOK;
		private String m_mflu_flujoMSGERROR;
		private Boolean m_mflu_porcentajeOK;
		private String m_mflu_porcentajeMSGERROR;
		private Boolean m_mflu_montoOK;
		private String m_mflu_montoMSGERROR;
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
		/// Gets or sets el valor de validación de: MOVI_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean MOVI_CodigoOK
		{
			get { return m_movi_codigoOK; }
			set
			{
				if (m_movi_codigoOK != value)
				{ m_movi_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: MOVI_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String MOVI_CodigoMSGERROR
		{
			get { return m_movi_codigoMSGERROR; }
			set
			{
				if (m_movi_codigoMSGERROR != value)
				{m_movi_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: MFLU_Item.
		/// </summary>
		[IgnoreDataMember]
		public Boolean MFLU_ItemOK
		{
			get { return m_mflu_itemOK; }
			set
			{
				if (m_mflu_itemOK != value)
				{ m_mflu_itemOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: MFLU_Item.
		/// </summary>
		[IgnoreDataMember]
		public String MFLU_ItemMSGERROR
		{
			get { return m_mflu_itemMSGERROR; }
			set
			{
				if (m_mflu_itemMSGERROR != value)
				{m_mflu_itemMSGERROR = value; }
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
		/// Gets or sets el valor de validación de: MFLU_Flujo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean MFLU_FlujoOK
		{
			get { return m_mflu_flujoOK; }
			set
			{
				if (m_mflu_flujoOK != value)
				{ m_mflu_flujoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: MFLU_Flujo.
		/// </summary>
		[IgnoreDataMember]
		public String MFLU_FlujoMSGERROR
		{
			get { return m_mflu_flujoMSGERROR; }
			set
			{
				if (m_mflu_flujoMSGERROR != value)
				{m_mflu_flujoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: MFLU_Porcentaje.
		/// </summary>
		[IgnoreDataMember]
		public Boolean MFLU_PorcentajeOK
		{
			get { return m_mflu_porcentajeOK; }
			set
			{
				if (m_mflu_porcentajeOK != value)
				{ m_mflu_porcentajeOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: MFLU_Porcentaje.
		/// </summary>
		[IgnoreDataMember]
		public String MFLU_PorcentajeMSGERROR
		{
			get { return m_mflu_porcentajeMSGERROR; }
			set
			{
				if (m_mflu_porcentajeMSGERROR != value)
				{m_mflu_porcentajeMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: MFLU_Monto.
		/// </summary>
		[IgnoreDataMember]
		public Boolean MFLU_MontoOK
		{
			get { return m_mflu_montoOK; }
			set
			{
				if (m_mflu_montoOK != value)
				{ m_mflu_montoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: MFLU_Monto.
		/// </summary>
		[IgnoreDataMember]
		public String MFLU_MontoMSGERROR
		{
			get { return m_mflu_montoMSGERROR; }
			set
			{
				if (m_mflu_montoMSGERROR != value)
				{m_mflu_montoMSGERROR = value; }
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
                //EMPR_CodigoOK  = true;
                //EMPR_CodigoMSGERROR  = "";
                //if( EMPR_Codigo == null)
                //{
                //    _isCorrect = false;
                //    EMPR_CodigoOK  = false;
                //    EMPR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_Codigo", "MovimientoFlujo");
                //    m_mensajeError += "* Debe ingresar el campo EMPR_Codigo" + Environment.NewLine;
                //}
                FLUJ_CodigoOK = true;
                FLUJ_CodigoMSGERROR = "";
                if (String.IsNullOrEmpty(FLUJ_Codigo))
                {
                    _isCorrect = false;
                    FLUJ_CodigoOK = false;
                    FLUJ_CodigoMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Flujo", "Movimiento Flujo");
                    m_mensajeError += "* Debe seleccionar el campo Flujo" + Environment.NewLine;
                }
                MFLU_PorcentajeOK = true;
                MFLU_PorcentajeMSGERROR = "";
                if (MFLU_Porcentaje <= 0 || MFLU_Porcentaje==null)
                {
                    _isCorrect = false;
                    MFLU_PorcentajeOK = false;
                    MFLU_PorcentajeMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Porcentaje", "Movimiento Flujo");
                    m_mensajeError += "* Debe ingresar el campo Porcentaje" + Environment.NewLine;
                }
                MFLU_MontoOK = true;
                MFLU_MontoMSGERROR  = "";
                if (MFLU_Monto<=0 || MFLU_Monto==null)
                {
                    _isCorrect = false;
                    MFLU_MontoOK = false;
                    MFLU_MontoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Monto", "Movimiento Flujo");
                    m_mensajeError += "* Debe ingresar el campo Monto" + Environment.NewLine;
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
