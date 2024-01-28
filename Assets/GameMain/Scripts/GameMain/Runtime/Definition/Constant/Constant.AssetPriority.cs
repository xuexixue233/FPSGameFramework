﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

namespace GameMain.Runtime
{
    public static partial class Constant
    {
        /// <summary>
        /// 资源优先级。
        /// </summary>
        public static class AssetPriority
        {
            public const int ConfigAsset = 100;
            public const int DataTableAsset = 100;
            public const int DictionaryAsset = 100;
            public const int FontAsset = 50;
            public const int MusicAsset = 20;
            public const int SceneAsset = 0;
            public const int SoundAsset = 30;
            public const int UIFormAsset = 50;
            public const int UISoundAsset = 30;

            public const int PlayerAsset = 90;
            public const int EnemyAsset = 80;
            public const int WeaponAsset = 30;
            public const int WeaponModAsset = 20;
            public const int EffectAsset = 70;


            public const int ItemModUIAsset = 10;
            public const int ItemModSelectAsset = 10;
        }
    }
}
