using MessagePack;
using System;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Waiting line state model.
    /// </summary>
    [MessagePackObject()]
    public class WaitingLineStateModel
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets host group id.
        /// </summary>
        [Key(0)]
        public int HostGroupId
        {
            get; init;
        }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [Key(1)]
        public int UserId
        {
            get; init;
        }

        /// <summary>
        /// Gets or sets estimated host id.
        /// </summary>
        [Key(2)]
        public int? EstimatedHostId
        {
            get; init;
        }

        /// <summary>
        /// Gets or sets estimated time.
        /// </summary>
        [Key(3)]
        public double? EstimatedWaitTime
        {
            get; init;
        }

        /// <summary>
        /// Gets or sets state.
        /// </summary>
        [Key(4)]
        public WaitingLineState State
        {
            get; init;
        }

        /// <summary>
        /// Gets or sets position.
        /// </summary>
        [Key(5)]
        public int Position
        {
            get; init;
        }

        /// <summary>
        /// Gets or sets if position is manually set.
        /// </summary>
        [Key(6)]
        public bool IsManualPosition
        {
            get; init;
        }

        /// <summary>
        /// Gets total time in waiting line.
        /// </summary>
        [Key(7)]
        public double TimeInLine
        {
            get; init;
        }

        /// <summary>
        /// Gets ready time.
        /// </summary>
        [Key(8)]
        public double ReadyTime
        {
            get; init;
        }

        /// <summary>
        /// Gets if ready timed out.
        /// </summary>
        [Key(9)]
        public bool IsReadyTimedOut
        {
            get; init;
        }

        /// <summary>
        /// Gets or sets entry id.
        /// </summary>
        [Key(10)]
        public int EntryId
        {
            get; init;
        }

        /// <summary>
        /// Gets or sets created time.
        /// </summary>
        [Key(11)]
        public DateTime CreatedTime
        {
            get; init;
        }

        #endregion
    }
}
