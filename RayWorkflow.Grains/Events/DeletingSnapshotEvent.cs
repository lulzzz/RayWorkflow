﻿using System;
using Ray.Core.Event;

namespace RayWorkflow.Grains.Events
{
    [Serializable]
    public class DeletingSnapshotEvent<TPrimaryKey> : IEvent
    {
        public TPrimaryKey PrimaryKey { get; set; }

        public DeletingSnapshotEvent()
        {
        }

        public DeletingSnapshotEvent(TPrimaryKey primaryKey) : this()
        {
            PrimaryKey = primaryKey;
        }
    }
}