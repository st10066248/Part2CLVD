using System.ComponentModel.DataAnnotations.Schema;

namespace Part2CLVD.Models
{
    public class Order
    {

        public int OrderId { get; set;}
        public string Name {get; set;} = "";
        public string Surname {get; set;} = "";
        public string Contact {get; set;} = "";
        public decimal Total {get; set;}

    }
}
