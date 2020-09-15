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
	public partial class Cab_Tarjas
	{
        #region [Variables Adicionales]
        private ObservableCollection<Det_Tarjas> m_ItemsDet_Tarjas;
	    #endregion

	    #region [ Propiedades Adicionales ]
        public ObservableCollection<Det_Tarjas> ItemsDet_Tarjas
        {
            get { return m_ItemsDet_Tarjas; }
            set { m_ItemsDet_Tarjas = value; }
        }
        [DataMember]
	    public String Cliente { set; get; }

        [DataMember]
        public String Temporal { set; get; }

        [DataMember]
        public String Moneda_Desc { set; get; }

	    #endregion
	}
}
