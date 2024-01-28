﻿﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using GameFramework.DataTable;
using System;
using System.Collections.Generic;
using GameMain.Runtime;
using UnityEngine;

namespace Hotfix
{
    [Serializable]
    public class WeaponData : AccessoryObjectData
    {
        [SerializeField]
        private string m_WeaponName;
        
        /// <summary>
        /// 玩家数据耐久度
        /// </summary>
        [SerializeField]
        private float m_Durability;

        [SerializeField]
        private float m_Weight = 0f;
        
        [SerializeField]
        private int m_Ergonomics;
        
        [SerializeField]
        private float m_Precision;
        
        [SerializeField]
        private int m_ShootingGallery;
        
        [SerializeField]
        private int m_VerticalRecoil;
        
        [SerializeField]
        private int m_HorizontalRecoil;
        
        [SerializeField]
        private int m_MuzzleVelocity;
        
        [SerializeField]
        private string m_FiringMode;
        
        [SerializeField]
        private string m_Caliber;
        
        [SerializeField]
        private int m_FiringRate;
        
        [SerializeField]
        private int m_EffectiveFiringRange;

        [SerializeField] 
        private List<FireMode> _FireMode;

        [SerializeField] 
        private List<Mod> _nextMods;

        public SerializableDictionary<Mod,int> weaponModId;

        public WeaponData(int entityId, int typeId, int ownerId, CampType ownerCamp)
            : base(entityId, typeId, ownerId, ownerCamp)
        {
            IDataTable<DRWeapon> dtWeapon = GameEntry.DataTable.GetDataTable<DRWeapon>();
            DRWeapon drWeapon = dtWeapon.GetDataRow(TypeId);
            if (drWeapon == null)
            {
                return;
            }

            m_WeaponName = drWeapon.WeaponName;
            m_Weight = drWeapon.Weight;
            m_Ergonomics = drWeapon.Ergonomics;
            m_Precision = drWeapon.Precision;
            m_ShootingGallery = drWeapon.ShootingGallery;
            m_VerticalRecoil = drWeapon.VerticalRecoil;
            m_HorizontalRecoil = drWeapon.HorizontalRecoil;
            m_MuzzleVelocity = drWeapon.MuzzleVelocity;
            m_FiringMode = drWeapon.FiringMode;
            m_Caliber = drWeapon.Caliber;
            m_FiringRate = drWeapon.FiringRate;
            m_EffectiveFiringRange = drWeapon.EffectiveFiringRange;

            _nextMods = new List<Mod>();
            var modName="";
            for (var index = 0; index<5 && (modName = drWeapon.GetNextModTypeAt(index)) != "None"; index++)
            {
                var modType=(Mod)Enum.Parse(typeof(Mod),modName);
                _nextMods.Add(modType);
            }

            _FireMode = new List<FireMode>();
            switch (m_FiringMode)
            {
                case "单发，全自动":
                    _FireMode.Add(FireMode.Single);
                    _FireMode.Add(FireMode.Auto);
                    break;
                case "单发":
                    _FireMode.Add(FireMode.Single);
                    break;
                case "半自动":
                    _FireMode.Add(FireMode.SemiAuto);
                    break;
                case "栓动式":
                    _FireMode.Add(FireMode.BoltAction);
                    break;
            }
        }

        public string WeaponName => m_WeaponName;

        public float Durability => m_Durability;

        public float Weight => m_Weight;

        public int Ergonomics => m_Ergonomics;

        public float Precision => m_Precision;

        public int ShootingGallery => m_ShootingGallery;

        public int VerticalRecoil => m_VerticalRecoil;

        public int HorizontalRecoil => m_HorizontalRecoil;

        public int MuzzleVelocity => m_MuzzleVelocity;

        public string FiringMode => m_FiringMode;

        public string Caliber => m_Caliber;

        public int FiringRate => m_FiringRate;

        public int EffectiveFiringRange => m_EffectiveFiringRange;

        public List<Mod> NextMods => _nextMods;

        public List<FireMode> WeaponFireMode => _FireMode;
    }
}