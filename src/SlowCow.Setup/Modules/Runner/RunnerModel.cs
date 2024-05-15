﻿using System;
namespace SlowCow.Setup.Modules.Runner;

public record RunnerModel
{
    public const string DefaultChannel = "stable";

    /// <summary>
    /// Unique identifier of the application is required for installing/uninstalling process.
    /// </summary>
    public required Guid ApplicationId { get; init; }

    /// <summary>
    /// Executable application relative path from the root of the installation folder.
    /// </summary>
    public required string ExecutableFileName { get; init; }

    /// <summary>
    /// Application display name. Will be used for links and folder names.
    /// </summary>
    public required string Name { get; init; } = "Application Name";
    public required string Description { get; init; } = "Please provide a description for your application.";
    public string Publisher { get; init; } = string.Empty;
    public string Channel { get; init; } = DefaultChannel;
    public bool HasRepairFlag { get; init; }

    public string InstallationFolderName => Name;
}