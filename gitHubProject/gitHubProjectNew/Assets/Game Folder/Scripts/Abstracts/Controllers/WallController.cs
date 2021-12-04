using UnityEngine;
using gitHubProjectNew.Managers;
using gitHubProjectNew.Controllers;

namespace gitHubProjectNew.Abstracts.Controllers
{
    public abstract class WallController : MonoBehaviour
    {

        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player != null && player.CanMove)
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}

