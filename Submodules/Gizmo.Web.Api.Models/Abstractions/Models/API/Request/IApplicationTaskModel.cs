namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Application task.
    /// </summary>
    public interface IApplicationTaskModel : IWebApiModel
    {
        /// <summary>
        /// The name of the task.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The junction object attached to this task if the task is a junction task, otherwise it will be null.
        /// </summary>
        ApplicationTaskModelJunction? TaskJunction { get; set; }

        /// <summary>
        /// The notification object attached to this task if the task is a notification task, otherwise it will be null.
        /// </summary>
        ApplicationTaskModelNotification? TaskNotification { get; set; }

        /// <summary>
        /// The process object attached to this task if the task is a process task, otherwise it will be null.
        /// </summary>
        ApplicationTaskModelProcess? TaskProcess { get; set; }

        /// <summary>
        /// The script object attached to this task if the task is a script task, otherwise it will be null.
        /// </summary>
        ApplicationTaskModelScript? TaskScript { get; set; }
    }
}