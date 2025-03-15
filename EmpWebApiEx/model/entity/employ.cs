using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmpWebApiEx.model.entity
{
    public class employ
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int empId { get; set; }
        public string empName { get; set; }
        public string empAddress { get; set; }
        public string empMail { get; set; }


    }
}
