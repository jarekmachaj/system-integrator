using System.Collections.Generic;

namespace SystemIntegrator.Core
{
    public class SystemIntegrator
    {
        private List<Action> _actions { get; } = new List<Action>();
        
        public void AddAction(Action action)
        {
            _actions.Add(action);
        }
    }
}
