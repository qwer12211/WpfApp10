//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp10
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int ID_Order { get; set; }
        public int Customer_ID { get; set; }
        public int Burger_ID { get; set; }
    
        public virtual Burgers Burgers {private get; set; }
        public virtual Customers Customers {private get; set; }
    }
}
