using HandsOnMVCUsingViewModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnMVCUsingViewModel.ViewModels
{
    public class EmpTitleViewModel
    {
        //This ViewModel class is to wrap uup a Title and EMploee model
        public Employee EmpModel { get; set; }
        public string PageTitle { get; set; }
    }
}
