using System.Collections.Generic;

namespace SPToCore.Model
{
    public class Sp
    {
        public string Name { get; set; }
        public string Schema { get; set; }
                
        public List<SpParam> Params = new List<SpParam>();
        public List<SpResultElement> Results = new List<SpResultElement>();

        public string GetMethodDefinition() {
            if (this.Results.Count == 0)
            {
                return $@"public void {this.Name}";
            }
            else {
                return $@"public async Task<List<{this.Name}Result>> {this.Name}Async";
            }            
        }
        
    }

}
