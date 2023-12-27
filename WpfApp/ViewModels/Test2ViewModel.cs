using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Base.ViewModels;

namespace WpfApp.ViewModels
{
    public class Test2ViewModel:ViewModelBase
    {
        public string TestLabel { get; set; } = nameof(Test2ViewModel);
    }
}
