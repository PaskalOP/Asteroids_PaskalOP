using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class PlayerController
    {
        
        float X;
        float Y;
        float Z;

        public void UpdateControllerMove(PlayerMove playerMove, PlayerView player )
        {
            
                X = Input.GetAxis("Horizontal");
            Y = Input.GetAxis("Jump");
            Z =  Input.GetAxis("Vertical");
            playerMove.Move(player, X, Y, Z);

        }
    }
}

