using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gitHubProjectNew.Managers;


namespace gitHubProjectNew.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
        public void TryAgainClick()
        {
            GameManager.Instance.LoadLevelScene();
        }

        public void ExitClick()
        {
            GameManager.Instance.LoadMenuScene(); 
        }
    }
}

