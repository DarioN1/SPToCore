using SPToCore.Model;
using System.Collections.Generic;

namespace SPToCore.T4
{
    partial class SPToCoreT4
    {
        private List<Sp> SpList { get; set; }

        private string Namespace { get; set; }
        private string SolutionDestinationFolder { get; set; }
        private string DestinationDbContext { get; set; }
        private string ProgramName { get { return System.AppDomain.CurrentDomain.FriendlyName; } }


        private string SourceDbContext { get; set; }
        public SPToCoreT4(List<Sp> _spList,
            string _namespace, 
            string _solutionDestinationFolder,            
            string _sourceDbContext) {
        
            this.SpList = _spList;
            this.Namespace = _namespace;
            this.SolutionDestinationFolder = _solutionDestinationFolder;
            this.DestinationDbContext = "SPToCoreContext";

            this.SourceDbContext = _sourceDbContext;
        }
    }

    
}
