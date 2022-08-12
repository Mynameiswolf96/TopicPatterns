using System.Collections;
using System.Collections.Generic;
using Asteroids;
using UnityEngine;

namespace Asteroids
{
    internal sealed class RotationShip : IRotation
    {
        private readonly Transform _transform;

        public RotationShip(Transform transform)
        {
            _transform = transform;
        }

        public void Rotation(Vector3 direction)
        {
            var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Deg2Rad;
            _transform.transform.rotation=Quaternion.AngleAxis(angle,Vector3.forward);
        }
    }
}
