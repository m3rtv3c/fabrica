//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fabrica
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductAccessories
    {
        public string HardwareArticle { get; set; }
        public string ArticleProduct { get; set; }
        public string Accommodation { get; set; }
        public Nullable<int> Width { get; set; }
        public Nullable<int> Length { get; set; }
        public Nullable<int> Turn { get; set; }
        public string Quantity { get; set; }
    
        public virtual Furniture Furniture { get; set; }
        public virtual Product Product { get; set; }
    }
}
