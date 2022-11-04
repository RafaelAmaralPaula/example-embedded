using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestEntityEmbbeded.Model
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Fantasy { get; set; }

        public InformationContact Contact { get; set; }

    }
}