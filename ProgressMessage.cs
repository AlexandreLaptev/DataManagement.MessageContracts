﻿using System;

namespace DataManagement.MessageContracts
{
    /// <summary>
    /// Uses by MassTransit as a message contract to send a progress message.
    /// </summary>
    public interface ProgressMessage
    {
        /// <summary>
        /// Progress message.
        /// </summary>
        string Message { get; }

        /// <summary>
        /// Progress status.
        /// </summary>
        ProgressStatus Status { get; set; }

        /// <summary>
        /// When the message was created.
        /// </summary>
        DateTime Timestamp { get; }
    }
}