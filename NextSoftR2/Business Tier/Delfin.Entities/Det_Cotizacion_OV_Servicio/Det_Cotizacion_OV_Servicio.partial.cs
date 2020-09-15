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
    public partial class Det_Cotizacion_OV_Servicio
    {
       private Boolean m_scot_editable = true;
       private Boolean m_scot_eliminable = true;


        /// <summary>
        /// Gets or sets el valor de: SERV_Tipo.
        /// </summary>
        [DataMember]
        public String SERV_Tipo { get; set; }
        /// <summary>
        /// Gets or sets el valor de: SERV_AfeIgv.
        /// </summary>
        [DataMember]
        public Boolean SERV_AfeIgv { get; set; }
        /// <summary>
        /// Gets or sets el valor de: SERV_AfeDet.
        /// </summary>
        [DataMember]
        public Boolean SERV_AfeDet { get; set; }
        /// <summary>
        /// Gets or sets el valor de: SERV_Nombre.
        /// </summary>
        [DataMember]
        public String SERV_Nombre { get; set; }
        /// <summary>
        /// Gets or sets el valor de: SERV_NombreCorto.
        /// </summary>
        [DataMember]
        public String SERV_NombreCorto { get; set; }
        /// <summary>
        /// Gets or sets el valor de: SCOT_Editable.
        /// </summary>
        [DataMember]
        public Boolean SCOT_Editable
        {
           get { return m_scot_editable; }
           set { m_scot_editable = value; }
        }
        /// <summary>
        /// Gets or sets el valor de: SCOT_Eliminable.
        /// </summary>
        [DataMember]
        public Boolean SCOT_Eliminable
        {
           get { return m_scot_eliminable; }
           set { m_scot_eliminable = value; }
        }
        /// <summary>
        /// Gets or sets el valor de: SCOT_EnviarFinanzas.
        /// </summary>
        [DataMember]
        public Boolean SCOT_EnviarFinanzas { get; set; }

        /// <summary>
        /// Gets or sets el valor de: TIPO_DescMnd.
        /// </summary>
        [DataMember]
        public String TIPO_DescMnd { get; set; }
        /// <summary>
        /// Gets or sets el valor de: TIPO_DescCMnd.
        /// </summary>
        [DataMember]
        public String TIPO_DescCMnd { get; set; }

        /// <summary>
        /// Gets or sets el valor de: ENTC_NomCom.
        /// </summary>
        [DataMember]
        public String ENTC_NomCom { get; set; }

        /// <summary>
        /// Gets or sets el valor de: TIPO_DescTDO.
        /// </summary>
        [DataMember]
        public String TIPO_DescTDO { get; set; }

        public void CalcularTotales()
        {
            try
            {
                if (SCOT_Cantidad.HasValue)
                {
                    if (CCOT_IngresoGasto == "I")
                    {
                        m_scot_importe_ingreso = SCOT_Cantidad.Value * SCOT_PrecioUni;
                        m_scot_importe_egreso = (Decimal)0.0;
                    }
                    else if (CCOT_IngresoGasto == "E")
                    {
                        m_scot_importe_ingreso = (Decimal)0.0;
                        m_scot_importe_egreso = SCOT_Cantidad.Value * SCOT_PrecioUni;
                    }
                    else
                    {
                        m_scot_importe_ingreso = (Decimal)0.0;
                        m_scot_importe_egreso = (Decimal)0.0;
                    }
                }
                else
                {
                    m_scot_importe_ingreso = (Decimal)0.0;
                    m_scot_importe_egreso = (Decimal)0.0;
                }
            }
            catch (Exception)
            { }
        }

        /// <summary>
        /// Gets or sets el valor de: SERV_CodigoStr.
        /// </summary>
        [DataMember]
        public String SERV_CodigoStr
        {
            get { return SERV_Codigo.ToString(); }
            set
            {
                Int32 _serv_codigo;
                if (!String.IsNullOrEmpty(value) && Int32.TryParse(value, out _serv_codigo))
                { m_serv_codigo = _serv_codigo; } // SERV_Codigo = 
                else
                { m_serv_codigo = -1; } // SERV_Codigo = 
            }
        }

        /// <summary>
        /// Gets or sets el valor de: CHAN_Cerrado.
        /// </summary>
        [DataMember]
        public Boolean CHAN_Cerrado { get; set; }
    }
}
