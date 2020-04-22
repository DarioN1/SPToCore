using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class Log4Net
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string WebApiMethod { get; set; }
        public string JsonPayload { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
    }
}
