using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace gitHubProjectNew.Controllers
{
    public class StartFloorController : MonoBehaviour
    {

        public void OnCollisionExit(Collision other)
        {

            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player !=null)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
