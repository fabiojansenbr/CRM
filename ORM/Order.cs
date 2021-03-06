//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ORM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Payments = new HashSet<Payment>();
        }
    
        public int Id { get; set; }
        public string Number { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public byte DeliveryStatus { get; set; }
        public int OwnerId { get; set; }
        public Nullable<int> DeliveryDriverId { get; set; }
        public string DeliveryAddress { get; set; }
        public Nullable<int> ReceiverId { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public Nullable<decimal> Sum { get; set; }
        public byte PaymentStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
