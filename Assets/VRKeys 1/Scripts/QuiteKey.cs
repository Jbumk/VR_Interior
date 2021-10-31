using UnityEngine;
using System.Collections;

namespace VRKeys{


    public class QuiteKey : Key
    {

        public override void HandleTriggerEnter(Collider other)
        {
            Application.Quit();
        }
  
    }
}