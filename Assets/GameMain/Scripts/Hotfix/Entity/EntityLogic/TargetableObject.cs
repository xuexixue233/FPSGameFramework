﻿using GameMain.Runtime;
using UnityEngine;
using UnityGameFramework.Runtime;
using GameEntry = GameMain.Runtime.GameEntry;

namespace Hotfix
{
    public abstract class TargetableObject : Entity
    {
        [SerializeField]
        private TargetableObjectData m_TargetableObjectData = null;
        
        public abstract ImpactData GetImpactData();
        
        public bool IsDead
        {
            get
            {
                return m_TargetableObjectData.HP <= 0;
            }
        }
        public virtual void ApplyDamage(Entity attacker, int damageHP)
        {
            
        }

        protected override void OnInit(object userData)
        {
            base.OnInit(userData);
            gameObject.SetLayerRecursively(Constant.Layer.TargetableObjectLayerId);
        }

        protected override void OnShow(object userData)
        {
            base.OnShow(userData);
            m_TargetableObjectData = userData as TargetableObjectData;
            if (m_TargetableObjectData == null)
            {
                Log.Error("Targetable object data is invalid.");
                return;
            }
        }

        protected virtual void OnDead(Entity attacker)
        {
            GameEntry.Entity.HideEntity(this);
        }
        
        private void OnTriggerEnter(Collider other)
        {
            
        }
    }
}