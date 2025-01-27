﻿using Nop.Services.Plugins;
using Nop.Web.Framework.Events;

namespace Nop.Plugin.Misc.Dynamics365.Services;

/// <summary>
/// Represents plugin event consumer
/// </summary>
public class EventConsumer : BaseAdminMenuCreatedEventConsumer
{
    public EventConsumer(IPluginManager<IPlugin> pluginManager) :
        base(pluginManager)
    {
    }

    /// <summary>
    /// Gets the plugin system name
    /// </summary>
    protected override string PluginSystemName => Dynamics365Defaults.SystemName;

    /// <summary>
    /// The system name of the menu item before with need to insert the current one
    /// </summary>
    protected override string BeforeMenuSystemName => "Local plugins";
}