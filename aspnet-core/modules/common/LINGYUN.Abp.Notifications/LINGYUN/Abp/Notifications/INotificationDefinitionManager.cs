﻿using JetBrains.Annotations;
using System.Collections.Generic;

namespace LINGYUN.Abp.Notifications
{
    public interface INotificationDefinitionManager
    {
        [NotNull]
        NotificationDefinition Get([NotNull] string category);

        IReadOnlyList<NotificationDefinition> GetAll();

        NotificationDefinition GetOrNull(string category);
    }
}
