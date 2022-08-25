﻿using TMPro;
using UnityEngine;

namespace CodeBase.UI.Windows
{
    class ShopWindow : WindowBase
    {
        [SerializeField] private TextMeshProUGUI _skullText;

        protected override void Initialize() =>
            RefreshSkullText();

        protected override void SubscribeUpdates() =>
            Progress.WorldData.LootData.Changed += RefreshSkullText;

        protected override void CleanUp()
        {
            base.CleanUp();
            Progress.WorldData.LootData.Changed -= RefreshSkullText;
        }

        private void RefreshSkullText() =>
            _skullText.text = Progress.WorldData.LootData.Collected.ToString();
    }
}