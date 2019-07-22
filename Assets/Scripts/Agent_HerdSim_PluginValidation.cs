using System;
using UnityEngine;
using WizardsCode.Plugin;
using WizardsCode.Validation;

namespace WizardsCode.validation
{
    public class Agent_HerdSim_PluginValidation : ValidationTest<Agent_HerdSim_PluginManager>
    {
        private string terrainLayerName = "Ground";

        public override ValidationTest<Agent_HerdSim_PluginManager> Instance => new Agent_HerdSim_PluginValidation();

        internal override Type ProfileType => typeof(HerdSim_Agent_Profile);

        internal override bool InitialCustomValidations()
        {
            AbstractPluginManager pluginManager = GameObject.FindObjectOfType<Agent_HerdSim_PluginManager>();
            bool result = base.InitialCustomValidations();
            if (UnityEngine.Terrain.activeTerrain.gameObject.layer == LayerMask.NameToLayer(terrainLayerName))
            {
                AddOrUpdateAsPass("Terrain Layer", pluginManager, "The terrain is marked as having the layer `Ground`.");
                result &= true;
            }
            else
            {
                ResolutionCallback callback = new ResolutionCallback(SetTerrainLayer, "Set Terrain Layer");
                AddOrUpdateAsError("Terrain Layer", pluginManager, "The terrain must be marked as having the layer `Ground`.", callback);
                result = false;
            }
            return result;
        }

        private void SetTerrainLayer()
        {
            UnityEngine.Terrain.activeTerrain.gameObject.layer = LayerMask.NameToLayer(terrainLayerName);
        }
    }
}
