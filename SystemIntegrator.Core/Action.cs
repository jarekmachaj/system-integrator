using System;
using System.Collections.Generic;
using System.Text;

namespace SystemIntegrator.Core
{
    public class Action
    {
        public string ActionName { get; set; }

        public virtual void Execute()
        {

        }
    }
}
