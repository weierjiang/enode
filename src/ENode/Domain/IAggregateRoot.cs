﻿using System.Collections.Generic;
using ENode.Eventing;

namespace ENode.Domain
{
    /// <summary>Represents an aggregate root.
    /// </summary>
    public interface IAggregateRoot
    {
        /// <summary>Represents the unique id of the aggregate root.
        /// </summary>
        string UniqueId { get; }
        /// <summary>Represents the current version of the aggregate root.
        /// </summary>
        int Version { get; }
        /// <summary>Upgrade the version of the aggregate root, pop and return all the uncommitted events.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IDomainEvent> CommitChanges();
        /// <summary>Replay the given event streams.
        /// </summary>
        /// <param name="eventStreams"></param>
        void ReplayEvents(IEnumerable<DomainEventStream> eventStreams);
    }
}
