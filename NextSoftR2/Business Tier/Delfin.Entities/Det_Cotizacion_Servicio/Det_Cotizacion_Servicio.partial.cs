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
	public partial class Det_Cotizacion_Servicio
	{
        #region [ Variables Adicionales ]
        private Boolean m_Trasanct = true;
        private String m_CONS_CodTMC;
        private String m_CONS_TabTMC;
        private Boolean m_Validado=false;
        #endregion

        #region [ Propiedades Adicionales ]
        [DataMember]
        public Boolean Trasanct
        {
            get { return m_Trasanct; }
            set { m_Trasanct = value; }
        }
        [DataMember]
        public String CONS_CodTMC
        {
            get { return m_CONS_CodTMC; }
            set { m_CONS_CodTMC = value; }
        }
        [DataMember]
        public String CONS_TabTMC
        {
            get { return m_CONS_TabTMC; }
            set { m_CONS_TabTMC = value; }
        }
        [DataMember]
        public String CONS_Desc_TMC { get; set; }

        [DataMember]
        public String CONS_Desc_Servicio { get; set; }

        [DataMember]
        public String Proveedor { get; set; }

        [DataMember]
        public String CONS_Desc_Moneda { get; set; }

        [DataMember]
        public String CONS_Desc_Base { get; set; }

        [DataMember]
        public Boolean Validado
        {
            get { return m_Validado; }
            set { m_Validado = value; }
        }
        #endregion
	}
}
