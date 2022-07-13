using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class AsteroidView : MonoBehaviour
    {
        [SerializeField] public GameObject _gameObject;
        [SerializeField] public Transform _transform;
        [SerializeField] public Collider _collider;
        [SerializeField] public Transform _spawnPosition;
        public Health _health;
    }
}

