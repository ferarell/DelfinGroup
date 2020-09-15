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
	public partial class Det_Tarifa_Servicio
	{
        #region [ Variables Adicionales ]
        private Boolean m_Trasanct = true;
        private String m_TIPO_CodTipo;
        private String m_TIPO_Desc1;
        #endregion

        #region [ Proipiedades Adicionales ]
        [DataMember]
        public Boolean Trasanct
        {
            get { return m_Trasanct; }
            set { m_Trasanct = value; }
        }
        [DataMember]
        public String TIPO_Desc1
        {
            get { return m_TIPO_Desc1; }
            set { m_TIPO_Desc1 = value; }
        }
        [DataMember]
        public String TIPO_CodTipo
        {
            get { return m_TIPO_CodTipo; }
            set { m_TIPO_CodTipo = value; }
        }
        [DataMember]
        public String TIPO_Desc_Servicio { get; set; }
        [DataMember]
        public String CONS_Desc_Moneda { get; set; }
        #endregion
	}
}
