using System.Collections.Generic;
public class AOTGenericReferences : UnityEngine.MonoBehaviour
{

	// {{ AOT assemblies
	public static readonly IReadOnlyList<string> PatchedAOTAssemblyList = new List<string>
	{
		"BehaviorDesigner.Runtime.dll",
		"DOTween.dll",
		"GameFramework.dll",
		"LitJson.dll",
		"System.Core.dll",
		"Unity.InputSystem.dll",
		"UnityEngine.CoreModule.dll",
		"UnityGameFramework.Runtime.dll",
		"mscorlib.dll",
	};
	// }}

	// {{ constraint implement type
	// }} 

	// {{ AOT generic types
	// BehaviorDesigner.Runtime.SharedVariable<float>
	// BehaviorDesigner.Runtime.SharedVariable<object>
	// DG.Tweening.Core.DOGetter<float>
	// DG.Tweening.Core.DOSetter<float>
	// GameFramework.DataTable.IDataTable<object>
	// GameFramework.Fsm.Fsm<object>
	// GameFramework.Fsm.FsmState<object>
	// GameFramework.Fsm.IFsm<object>
	// GameFramework.GameFrameworkAction<object>
	// System.Action<SerializableDictionary.SerializableKeyValuePair<int,int>>
	// System.Action<SerializableDictionary.SerializableKeyValuePair<int,object>>
	// System.Action<SerializableDictionary.SerializableKeyValuePair<object,object>>
	// System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>
	// System.Action<byte>
	// System.Action<float>
	// System.Action<int>
	// System.Action<object>
	// System.Collections.Generic.ArraySortHelper<SerializableDictionary.SerializableKeyValuePair<int,int>>
	// System.Collections.Generic.ArraySortHelper<SerializableDictionary.SerializableKeyValuePair<int,object>>
	// System.Collections.Generic.ArraySortHelper<SerializableDictionary.SerializableKeyValuePair<object,object>>
	// System.Collections.Generic.ArraySortHelper<byte>
	// System.Collections.Generic.ArraySortHelper<int>
	// System.Collections.Generic.ArraySortHelper<object>
	// System.Collections.Generic.Comparer<SerializableDictionary.SerializableKeyValuePair<int,int>>
	// System.Collections.Generic.Comparer<SerializableDictionary.SerializableKeyValuePair<int,object>>
	// System.Collections.Generic.Comparer<SerializableDictionary.SerializableKeyValuePair<object,object>>
	// System.Collections.Generic.Comparer<byte>
	// System.Collections.Generic.Comparer<int>
	// System.Collections.Generic.Comparer<object>
	// System.Collections.Generic.Dictionary.Enumerator<Hotfix.AIUtility.CampPair,byte>
	// System.Collections.Generic.Dictionary.Enumerator<System.Collections.Generic.KeyValuePair<byte,byte>,object>
	// System.Collections.Generic.Dictionary.Enumerator<int,int>
	// System.Collections.Generic.Dictionary.Enumerator<int,object>
	// System.Collections.Generic.Dictionary.Enumerator<object,byte>
	// System.Collections.Generic.Dictionary.Enumerator<object,int>
	// System.Collections.Generic.Dictionary.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<Hotfix.AIUtility.CampPair,byte>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<System.Collections.Generic.KeyValuePair<byte,byte>,object>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<int,int>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<int,object>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<object,byte>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<object,int>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.KeyCollection<Hotfix.AIUtility.CampPair,byte>
	// System.Collections.Generic.Dictionary.KeyCollection<System.Collections.Generic.KeyValuePair<byte,byte>,object>
	// System.Collections.Generic.Dictionary.KeyCollection<int,int>
	// System.Collections.Generic.Dictionary.KeyCollection<int,object>
	// System.Collections.Generic.Dictionary.KeyCollection<object,byte>
	// System.Collections.Generic.Dictionary.KeyCollection<object,int>
	// System.Collections.Generic.Dictionary.KeyCollection<object,object>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<Hotfix.AIUtility.CampPair,byte>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<System.Collections.Generic.KeyValuePair<byte,byte>,object>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<int,int>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<int,object>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<object,byte>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<object,int>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.ValueCollection<Hotfix.AIUtility.CampPair,byte>
	// System.Collections.Generic.Dictionary.ValueCollection<System.Collections.Generic.KeyValuePair<byte,byte>,object>
	// System.Collections.Generic.Dictionary.ValueCollection<int,int>
	// System.Collections.Generic.Dictionary.ValueCollection<int,object>
	// System.Collections.Generic.Dictionary.ValueCollection<object,byte>
	// System.Collections.Generic.Dictionary.ValueCollection<object,int>
	// System.Collections.Generic.Dictionary.ValueCollection<object,object>
	// System.Collections.Generic.Dictionary<Hotfix.AIUtility.CampPair,byte>
	// System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<byte,byte>,object>
	// System.Collections.Generic.Dictionary<int,int>
	// System.Collections.Generic.Dictionary<int,object>
	// System.Collections.Generic.Dictionary<object,byte>
	// System.Collections.Generic.Dictionary<object,int>
	// System.Collections.Generic.Dictionary<object,object>
	// System.Collections.Generic.EqualityComparer<Hotfix.AIUtility.CampPair>
	// System.Collections.Generic.EqualityComparer<System.Collections.Generic.KeyValuePair<byte,byte>>
	// System.Collections.Generic.EqualityComparer<byte>
	// System.Collections.Generic.EqualityComparer<int>
	// System.Collections.Generic.EqualityComparer<object>
	// System.Collections.Generic.ICollection<SerializableDictionary.SerializableKeyValuePair<int,int>>
	// System.Collections.Generic.ICollection<SerializableDictionary.SerializableKeyValuePair<int,object>>
	// System.Collections.Generic.ICollection<SerializableDictionary.SerializableKeyValuePair<object,object>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<Hotfix.AIUtility.CampPair,byte>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.Collections.Generic.KeyValuePair<byte,byte>,object>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<int,int>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<int,object>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object,byte>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object,int>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.ICollection<byte>
	// System.Collections.Generic.ICollection<int>
	// System.Collections.Generic.ICollection<object>
	// System.Collections.Generic.IComparer<SerializableDictionary.SerializableKeyValuePair<int,int>>
	// System.Collections.Generic.IComparer<SerializableDictionary.SerializableKeyValuePair<int,object>>
	// System.Collections.Generic.IComparer<SerializableDictionary.SerializableKeyValuePair<object,object>>
	// System.Collections.Generic.IComparer<byte>
	// System.Collections.Generic.IComparer<int>
	// System.Collections.Generic.IComparer<object>
	// System.Collections.Generic.IDictionary<object,LitJson.ArrayMetadata>
	// System.Collections.Generic.IDictionary<object,LitJson.ObjectMetadata>
	// System.Collections.Generic.IDictionary<object,LitJson.PropertyMetadata>
	// System.Collections.Generic.IDictionary<object,object>
	// System.Collections.Generic.IEnumerable<SerializableDictionary.SerializableKeyValuePair<int,int>>
	// System.Collections.Generic.IEnumerable<SerializableDictionary.SerializableKeyValuePair<int,object>>
	// System.Collections.Generic.IEnumerable<SerializableDictionary.SerializableKeyValuePair<object,object>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Hotfix.AIUtility.CampPair,byte>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Collections.Generic.KeyValuePair<byte,byte>,object>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int,int>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int,object>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,byte>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,int>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.IEnumerable<byte>
	// System.Collections.Generic.IEnumerable<int>
	// System.Collections.Generic.IEnumerable<object>
	// System.Collections.Generic.IEnumerator<SerializableDictionary.SerializableKeyValuePair<int,int>>
	// System.Collections.Generic.IEnumerator<SerializableDictionary.SerializableKeyValuePair<int,object>>
	// System.Collections.Generic.IEnumerator<SerializableDictionary.SerializableKeyValuePair<object,object>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<Hotfix.AIUtility.CampPair,byte>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Collections.Generic.KeyValuePair<byte,byte>,object>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<int,int>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<int,object>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object,byte>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object,int>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.IEnumerator<byte>
	// System.Collections.Generic.IEnumerator<int>
	// System.Collections.Generic.IEnumerator<object>
	// System.Collections.Generic.IEqualityComparer<Hotfix.AIUtility.CampPair>
	// System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<byte,byte>>
	// System.Collections.Generic.IEqualityComparer<int>
	// System.Collections.Generic.IEqualityComparer<object>
	// System.Collections.Generic.IList<SerializableDictionary.SerializableKeyValuePair<int,int>>
	// System.Collections.Generic.IList<SerializableDictionary.SerializableKeyValuePair<int,object>>
	// System.Collections.Generic.IList<SerializableDictionary.SerializableKeyValuePair<object,object>>
	// System.Collections.Generic.IList<byte>
	// System.Collections.Generic.IList<int>
	// System.Collections.Generic.IList<object>
	// System.Collections.Generic.KeyValuePair<Hotfix.AIUtility.CampPair,byte>
	// System.Collections.Generic.KeyValuePair<System.Collections.Generic.KeyValuePair<byte,byte>,object>
	// System.Collections.Generic.KeyValuePair<byte,byte>
	// System.Collections.Generic.KeyValuePair<int,int>
	// System.Collections.Generic.KeyValuePair<int,object>
	// System.Collections.Generic.KeyValuePair<object,byte>
	// System.Collections.Generic.KeyValuePair<object,int>
	// System.Collections.Generic.KeyValuePair<object,object>
	// System.Collections.Generic.List.Enumerator<SerializableDictionary.SerializableKeyValuePair<int,int>>
	// System.Collections.Generic.List.Enumerator<SerializableDictionary.SerializableKeyValuePair<int,object>>
	// System.Collections.Generic.List.Enumerator<SerializableDictionary.SerializableKeyValuePair<object,object>>
	// System.Collections.Generic.List.Enumerator<byte>
	// System.Collections.Generic.List.Enumerator<int>
	// System.Collections.Generic.List.Enumerator<object>
	// System.Collections.Generic.List<SerializableDictionary.SerializableKeyValuePair<int,int>>
	// System.Collections.Generic.List<SerializableDictionary.SerializableKeyValuePair<int,object>>
	// System.Collections.Generic.List<SerializableDictionary.SerializableKeyValuePair<object,object>>
	// System.Collections.Generic.List<byte>
	// System.Collections.Generic.List<int>
	// System.Collections.Generic.List<object>
	// System.Collections.Generic.ObjectComparer<SerializableDictionary.SerializableKeyValuePair<int,int>>
	// System.Collections.Generic.ObjectComparer<SerializableDictionary.SerializableKeyValuePair<int,object>>
	// System.Collections.Generic.ObjectComparer<SerializableDictionary.SerializableKeyValuePair<object,object>>
	// System.Collections.Generic.ObjectComparer<byte>
	// System.Collections.Generic.ObjectComparer<int>
	// System.Collections.Generic.ObjectComparer<object>
	// System.Collections.Generic.ObjectEqualityComparer<Hotfix.AIUtility.CampPair>
	// System.Collections.Generic.ObjectEqualityComparer<System.Collections.Generic.KeyValuePair<byte,byte>>
	// System.Collections.Generic.ObjectEqualityComparer<byte>
	// System.Collections.Generic.ObjectEqualityComparer<int>
	// System.Collections.Generic.ObjectEqualityComparer<object>
	// System.Collections.Generic.Queue.Enumerator<object>
	// System.Collections.Generic.Queue<object>
	// System.Collections.ObjectModel.ReadOnlyCollection<SerializableDictionary.SerializableKeyValuePair<int,int>>
	// System.Collections.ObjectModel.ReadOnlyCollection<SerializableDictionary.SerializableKeyValuePair<int,object>>
	// System.Collections.ObjectModel.ReadOnlyCollection<SerializableDictionary.SerializableKeyValuePair<object,object>>
	// System.Collections.ObjectModel.ReadOnlyCollection<byte>
	// System.Collections.ObjectModel.ReadOnlyCollection<int>
	// System.Collections.ObjectModel.ReadOnlyCollection<object>
	// System.Comparison<SerializableDictionary.SerializableKeyValuePair<int,int>>
	// System.Comparison<SerializableDictionary.SerializableKeyValuePair<int,object>>
	// System.Comparison<SerializableDictionary.SerializableKeyValuePair<object,object>>
	// System.Comparison<byte>
	// System.Comparison<int>
	// System.Comparison<object>
	// System.EventHandler<object>
	// System.Func<SerializableDictionary.SerializableKeyValuePair<int,int>,System.Collections.Generic.KeyValuePair<int,int>>
	// System.Func<SerializableDictionary.SerializableKeyValuePair<int,int>,int>
	// System.Func<SerializableDictionary.SerializableKeyValuePair<int,object>,System.Collections.Generic.KeyValuePair<int,object>>
	// System.Func<SerializableDictionary.SerializableKeyValuePair<int,object>,int>
	// System.Func<SerializableDictionary.SerializableKeyValuePair<int,object>,object>
	// System.Func<SerializableDictionary.SerializableKeyValuePair<object,object>,System.Collections.Generic.KeyValuePair<object,object>>
	// System.Func<SerializableDictionary.SerializableKeyValuePair<object,object>,byte>
	// System.Func<SerializableDictionary.SerializableKeyValuePair<object,object>,object>
	// System.Func<System.Collections.Generic.KeyValuePair<object,object>,byte>
	// System.Func<float>
	// System.Func<object,byte>
	// System.Func<object,object>
	// System.Func<object>
	// System.Lazy<object>
	// System.Linq.Buffer<object>
	// System.Linq.Enumerable.Iterator<SerializableDictionary.SerializableKeyValuePair<object,object>>
	// System.Linq.Enumerable.Iterator<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Linq.Enumerable.Iterator<object>
	// System.Linq.Enumerable.WhereEnumerableIterator<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Linq.Enumerable.WhereEnumerableIterator<object>
	// System.Linq.Enumerable.WhereSelectArrayIterator<SerializableDictionary.SerializableKeyValuePair<object,object>,System.Collections.Generic.KeyValuePair<object,object>>
	// System.Linq.Enumerable.WhereSelectArrayIterator<SerializableDictionary.SerializableKeyValuePair<object,object>,object>
	// System.Linq.Enumerable.WhereSelectArrayIterator<object,object>
	// System.Linq.Enumerable.WhereSelectEnumerableIterator<SerializableDictionary.SerializableKeyValuePair<object,object>,System.Collections.Generic.KeyValuePair<object,object>>
	// System.Linq.Enumerable.WhereSelectEnumerableIterator<SerializableDictionary.SerializableKeyValuePair<object,object>,object>
	// System.Linq.Enumerable.WhereSelectEnumerableIterator<object,object>
	// System.Linq.Enumerable.WhereSelectListIterator<SerializableDictionary.SerializableKeyValuePair<object,object>,System.Collections.Generic.KeyValuePair<object,object>>
	// System.Linq.Enumerable.WhereSelectListIterator<SerializableDictionary.SerializableKeyValuePair<object,object>,object>
	// System.Linq.Enumerable.WhereSelectListIterator<object,object>
	// System.Nullable<int>
	// System.Predicate<SerializableDictionary.SerializableKeyValuePair<int,int>>
	// System.Predicate<SerializableDictionary.SerializableKeyValuePair<int,object>>
	// System.Predicate<SerializableDictionary.SerializableKeyValuePair<object,object>>
	// System.Predicate<byte>
	// System.Predicate<int>
	// System.Predicate<object>
	// System.Runtime.CompilerServices.ConditionalWeakTable.CreateValueCallback<object,object>
	// System.Runtime.CompilerServices.ConditionalWeakTable.Enumerator<object,object>
	// System.Runtime.CompilerServices.ConditionalWeakTable<object,object>
	// UnityEngine.InputSystem.InputBindingComposite<UnityEngine.Vector2>
	// UnityEngine.InputSystem.InputControl<UnityEngine.Vector2>
	// UnityEngine.InputSystem.InputProcessor<UnityEngine.Vector2>
	// UnityEngine.InputSystem.Utilities.InlinedArray<object>
	// }}

