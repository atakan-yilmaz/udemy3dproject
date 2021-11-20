using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gitHubProjectNew.Inputs;
using gitHubProjectNew.Movements;


namespace gitHubProjectNew.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        
        [SerializeField] float _force = 750f;
        [SerializeField] float _turnSpeed = 75f;
        

        Mover _mover;
        DefaultInput _input;
        Rotator _rotator;

        bool _isForceUp;
        float _leftRight;

        public float TurnSpeed => _turnSpeed;
        public float Force => _force;

        private void Awake()
        {
            _mover = new Mover(this) ;
            _input = new DefaultInput();
            _rotator = new Rotator(this);
        }

        private void Update()
        {


            //Debug.Log(_input.LeftRight);
            //Debug.Log(_input.IsForceUp);

            if (_input.IsForceUp)
            {
                _isForceUp = true;
            }
            else
            {
                _isForceUp = false;
            }

            _leftRight = _input.LeftRight;
        }

        private void FixedUpdate()
        {
            if (_isForceUp)
            {
                _mover.FixedTick();
            }

            _rotator.FixedTick(_leftRight);
        }
    }
}

