using System.Reflection;

namespace Patchwork.Utility {
	/// <summary>
	///     Commonly used combinations of the BindingFlags enum.
	/// </summary>
	internal static class CommonBindingFlags {
		/// <summary>
		///     Instance, Static, Public, NonPublic
		/// </summary>
		public static BindingFlags Everything = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static
			| BindingFlags.Instance;
	}
}