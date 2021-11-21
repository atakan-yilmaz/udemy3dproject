using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gitHubProjectNew.Inputs;
using gitHubProjectNew.Movements;


namespace gitHubProjectNew.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        
        [SerializeField] float _force = 900f;
        [SerializeField] float _turnSpeed = 100f;
        

        Mover _mover;
        DefaultInput _input;
        Rotator _rotator;
        Fuel _fuel;

        bool _canForceUp;
        float _leftRight;

        public float TurnSpeed => _turnSpeed;
        public float Force => _force;

        private void Awake()
        {
            _mover = new Mover(this) ;
            _input = new DefaultInput();
            _rotator = new Rotator(this);
            _fuel = GetComponent<Fuel>();
        }

        private void Update()
        {

            //Debug.Log(_input.LeftRight);
            //Debug.Log(_input.IsForceUp);

            if (_input.IsForceUp && !_fuel.IsEmpty)
            {
                _canForceUp = true;
            }
            else
            {
                _canForceUp = false;
                _fuel.FuelIncrease(increase: 0.08f);
            }

            _leftRight = _input.LeftRight;
        }

        private void FixedUpdate()
        {
            if (_canForceUp)
            {
                _mover.FixedTick();
                _fuel.FuelDecrease(decrease: 0.2f);
            }

            _rotator.FixedTick(_leftRight);
        }
    }
}

