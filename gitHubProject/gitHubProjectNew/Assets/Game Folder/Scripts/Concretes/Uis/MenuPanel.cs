using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gitHubProjectNew.Managers;



namespace gitHubProjectNew.Uis
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartClick()
        {
            GameManager.Instance.LoadLevelScene(1);
        }

        public void ExitClick()
        {
            GameManager.Instance.Exit();
        }
    }
}

