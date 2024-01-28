﻿using System;
using UnityEngine;
using UnityEngine.UI;
using UnityGameFramework.Runtime;
using GameEntry=GameMain.Runtime.GameEntry;

namespace Hotfix
{
    public class LevelForm : UGuiForm
    {
        public Button CloseButtton;
        public Button GameButton;

        private void BackMenu()
        {
            PlayUISound(10001);
            Close();
        }

        private void StartGame()
        {
            PlayUISound(10001);
            GameEntry.Event.Fire(this,ChangeSceneEventArgs.Create(2));
        }
        
        protected override void OnInit(object userData)
        {
            base.OnInit(userData);
            
            CloseButtton.onClick.RemoveAllListeners();
            CloseButtton.onClick.AddListener(BackMenu);
            
            GameButton.onClick.RemoveAllListeners();
            GameButton.onClick.AddListener(StartGame);
        }

        protected override void OnOpen(object userData)
        {
            base.OnOpen(userData);
        }

        protected override void OnClose(bool isShutdown, object userData)
        {
            base.OnClose(isShutdown, userData);
        }
    }
}