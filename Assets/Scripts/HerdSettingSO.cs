using UnityEngine;
using WizardsCode.Validation;

namespace WizardsCode.Plugin.Validation
{
    [CreateAssetMenu(fileName = "HerdAnimalSettingSO_DESCRIPTIVENAME", menuName = "Wizards Code/Agent/HerdSim/Herd Settings")]
    public class HerdSettingSO : PrefabSettingSO
    {
        [Header("Herd")]
        [Tooltip("The number of animals in the herd.")]
        public int numberOfAnimals = 5;
        [Tooltip("The radius of the circle (for grounded models) or sphere (for non-grounded models) within which the animals will spawn.")]
        public float spawnRadius = 5;

        [Header("Model")]
        [Tooltip("The minimum size for the model. Spawned models will be sized randomly between this and maxSize.")]
        public float minSize = 0.8f;
        [Tooltip("The minimum size for the model. Spawned models will be sized randomly between this and minSize.")]
        public float maxSize = 1.1f;
        [Tooltip("The minimum angle that the model will be spawned at around the Y axis. The model will be spawned at a random angle between this and maxAngle.")]
        public float maxAngle = 360;
        [Tooltip("The maximum angle that the model will be spawned at around the Y axis. The model will be spawned at a random angle between this and minAngle.")]
        public float minAngle = 0;
        [Tooltip("Set to true if the object must be spawned on the ground.")]
        public bool isGrounded = true;
        [Tooltip("The Y offset to be used when positioning the model. If your model does not have he origin at the base then use this to ensure that the model is correctly positioned.")]
        public float yOffset = 0;

        internal override void InstantiatePrefab()
        {
            Instance = new GameObject(SettingName + " Herd");
            Instance.transform.position = spawnPosition;

            for (int i = 1; i <= numberOfAnimals; i++)
            {
                float size = Random.Range(minSize, maxSize);
                Vector3 pos = (Random.insideUnitSphere * spawnRadius);
                if (isGrounded)
                {
                    pos.y = UnityEngine.Terrain.activeTerrain.SampleHeight(pos) + (yOffset * size);
                }
                Quaternion angle = Quaternion.Euler(0, Random.Range(minAngle, maxAngle), 0);
                GameObject obj = ConvertToGameObject(Instantiate(SuggestedValue));
                obj.transform.localScale = new Vector3(size, size, size);
                obj.transform.position = pos;
                obj.transform.rotation = angle;

                Vector3 scale = obj.transform.lossyScale;
                obj.transform.SetParent(Instance.transform, false);
                obj.transform.localScale = scale;
            }
        }
    }
}
