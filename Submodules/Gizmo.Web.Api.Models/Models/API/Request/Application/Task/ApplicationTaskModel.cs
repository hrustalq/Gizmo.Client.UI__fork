using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application task.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class ApplicationTaskModel : IApplicationTaskModel, IModelIntIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The type of the application task.
        /// </summary>
        [MessagePack.Key(1)]
        [EnumValueValidation]
        public TaskType TaskType { get; set; }

        /// <summary>
        /// The GUID of the product.
        /// </summary>
        [MessagePack.Key(2)]
        public Guid Guid { get; set; }

        /// <summary>
        /// The name of the task.
        /// </summary>
        [MessagePack.Key(3)]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The junction object attached to this task if the task is a junction task, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(4)]
        public ApplicationTaskModelJunction? TaskJunction { get; set; }

        /// <summary>
        /// The notification object attached to this task if the task is a notification task, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(5)]
        public ApplicationTaskModelNotification? TaskNotification { get; set; }

        /// <summary>
        /// The process object attached to this task if the task is a process task, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(6)]
        public ApplicationTaskModelProcess? TaskProcess { get; set; }

        /// <summary>
        /// The script object attached to this task if the task is a script task, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(7)]
        public ApplicationTaskModelScript? TaskScript { get; set; }

        #endregion
    }
}
