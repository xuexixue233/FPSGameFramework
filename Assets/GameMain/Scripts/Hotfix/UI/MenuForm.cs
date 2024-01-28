﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityGameFramework.Runtime;
using GameEntry=GameMain.Runtime.GameEntry;

namespace Hotfix
{
    public class MenuForm : UGuiForm
    {
        // [SerializeField]
        // private GameObject m_QuitButton = null;

        public Button StartButton;
        public Button EquipmentButton;
        public Button QuitButton;
        public CommonButton c_StartButton;

        private void OnStartButtonClick()
        {
            GameEntry.UI.OpenUIForm(UIFormId.LevelForm);
        }

        private void OnQuitButtonClick()
        {
            GameEntry.UI.OpenDialog(new DialogParams()
            {
                Mode = 2,
                Title = GameEntry.Localization.GetString("AskQuitGame.Title"),
                Message = GameEntry.Localization.GetString("AskQuitGame.Message"),
                OnClickConfirm = delegate (object userData) { UnityGameFramework.Runtime.GameEntry.Shutdown(ShutdownType.Quit); },
            });
        }

        private void EquipmentButtonClick()
        {
            GameEntry.Event.Fire(this,ChangeSceneEventArgs.Create(3));
        }

        protected override void OnInit(object userData)
        {
            base.OnInit(userData);
            StartButton.onClick.RemoveAllListeners();
            StartButton.onClick.AddListener(() =>
            {
                PlayUISound(10001);
                OnStartButtonClick();
            });
            
            QuitButton.onClick.RemoveAllListeners();
            QuitButton.onClick.AddListener(() =>
            {
                PlayUISound(10001);
                OnQuitButtonClick();
            });
            
            EquipmentButton.onClick.RemoveAllListeners();
            EquipmentButton.onClick.AddListener(() =>
            {
                PlayUISound(10001);
                EquipmentButtonClick();
            });
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
