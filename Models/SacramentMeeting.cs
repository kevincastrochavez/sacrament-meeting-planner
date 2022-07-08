using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sacramentMeetingPlanner.Models
{
    public class SacramentMeeting
    {
        public int SacramentMeetingID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string Invocation { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string Benediction { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Required]
        [Range(1, 341)]
        [Display(Name = "Opening Hymn")]
        public Hymn OpeningHymn { get; set; }

        [Required]
        [Range(1, 341)]
        [Display(Name = "Sacrament Hymn")]
        public Hymn SacramentHymn { get; set; }

        [Required]
        [Range(1, 341)]
        [Display(Name = "Closing Hymn")]
        public Hymn ClosingHymn { get; set; }

        [Required]
        [Range(1, 341)]
        [Display(Name = "Dismissal Hymn")]
        public Hymn DismissalHymn { get; set; }
        
        [Required]
        public Bishopric Presiding { get; set; }

        [Required]
        public Bishopric Conducting { get; set; }

        
        public int SpeakerID { get; set; }

        
        public int BishopricID { get; set; }

        
        public int HymnID { get; set; }

    }
}