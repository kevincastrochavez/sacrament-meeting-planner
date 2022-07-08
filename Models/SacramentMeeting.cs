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
        [Display(Name = "Opening Hymn")]
        public int OpeningHymn { get; set; }

        [Required]
        [Display(Name = "Sacrament Hymn")]
        public int SacramentHymn { get; set; }

        [Required]
        [Display(Name = "Closing Hymn")]
        public int ClosingHymn { get; set; }

        [Required]
        [Display(Name = "Dismissal Hymn")]
        public int DismissalHymn { get; set; }
        
        [Required]
        public int Presiding { get; set; }

        [Required]
        public int Conducting { get; set; }

        
        public int SpeakerID { get; set; }
        
        public int BishopricID { get; set; }

        public Bishopric Bishopric { get; set; }
        
        public int HymnID { get; set; }

        public Hymn Hymn { get; set; }

    }
}