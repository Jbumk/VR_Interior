using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace VRKeys
{
    public class JoinKey : Key
    {

        public override void HandleTriggerEnter(Collider other)
        {
            SceneManager.LoadScene("MainMenu");
        }

 
    }
}

