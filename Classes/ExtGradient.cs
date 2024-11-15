﻿using System;
using UnityEngine;

namespace qwerty_menu.Classes
{
    public class ExtGradient
    {
        public GradientColorKey[] colors = new GradientColorKey[]
        {
            new GradientColorKey(Color.black, 0f),
            new GradientColorKey(Color.magenta, 0f),
            new GradientColorKey(Color.black, 0f)
        };

        public bool isRainbow = false;
        public bool copyRigColors = false;
    }
}
