﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour {

     Resolution res;
     
     void Start()
     {
         res = Screen.currentResolution;
         if(res.refreshRate == 60)
             QualitySettings.vSyncCount = 1;
         if(res.refreshRate == 120)
             QualitySettings.vSyncCount = 2;
         print (QualitySettings.vSyncCount);
     }

     	
	// Update is called once per frame
	void Update () {
		
	}
}
