using UnityEngine;
using gitHubProjectNew.Abstracts.Controllers;
using System;
using System.Collections;
using System.Collections.Generic;


namespace gitHubProjectNew.Controllers
{
    public class MoverWallController : WallController
    {
        [SerializeField] Vector3 _direction;
        [SerializeField] float _speed = 1f;
        [SerializeField] float _directionFactor = 1f;

        Vector3 _startPosition;
        const float FULL_CIRCLE = Mathf.PI * 2f;
        float _factor;

        private void Awake()
        {
            _startPosition = transform.position;
        }

        private void Update()
        {
            float cycle = Time.time / _speed;
            float sinWawe = Mathf.Sin(cycle * FULL_CIRCLE);

            //_factor = Mathf.Abs(sinWawe);

            _factor = sinWawe / 2f + 0.5f;

            Vector3 offset = _direction * _factor;
            transform.position = offset + _startPosition * _directionFactor;

            //Debug.Log(Mathf.Sin(Time.time));
        }
    }
}

