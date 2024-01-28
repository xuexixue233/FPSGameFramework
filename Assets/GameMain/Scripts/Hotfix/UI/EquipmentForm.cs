using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using GameFramework.Event;
using GameFramework.ObjectPool;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityGameFramework.Runtime;
using GameEntry=GameMain.Runtime.GameEntry;

namespace Hotfix
{
    public class EquipmentForm : UGuiForm
    {

        public Weapon showedWeapon;
        public GameObject attributeList;

        #region Reference

        [Header("Button")] 
        public Button backButton;
        public Button listButton;
        public Image showImage;
        public Image hideImage;

        [Header("List-Fill")] 
        public Image durabilityImage;
        public Image weightImage;
        public Image ergonomicsImage;
        public Image precisionImage;
        public Image shootingGalleryImage;
        public Image verticalRecoilImage;
        public Image horizontalRecoilImage;
        public Image muzzleVelocityImage;

        [Header("list-Text")] 
        public TMP_Text durabilityText;
        public TMP_Text weightText;
        public TMP_Text ergonomicsText;
        public TMP_Text precisionText;
        public TMP_Text shootingGalleryText;
        public TMP_Text verticalRecoilText;
        public TMP_Text horizontalRecoilText;
        public TMP_Text muzzleVelocityText;

        public TMP_Text firingModeText;
        public TMP_Text caliberText;
        public TMP_Text firingRateText;
        public TMP_Text effectiveFiringRange;
        
        public GameObject circleGameObject;
        public RectTransform previewRect;
        
        #endregion

        private void BackToMenu()
        {
            GameEntry.Event.Fire(this,ChangeSceneEventArgs.Create(1));
        }

        protected override void OnInit(object userData)
        {
            base.OnInit(userData);
            
            backButton.onClick.RemoveAllListeners();
            backButton.onClick.AddListener(BackToMenu);
            
            listButton.onClick.RemoveAllListeners();
            listButton.onClick.AddListener((() =>
            {
                attributeList.SetActive(!attributeList.activeSelf);
                showImage.gameObject.SetActive(!showImage.gameObject.activeSelf);
                hideImage.gameObject.SetActive(!hideImage.gameObject.activeSelf);
            }));
        }

        protected override void OnOpen(object userData)
        {
            base.OnOpen(userData);
            
            showedWeapon = (Weapon)userData;
            durabilityText.text = "100/100(100)";
            RefreshText();
            RefreshImage();
            foreach (var mod in showedWeapon.m_WeaponData.NextMods)
            {
                GameEntry.Event.Fire(this,ShowItemModUIEventArgs.Create(mod));
            }

            var loadingForm = GameEntry.UI.GetUIForm(UIFormId.LoadingForm);
            GameEntry.UI.CloseUIForm(loadingForm);
        }

        public void RefreshText()
        {
            weightText.text = showedWeapon.weaponAttribute.Weight.ToString(CultureInfo.InvariantCulture);
            ergonomicsText.text = showedWeapon.weaponAttribute.Ergonomics.ToString();
            precisionText.text = showedWeapon.weaponAttribute.Precision.ToString(CultureInfo.InvariantCulture);
            shootingGalleryText.text = showedWeapon.weaponAttribute.ShootingGallery.ToString();
            verticalRecoilText.text = showedWeapon.weaponAttribute.VerticalRecoil.ToString();
            horizontalRecoilText.text = showedWeapon.weaponAttribute.HorizontalRecoil.ToString();
            muzzleVelocityText.text = showedWeapon.weaponAttribute.MuzzleVelocity.ToString();
            
            firingModeText.text = showedWeapon.weaponAttribute.FiringMode;
            caliberText.text = showedWeapon.weaponAttribute.Caliber;
            firingRateText.text = showedWeapon.weaponAttribute.FiringRate.ToString();
            effectiveFiringRange.text = showedWeapon.weaponAttribute.EffectiveFiringRange.ToString();
        }

        public void RefreshImage()
        {
            weightImage.fillAmount = showedWeapon.weaponAttribute.Weight / 20;
            ergonomicsImage.fillAmount = (float)showedWeapon.weaponAttribute.Ergonomics / 100;
            precisionImage.fillAmount = 1-showedWeapon.weaponAttribute.Precision / 50;
            shootingGalleryImage.fillAmount = (float)showedWeapon.weaponAttribute.ShootingGallery / 10000;
            verticalRecoilImage.fillAmount = (float)showedWeapon.weaponAttribute.VerticalRecoil / 500;
            horizontalRecoilImage.fillAmount = (float)showedWeapon.weaponAttribute.HorizontalRecoil / 500;
            muzzleVelocityImage.fillAmount = (float)showedWeapon.weaponAttribute.MuzzleVelocity / 2000;
        }

        protected override void OnClose(bool isShutdown, object userData)
        {
            base.OnClose(isShutdown, userData);
            
        }
        
    }
}
