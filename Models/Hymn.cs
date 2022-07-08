using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sacramentMeetingPlanner.Models
{
    public class Hymn
    {
        public int HymnID { get; set; }

        [Required]
        [Range(1, 341)]
        public int Number { get; set; }

        [Required]
        public string Title { get; set; }
    }
}