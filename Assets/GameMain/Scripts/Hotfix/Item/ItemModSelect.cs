﻿using System;
using UnityEngine;
using UnityEngine.UI;
using UnityGameFramework.Runtime;
using GameEntry = GameMain.Runtime.GameEntry;

namespace Hotfix
{
    public class ItemModSelect : ItemLogic
    {
        private EquipmentForm _equipmentForm;
        public int modId;
        public Mod mod;
        public Button selectButton;
        public RawImage modImage;
        
        protected override void OnInit(object userData)
        {
            base.OnInit(userData);
            selectButton.onClick.RemoveAllListeners();
            selectButton.onClick.AddListener((() =>
            {
                GameEntry.Sound.PlayUISound(10001);
                GameEntry.Event.Fire(this,ShowWeaponModEventArgs.Create(mod, modId, _equipmentForm.showedWeapon.Id));
                GameEntry.Event.Fire(this,HideAllSelectButtonEventArgs.Create());
            }));
        }

        protected override void OnShow(object userData)
        {
            base.OnShow(userData);
            _equipmentForm = GameEntry.UI.GetUIForm(UIFormId.EquipmentForm) as EquipmentForm;
            if (userData is not WeaponModData data)
            {
                mod = userData is Mod mod1 ? mod1 : Mod.None;
                modImage.color = Color.clear;
                selectButton.onClick.RemoveAllListeners();
                selectButton.onClick.AddListener((() =>
                {
                    GameEntry.Event.Fire(this,HideItemModUIEventArgs.Create(mod));
                    GameEntry.Event.Fire(this,HideAllSelectButtonEventArgs.Create());
                }));
                return;
            }
            mod = data.ModType;
            modId = data.TypeId;
        }

        protected override void OnHide(bool isShutdown, object userData)
        {
            base.OnHide(isShutdown, userData);
        }

        protected override void OnUpdate(float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(elapseSeconds, realElapseSeconds);
        }
        
    }
}