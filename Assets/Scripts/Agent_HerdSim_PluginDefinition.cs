using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace wizardscode.plugin
{
    public class Agent_HerdSim_PluginDefinition : AbstractPluginDefinition
    {
        public override PluginCategory GetCategory()
        {
            return PluginCategory.Agent;
        }

        public override Type GetManagerType()
        {
            return typeof(Agent_HerdSim_PluginManager);
        }

        public override string GetPluginImplementationClassName()
        {
            return "HerdSimController";
        }

        public override string GetProfileTypeName()
        {
            return typeof(HerdSim_Agent_Profile).Name.ToString();
        }

        public override string GetReadableName()
        {
            return "HerdSim";
        }

        public override string GetURL()
        {
            return "https://assetstore.unity.com/publishers/1075";
        }
    }
}
