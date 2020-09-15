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
	public partial class Det_Cotizacion_OV_EventosTareas
	{
        private Int32 m_nvia_codigo;

        [DataMember]
        public Int32 NVIA_Codigo
        {
            get { return m_nvia_codigo; }
            set
            {
                if (m_nvia_codigo != value)
                {
                    m_nvia_codigo = value;
                    OnPropertyChanged("NVIA_Codigo");
                }
            }
        }
	}
}
