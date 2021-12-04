using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace gitHubProjectNew.Abstract.Utilities
{
    public class SingletonThisObject<T> : MonoBehaviour
    {
        public static T Instance { get; private set; }
        protected private void SingletonThisGameObject(T entity)
        {
            if (Instance == null)
            {
                Instance = entity;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}

