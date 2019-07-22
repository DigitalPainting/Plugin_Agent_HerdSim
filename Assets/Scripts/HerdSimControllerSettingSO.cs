using UnityEngine;
using WizardsCode.Extension;
using WizardsCode.Validation;

namespace WizardsCode.Plugin.Validation
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
