using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExamBelt.Models
{
    public class AnActivity
    {
        [Key]
        public int ActivityID { get; set; }

        [Required(ErrorMessage="Input Required")]
        public string Title { get; set; }
        [Required(ErrorMessage="Input Required")]
        public DateTime Time { get; set; }
        [Required(ErrorMessage="Input Required")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage="Input Required")]
        public int Duration { get; set; }
        [Required(ErrorMessage="Input Required")]
        public string TimeChooser { get; set; }
        [Required(ErrorMessage="Input Required")]
        public string Description { get; set; }
        [Required(ErrorMessage="Input Required")]
        public DateTime Created_At { get; set; } = DateTime.Now;
        [Required(ErrorMessage="Input Required")]
        public DateTime Updated_At { get; set; } = DateTime.Now;

        public int UserID { get; set; }
        public string CreatorNameFirst {get; set;}
        public string CreatorNameLast {get; set;}
        public List<Participant> AllParticipants {get; set;} 
    }
}