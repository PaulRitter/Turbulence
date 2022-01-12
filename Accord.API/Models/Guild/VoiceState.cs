﻿using Newtonsoft.Json;

namespace Accord.API.Models.Guild;

public class VoiceState
{
    /// <summary>
    /// The guild id this voice state is for
    /// </summary>
    [JsonProperty("guild_id", Required = Required.DisallowNull)]
    public ulong GuildId { get; internal set; }

    /// <summary>
    /// The channel id this user is connected to
    /// </summary>
    [JsonProperty("channel_id", Required = Required.AllowNull)]
    public ulong? ChannelId { get; internal set; }

    /// <summary>
    /// The user id this voice state is for
    /// </summary>
    [JsonProperty("user_id", Required = Required.Always)]
    public ulong UserId { get; internal set; }

    /// <summary>
    /// The guild member this voice state is for
    /// </summary>
    [JsonProperty("member", Required = Required.DisallowNull)]
    public GuildMember Member { get; internal set; } = null!;

    /// <summary>
    /// The session id for this voice state
    /// </summary>
    [JsonProperty("session_id", Required = Required.Always)]
    public string SessionId { get; internal set; } = null!;

    /// <summary>
    /// Whether this user is deafened by the server
    /// </summary>
    [JsonProperty("deaf", Required = Required.Always)]
    public bool Deaf { get; internal set; }

    /// <summary>
    /// Whether this user is muted by the server
    /// </summary>
    [JsonProperty("mute", Required = Required.Always)]
    public bool Mute { get; internal set; }

    /// <summary>
    /// Whether this user is locally deafened
    /// </summary>
    [JsonProperty("self_deaf", Required = Required.Always)]
    public bool SelfDeaf { get; internal set; }

    /// <summary>
    /// Whether this user is locally muted
    /// </summary>
    [JsonProperty("self_mute", Required = Required.Always)]
    public bool SelfMute { get; internal set; }

    /// <summary>
    /// Whether this user is streaming using "go live"
    /// </summary>
    [JsonProperty("self_stream", Required = Required.DisallowNull)]
    public bool SelfStream { get; internal set; }

    /// <summary>
    /// Whether this user's camera is enabled
    /// </summary>
    [JsonProperty("self_video", Required = Required.Always)]
    public bool SelfVideo { get; internal set; }

    /// <summary>
    /// Whether this user is muted by the current user
    /// </summary>
    [JsonProperty("suppress", Required = Required.Always)]
    public bool Suppress { get; internal set; }

    /// <summary>
    /// The time at which the user requested to speak. ISO8601 timestamp
    /// </summary>
    [JsonProperty("request_to_speak_timestamp", Required = Required.AllowNull)]
    public string? RequestToSpeakTimestamp { get; internal set; }


}