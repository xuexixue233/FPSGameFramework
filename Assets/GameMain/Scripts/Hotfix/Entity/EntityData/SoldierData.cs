﻿using System;
using System.Collections.Generic;
using GameFramework.DataTable;
using GameMain.Runtime;
using UnityEngine;

namespace Hotfix
{
    [Serializable]
    public abstract class SoldierData : TargetableObjectData
    {
        [SerializeField]
        protected List<WeaponData> m_WeaponDatas = new List<WeaponData>();
        
        [SerializeField]
        protected int m_MaxHP = 100;
        
        [SerializeField]
        protected float m_WalkingForwardSpeed = 0;
        
        [SerializeField]
        protected float m_WalkingBackSpeed = 0;
        
        [SerializeField]
        protected float m_WalkingStrafeSpeed = 0;
        
        [SerializeField]
        protected float m_RunningForwardSpeed = 0;
        
        [SerializeField]
        protected float m_RunningStrafeSpeed = 0;
        
        [SerializeField]
        protected int m_DeadEffectId = 0;

        [SerializeField]
        protected int m_DeadSoundId = 0;
        
        protected SoldierData(int entityId, int typeId, CampType camp) : base(entityId, typeId, camp)
        {
            IDataTable<DRSoldier> dtSoldier = GameEntry.DataTable.GetDataTable<DRSoldier>();
            DRSoldier drSoldier = dtSoldier.GetDataRow(TypeId);
            if (drSoldier == null)
            {
                return;
            }
            
            for (int index = 0, weaponId = 0; (weaponId = drSoldier.GetWeaponIdAt(index)) > 0; index++)
            {
                AttachWeaponData(new WeaponData(GameEntry.Entity.GenerateSerialId(), weaponId, Id, Camp));
            }

            m_WalkingForwardSpeed = drSoldier.WalkingForwardSpeed;
            m_WalkingBackSpeed = drSoldier.WalkingBackSpeed;
            m_WalkingStrafeSpeed = drSoldier.WalkingStrafeSpeed;
            m_RunningForwardSpeed = drSoldier.RunningForwardSpeed;
            m_RunningStrafeSpeed = drSoldier.RunningStrafeSpeed;
            
            m_DeadEffectId = drSoldier.DeadEffectId;
            m_DeadSoundId = drSoldier.DeadSoundId;

            HP = m_MaxHP;
        }
        
        /// <summary>
        /// 最大生命。
        /// </summary>
        public override int MaxHP => m_MaxHP;

        public float WalkingForwardSpeed => m_WalkingForwardSpeed;

        public float WalkingBackSpeed => m_WalkingBackSpeed;

        public float WalkingStrafeSpeed => m_WalkingStrafeSpeed;

        public float RunningForwardSpeed => m_RunningForwardSpeed;

        public float RunningStrafeSpeed => m_RunningStrafeSpeed;

        public int DeadEffectId => m_DeadEffectId;

        public int DeadSoundId => m_DeadSoundId;

        public List<WeaponData> GetAllWeaponDatas()
        {
            return m_WeaponDatas;
        }
        
        public void AttachWeaponData(WeaponData weaponData)
        {
            if (weaponData == null)
            {
                return;
            }

            if (m_WeaponDatas.Contains(weaponData))
            {
                return;
            }

            m_WeaponDatas.Add(weaponData);
        }

        public void DetachWeaponData(WeaponData weaponData)
        {
            if (weaponData == null)
            {
                return;
            }

            m_WeaponDatas.Remove(weaponData);
        }
        
        private void RefreshData()
        {
            m_MaxHP = 100;

            if (HP > m_MaxHP)
            {
                HP = m_MaxHP;
            }
        }
    }
}