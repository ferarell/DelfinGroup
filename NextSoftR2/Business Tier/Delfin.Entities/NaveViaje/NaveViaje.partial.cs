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
    public partial class NaveViaje
    {
        /// <summary>
        /// Gets or sets el valor de: NVIA_DesEstado.
        /// </summary>
        [DataMember]
        public String NVIA_DesEstado { get; set; }

        /// <summary>
        /// Gets or sets el valor de: NAVE_Nombre.
        /// </summary>
        [DataMember]
        public String NAVE_Nombre { get; set; }

        /// <summary>
        /// Gets or sets el valor de: CONS_DescVia.
        /// </summary>
        [DataMember]
        public String CONS_DescVia { get; set; }
        /// <summary>
        /// Gets or sets el valor de: ENTC_Transportista.
        /// </summary>
        [DataMember]
        public String ENTC_NomTransportista { get; set; }
        /// <summary>
        /// Gets or sets el valor de: ENTC_AgentePortuario.
        /// </summary>
        [DataMember]
        public String ENTC_NomAgentePort_EXPO { get; set; }
        /// <summary>
        /// Gets or sets el valor de: ENTC_Transportista.
        /// </summary>
        [DataMember]
        public String ENTC_NomTransp { get; set; }
        
        /// <summary>
        /// Gets or sets el valor de: ENTC_NomTermin.
        /// </summary>
        [DataMember]
        public String ENTC_NomTermin { get; set; }
        /// <summary>
        /// Gets or sets el valor de: CONS_DescRGM.
        /// </summary>
        [DataMember]
        public String CONS_DescRGM { get; set; }
        /// <summary>
        /// Gets or sets el valor de: CONS_DescRGM.
        /// </summary>
        [DataMember]
        public String CONS_DescVIA { get; set; }
        /// <summary>
        /// Gets or sets el valor de: TIPO_DescTRF.
        /// </summary>
        [DataMember]
        public String TIPO_DescTRF { get; set; }

        /// <summary>
        /// Gets or sets el valor de: PUER_Nombre.
        /// </summary>
        [DataMember]
        public String PUER_Nombre { get; set; }
        /// <summary>
        /// Gets or sets el valor de: TIPO_TabPAI.
        /// </summary>
        [DataMember]
        public String TIPO_TabPAI { get; set; }
        /// <summary>
        /// Gets or sets el valor de: TIPO_CodPAI.
        /// </summary>
        [DataMember]
        public String TIPO_CodPAI { get; set; }
        /// <summary>
        /// Gets or sets el valor de: TIPO_DescPAI.
        /// </summary>
        [DataMember]
        public String TIPO_DescPAI { get; set; }

        [DataMember]
        public String ENTC_NomAgente { get; set; }

        [DataMember]
        public String ENTC_NomAgent1 { get; set; }

        [DataMember]
        public String ENTC_NomAgent2 { get; set; }

        /// <summary>
        /// Gets or sets el valor de: PUER_CodEstandar
        /// </summary>
        [DataMember]
        public String PUER_CodEstandar { get; set; }

        public enum TInterfazNaveViaje
        {
           Normal = 0, GenerarAsientos = 1
        }

        public Int16 SUCR_Codigo { get; set; }

        public Int16 EMPR_Codigo { get; set; }

    }
}
