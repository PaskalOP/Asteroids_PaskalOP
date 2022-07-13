using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class AsteroidFactory : MonoBehaviour
    {
        public Health _health;
        public AsteroidView  _asteroid;
        

        private void Awake()
        {
            _asteroid = new AsteroidView(); //инициализировать в меине*
           
        }

        public static  AsteroidView CreateAsteroids(Health health, Vector3 spawnposition, string asteroidsList)
        {
            
            
                var asteroid = Instantiate(Resources.Load<AsteroidView>($"Enemy/{asteroidsList}"), spawnposition, Quaternion.identity);
                asteroid._health = health;
                asteroid._spawnPosition.position = spawnposition;
                return asteroid;
 
        }
    }
}

