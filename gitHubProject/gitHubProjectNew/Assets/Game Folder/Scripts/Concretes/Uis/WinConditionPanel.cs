using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gitHubProjectNew.Managers;

namespace gitHubProjectNew.Uis
{
    public class WinConditionPanel : MonoBehaviour
    {
        public void YesClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
    }
}

