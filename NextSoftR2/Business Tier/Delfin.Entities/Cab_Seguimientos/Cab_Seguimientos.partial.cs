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
	public partial class Cab_Seguimientos
	{
        [DataMember]
	    public String Cliente { set; get; }

        [DataMember]
        public String CANTIDAD { set; get; }

        [DataMember]
        public String COPE_NumDoc { set; get; }

        [DataMember]
        public ObservableCollection<Det_Seguimientos> ItemsDetSeguimientos  { set; get; }
        
	}
}
