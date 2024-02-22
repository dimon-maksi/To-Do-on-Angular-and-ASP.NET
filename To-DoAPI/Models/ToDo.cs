using System.ComponentModel.DataAnnotations;

namespace To_DoAPI.Models
{
    public class ToDo
    {
        [Key]
        public int ToDoId { get; set; } = 0;

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = "";

        [Required]
        [StringLength(200)]
        public string Desctiption { get; set; } = "";

        [Required]
        public DateTime Created { get; set; } = DateTime.Now;

        [Required]
        public DateTime DeadLine { get; set; }

        private bool _status;
        [Required]
        public string Status
        {
            get 
            {
                if (_status == true) return "Done";
                else return "Planned";
            }
            set 
            {
                if (value == "Done") _status = true;
                else _status = false;
            }
        }

    }
}
