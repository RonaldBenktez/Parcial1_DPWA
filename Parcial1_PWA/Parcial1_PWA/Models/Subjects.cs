using System.ComponentModel.DataAnnotations;
namespace Parcial1_PWA.Models
{
    public class Subjects
    {
        public int SubjectId { get; set; }

        [Required, StringLength(50)]
        public string SubjectName { get; set; }

        public int VU { get; set; }

        public bool IsActive { get; set; }

        public DateTime Created { get; set; }

        [Required, StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime Edited { get; set; }

        [Required, StringLength(50)]
        public string EditedBy { get; set; }
    }
}
