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
	public partial class Det_Tarjas
	{
        #region [ Variables Adicionales ]
        private Boolean m_Trasanct = true;
        #endregion

        #region [ Propiedades Adicionales ]

        [DataMember]
	    public String PACK_Desc { set; get; }

        [DataMember]
        public String CONS_Estado { set; get; }

        [DataMember]
        public Int32 Correlativo { set; get; }

        [DataMember]
        public Int16 Cantidad { set; get; }

        [DataMember]
        public Boolean Trasanct
        {
            get { return m_Trasanct; }
            set { m_Trasanct = value; }
        }
	    #endregion
    }
}
