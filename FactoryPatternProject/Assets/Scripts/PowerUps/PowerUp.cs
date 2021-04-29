using UnityEngine;

namespace PowerUps
{
    public class PowerUp : MonoBehaviour
    {
        [SerializeField]
        private string m_Id;

        //de esta manera se tare solo el get de la variable m_Id
        public string Id => m_Id;
    }
}

