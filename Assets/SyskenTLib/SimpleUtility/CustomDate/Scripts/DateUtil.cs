using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SyskenTLib.SimpleUtility.CustomDate
{
    public class DateUtil 
    {
        public static string NowToText()
        {
            DateTime nowTime = DateTime.Now;
            return nowTime.ToString( "yyyyMMddHHmmss" );
        }
        
        public static string NowUtcToText()
        {
            DateTime nowTime = DateTime.UtcNow;
            return nowTime.ToString( "yyyyMMddHHmmss" );
        }
    }
}
