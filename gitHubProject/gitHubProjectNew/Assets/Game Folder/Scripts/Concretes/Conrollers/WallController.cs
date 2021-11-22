using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using gitHubProjectNew.Managers;


namespace gitHubProjectNew.Controllers
{
    public class WallController : MonoBehaviour
    {

        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player != null)
            {
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                GameManager.Instance.GameOver();
            }
        }
    }
}

