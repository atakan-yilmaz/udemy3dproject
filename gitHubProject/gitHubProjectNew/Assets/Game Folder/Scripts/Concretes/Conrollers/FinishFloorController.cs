using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using gitHubProjectNew.Managers;

namespace gitHubProjectNew.Controllers
{
    public class FinishFloorController : MonoBehaviour
    {

        [SerializeField] GameObject _finishFloorMagicalSource;
        [SerializeField] GameObject _finishFloorEnemySkull;

        private void OnCollisionEnter(Collision other)
        {

            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player == null || !player.CanMove) return;
            
            if (other.GetContact(0).normal.y == -1)
            {
                _finishFloorMagicalSource.gameObject.SetActive(true);
                _finishFloorEnemySkull.gameObject.SetActive(true);

                GameManager.Instance.MissionSucced();
            }

            else
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}
