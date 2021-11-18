using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using firstUdemyProject.input;


namespace firstUdemyProject.controller
{

    public class playerController : MonoBehaviour
    {
        [SerializeField] float _force;
        Rigidbody _rigidBody;
        defaultInput _input;

        bool _isForceUp;

        private void Awake()
        {
            _rigidBody = GetComponent<Rigidbody>();
            _input = new defaultInput();
        }


        private void Update()
        {
            //input

            Debug.Log(_input.IsForceUp);

            if (_input.IsForceUp)
            {
                _isForceUp = true;
            }
            else
            {
                _isForceUp = false;
            }

        }

        private void FixedUpdate()
        {
            //physics 
            if (_isForceUp)
            {
                _rigidBody.AddForce(Vector3.up * Time.deltaTime * _force);
            }

        }
    }

}
