using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using wizardscode.plugin;

namespace wizardscode.validation
{
    public class Agent_HerdSim_PluginValidation : ValidationTest<Agent_HerdSim_PluginManager>
    {
        public override ValidationTest<Agent_HerdSim_PluginManager> Instance => new Agent_HerdSim_PluginValidation();

        internal override string ProfileType => typeof(HerdSim_Agent_Profile).ToString();
    }
}
