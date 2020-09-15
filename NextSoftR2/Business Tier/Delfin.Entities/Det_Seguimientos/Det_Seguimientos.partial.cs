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
	public partial class Det_Seguimientos
	{
        #region [ Variables Adicionales ]
        private Boolean m_Tranct = false; 
        #endregion

        #region [ Propiedades Adicionales ]
        [DataMember]
        public Boolean Tranct
        {
            get { return m_Tranct; }
            set { m_Tranct = value; }
        }
        [DataMember]
	    public Int32 Item { set; get; }

        [DataMember]
        public String CONS_CodESSSTR { set; get; }

        [DataMember]
        public Int32 PACK_Codigo { get; set; }

        [DataMember]
        public String PACK_DescC { set; get; }
	    #endregion
	}
}
