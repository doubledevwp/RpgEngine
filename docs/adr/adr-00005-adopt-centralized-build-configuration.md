# Adopt Centralized Build Configuration
## Status
### Accepted

Decision Question: How should build configuration be managed consistently across the RPG Engine solution?

Date: 2026-07-14

Decider(s): Aaron Mina

Supersedes: None

Superseded By: None

## Related Decisions

Depends On: [ADR-00000-framework-philosophy](./adr-00000-framework-philosophy.md), [ADR-00002-adopt-a-modular-monolith-architecture](./adr-00002-adopt-a-modular-monolith-architecture.md)
, [ADR-00004-select-the-development-platform](./adr-00004-select-the-development-platform.md)

Extends: None

Related To: None

## Context and Problem

The RPG Engine is organized as a Modular Monolith consisting of multiple projects that collectively form a single framework. As the number of projects grows, maintaining consistent build settings across every project becomes increasingly difficult.

Duplicating compiler settings, language versions, nullable reference type configuration, warning policies, package metadata, and other build properties within every project increases maintenance effort and introduces the risk of configuration drift. Even minor inconsistencies can lead to different compiler behavior, reduced code quality, or unexpected build failures.

A centralized approach is required to ensure that all projects within the solution are built using the same standards while allowing individual projects to override settings only when a legitimate architectural need exists.

## Considered Options
### 1. Configure Each Project Independently

Each project maintains its own build configuration.

**Advantages**

- Complete flexibility for each project.
- Easy to understand in very small solutions.
- No shared build configuration files.

**Disadvantages**

- Significant duplication.
- High risk of inconsistent settings.
- More difficult to maintain as the solution grows.
- Updating build standards requires changes to every project.

### 2. Centralized Build Configuration

Store shared build settings in solution-level build configuration files such as `Directory.Build.props` and `Directory.Build.targets`.

**Advantages**

- Single authoritative source for shared build configuration.
- Consistent compiler behavior across the solution.
- Simplifies maintenance.
- Reduces duplication.
- Makes adopting new build standards significantly easier.

**Disadvantages**

- Contributors must understand centralized MSBuild configuration.
- Individual project overrides require careful consideration.

## Decision

The RPG Engine shall centralize shared build configuration using solution-level MSBuild configuration files.

Common compiler options, language settings, code quality rules, package metadata, and other solution-wide build properties shall be defined in `Directory.Build.props` or `Directory.Build.targets` whenever practical.

Individual project files should contain only configurations that are specific to that project. Shared configurations shall not be duplicated across multiple project files unless a documented exception exists.

Centralizing build configuration establishes a single authoritative source for solution-wide build behavior, improves maintainability, and reduces configuration drift as the framework evolves.

## Decision Rules

1. Shared build configuration shall be defined in solution-level MSBuild configuration files whenever practical.
1. Project files shall contain only project-specific build configuration.
1. Shared compiler options shall not be duplicated across project files.
1. New solution-wide build settings shall be added to the centralized build configuration rather than copied into individual projects.
1. Project-specific overrides should be documented when they intentionally differ from the solution defaults.
1. Build configuration shall remain consistent across all production and test projects unless a documented exception exists.

## Consequences
### Positive
1. Build configuration remains consistent across the entire solution.
1. Compiler behavior is standardized for every project.
1. New build standards can be introduced by modifying a single configuration file.
1. Configuration drift between projects is significantly reduced.
1. Project files become smaller and easier to maintain.
1. Contributors have a single authoritative source for shared build configuration.

### Negative
1. Contributors must understand how centralized MSBuild configuration is applied.
1. Incorrect changes to centralized configuration may affect every project in the solution.
