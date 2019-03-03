using System;
using System.Collections.Generic;
using System.Text;

namespace SystemIntegrator.Core.Actions
{
    public class WriteLineAction
    {
        public string Message { get; set; }

        public WriteLineAction(string message)
        {
            Message = message;
        }

    }
}
