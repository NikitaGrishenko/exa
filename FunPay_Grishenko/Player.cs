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
    
    public partial class Player
    {
        public Player()
        {
            this.GameAccoun = new HashSet<GameAccoun>();
        }
    
        public int IdPlayer { get; set; }
        public string Name { get; set; }
        public string E_mail { get; set; }
        public int Rating { get; set; }
        public System.DateTime DateRegistracii { get; set; }
    
        public virtual ICollection<GameAccoun> GameAccoun { get; set; }
        public virtual Partnership Partnership { get; set; }
    }
}
