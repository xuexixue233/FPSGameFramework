using System.Collections.Generic;
using GameFramework.Fsm;
using GameFramework.Procedure;
using System.Reflection;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace GameMain.Runtime
{
    public class ProcedureHotfix : ProcedureBase
    {
        public override bool UseNativeDialog => true;
        
        private bool m_LoadAssemblyComplete;
        private bool m_LoadMetadataAssemblyComplete;

        public static string HotfixDllName => "Hotfix";

        public static List<string> AotDllName = new List<string>()
        {
            ""
        };
        
        private Assembly m_HotfixAssembly;
        
        private List<Assembly> m_MetadataAssembly;

        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);
        }

        protected override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        }

        protected override void OnLeave(IFsm<IProcedureManager> procedureOwner, bool isShutdown)
        {
            base.OnLeave(procedureOwner, isShutdown);
        }
    }
}

