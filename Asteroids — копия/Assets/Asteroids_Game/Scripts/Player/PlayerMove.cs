using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class PlayerMove
    {
       // private PlayerView _playerView;
        private float Speed = 3;

        public  void Move (PlayerView player, float x, float y, float z)
        {
            Debug.Log("запустился Move");

            if (player._rigidbody)
            {
                player._rigidbody.AddForce(new Vector3(x, y, z) * Speed);
                Debug.Log("Должен сработать Add Force"); 
            }
        }
    }
}

