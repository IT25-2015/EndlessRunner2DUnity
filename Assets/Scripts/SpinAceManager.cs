using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpinAceManager
{
    public class SpinAceManager : MonoBehaviour
    {
      public static PlayerManager playerManager
        {
            get
            {
                if(playerManager != null)
                {
                    return playerManager;
                }
                
                return null;
            }
            set
            {
                playerManager = value;
            }
        }
            
    }
}

