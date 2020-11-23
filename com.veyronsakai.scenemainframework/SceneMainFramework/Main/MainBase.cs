using PrefabGenerator;
using UnityEngine;

namespace SceneMainFramework.Main
{
    /// <summary>
    /// Base class of Main class in each scene.
    /// </summary>
    public abstract class MainBase : MonoBehaviour
    {
        protected PrefabFactory PrefabFactory;
        protected abstract void Inject();
        protected abstract void OnAwake();
        protected abstract void OnStart();
        protected abstract void OnUpdate();
    
        private void Awake()
        {
            Inject();
            OnAwake();
        }

        private void Start()
        {
            OnStart();
        }

        private void Update()
        {
            OnUpdate();
        }
    }
}
