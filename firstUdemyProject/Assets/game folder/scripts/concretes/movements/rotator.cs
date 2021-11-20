using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using firstUdemyProject.controller;



namespace firstUdemyProject.movements
{
    public class rotator
    {
        Rigidbody _rigidbody;
        playerController _playerController;


        public rotator(playerController playerController)
        {
            _playerController = playerController;
            _rigidbody = playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick(float direction)
        {
            _playerController.transform.Rotate(eulers: Vector3.forward * Time.deltaTime * direction * _playerController.TurnSpeed);
        }
    }
}