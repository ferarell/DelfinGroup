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
	public partial class Planillas
	{
		#region [ Variables Validación ]
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_plan_tipoOK;
		private String m_plan_tipoMSGERROR;
		private Boolean m_plan_codigoOK;
		private String m_plan_codigoMSGERROR;
		private Boolean m_plan_fechaemisionOK;
		private String m_plan_fechemisionMSGERROR;
		private Boolean m_plan_conceptoOK;
		private String m_plan_conceptoMSGERROR;
		private Boolean m_cons_tabestOK;
		private String m_cons_tabestMSGERROR;
		private Boolean m_cons_codestOK;
		private String m_cons_codestMSGERROR;
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
		/// Gets or sets el valor de validación de: PLAN_Tipo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean PLAN_TipoOK
		{
			get { return m_plan_tipoOK; }
			set
			{
				if (m_plan_tipoOK != value)
				{ m_plan_tipoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PLAN_Tipo.
		/// </summary>
		[IgnoreDataMember]
		public String PLAN_TipoMSGERROR
		{
			get { return m_plan_tipoMSGERROR; }
			set
			{
				if (m_plan_tipoMSGERROR != value)
				{m_plan_tipoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PLAN_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean PLAN_CodigoOK
		{
			get { return m_plan_codigoOK; }
			set
			{
				if (m_plan_codigoOK != value)
				{ m_plan_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PLAN_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String PLAN_CodigoMSGERROR
		{
			get { return m_plan_codigoMSGERROR; }
			set
			{
				if (m_plan_codigoMSGERROR != value)
				{m_plan_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PLAN_FechEmision.
		/// </summary>
		[IgnoreDataMember]
		public Boolean PLAN_FechaEmisionOK
		{
			get { return m_plan_fechaemisionOK; }
			set
			{
				if (m_plan_fechaemisionOK != value)
				{ m_plan_fechaemisionOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PLAN_FechEmision.
		/// </summary>
		[IgnoreDataMember]
		public String PLAN_FechEmisionMSGERROR
		{
			get { return m_plan_fechemisionMSGERROR; }
			set
			{
				if (m_plan_fechemisionMSGERROR != value)
				{m_plan_fechemisionMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PLAN_Concepto.
		/// </summary>
		[IgnoreDataMember]
		public Boolean PLAN_ConceptoOK
		{
			get { return m_plan_conceptoOK; }
			set
			{
				if (m_plan_conceptoOK != value)
				{ m_plan_conceptoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PLAN_Concepto.
		/// </summary>
		[IgnoreDataMember]
		public String PLAN_ConceptoMSGERROR
		{
			get { return m_plan_conceptoMSGERROR; }
			set
			{
				if (m_plan_conceptoMSGERROR != value)
				{m_plan_conceptoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_TabEST.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CONS_TabESTOK
		{
			get { return m_cons_tabestOK; }
			set
			{
				if (m_cons_tabestOK != value)
				{ m_cons_tabestOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TabEST.
		/// </summary>
		[IgnoreDataMember]
		public String CONS_TabESTMSGERROR
		{
			get { return m_cons_tabestMSGERROR; }
			set
			{
				if (m_cons_tabestMSGERROR != value)
				{m_cons_tabestMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodEST.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CONS_CodESTOK
		{
			get { return m_cons_codestOK; }
			set
			{
				if (m_cons_codestOK != value)
				{ m_cons_codestOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodEST.
		/// </summary>
		[IgnoreDataMember]
		public String CONS_CodESTMSGERROR
		{
			get { return m_cons_codestMSGERROR; }
			set
			{
				if (m_cons_codestMSGERROR != value)
				{m_cons_codestMSGERROR = value; }
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
            //if( EMPR_Codigo == null)
            //{
            //   _isCorrect = false;
            //   EMPR_CodigoOK  = false;
            //   EMPR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_Codigo", "Planillas");
            //   m_mensajeError += "* Debe ingresar el campo EMPR_Codigo" + Environment.NewLine;
            //}
				PLAN_TipoOK  = true;
				PLAN_TipoMSGERROR  = "";
				if( String.IsNullOrEmpty(PLAN_Tipo) )
				{
					_isCorrect = false;
					PLAN_TipoOK  = false;
					PLAN_TipoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Tipo de Planilla", "Planillas");
               m_mensajeError += "* Debe ingresar el campo Tipo de Planilla" + Environment.NewLine;
				}
				PLAN_CodigoOK  = true;
				PLAN_CodigoMSGERROR  = "";
            //if( String.IsNullOrEmpty(PLAN_Codigo) )
            //{
            //   _isCorrect = false;
            //   PLAN_CodigoOK  = false;
            //   PLAN_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PLAN_Codigo", "Planillas");
            //   m_mensajeError += "* Debe ingresar el campo PLAN_Codigo" + Environment.NewLine;
            //}
				PLAN_FechaEmisionOK  = true;
				PLAN_FechEmisionMSGERROR  = "";
				if( PLAN_FechaEmision == null)
				{
					_isCorrect = false;
					PLAN_FechaEmisionOK  = false;
					PLAN_FechEmisionMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Fecha de Emisión", "Planillas");
               m_mensajeError += "* Debe ingresar el campo Fecha de Emisión" + Environment.NewLine;
				}
				PLAN_ConceptoOK  = true;
				PLAN_ConceptoMSGERROR  = "";
				if( String.IsNullOrEmpty(PLAN_Concepto) )
				{
					_isCorrect = false;
					PLAN_ConceptoOK  = false;
					PLAN_ConceptoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Concepto", "Planillas");
               m_mensajeError += "* Debe ingresar el campo Concepto" + Environment.NewLine;
				}
				CONS_TabESTOK  = true;
				CONS_TabESTMSGERROR  = "";
            //if( String.IsNullOrEmpty(CONS_TabEST) )
            //{
            //   _isCorrect = false;
            //   CONS_TabESTOK  = false;
            //   CONS_TabESTMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CONS_TabEST", "Planillas");
            //   m_mensajeError += "* Debe ingresar el campo CONS_TabEST" + Environment.NewLine;
            //}
                CONS_TabESTOK = true;
                CONS_TabESTMSGERROR = "";
                if (String.IsNullOrEmpty(Banco))
                {
                    _isCorrect = false;
                    CONS_TabESTOK = false;
                    CONS_TabESTMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "campo Cuenta Bancaria", "Planilla");
                    m_mensajeError += "* Debe ingresar el campo Cuenta Bancaria" + Environment.NewLine;
                }
                CONS_CodESTOK = true;
				CONS_CodESTMSGERROR  = "";
				if( String.IsNullOrEmpty(CONS_CodEST) )
				{
					_isCorrect = false;
					CONS_CodESTOK  = false;
					CONS_CodESTMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Estado de Planilla", "Planillas");
               m_mensajeError += "* Debe ingresar el campo Estado de Planilla" + Environment.NewLine;
				}

            if (ListDetCtaCte != null)
            {
                if (ListDetCtaCte.Count == 00)
                {
                    _isCorrect = false;
                    m_mensajeError += "* Debe buscar y seleccionar registros para completar la planilla" + Environment.NewLine;
                }
               foreach (Entities.DetCtaCte iDetCta in ListDetCtaCte)
               {
                  if (!iDetCta.ENCB_NroCuenta_Bool && !iDetCta.ENTC_Interbancario_Bool)
                  {
                     _isCorrect = false;
                     m_mensajeError += String.Format("* El registro: {1} [{2}/{3}-{4}] no tiene Cuenta Registrada.{0}", Environment.NewLine, iDetCta.CCCT_Codigo, iDetCta.TIPO_TDO, iDetCta.CCCT_Serie, iDetCta.CCCT_Numero);
                  }
               }
            }
            else
            {
               _isCorrect = false;
               m_mensajeError += "* Debe buscar y seleccionar registros para completar la planilla" + Environment.NewLine;
            }
            
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
