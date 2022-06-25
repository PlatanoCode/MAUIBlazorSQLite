using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIBlazorSQLite.Data.Entities
{
    public class ToDo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string DayOfTheWeekText { get; set; }

        public string TitleText { get; set; }

        public string DescriptionText { get; set; }
    }
}
