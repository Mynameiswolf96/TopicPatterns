using System;
using UnityEngine;

namespace Asteroids
{
    internal sealed class Player : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _force;
        [SerializeField] private float _maxHealth = 20f;
        [SerializeField] private float damage;
        private Rigidbody _rb;
        private Camera _camera;
        private Ship _ship;
        private HP _hp;
        private Shooting _shooting;
        
        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
            _camera = Camera.main;
            var moveTransform = new AccelerationMove(transform, _speed, _acceleration);
            var rotation = new RotationShip(transform);
            _ship = new Ship(moveTransform, rotation);
            _hp = new HP(_maxHealth, _maxHealth);
            _shooting = new Shooting(_bullet, _barrel, _force);
        }
        
        private void Update()
        {
            var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
            _ship.Rotation(direction);
            _ship.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _ship.AddAcceleration();
            }
            
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _ship.RemoveAcceleration();
            }
            
            if (Input.GetButtonDown("Fire1"))
            {
                _shooting.BulletShooting();
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
           _hp.ChangeHP(damage,gameObject);
        }
    }
}