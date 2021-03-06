using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	[RequiredByNativeCode]
	public struct AnimatorControllerPlayable : IPlayable, IEquatable<AnimatorControllerPlayable>
	{
		private PlayableHandle m_Handle;

		private static readonly AnimatorControllerPlayable m_NullPlayable = new AnimatorControllerPlayable(PlayableHandle.Null);

		public static AnimatorControllerPlayable Null
		{
			get
			{
				return AnimatorControllerPlayable.m_NullPlayable;
			}
		}

		internal AnimatorControllerPlayable(PlayableHandle handle)
		{
			this.m_Handle = PlayableHandle.Null;
			this.SetHandle(handle);
		}

		public static AnimatorControllerPlayable Create(PlayableGraph graph, RuntimeAnimatorController controller)
		{
			PlayableHandle handle = AnimatorControllerPlayable.CreateHandle(graph, controller);
			return new AnimatorControllerPlayable(handle);
		}

		private static PlayableHandle CreateHandle(PlayableGraph graph, RuntimeAnimatorController controller)
		{
			PlayableHandle @null = PlayableHandle.Null;
			PlayableHandle result;
			if (!AnimatorControllerPlayable.CreateHandleInternal(graph, controller, ref @null))
			{
				result = PlayableHandle.Null;
			}
			else
			{
				result = @null;
			}
			return result;
		}

		public PlayableHandle GetHandle()
		{
			return this.m_Handle;
		}

		public void SetHandle(PlayableHandle handle)
		{
			if (this.m_Handle.IsValid())
			{
				throw new InvalidOperationException("Cannot call IPlayable.SetHandle on an instance that already contains a valid handle.");
			}
			if (handle.IsValid())
			{
				if (!handle.IsPlayableOfType<AnimatorControllerPlayable>())
				{
					throw new InvalidCastException("Can't set handle: the playable is not an AnimatorControllerPlayable.");
				}
			}
			this.m_Handle = handle;
		}

		public static implicit operator Playable(AnimatorControllerPlayable playable)
		{
			return new Playable(playable.GetHandle());
		}

		public static explicit operator AnimatorControllerPlayable(Playable playable)
		{
			return new AnimatorControllerPlayable(playable.GetHandle());
		}

		public bool Equals(AnimatorControllerPlayable other)
		{
			return this.GetHandle() == other.GetHandle();
		}

		private static bool CreateHandleInternal(PlayableGraph graph, RuntimeAnimatorController controller, ref PlayableHandle handle)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_CreateHandleInternal(ref graph, controller, ref handle);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_CreateHandleInternal(ref PlayableGraph graph, RuntimeAnimatorController controller, ref PlayableHandle handle);

		private static RuntimeAnimatorController GetAnimatorControllerInternal(ref PlayableHandle handle)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetAnimatorControllerInternal(ref handle);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RuntimeAnimatorController INTERNAL_CALL_GetAnimatorControllerInternal(ref PlayableHandle handle);

		public float GetFloat(string name)
		{
			return AnimatorControllerPlayable.GetFloatString(ref this.m_Handle, name);
		}

		public float GetFloat(int id)
		{
			return AnimatorControllerPlayable.GetFloatID(ref this.m_Handle, id);
		}

		public void SetFloat(string name, float value)
		{
			AnimatorControllerPlayable.SetFloatString(ref this.m_Handle, name, value);
		}

		public void SetFloat(int id, float value)
		{
			AnimatorControllerPlayable.SetFloatID(ref this.m_Handle, id, value);
		}

		public bool GetBool(string name)
		{
			return AnimatorControllerPlayable.GetBoolString(ref this.m_Handle, name);
		}

		public bool GetBool(int id)
		{
			return AnimatorControllerPlayable.GetBoolID(ref this.m_Handle, id);
		}

		public void SetBool(string name, bool value)
		{
			AnimatorControllerPlayable.SetBoolString(ref this.m_Handle, name, value);
		}

		public void SetBool(int id, bool value)
		{
			AnimatorControllerPlayable.SetBoolID(ref this.m_Handle, id, value);
		}

		public int GetInteger(string name)
		{
			return AnimatorControllerPlayable.GetIntegerString(ref this.m_Handle, name);
		}

		public int GetInteger(int id)
		{
			return AnimatorControllerPlayable.GetIntegerID(ref this.m_Handle, id);
		}

		public void SetInteger(string name, int value)
		{
			AnimatorControllerPlayable.SetIntegerString(ref this.m_Handle, name, value);
		}

		public void SetInteger(int id, int value)
		{
			AnimatorControllerPlayable.SetIntegerID(ref this.m_Handle, id, value);
		}

		public void SetTrigger(string name)
		{
			AnimatorControllerPlayable.SetTriggerString(ref this.m_Handle, name);
		}

		public void SetTrigger(int id)
		{
			AnimatorControllerPlayable.SetTriggerID(ref this.m_Handle, id);
		}

		public void ResetTrigger(string name)
		{
			AnimatorControllerPlayable.ResetTriggerString(ref this.m_Handle, name);
		}

		public void ResetTrigger(int id)
		{
			AnimatorControllerPlayable.ResetTriggerID(ref this.m_Handle, id);
		}

		public bool IsParameterControlledByCurve(string name)
		{
			return AnimatorControllerPlayable.IsParameterControlledByCurveString(ref this.m_Handle, name);
		}

		public bool IsParameterControlledByCurve(int id)
		{
			return AnimatorControllerPlayable.IsParameterControlledByCurveID(ref this.m_Handle, id);
		}

		public int GetLayerCount()
		{
			return AnimatorControllerPlayable.GetLayerCountInternal(ref this.m_Handle);
		}

		private static int GetLayerCountInternal(ref PlayableHandle handle)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetLayerCountInternal(ref handle);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetLayerCountInternal(ref PlayableHandle handle);

		private static string GetLayerNameInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetLayerNameInternal(ref handle, layerIndex);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string INTERNAL_CALL_GetLayerNameInternal(ref PlayableHandle handle, int layerIndex);

		public string GetLayerName(int layerIndex)
		{
			return AnimatorControllerPlayable.GetLayerNameInternal(ref this.m_Handle, layerIndex);
		}

		private static int GetLayerIndexInternal(ref PlayableHandle handle, string layerName)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetLayerIndexInternal(ref handle, layerName);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetLayerIndexInternal(ref PlayableHandle handle, string layerName);

		public int GetLayerIndex(string layerName)
		{
			return AnimatorControllerPlayable.GetLayerIndexInternal(ref this.m_Handle, layerName);
		}

		private static float GetLayerWeightInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetLayerWeightInternal(ref handle, layerIndex);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_GetLayerWeightInternal(ref PlayableHandle handle, int layerIndex);

		public float GetLayerWeight(int layerIndex)
		{
			return AnimatorControllerPlayable.GetLayerWeightInternal(ref this.m_Handle, layerIndex);
		}

		private static void SetLayerWeightInternal(ref PlayableHandle handle, int layerIndex, float weight)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_SetLayerWeightInternal(ref handle, layerIndex, weight);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetLayerWeightInternal(ref PlayableHandle handle, int layerIndex, float weight);

		public void SetLayerWeight(int layerIndex, float weight)
		{
			AnimatorControllerPlayable.SetLayerWeightInternal(ref this.m_Handle, layerIndex, weight);
		}

		private static AnimatorStateInfo GetCurrentAnimatorStateInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetCurrentAnimatorStateInfoInternal(ref handle, layerIndex);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AnimatorStateInfo INTERNAL_CALL_GetCurrentAnimatorStateInfoInternal(ref PlayableHandle handle, int layerIndex);

		public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetCurrentAnimatorStateInfoInternal(ref this.m_Handle, layerIndex);
		}

		private static AnimatorStateInfo GetNextAnimatorStateInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetNextAnimatorStateInfoInternal(ref handle, layerIndex);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AnimatorStateInfo INTERNAL_CALL_GetNextAnimatorStateInfoInternal(ref PlayableHandle handle, int layerIndex);

		public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetNextAnimatorStateInfoInternal(ref this.m_Handle, layerIndex);
		}

		private static AnimatorTransitionInfo GetAnimatorTransitionInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetAnimatorTransitionInfoInternal(ref handle, layerIndex);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AnimatorTransitionInfo INTERNAL_CALL_GetAnimatorTransitionInfoInternal(ref PlayableHandle handle, int layerIndex);

		public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetAnimatorTransitionInfoInternal(ref this.m_Handle, layerIndex);
		}

		private static AnimatorClipInfo[] GetCurrentAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetCurrentAnimatorClipInfoInternal(ref handle, layerIndex);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AnimatorClipInfo[] INTERNAL_CALL_GetCurrentAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex);

		public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetCurrentAnimatorClipInfoInternal(ref this.m_Handle, layerIndex);
		}

		public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
		{
			if (clips == null)
			{
				throw new ArgumentNullException("clips");
			}
			AnimatorControllerPlayable.GetAnimatorClipInfoInternal(ref this.m_Handle, layerIndex, true, clips);
		}

		public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
		{
			if (clips == null)
			{
				throw new ArgumentNullException("clips");
			}
			AnimatorControllerPlayable.GetAnimatorClipInfoInternal(ref this.m_Handle, layerIndex, false, clips);
		}

		private static void GetAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex, bool isCurrent, object clips)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_GetAnimatorClipInfoInternal(ref handle, layerIndex, isCurrent, clips);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex, bool isCurrent, object clips);

		private static int GetAnimatorClipInfoCountInternal(ref PlayableHandle handle, int layerIndex, bool current)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetAnimatorClipInfoCountInternal(ref handle, layerIndex, current);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetAnimatorClipInfoCountInternal(ref PlayableHandle handle, int layerIndex, bool current);

		public int GetCurrentAnimatorClipInfoCount(int layerIndex)
		{
			return AnimatorControllerPlayable.GetAnimatorClipInfoCountInternal(ref this.m_Handle, layerIndex, true);
		}

		public int GetNextAnimatorClipInfoCount(int layerIndex)
		{
			return AnimatorControllerPlayable.GetAnimatorClipInfoCountInternal(ref this.m_Handle, layerIndex, false);
		}

		private static AnimatorClipInfo[] GetNextAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetNextAnimatorClipInfoInternal(ref handle, layerIndex);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AnimatorClipInfo[] INTERNAL_CALL_GetNextAnimatorClipInfoInternal(ref PlayableHandle handle, int layerIndex);

		public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex)
		{
			return AnimatorControllerPlayable.GetNextAnimatorClipInfoInternal(ref this.m_Handle, layerIndex);
		}

		internal string ResolveHash(int hash)
		{
			return AnimatorControllerPlayable.ResolveHashInternal(ref this.m_Handle, hash);
		}

		private static string ResolveHashInternal(ref PlayableHandle handle, int hash)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_ResolveHashInternal(ref handle, hash);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string INTERNAL_CALL_ResolveHashInternal(ref PlayableHandle handle, int hash);

		private static bool IsInTransitionInternal(ref PlayableHandle handle, int layerIndex)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_IsInTransitionInternal(ref handle, layerIndex);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_IsInTransitionInternal(ref PlayableHandle handle, int layerIndex);

		public bool IsInTransition(int layerIndex)
		{
			return AnimatorControllerPlayable.IsInTransitionInternal(ref this.m_Handle, layerIndex);
		}

		private static int GetParameterCountInternal(ref PlayableHandle handle)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetParameterCountInternal(ref handle);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetParameterCountInternal(ref PlayableHandle handle);

		public int GetParameterCount()
		{
			return AnimatorControllerPlayable.GetParameterCountInternal(ref this.m_Handle);
		}

		private static AnimatorControllerParameter[] GetParametersArrayInternal(ref PlayableHandle handle)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetParametersArrayInternal(ref handle);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern AnimatorControllerParameter[] INTERNAL_CALL_GetParametersArrayInternal(ref PlayableHandle handle);

		public AnimatorControllerParameter GetParameter(int index)
		{
			AnimatorControllerParameter[] parametersArrayInternal = AnimatorControllerPlayable.GetParametersArrayInternal(ref this.m_Handle);
			if (index < 0 && index >= parametersArrayInternal.Length)
			{
				throw new IndexOutOfRangeException("index");
			}
			return parametersArrayInternal[index];
		}

		[GeneratedByOldBindingsGenerator, ThreadAndSerializationSafe]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int StringToHash(string name);

		[ExcludeFromDocs]
		public void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer)
		{
			float fixedTime = 0f;
			this.CrossFadeInFixedTime(stateName, transitionDuration, layer, fixedTime);
		}

		[ExcludeFromDocs]
		public void CrossFadeInFixedTime(string stateName, float transitionDuration)
		{
			float fixedTime = 0f;
			int layer = -1;
			this.CrossFadeInFixedTime(stateName, transitionDuration, layer, fixedTime);
		}

		public void CrossFadeInFixedTime(string stateName, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float fixedTime)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, layer, fixedTime);
		}

		[ExcludeFromDocs]
		public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer)
		{
			float fixedTime = 0f;
			this.CrossFadeInFixedTime(stateNameHash, transitionDuration, layer, fixedTime);
		}

		[ExcludeFromDocs]
		public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration)
		{
			float fixedTime = 0f;
			int layer = -1;
			this.CrossFadeInFixedTime(stateNameHash, transitionDuration, layer, fixedTime);
		}

		public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float fixedTime)
		{
			AnimatorControllerPlayable.CrossFadeInFixedTimeInternal(ref this.m_Handle, stateNameHash, transitionDuration, layer, fixedTime);
		}

		private static void CrossFadeInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float fixedTime)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_CrossFadeInFixedTimeInternal(ref handle, stateNameHash, transitionDuration, layer, fixedTime);
		}

		[ExcludeFromDocs]
		private static void CrossFadeInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration, int layer)
		{
			float fixedTime = 0f;
			AnimatorControllerPlayable.INTERNAL_CALL_CrossFadeInFixedTimeInternal(ref handle, stateNameHash, transitionDuration, layer, fixedTime);
		}

		[ExcludeFromDocs]
		private static void CrossFadeInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration)
		{
			float fixedTime = 0f;
			int layer = -1;
			AnimatorControllerPlayable.INTERNAL_CALL_CrossFadeInFixedTimeInternal(ref handle, stateNameHash, transitionDuration, layer, fixedTime);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_CrossFadeInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration, int layer, float fixedTime);

		[ExcludeFromDocs]
		public void CrossFade(string stateName, float transitionDuration, int layer)
		{
			float normalizedTime = float.NegativeInfinity;
			this.CrossFade(stateName, transitionDuration, layer, normalizedTime);
		}

		[ExcludeFromDocs]
		public void CrossFade(string stateName, float transitionDuration)
		{
			float normalizedTime = float.NegativeInfinity;
			int layer = -1;
			this.CrossFade(stateName, transitionDuration, layer, normalizedTime);
		}

		public void CrossFade(string stateName, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), transitionDuration, layer, normalizedTime);
		}

		[ExcludeFromDocs]
		public void CrossFade(int stateNameHash, float transitionDuration, int layer)
		{
			float normalizedTime = float.NegativeInfinity;
			this.CrossFade(stateNameHash, transitionDuration, layer, normalizedTime);
		}

		[ExcludeFromDocs]
		public void CrossFade(int stateNameHash, float transitionDuration)
		{
			float normalizedTime = float.NegativeInfinity;
			int layer = -1;
			this.CrossFade(stateNameHash, transitionDuration, layer, normalizedTime);
		}

		public void CrossFade(int stateNameHash, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
			AnimatorControllerPlayable.CrossFadeInternal(ref this.m_Handle, stateNameHash, transitionDuration, layer, normalizedTime);
		}

		private static void CrossFadeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_CrossFadeInternal(ref handle, stateNameHash, transitionDuration, layer, normalizedTime);
		}

		[ExcludeFromDocs]
		private static void CrossFadeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration, int layer)
		{
			float normalizedTime = float.NegativeInfinity;
			AnimatorControllerPlayable.INTERNAL_CALL_CrossFadeInternal(ref handle, stateNameHash, transitionDuration, layer, normalizedTime);
		}

		[ExcludeFromDocs]
		private static void CrossFadeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration)
		{
			float normalizedTime = float.NegativeInfinity;
			int layer = -1;
			AnimatorControllerPlayable.INTERNAL_CALL_CrossFadeInternal(ref handle, stateNameHash, transitionDuration, layer, normalizedTime);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_CrossFadeInternal(ref PlayableHandle handle, int stateNameHash, float transitionDuration, int layer, float normalizedTime);

		[ExcludeFromDocs]
		public void PlayInFixedTime(string stateName, int layer)
		{
			float fixedTime = float.NegativeInfinity;
			this.PlayInFixedTime(stateName, layer, fixedTime);
		}

		[ExcludeFromDocs]
		public void PlayInFixedTime(string stateName)
		{
			float fixedTime = float.NegativeInfinity;
			int layer = -1;
			this.PlayInFixedTime(stateName, layer, fixedTime);
		}

		public void PlayInFixedTime(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float fixedTime)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), layer, fixedTime);
		}

		[ExcludeFromDocs]
		public void PlayInFixedTime(int stateNameHash, int layer)
		{
			float fixedTime = float.NegativeInfinity;
			this.PlayInFixedTime(stateNameHash, layer, fixedTime);
		}

		[ExcludeFromDocs]
		public void PlayInFixedTime(int stateNameHash)
		{
			float fixedTime = float.NegativeInfinity;
			int layer = -1;
			this.PlayInFixedTime(stateNameHash, layer, fixedTime);
		}

		public void PlayInFixedTime(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float fixedTime)
		{
			AnimatorControllerPlayable.PlayInFixedTimeInternal(ref this.m_Handle, stateNameHash, layer, fixedTime);
		}

		private static void PlayInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float fixedTime)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_PlayInFixedTimeInternal(ref handle, stateNameHash, layer, fixedTime);
		}

		[ExcludeFromDocs]
		private static void PlayInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash, int layer)
		{
			float fixedTime = float.NegativeInfinity;
			AnimatorControllerPlayable.INTERNAL_CALL_PlayInFixedTimeInternal(ref handle, stateNameHash, layer, fixedTime);
		}

		[ExcludeFromDocs]
		private static void PlayInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash)
		{
			float fixedTime = float.NegativeInfinity;
			int layer = -1;
			AnimatorControllerPlayable.INTERNAL_CALL_PlayInFixedTimeInternal(ref handle, stateNameHash, layer, fixedTime);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_PlayInFixedTimeInternal(ref PlayableHandle handle, int stateNameHash, int layer, float fixedTime);

		[ExcludeFromDocs]
		public void Play(string stateName, int layer)
		{
			float normalizedTime = float.NegativeInfinity;
			this.Play(stateName, layer, normalizedTime);
		}

		[ExcludeFromDocs]
		public void Play(string stateName)
		{
			float normalizedTime = float.NegativeInfinity;
			int layer = -1;
			this.Play(stateName, layer, normalizedTime);
		}

		public void Play(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.m_Handle, AnimatorControllerPlayable.StringToHash(stateName), layer, normalizedTime);
		}

		[ExcludeFromDocs]
		public void Play(int stateNameHash, int layer)
		{
			float normalizedTime = float.NegativeInfinity;
			this.Play(stateNameHash, layer, normalizedTime);
		}

		[ExcludeFromDocs]
		public void Play(int stateNameHash)
		{
			float normalizedTime = float.NegativeInfinity;
			int layer = -1;
			this.Play(stateNameHash, layer, normalizedTime);
		}

		public void Play(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
			AnimatorControllerPlayable.PlayInternal(ref this.m_Handle, stateNameHash, layer, normalizedTime);
		}

		private static void PlayInternal(ref PlayableHandle handle, int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_PlayInternal(ref handle, stateNameHash, layer, normalizedTime);
		}

		[ExcludeFromDocs]
		private static void PlayInternal(ref PlayableHandle handle, int stateNameHash, int layer)
		{
			float normalizedTime = float.NegativeInfinity;
			AnimatorControllerPlayable.INTERNAL_CALL_PlayInternal(ref handle, stateNameHash, layer, normalizedTime);
		}

		[ExcludeFromDocs]
		private static void PlayInternal(ref PlayableHandle handle, int stateNameHash)
		{
			float normalizedTime = float.NegativeInfinity;
			int layer = -1;
			AnimatorControllerPlayable.INTERNAL_CALL_PlayInternal(ref handle, stateNameHash, layer, normalizedTime);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_PlayInternal(ref PlayableHandle handle, int stateNameHash, int layer, float normalizedTime);

		public bool HasState(int layerIndex, int stateID)
		{
			return AnimatorControllerPlayable.HasStateInternal(ref this.m_Handle, layerIndex, stateID);
		}

		private static bool HasStateInternal(ref PlayableHandle handle, int layerIndex, int stateID)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_HasStateInternal(ref handle, layerIndex, stateID);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_HasStateInternal(ref PlayableHandle handle, int layerIndex, int stateID);

		private static void SetFloatString(ref PlayableHandle handle, string name, float value)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_SetFloatString(ref handle, name, value);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetFloatString(ref PlayableHandle handle, string name, float value);

		private static void SetFloatID(ref PlayableHandle handle, int id, float value)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_SetFloatID(ref handle, id, value);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetFloatID(ref PlayableHandle handle, int id, float value);

		private static float GetFloatString(ref PlayableHandle handle, string name)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetFloatString(ref handle, name);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_GetFloatString(ref PlayableHandle handle, string name);

		private static float GetFloatID(ref PlayableHandle handle, int id)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetFloatID(ref handle, id);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float INTERNAL_CALL_GetFloatID(ref PlayableHandle handle, int id);

		private static void SetBoolString(ref PlayableHandle handle, string name, bool value)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_SetBoolString(ref handle, name, value);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetBoolString(ref PlayableHandle handle, string name, bool value);

		private static void SetBoolID(ref PlayableHandle handle, int id, bool value)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_SetBoolID(ref handle, id, value);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetBoolID(ref PlayableHandle handle, int id, bool value);

		private static bool GetBoolString(ref PlayableHandle handle, string name)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetBoolString(ref handle, name);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_GetBoolString(ref PlayableHandle handle, string name);

		private static bool GetBoolID(ref PlayableHandle handle, int id)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetBoolID(ref handle, id);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_GetBoolID(ref PlayableHandle handle, int id);

		private static void SetIntegerString(ref PlayableHandle handle, string name, int value)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_SetIntegerString(ref handle, name, value);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetIntegerString(ref PlayableHandle handle, string name, int value);

		private static void SetIntegerID(ref PlayableHandle handle, int id, int value)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_SetIntegerID(ref handle, id, value);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetIntegerID(ref PlayableHandle handle, int id, int value);

		private static int GetIntegerString(ref PlayableHandle handle, string name)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetIntegerString(ref handle, name);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetIntegerString(ref PlayableHandle handle, string name);

		private static int GetIntegerID(ref PlayableHandle handle, int id)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_GetIntegerID(ref handle, id);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetIntegerID(ref PlayableHandle handle, int id);

		private static void SetTriggerString(ref PlayableHandle handle, string name)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_SetTriggerString(ref handle, name);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetTriggerString(ref PlayableHandle handle, string name);

		private static void SetTriggerID(ref PlayableHandle handle, int id)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_SetTriggerID(ref handle, id);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetTriggerID(ref PlayableHandle handle, int id);

		private static void ResetTriggerString(ref PlayableHandle handle, string name)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_ResetTriggerString(ref handle, name);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ResetTriggerString(ref PlayableHandle handle, string name);

		private static void ResetTriggerID(ref PlayableHandle handle, int id)
		{
			AnimatorControllerPlayable.INTERNAL_CALL_ResetTriggerID(ref handle, id);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_ResetTriggerID(ref PlayableHandle handle, int id);

		private static bool IsParameterControlledByCurveString(ref PlayableHandle handle, string name)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_IsParameterControlledByCurveString(ref handle, name);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_IsParameterControlledByCurveString(ref PlayableHandle handle, string name);

		private static bool IsParameterControlledByCurveID(ref PlayableHandle handle, int id)
		{
			return AnimatorControllerPlayable.INTERNAL_CALL_IsParameterControlledByCurveID(ref handle, id);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_IsParameterControlledByCurveID(ref PlayableHandle handle, int id);
	}
}
