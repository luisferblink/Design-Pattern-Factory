using UnityEngine;

namespace PowerUps
{
    public class PowerUpSpawner : MonoBehaviour
    {
        [SerializeField] private PowerUpConfiguration m_PowerUpConfiguration;
        private PowerUpFactory m_PowerUpFactory;

        public void Awake()
        {
            m_PowerUpFactory = new PowerUpFactory(Instantiate(m_PowerUpConfiguration));
        }


        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                m_PowerUpFactory.Create("Speed");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                m_PowerUpFactory.Create("Drunk");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                m_PowerUpFactory.Create("Attack");
            }
        }
    }
}

