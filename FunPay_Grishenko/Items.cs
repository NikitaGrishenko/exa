//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FunPay_Grishenko
{
    using System;
    using System.Collections.Generic;
    
    public partial class Items
    {
        public Items()
        {
            this.Deal = new HashSet<Deal>();
            this.GameAccoun = new HashSet<GameAccoun>();
        }
    
        public int IdItem { get; set; }
        public string Name { get; set; }
        public string ItemType { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    
        public virtual ICollection<Deal> Deal { get; set; }
        public virtual ICollection<GameAccoun> GameAccoun { get; set; }
    }
}
