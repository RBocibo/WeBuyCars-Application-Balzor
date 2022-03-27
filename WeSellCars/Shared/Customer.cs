using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeSellCars.Shared
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Please provide a name")]
        public string CustomerName { get; set; } = default!;
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string CustomerEmail { get; set; } = default!;

        [Required(ErrorMessage = "Please provide a street with house number.")]
        public string Street { get; set; } = default!;
        [Required(ErrorMessage = "Please provide a city")]
        public string City { get; set; } = default!;
        [Required(ErrorMessage = "Please provide province")]
        public string Province { get; set; } = default!;

        public Order Order { get; set; }
    }
}
