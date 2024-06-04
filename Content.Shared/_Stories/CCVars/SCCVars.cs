using Robust.Shared.Configuration;

namespace Content.Shared.Stories.SCCVars;

/// <summary>
///     Corvax modules console variables
/// </summary>
[CVarDefs]
// ReSharper disable once InconsistentNaming
public sealed class SCCVars
{
    /**
     * Auto Vote
     */

    /// <summary>
    /// Auto Vote.
    /// </summary>
    public static readonly CVarDef<bool> AutoVoteEnabled =
        CVarDef.Create("autovote.enabled", false, CVar.SERVERONLY);
}
