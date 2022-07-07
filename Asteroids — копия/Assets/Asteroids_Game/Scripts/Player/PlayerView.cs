using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] public Transform _transform;
        [SerializeField] public Rigidbody _rigidbody;
        [SerializeField] public Collider _collider;
        [SerializeField] public GameObject _gameObject;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }
    }
}

