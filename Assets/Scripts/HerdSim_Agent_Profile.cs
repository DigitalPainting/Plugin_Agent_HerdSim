using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using wizardscode.editor;
using wizardscode.extension;
using wizardscode.plugin.validation;
using wizardscode.validation;

namespace wizardscode.plugin
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
