using firstUdemyProject.controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace firstUdemyProject.movements
{
    public class mover
    {
        playerController _playerController;
        Rigidbody _rigidbody;
        
        

        public mover(playerController playerController)
        {
            _playerController = playerController;
            _rigidbody = playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick()
        {
            _rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * _playerController.Force);
        }
    }
}

