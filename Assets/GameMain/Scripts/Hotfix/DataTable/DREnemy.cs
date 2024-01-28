﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：2023-11-05 15:46:29.108
//------------------------------------------------------------

using GameFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace Hotfix
{
    /// <summary>
    /// 敌人表。
    /// </summary>
    public class DREnemy : DataRowBase
    {
        private int m_Id = 0;

        /// <summary>
        /// 获取敌人编号。
        /// </summary>
        public override int Id
        {
            get
            {
                return m_Id;
            }
        }

        /// <summary>
        /// 获取视线距离。
        /// </summary>
        public float ViewDistance
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取视野范围。
        /// </summary>
        public float FieldOfViewAngle
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取反应最小时间。
        /// </summary>
        public float WaitMinTime
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取反应最大时间时间。
        /// </summary>
        public float WaitMaxTime
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取攻击力。
        /// </summary>
        public int Attack
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取攻击间隔。
        /// </summary>
        public float AttackInterval
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取巡逻视线角度。
        /// </summary>
        public float PatrolViewAngle
        {
            get;
            private set;
        }

        public override bool ParseDataRow(string dataRowString, object userData)
        {
            string[] columnStrings = dataRowString.Split(DataTableExtension.DataSplitSeparators);
            for (int i = 0; i < columnStrings.Length; i++)
            {
                columnStrings[i] = columnStrings[i].Trim(DataTableExtension.DataTrimSeparators);
            }

            int index = 0;
            index++;
            m_Id = int.Parse(columnStrings[index++]);
            index++;
            ViewDistance = float.Parse(columnStrings[index++]);
            FieldOfViewAngle = float.Parse(columnStrings[index++]);
            WaitMinTime = float.Parse(columnStrings[index++]);
            WaitMaxTime = float.Parse(columnStrings[index++]);
            Attack = int.Parse(columnStrings[index++]);
            AttackInterval = float.Parse(columnStrings[index++]);
            PatrolViewAngle = float.Parse(columnStrings[index++]);

            GeneratePropertyArray();
            return true;
        }

        public override bool ParseDataRow(byte[] dataRowBytes, int startIndex, int length, object userData)
        {
            using (MemoryStream memoryStream = new MemoryStream(dataRowBytes, startIndex, length, false))
            {
                using (BinaryReader binaryReader = new BinaryReader(memoryStream, Encoding.UTF8))
                {
                    m_Id = binaryReader.Read7BitEncodedInt32();
                    ViewDistance = binaryReader.ReadSingle();
                    FieldOfViewAngle = binaryReader.ReadSingle();
                    WaitMinTime = binaryReader.ReadSingle();
                    WaitMaxTime = binaryReader.ReadSingle();
                    Attack = binaryReader.Read7BitEncodedInt32();
                    AttackInterval = binaryReader.ReadSingle();
                    PatrolViewAngle = binaryReader.ReadSingle();
                }
            }

            GeneratePropertyArray();
            return true;
        }

        private void GeneratePropertyArray()
        {

        }
    }
}
