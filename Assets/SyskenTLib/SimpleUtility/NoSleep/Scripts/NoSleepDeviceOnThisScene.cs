using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SyskenTLib.SimpleUtility.NoSleep
{
    public class NoSleepDeviceOnThisScene : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            TurnOffSleeFunction();
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void OnDestroy()
        {
            TurnOnSleeFunction();
        }


        private void TurnOffSleeFunction()
        {
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
        }
        
        private void TurnOnSleeFunction()
        {
            Screen.sleepTimeout = SleepTimeout.SystemSetting;
        }
    }
}
