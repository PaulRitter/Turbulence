﻿using Turbulence.Discord.Models;
using Turbulence.Discord.Models.DiscordChannel;
using Turbulence.Discord.Models.DiscordEmoji;
using Turbulence.Discord.Models.DiscordUser;

namespace Turbulence.Core.ViewModels.Design;

public class DesignMessagesViewModel : MessagesViewModel
{
    public DesignMessagesViewModel()
    {
        Title = "Channel";
        var user1 = new User()
        {
            Id = new(0),
            Username = "User",
            Discriminator = "0",
            Avatar = ""
        };
        var user2 = new User()
        {
            Id = new(0),
            Username = "User2",
            Discriminator = "0",
            Avatar = ""
        };
        var reactions = new Reaction[]
        {
            new Reaction()
            {
                Count = 1,
                Me = true,
                Emoji = new Emoji()
                {
                    Id = null,
                    Name = "\U0001F629", // :weary:
                }
            },
            new Reaction()
            {
                Count = 1,
                Me = false,
                Emoji = new Emoji()
                {
                    Id = null,
                    Name = "\U0001F914", // :think:
                }
            }
        };
        var now = DateTimeOffset.Now;
        var message1 = CreateMessage("hello", MessageType.DEFAULT, user1, now - new TimeSpan(24, 0, 0), reactions: reactions);
        CurrentMessages.AddRange(new List<Message> {
            message1,
            CreateMessage("no", MessageType.DEFAULT, user2, now - new TimeSpan(0, 1, 0), message1),
        });
    }

    private static Message CreateMessage(string content, MessageType type, User author, DateTimeOffset timestamp, Message? reference = null, Reaction[]? reactions = null) => new Message()
    {
        Content = content,
        Type = type,
        Author = author,
        Id = new(0),
        ChannelId = new(0),
        Timestamp = timestamp,
        EditedTimestamp = null,
        Tts = false,
        MentionEveryone = false,
        Mentions = Array.Empty<User>(),
        MentionRoles = Array.Empty<Snowflake>(),
        Attachments = Array.Empty<Attachment>(),
        Embeds = Array.Empty<Embed>(),
        Pinned = false,
        ReferencedMessage = reference,
        Reactions = reactions,
    };
}
