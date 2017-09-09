using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace LanSiDai.Models
{
    public class Questions
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string PersonId { get; set; }
        public string AnsId { get; set; }
        public string QuestionCategory { get; set; }
        public DateTime CreatTime { get; set; }
        public bool IsActive { get; set; }
    }
}