	public void RefMethods()
	{
		// object BehaviorDesigner.Runtime.Tasks.Task.GetComponent<object>()
		// object DG.Tweening.TweenSettingsExtensions.From<object>(object)
		// object DG.Tweening.TweenSettingsExtensions.From<object>(object,bool,bool)
		// object DG.Tweening.TweenSettingsExtensions.OnComplete<object>(object,DG.Tweening.TweenCallback)
		// object DG.Tweening.TweenSettingsExtensions.SetEase<object>(object,DG.Tweening.Ease)
		// GameFramework.DataTable.IDataTable<object> GameFramework.DataTable.IDataTableManager.GetDataTable<object>()
		// System.Void GameFramework.Fsm.Fsm<object>.ChangeState<object>()
		// System.Void GameFramework.Fsm.FsmState<object>.ChangeState<object>(GameFramework.Fsm.IFsm<object>)
		// object GameFramework.Fsm.IFsm<object>.GetData<object>(string)
		// System.Void GameFramework.Fsm.IFsm<object>.SetData<object>(string,object)
		// System.Void GameFramework.GameFrameworkLog.Error<object,object,object>(string,object,object,object)
		// System.Void GameFramework.GameFrameworkLog.Error<object,object>(string,object,object)
		// System.Void GameFramework.GameFrameworkLog.Info<object,object,object,object>(string,object,object,object,object)
		// System.Void GameFramework.GameFrameworkLog.Info<object,object>(string,object,object)
		// System.Void GameFramework.GameFrameworkLog.Info<object>(string,object)
		// System.Void GameFramework.GameFrameworkLog.Warning<object,object>(string,object,object)
		// System.Void GameFramework.GameFrameworkLog.Warning<object>(string,object)
		// object GameFramework.ReferencePool.Acquire<object>()
		// object GameFramework.ReferencePool.ReferenceCollection.Acquire<object>()
		// object GameFramework.Setting.ISettingManager.GetObject<object>(string)
		// System.Void GameFramework.Setting.ISettingManager.SetObject<object>(string,object)
		// string GameFramework.Utility.Text.Format<byte,object,object>(string,byte,object,object)
		// string GameFramework.Utility.Text.Format<int>(string,int)
		// string GameFramework.Utility.Text.Format<object,object,object,object>(string,object,object,object,object)
		// string GameFramework.Utility.Text.Format<object,object,object>(string,object,object,object)
		// string GameFramework.Utility.Text.Format<object,object>(string,object,object)
		// string GameFramework.Utility.Text.Format<object>(string,object)
		// string GameFramework.Utility.Text.ITextHelper.Format<byte,object,object>(string,byte,object,object)
		// string GameFramework.Utility.Text.ITextHelper.Format<int>(string,int)
		// string GameFramework.Utility.Text.ITextHelper.Format<object,object,object,object>(string,object,object,object,object)
		// string GameFramework.Utility.Text.ITextHelper.Format<object,object,object>(string,object,object,object)
		// string GameFramework.Utility.Text.ITextHelper.Format<object,object>(string,object,object)
		// string GameFramework.Utility.Text.ITextHelper.Format<object>(string,object)
		// object LitJson.JsonMapper.ToObject<object>(string)
		// object System.Activator.CreateInstance<object>()
		// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,object>> System.Linq.Enumerable.Select<SerializableDictionary.SerializableKeyValuePair<object,object>,System.Collections.Generic.KeyValuePair<object,object>>(System.Collections.Generic.IEnumerable<SerializableDictionary.SerializableKeyValuePair<object,object>>,System.Func<SerializableDictionary.SerializableKeyValuePair<object,object>,System.Collections.Generic.KeyValuePair<object,object>>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.Select<SerializableDictionary.SerializableKeyValuePair<object,object>,object>(System.Collections.Generic.IEnumerable<SerializableDictionary.SerializableKeyValuePair<object,object>>,System.Func<SerializableDictionary.SerializableKeyValuePair<object,object>,object>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.Select<object,object>(System.Collections.Generic.IEnumerable<object>,System.Func<object,object>)
		// object[] System.Linq.Enumerable.ToArray<object>(System.Collections.Generic.IEnumerable<object>)
		// System.Collections.Generic.List<object> System.Linq.Enumerable.ToList<object>(System.Collections.Generic.IEnumerable<object>)
		// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,object>> System.Linq.Enumerable.Iterator<SerializableDictionary.SerializableKeyValuePair<object,object>>.Select<System.Collections.Generic.KeyValuePair<object,object>>(System.Func<SerializableDictionary.SerializableKeyValuePair<object,object>,System.Collections.Generic.KeyValuePair<object,object>>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.Iterator<SerializableDictionary.SerializableKeyValuePair<object,object>>.Select<object>(System.Func<SerializableDictionary.SerializableKeyValuePair<object,object>,object>)
		// System.Collections.Generic.IEnumerable<object> System.Linq.Enumerable.Iterator<object>.Select<object>(System.Func<object,object>)
		// System.Void* Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<UnityEngine.Vector2>(UnityEngine.Vector2&)
		// int Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<UnityEngine.Vector2>()
		// object UnityEngine.Component.GetComponent<object>()
		// object UnityEngine.Component.GetComponentInChildren<object>()
		// System.Void UnityEngine.Component.GetComponentsInChildren<object>(bool,System.Collections.Generic.List<object>)
		// object[] UnityEngine.Component.GetComponentsInChildren<object>()
		// object[] UnityEngine.Component.GetComponentsInChildren<object>(bool)
		// object UnityEngine.GameObject.AddComponent<object>()
		// object UnityEngine.GameObject.GetComponent<object>()
		// object UnityEngine.GameObject.GetComponentInParent<object>()
		// object UnityEngine.GameObject.GetComponentInParent<object>(bool)
		// System.Void UnityEngine.GameObject.GetComponentsInChildren<object>(bool,System.Collections.Generic.List<object>)
		// object[] UnityEngine.GameObject.GetComponentsInChildren<object>(bool)
		// UnityEngine.Vector2 UnityEngine.InputSystem.InputAction.CallbackContext.ReadValue<UnityEngine.Vector2>()
		// UnityEngine.Vector2 UnityEngine.InputSystem.InputActionState.ApplyProcessors<UnityEngine.Vector2>(int,UnityEngine.Vector2,UnityEngine.InputSystem.InputControl<UnityEngine.Vector2>)
		// UnityEngine.Vector2 UnityEngine.InputSystem.InputActionState.ReadValue<UnityEngine.Vector2>(int,int,bool)
		// object UnityExtension.GetOrAddComponent<object>(UnityEngine.GameObject)
		// GameFramework.DataTable.IDataTable<object> UnityGameFramework.Runtime.DataTableComponent.GetDataTable<object>()
		// System.Void UnityGameFramework.Runtime.Log.Error<object,object,object>(string,object,object,object)
		// System.Void UnityGameFramework.Runtime.Log.Error<object,object>(string,object,object)
		// System.Void UnityGameFramework.Runtime.Log.Info<object,object,object,object>(string,object,object,object,object)
		// System.Void UnityGameFramework.Runtime.Log.Info<object,object>(string,object,object)
		// System.Void UnityGameFramework.Runtime.Log.Info<object>(string,object)
		// System.Void UnityGameFramework.Runtime.Log.Warning<object,object>(string,object,object)
		// System.Void UnityGameFramework.Runtime.Log.Warning<object>(string,object)
		// object UnityGameFramework.Runtime.SettingComponent.GetObject<object>(string)
		// System.Void UnityGameFramework.Runtime.SettingComponent.SetObject<object>(string,object)
	}
}