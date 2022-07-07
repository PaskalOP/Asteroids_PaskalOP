using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class PlayerMove
    {
      
        private float Speed = 15;

        public  void Move (PlayerView player, float x, float y, float z)
        {
           

            if (player._rigidbody)
            {
                player._rigidbody.AddForce(new Vector3(x, y, z) * Speed);
                
            }
        }
    }
}

