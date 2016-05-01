﻿using UnityEngine;
using System;

namespace NewtonPlugin
{
    [DisallowMultipleComponent]
    [AddComponentMenu("Newton Physics/Newton World")]
    public class NewtonWorld : MonoBehaviour
    {
        private dNewtonWorld m_world;

        void Start()
        {
            m_world = new dNewtonWorld();
        }

        void OnDestroy()
        {
            m_world.Dispose();
        }
    }
}

