/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Vuforia
{
    /// <summary>
    /// This behaviour associates a Virtual Button with a game object. Use the
    /// functionality in ImageTargetBehaviour to create and destroy Virtual Buttons
    /// at run-time.
    /// </summary>
    public class VirtualButtonBehaviour : VirtualButtonAbstractBehaviour
    {
		public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) { 


			Application.LoadLevel (0);

			Debug.Log("button Pressed");

		}

		/// <summary>
		/// Called when the virtual button has just been released:
		/// </summary>
		public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) { 



		}
    }
}
