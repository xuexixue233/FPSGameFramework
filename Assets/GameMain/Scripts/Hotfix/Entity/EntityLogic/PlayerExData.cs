﻿using UnityEngine;

namespace Hotfix
{
    public class PlayerExData : SoldierExData
    {
        public Transform modelTransform;
        public Transform cameraHolder;
        public Transform cameraTransform;
        public Scr_Models.PlayerSettingModel playerSetting;
        public LayerMask playerMask;
        public LayerMask groundMask;
    }
}