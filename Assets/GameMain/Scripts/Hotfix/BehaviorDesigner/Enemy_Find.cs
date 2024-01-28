﻿using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using GameMain.Runtime;
using UnityEngine;

namespace Hotfix
{
    public class Enemy_Find : Action
    {
        public SharedInt soundId;
        public Enemy enemy;
        public override void OnStart()
        {
            enemy = GetComponent<Enemy>();
            GameEntry.Sound.PlaySound(10009,"Enemy");
        }

        public override TaskStatus OnUpdate()
        {
            return TaskStatus.Success;
        }
    }
}