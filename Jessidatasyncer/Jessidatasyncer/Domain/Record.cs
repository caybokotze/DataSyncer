using System;
using System.ComponentModel.DataAnnotations;

namespace Jessidatasyncer.Domain
{
    public class Record
    {
        [Key]
        public int Id { get; set; }
        
        public DateTime DateTime { get; set; }
        
        public string Message { get; set; }
    }
}