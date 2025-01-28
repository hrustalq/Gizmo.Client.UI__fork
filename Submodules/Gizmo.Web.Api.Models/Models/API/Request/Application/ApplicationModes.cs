#nullable enable

using Gizmo;

using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application modes.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationModes
    {
        /// <summary>
        /// Single player.
        /// </summary>
        [Key(0)]
        public bool SinglePlayer { get; set; }

        /// <summary>
        /// Online multiplayer.
        /// </summary>
        //[IsGameModeAttibute()]
        [Key(1)]
        public bool Online { get; set; }

        /// <summary>
        /// Lan Multiplayer.
        /// </summary>
        //[IsGameModeAttibute()]
        [Key(2)]
        public bool Multiplayer { get; set; }

        /// <summary>
        /// Settings.
        /// </summary>
        [Key(3)]
        public bool Settings { get; set; }

        /// <summary>
        /// Utility.
        /// </summary>
        [Key(4)]
        public bool Utility { get; set; }

        /// <summary>
        /// Game.
        /// </summary>
        [Key(5)]
        public bool Game { get; set; }

        /// <summary>
        /// Application.
        /// </summary>
        [Key(6)]
        public bool Application { get; set; }

        /// <summary>
        /// Free to play.
        /// </summary>
        [Key(7)]
        public bool FreeToPlay { get; set; }

        /// <summary>
        /// Requires subscription.
        /// </summary>
        [Key(8)]
        public bool RequiresSubscription { get; set; }

        /// <summary>
        /// Free trial.
        /// </summary>
        [Key(9)]
        public bool FreeTrial { get; set; }

        /// <summary>
        /// Split screen.
        /// </summary>
        //[IsGameModeAttibute()]
        [Key(10)]
        public bool SplitScreenMultiPlayer { get; set; }

        /// <summary>
        /// Lan co-op.
        /// </summary>
        //[IsGameModeAttibute()]
        [Key(11)]
        public bool CoOpLan { get; set; }

        /// <summary>
        /// Online co-op.
        /// </summary>
        //[IsGameModeAttibute()]
        [Key(12)]
        public bool CoOpOnline { get; set; }

        /// <summary>
        /// One time purchase.
        /// </summary>
        [Key(13)]
        public bool OneTimePurchase { get; set; }
    }
}