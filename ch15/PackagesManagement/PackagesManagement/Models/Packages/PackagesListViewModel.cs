using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackagesManagement.Models.Packages
{
    public class PackagesListViewModel
    {
        public IReadOnlyCollection<PackageInfosViewModel> Items { get; set; }
    }
}
