﻿using BehaviorDesigner.Runtime;
using GameMain.Runtime;
using UnityEngine;

namespace Hotfix
{
    public class Enemy : Soldier
    {
        public BehaviorTree _behaviorTree;
        public EnemyData enemyData;
        public int Attack=10;
        public bool isSpeak = false;
        public int soundId;
        protected override void OnInit(object userData)
        {
            base.OnInit(userData);
            _behaviorTree=gameObject.GetComponent<BehaviorTree>();
        }

        private void InitBehaviorTree()
        {
            _behaviorTree.GetVariable("ViewDistance").SetValue(enemyData.ViewDistance);
            _behaviorTree.GetVariable("FieldOfViewAngle").SetValue(enemyData.FieldOfViewAngle);
            _behaviorTree.GetVariable("WaitMinTime").SetValue(enemyData.WaitMinTime);
            _behaviorTree.GetVariable("WaitMaxTime").SetValue(enemyData.WaitMaxTime);
            _behaviorTree.GetVariable("AttackInterval").SetValue(enemyData.AttackInterval);
        }

        protected override void OnShow(object userData)
        {
            base.OnShow(userData);
            enemyData = userData as EnemyData;
            if (enemyData==null)
            {
                return;
            }
            //启动行为树
            InitBehaviorTree();
            _behaviorTree.EnableBehavior();
            gameObject.SetLayerRecursively(Constant.Layer.EnemyLayerId);
            enemyData.HP = 100;
        }

        public override void ApplyDamage(Entity attacker, int damageHP)
        {
            GameEntry.Sound.PlaySound(10008,"Enemy");
            soundId = 10008;
            enemyData.HP -= damageHP;
            if (enemyData.HP<=0)
            {
                GameEntry.Event.Fire(this,EnemyDeadEventArgs.Create(this));
                OnDead(attacker);
            }
        }

        protected override void OnDead(Entity attacker)
        {
            GameEntry.Sound.PlaySound(10007,"Enemy");
            
            _behaviorTree.OnDestroy();
            base.OnDead(attacker);
        }

        public void ShootSuccess(GameObject target)
        {
            var player = target.GetComponentInParent<Player>();
            if (player==null)
            {
                return;
            }
            AIUtility.AttackCollision(this,player,Attack);
        }

        protected override void OnHide(bool isShutdown, object userData)
        {
            base.OnHide(isShutdown, userData);
        }
    }
}