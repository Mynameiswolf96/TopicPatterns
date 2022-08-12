using UnityEngine;
namespace Asteroids
{
    internal class MoveHero : IMove
    {
        private readonly Transform _transform;
        private Vector3 _move;
        private Rigidbody _rb;
        
        public float Speed { get; protected set; }
        
        public MoveHero(Transform transform, float speed)
        {
            _transform = transform;
            Speed = speed;
        }
        
        public void Move(float horizontal, float vertical, float deltaTime)
        {
            var speed = deltaTime * Speed;
            _move = new Vector3(horizontal * speed, vertical * speed, 0.0f);
            _rb.AddForce(_move);
            _transform.localPosition += _move;
        }
    }
}