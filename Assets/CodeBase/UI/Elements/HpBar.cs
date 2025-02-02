﻿using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.UI.Elements
{
    public class HpBar : MonoBehaviour
    {
        [SerializeField] private Image _currentImage;

        public void SetValue(float current, float max)
        {
            _currentImage.fillAmount = current / max;
        }
    }
}