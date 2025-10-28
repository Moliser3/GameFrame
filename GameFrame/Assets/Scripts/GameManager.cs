using System;
using UnityEngine.SceneManagement;

namespace Moliser3
{
    using UnityEngine;


    public class GameManager : MonoBehaviour
    {
        public static GameManager GM;

        private void Awake()
        {
            if (GM == null)
            {
                GM = this;
                DontDestroyOnLoad(this);
            }
        }

        void Start()
        {
            //SceneManager.LoadScene("Level_0");
        }

        void Update()
        {
        }
    }
}