//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using UnityEngine;
using UnityGameFramework.Runtime;

namespace GameMain.Runtime
{
    /// <summary>
    /// 游戏入口。
    /// </summary>
    public partial class GameEntry : MonoBehaviour
    {

        public static BuiltinDataComponent BuiltinData
        {
            get;
            private set;
        }
        
        public static ItemComponent Item
        {
            get;
            private set;
        }
        
        
        private static void InitCustomComponents()
        {
            BuiltinData = UnityGameFramework.Runtime.GameEntry.GetComponent<BuiltinDataComponent>();
            Item=UnityGameFramework.Runtime.GameEntry.GetComponent<ItemComponent>();
        }
    }
}
