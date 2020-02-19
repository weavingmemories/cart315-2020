﻿using System;
using System.Collections.Generic;
using UnityEngine;
public class CameraController : MonoBehaviour
{
    [Serializable]
    public class CameraShortcut
    {
        public Camera camera;
        public KeyCode key;
    }
    public List<CameraShortcut> cameraShortcuts = new List<CameraShortcut>();
    private void Update()
    {
        foreach (CameraShortcut cs in cameraShortcuts)
        {
            if (Input.GetKey(cs.key))
            {
                foreach (CameraShortcut cs2 in cameraShortcuts)
                    cs2.camera.enabled = cs2.camera == cs.camera;
                break;
            }
        }
    }
}