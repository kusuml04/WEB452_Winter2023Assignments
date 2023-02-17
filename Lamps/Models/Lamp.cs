using System;
using System.ComponentModel.DataAnnotations;

namespace Lamps.Models
{
    public class Lamp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brightness { get; set; }
        public string Efficiency { get; set; }
        public string Shapes { get; set; }
        public string ColorTemperature { get; set; }
        public int Rating { get; set; }
    }
}