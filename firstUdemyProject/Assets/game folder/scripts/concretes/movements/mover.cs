using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace firstUdemyProject.movements
{
    public class mover
    {

        Rigidbody _rigidbody;

        public mover(Rigidbody rigidbody)
        {
            _rigidbody = rigidbody;
        }

        public void FixedTick()
        {
            _rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * 10f);
        }
    }
}

