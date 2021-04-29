using System;
using System.Collections.Generic;
using UnityEngine;

namespace PowerUps
{
    [CreateAssetMenu(menuName = "Custom/Power up configuration")]
    public class PowerUpConfiguration : ScriptableObject
    {
        [SerializeField] private PowerUp[] m_PowerUps;

        private Dictionary<string, PowerUp> idToPowerUp = new Dictionary<string, PowerUp>();


        void Awake()
        {
            foreach (var powerUp in m_PowerUps)
            {
                idToPowerUp.Add(powerUp.Id, powerUp);
            }
        }

        public PowerUp GetPowerUpPrefabById(string id)
        {
            //en esta parte nuestro codigo con el TryGetValue
            //verifica si no es nulo el el powerup y de ser asi
            //retorna una excepcion
            if (!idToPowerUp.TryGetValue(id, out var powerUp))
            {
                throw new Exception("Not Found");
            }

            return powerUp;
        }
    }
}

