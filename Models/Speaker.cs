using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sacramentMeetingPlanner.Models
{
    public class Speaker
    {
        public int SpeakerID { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z ]*$")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Display(Name = "Speaker Subject")]
        public string SubjectType { get; set; }

        [Required]
        public string Gender { get; set; }

        [Display(Name = "Sacrament Meeting")]
        public int? SacramentMeetingID { get; set; }

        public SacramentMeeting? SacramentMeeting { get; set; }
    }
}