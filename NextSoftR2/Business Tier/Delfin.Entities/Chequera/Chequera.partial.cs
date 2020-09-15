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
   public partial class Chequera
   {
      [DataMember]
      public String CHEQ_Diferido_Text { get; set; }
      [DataMember]
      public String CHEQ_Estado_Text { get; set; }

   }
}
