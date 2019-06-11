using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using wizardscode.extension;
using wizardscode.validation;

namespace wizardscode.plugin.validation
{
    [CreateAssetMenu(fileName = "HerdSimSettingSO_DESCRIPTIVENAME", menuName = "Wizards Code/Agent/HerdSim/Controller Settings")]
    public class HerdSimControllerSettingSO : PrefabSettingSO
    {

        internal override void InstantiatePrefab()
        {
            CreateLayers();
            base.InstantiatePrefab();
        }

        private void CreateLayers()
        {
            // FIXME Check we are not overwriting existing layers
            LayerMaskExtension.CreateLayer(25, "Ground");
            LayerMaskExtension.CreateLayer(26, "HerdSim");
        }
    }
}
