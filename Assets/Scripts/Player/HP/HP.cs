using UnityEngine;

namespace Asteroids
{

    internal sealed class HP
    {
        private float _curHealth;
        private float _maxHealth = 20f;
        

        public  HP(float maxHealth, float curHealth)
        {
            _maxHealth = maxHealth;
            _curHealth = curHealth;

        }

        public void ChangeHP(float hp,GameObject gameObject)
        {
            _curHealth += hp;
            if (_curHealth <= 0)
            {
                gameObject.SetActive(false);
            }

            if (_curHealth >= _maxHealth)
            {
                _curHealth = _maxHealth;
            }
        }
    }
}