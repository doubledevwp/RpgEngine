# Select the Development Platform

## Status
Accepted

Date: 2026-07-14

Decider(s): Aaron Mina

## Context and Problem

The RPG Engine is intended to be a long-lived framework that can support multiple applications including command-line tools, REST APIs, desktop applications, web applications, Discord bots, and other future integrations.

Selecting the development platform is one of the earliest and most significant architectural decisions because it influences nearly every aspect of the project, including language features, tooling, performance, package management, testing frameworks, deployment, community support, and long-term maintenance.

The selected platform should align with the project philosophy established in ADR-00000 and provide a stable, modern foundation capable of supporting the long-term goals of the RPG Engine.

## Considered Options

### 1. PHP

Develop the framework using PHP.

**Advantages**

- Large developer community.
- Mature package ecosystem.
- Common hosting environments.

**Disadvantages**

- Primarily focused on web development.
- Less suitable for a reusable engine intended to support multiple application types.
- Does not provide the language features, tooling, or development experience desired for this project.

---

### 2. Python

Develop the framework using Python.

**Advantages**

- Excellent readability.
- Large open-source ecosystem.
- Rapid development.

**Disadvantages**

- Dynamic typing increases the likelihood of runtime errors.
- Lower performance for computational workloads.
- Packaging and dependency management do not align as closely with the project's long-term maintenance goals.

---

### 3. .NET

Develop the framework using C# and the .NET platform.

**Advantages**

- Modern object-oriented language.
- Excellent tooling.
- Strong type system.
- High performance.
- Cross-platform support.
- Mature package ecosystem.
- Long-Term Support (LTS) releases.
- Excellent testing and debugging tools.

**Disadvantages**

- Requires developers to remain current with .NET LTS releases.
- New language features may require periodic learning and migration.

## Decision

The RPG Engine will be developed using **C#** on the **.NET Long-Term Support (LTS)** platform.

The project will target the current .NET LTS release and migrate to future LTS releases as practical. This approach provides a balance between long-term stability and access to modern language features, runtime improvements, security updates, and tooling enhancements.

The framework will adopt modern C# language features when they improve readability, maintainability, correctness, or developer productivity. New language features should not be adopted solely because they are available.

## Decision Rules

1. All production code shall target the current supported .NET LTS release.
1. Upgrades to newer .NET LTS releases should be evaluated after they become stable and supported.
1. Preview SDKs and preview language features shall not be used in production code unless explicitly approved by a future ADR.
1. Third-party libraries should be evaluated for compatibility with the project's supported .NET version before adoption.
1. Language features should improve readability and maintainability rather than simply demonstrating the latest syntax.

## Consequences

1. Good - The project benefits from Microsoft's long-term support lifecycle, providing security updates and platform stability.
1. Good - Contributors gain access to modern language features that improve code quality and developer productivity.
1. Good - Excellent tooling simplifies development, debugging, profiling, and testing.
1. Good - Strong typing and compile-time analysis reduce runtime defects.
1. Good - A mature package ecosystem reduces the need to reinvent common functionality.
1. Good - Long-Term Support releases provide predictable upgrade cycles and reduce maintenance risk.
1. Bad - Periodic upgrades are required to remain aligned with supported LTS releases.
1. Bad - Contributors should remain familiar with modern C# language features and .NET development practices.
1. Bad - Some third-party libraries may lag behind the latest LTS releases and require evaluation before adoption.
