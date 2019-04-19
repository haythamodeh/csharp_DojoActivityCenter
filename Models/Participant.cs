namespace ExamBelt.Models
{
    public class Participant {
        public int ParticipantID { get; set; }
        public int UserID {get; set;}
        public int ActivityID {get; set;}
        public User User {get; set;}
        public AnActivity Activity {get; set;}

    }
}