using SPToCore.Model;
using System.Collections.Generic;

namespace SPToCore.T4
{
    partial class SPToCoreT4
    {
        private List<Sp> SpList { get; set; }
        private string SourceDbContext { get; set; }
        public SPToCoreT4(List<Sp> spList,string sourceDbContext) {
            this.SpList = spList;
            this.SourceDbContext = sourceDbContext;
        }
    }

    
}
