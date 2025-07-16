using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
namespace SkillTrackr.Domain.Entities
{
    public class ProgressLog
    {
        public int Id { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }

        public DateTime Date { get; set; }
        public int HoursLogged { get; set; }
        public string? Notes { get; set; }
    }
}