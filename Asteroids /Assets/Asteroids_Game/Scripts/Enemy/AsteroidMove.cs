using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class AsteroidMove
    {
        //float Speed=5;
        //private AsteroidView _asteroid;

        public static  void MoveAsteroid(AsteroidView asteroid, float speed, PlayerView player)
        {
            asteroid._transform.position = asteroid._transform.TransformDirection(player._transform.position ) * speed * Time.fixedDeltaTime;

        }
    }
}

