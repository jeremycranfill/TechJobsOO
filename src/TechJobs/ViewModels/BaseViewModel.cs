using System;
using System.Collections.Generic;
using TechJobs.Models;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobs.ViewModels
{
    public class BaseViewModel 
    {
        // View title
        public string Title { get; set; } = "";

        // All columns, for display
        public List<JobFieldType> Columns { get; set; }

       virtual public JobFieldType Column { get; set; }

    }
}
