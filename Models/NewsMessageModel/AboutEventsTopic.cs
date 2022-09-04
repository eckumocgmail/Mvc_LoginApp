using System.ComponentModel.DataAnnotations;

namespace MessageService
{


    /// <summary>
    /// Свеедния о распространяемой информации
    /// </summary>
    public class AboutEventsTopic
    {
        public int ID { get; set; }


        [Required]
        [MinLength(5)]
        [MaxLength(25)]
        public string TopicName { get; set; }
        public string TopicDescription { get; set; }
        
    }
}