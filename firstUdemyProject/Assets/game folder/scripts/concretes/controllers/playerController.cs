using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using firstUdemyProject.input;
using firstUdemyProject.movements;

namespace firstUdemyProject.controller
{

    public class playerController : MonoBehaviour
    {
        
        defaultInput _input;
        mover _mover;

        bool _isForceUp;
        

        private void Awake()
        {
            _input = new defaultInput();
            _mover = new mover(rigidbody: GetComponent<Rigidbody>());
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
                _mover.FixedTick();
            }

        }
    }

}
