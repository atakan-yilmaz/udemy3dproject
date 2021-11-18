using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace firstUdemyProject.input
{
    public class defaultInput
    {

        private defaultAction _input;

        public bool IsForceUp { get; private set; }

        public defaultInput()
        {
            _input = new defaultAction();

            _input.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();

            _input.Enable();
        }

    }

}
