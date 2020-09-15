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
	public partial class Nave
	{
        		/// <summary>
		/// Gets or sets el valor de: Nave_Codigo.
		/// </summary>
        [DataMember]
        public string VIA { get; set; }

        [DataMember]
        public string ENTIDADEMISORA { get; set; }

	}
}
