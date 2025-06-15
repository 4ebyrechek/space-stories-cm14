using Robust.Shared.Configuration;

namespace Content.Shared._Stories.SCCVars;

/// <summary>
///     Stories modules console variables
/// </summary>
[CVarDefs]
// ReSharper disable once InconsistentNaming
public sealed class SCCVars
{
    /**
     * TTS (Text-To-Speech)
     */

    /// <summary>
    /// URL of the TTS server API.
    /// </summary>
    public static readonly CVarDef<bool> TTSEnabled =
        CVarDef.Create("tts.enabled", false, CVar.SERVER | CVar.REPLICATED | CVar.ARCHIVE);

    /// <summary>
    /// Whether the TTS system is enabled on the client.
    /// </summary>
    public static readonly CVarDef<bool> TTSEnabledClient =
        CVarDef.Create("tts.enabled_client", true, CVar.CLIENTONLY | CVar.ARCHIVE);

    /// <summary>
    /// URL of the TTS server API.
    /// </summary>
    public static readonly CVarDef<string> TTSApiUrl =
        CVarDef.Create("tts.api_url", "", CVar.SERVERONLY | CVar.ARCHIVE);

    /// <summary>
    /// Auth token of the TTS server API.
    /// </summary>
    public static readonly CVarDef<string> TTSApiToken =
        CVarDef.Create("tts.api_token", "", CVar.SERVERONLY | CVar.CONFIDENTIAL);

    /// <summary>
    /// Amount of seconds before timeout for API
    /// </summary>
    public static readonly CVarDef<int> TTSApiTimeout =
        CVarDef.Create("tts.api_timeout", 5, CVar.SERVERONLY | CVar.ARCHIVE);

    /// <summary>
    /// Default volume setting of TTS sound for marines
    /// </summary>
    public static readonly CVarDef<float> TTSVolumeMarines =
        CVarDef.Create("tts.volume_marines", 1.0f, CVar.CLIENTONLY | CVar.ARCHIVE);

    /// <summary>
    /// Default volume setting of TTS sound for xenos
    /// </summary>
    public static readonly CVarDef<float> TTSVolumeXenos =
        CVarDef.Create("tts.volume_xenos", 1.0f, CVar.CLIENTONLY | CVar.ARCHIVE);

    /// <summary>
    /// Default volume setting of TTS sound for radio
    /// </summary>
    public static readonly CVarDef<float> TTSVolumeRadio =
        CVarDef.Create("tts.volume_radio", 0.5f, CVar.CLIENTONLY | CVar.ARCHIVE);

    /// <summary>
    /// Default volume setting of TTS sound for others
    /// </summary>
    public static readonly CVarDef<float> TTSVolumeOther =
        CVarDef.Create("tts.volume_other", 1.0f, CVar.CLIENTONLY | CVar.ARCHIVE);

    /// <summary>
    /// Count of in-memory cached tts voice lines.
    /// </summary>
    public static readonly CVarDef<int> TTSMaxCache =
        CVarDef.Create("tts.max_cache", 250, CVar.SERVERONLY | CVar.ARCHIVE);

    /**
     * Sponsors
     */

    /// <summary>
    ///     URL of the sponsors server API.
    /// </summary>
    public static readonly CVarDef<string> SponsorsApiUrl =
        CVarDef.Create("sponsor.api_url", "", CVar.SERVERONLY);

    /*
     * Queue
     */

    /// <summary>
    ///     Controls if the connections queue is enabled. If enabled stop kicking new players after `SoftMaxPlayers` cap and instead add them to queue.
    /// </summary>
    public static readonly CVarDef<bool>
        QueueEnabled = CVarDef.Create("queue.enabled", false, CVar.SERVERONLY);

    /*
     * Discord Auth
     */

    /// <summary>
    ///     Enabled Discord linking, show linking button and modal window
    /// </summary>
    public static readonly CVarDef<bool> DiscordAuthEnabled =
        CVarDef.Create("discord_auth.enabled", false, CVar.SERVERONLY);

    /// <summary>
    ///     URL of the Discord auth server API
    /// </summary>
    public static readonly CVarDef<string> DiscordAuthApiUrl =
        CVarDef.Create("discord_auth.api_url", "", CVar.SERVERONLY);

    /// <summary>
    ///     Secret key of the Discord auth server API
    /// </summary>
    public static readonly CVarDef<string> DiscordAuthApiKey =
        CVarDef.Create("discord_auth.api_key", "", CVar.SERVERONLY | CVar.CONFIDENTIAL);


    /*
    * Hijack Volume
    */

    /// <summary>
    /// Default volume setting of Hijack Song
    /// </summary>
    public static readonly CVarDef<float> HijackVolume =
        CVarDef.Create("rmc.hijack_volume", 1.5f, CVar.CLIENTONLY | CVar.ARCHIVE);

    /*
    * Auto Climbing
    */

    /// <summary>
    /// Controls whether the player will automatically climb entities with the AutoClimbable component
    /// </summary>
    public static readonly CVarDef<bool> AutoClimb =
        CVarDef.Create("rmc.autoclimb", true, CVar.ARCHIVE | CVar.CLIENT | CVar.REPLICATED);
}
