using UnityEngine;
using WizardsCode.Editor;
using WizardsCode.Plugin.Validation;
using WizardsCode.Plugin;

namespace WizardsCode.Plugin
{
    [CreateAssetMenu(fileName = "DECRIPTIVENAME_CATEGORY_Profile", menuName = "Wizards Code/Agent/HerdSim/Plugin Profile")]
    public class HerdSim_Agent_Profile : AbstractPluginProfile
    {
        [Tooltip("The main HerdSim Controller.")]
        [Expandable(isRequired: true)]
        public HerdSimControllerSettingSO herdSimController;
        
        [Tooltip("The definition of the herd to add.")]
        [Expandable(isRequired: true)]
        public HerdSettingSO herd;
    }
}
