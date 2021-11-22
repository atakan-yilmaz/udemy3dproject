using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace gitHubProjectNew.Controllers
{
    public class FinishFloorController : MonoBehaviour
    {

        [SerializeField] GameObject _finishFloorMagicalSource;
        [SerializeField] GameObject _finishFloorEnemySkull;

        private void OnCollisionEnter(Collision other)
        {

            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player == null) return;

            if (other.GetContact(0).normal.y == -1)
            {
                _finishFloorMagicalSource.gameObject.SetActive(true);
                _finishFloorEnemySkull.gameObject.SetActive(true);
            }
            else
            {
                //game over

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
