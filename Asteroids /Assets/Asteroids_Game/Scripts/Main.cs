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
        [SerializeField] private List <AsteroidView> asteroid;
        private List<string> asteroidTyp;
        //private AsteroidMove _asteroidMove; 


        void Awake()
        {
            _playerController = new PlayerController();
            _playerMove = new PlayerMove();
            //_asteroidMove = new AsteroidMove();

             asteroidTyp = new List<string>();
        asteroidTyp.Add("Asteroid Lava Blue");
            asteroidTyp.Add("Asteroid Lava Red");
            asteroidTyp.Add("Mine Sample 2");
        }
        private void Start()
        {

            for (int i = 0; i< asteroid.Count; i++)
            { 
              AsteroidFactory.CreateAsteroids(new Health(100f, 100f), asteroid[i]._spawnPosition.position, asteroidTyp[i]);
                
            }
        }

        void Update()
        {
            _playerController.UpdateControllerMove(_playerMove, _player);

            for (int i = 0; i < asteroid.Count; i++)
            {
                AsteroidMove.MoveAsteroid(asteroid[i], 20, _player);
                //Debug.Log($"начал двидение {i} asteroid");  
            }
        }
    }
}

