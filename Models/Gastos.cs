//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamenParcial.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gastos
    {
        public int Id { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Cantidad { get; set; }
        public int CategoriaId { get; set; }
        public int MonedaId { get; set; }
        public int LugarId { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual Moneda Moneda { get; set; }
        public virtual Lugar Lugar { get; set; }
    }
}
