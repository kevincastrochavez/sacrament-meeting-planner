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
        [RegularExpression(@"^[A-Z]+[a-zA-Z ]*$")]
        public string Invocation { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z ]*$")]
        public string Benediction { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public int? OpeningHymnID { get; set; }

        public int? SacramentHymnID { get; set; }

        public int? ClosingHymnID { get; set; }

        public int? DismissalHymnID { get; set; }
        
        public int? PresidingID { get; set; }

        public int? ConductingID { get; set; }

        // [Display(Name = "Musical Number Hymn")]
        // public int? MusicalNumberID { get; set; }

        // public Hymn MusicalNumber { get; set; }

        // [Display(Name = "Musical Performance")]
        // public string MusicalPerformance { get; set;}

        public int? BishopricID { get; set; }

        public Bishopric? Bishopric { get; set; }

        public Bishopric? Presiding { get; set; }

        public Bishopric? Conducting { get; set; }
        
        public int? HymnID { get; set; }

        public Hymn? Hymn { get; set; }

        [Display(Name = "Opening Hymn")]
        public Hymn? OpeningHymn {get; set; }

        [Display(Name = "Sacrament Hymn")]
        public Hymn? SacramentHymn {get; set; }

        [Display(Name = "Closing Hymn")]
        public Hymn? ClosingHymn {get; set; }

        [Display(Name = "Dismissal Hymn")]
        public Hymn? DismissalHymn {get; set; }

    }
}