using System;
using UnityEditor;
using UnityEditorInternal;

namespace Kogane
{
	[InitializeOnLoad]
	public static class EditorFocusWatcher
	{
		public static Action OnFocused   { get; set; }
		public static Action OnUnfocused { get; set; }

		private static bool m_isFocused;

		static EditorFocusWatcher()
		{
			EditorApplication.update += Update;
		}

		private static void Update()
		{
			var isApplicationActive = InternalEditorUtility.isApplicationActive;

			if ( !m_isFocused && isApplicationActive )
			{
				m_isFocused = true;
				OnFocused?.Invoke();
				;
			}
			else if ( m_isFocused && !isApplicationActive )
			{
				m_isFocused = false;
				OnUnfocused?.Invoke();
			}
		}
	}
}