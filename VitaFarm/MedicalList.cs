//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VitaFarm
{
    using System;
    using System.Collections.Generic;
    
    public partial class MedicalList
    {
        public MedicalList()
        {
            this.MedicalOrder = new HashSet<MedicalOrder>();
        }
    
        public int UID { get; set; }
        public byte[] Photo { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Source { get; set; }
        public decimal Price { get; set; }
        public string Value { get; set; }
        public string Count_ { get; set; }
        public float Perc { get; set; }
    
        public virtual ICollection<MedicalOrder> MedicalOrder { get; set; }
    }
}
