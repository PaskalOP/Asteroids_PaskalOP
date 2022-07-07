using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class Main : MonoBehaviour
    {
        private PlayerController _playerController;
        [SerializeField] private PlayerView _player;
        private PlayerMove _playerMove;
        
        void Awake()
        {
            _playerController = new PlayerController();
            _playerMove = new PlayerMove();
        }


        void Update()
        {
            _playerController.UpdateControllerMove(_playerMove, _player);
        }
    }
}

