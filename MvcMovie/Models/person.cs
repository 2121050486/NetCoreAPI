using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class person
    {
        [Key]
        public string personID { get;set;}
        public string fullname { get;set;}
        public string address { get;set;}
    }
}

