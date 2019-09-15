namespace DinnerMe2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Booking
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int DeskId { get; set; }

        public bool Birthday { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Desk Desk { get; set; }
    }
}
