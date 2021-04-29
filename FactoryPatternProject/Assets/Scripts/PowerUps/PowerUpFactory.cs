using UnityEngine;

namespace PowerUps
{
    public class PowerUpFactory
    {
        private readonly PowerUpConfiguration m_PowerUpConfiguration;

        public PowerUpFactory(PowerUpConfiguration powerUpConfiguration)
        {
            m_PowerUpConfiguration = powerUpConfiguration;
        }

        public PowerUp Create(string id)
        {
            var powerUp = m_PowerUpConfiguration.GetPowerUpPrefabById(id);
            return Object.Instantiate(powerUp);
        }
    }
}

