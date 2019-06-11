using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using wizardscode.plugin;

namespace wizardscode.validation
{
    public class Agent_HerdSim_PluginValidation : ValidationTest<Agent_HerdSim_PluginManager>
    {
        private string terrainLayerName = "Ground";

        public override ValidationTest<Agent_HerdSim_PluginManager> Instance => new Agent_HerdSim_PluginValidation();

        internal override string ProfileType => typeof(HerdSim_Agent_Profile).ToString();

        internal override void CustomValidations()
        {
            if (Terrain.activeTerrain.gameObject.layer == LayerMask.NameToLayer(terrainLayerName))
            {
                Collection.AddOrUpdate(GetPassResult("Terrain layer", "The terrain is marked as having the layer `Ground`.", GetType().Name), GetType().Name);
            }
            else
            {
                ResolutionCallback callback = new ResolutionCallback(SetTerrainLayer, "Set Terrain Layer");
                Collection.AddOrUpdate(GetErrorResult("Terrain layer", "The terrain must be marked as having the layer `Ground`.", GetType().Name, callback), GetType().Name);
            }
        }

        private void SetTerrainLayer()
        {
            Terrain.activeTerrain.gameObject.layer = LayerMask.NameToLayer(terrainLayerName);
        }
    }
}
