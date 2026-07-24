# Adopt a Modular Monolith Architecture

## Status
Accepted

Decision Question: How should the RPG Engine solution be architected to support long-term growth and maintainability?

Date: 2026-07-14

Decider(s): Aaron Mina

Supersedes: None

Superseded By: None

## Related Decisions

Depends On: [adr-00000-framework-philosophy](./adr-00000-framework-philosophy.md)

Extends: None

Related To: [adr-00003-organize-projects-by-business-domains](./adr-00003-organize-projects-by-business-domain.md)

## Context and Problem

The RPG Engine is intended to become a reusable framework for developing tabletop role-playing game systems rather than a single application. As the framework evolves, additional domains such as character creation, combat, inventory management, rules engines, persistence, APIs, and user interfaces will be introduced.

Without a well-defined architectural structure, the solution could quickly become difficult to navigate, maintain, and extend. Placing all functionality into a single project would increase coupling between unrelated components, make testing more difficult, and reduce the ability to evolve individual subsystems independently.

Conversely, adopting a distributed architecture such as microservices would introduce unnecessary complexity for a framework that is primarily intended to be consumed as a set of libraries.

An architectural approach is needed that provides clear boundaries between business domains while remaining simple to develop, test, and maintain throughout the lifetime of the framework.

## Considered Options

### 1. Single Class Library

Place all functionality into a single project.

**Advantages**

- Simplest solution structure.
- Minimal project management overhead.
- Easy to understand for very small applications.

**Disadvantages**

- Poor separation of concerns.
- Difficult to scale as the framework grows.
- Increased coupling between unrelated features.
- Longer build times as the project grows.
- More difficult to test and maintain.

### 2. Modular Monolith

Separate the solution into multiple projects, each representing a major business domain while remaining part of a single deployable solution.

**Advantages**

- Clear separation of responsibilities.
- Easier navigation.
- Independent unit testing.
- Encourages high cohesion and loose coupling.
- Individual projects may later be published as standalone NuGet packages.
- Allows the architecture to evolve without unnecessary operational complexity.

**Disadvantages**

- More projects to maintain.
- Requires architectural discipline when defining project boundaries and dependencies.

### 3. Microservices

Split the framework into independently deployable services.

**Advantages**

- Independent deployment.
- Independent scaling.
- Clear service ownership.

**Disadvantages**

- Significantly greater operational complexity.
- Requires distributed communication.
- More difficult to develop, debug, and test.
- Not appropriate for a reusable framework.
- Introduces infrastructure requirements that provide little value for this project.

## Decision

The RPG Engine shall adopt a **Modular Monolith** architecture.

Each major business domain shall be implemented as its own project within a single solution. Projects should represent cohesive business capabilities rather than technical layers.

The initial solution structure includes, but are not limited to:

```
src/
    RpgEngine.Core
    RpgEngine.Dice
    RpgEngine.Characters
    RpgEngine.Combat
    RpgEngine.Rules
    RpgEngine.Items

tests/
    RpgEngine.Core.Tests
    RpgEngine.Dice.Tests
    RpgEngine.Characters.Tests
```

This architecture provides clear boundaries between business domains while maintaining the simplicity of a single deployable solution. As the framework grows, additional domains can be introduced with minimal impact on existing projects.

The solution shall favor **high cohesion within projects** and **low coupling between projects**.

Projects should be designed with sufficient independence that they may later be published as standalone NuGet packages if doing so provides value.

## Decision Rules

1. Every major business domain shall be implemented as its own project.
1. Every project shall have a single, well-defined responsibility.
1. Shared abstractions and common functionality shall reside in `RpgEngine.Core`.
1. Circular project references are prohibited.
1. Projects shall depend only on the minimum number of other projects necessary to fulfill their responsibilities.
1. Test projects shall mirror the production projects they validate.
1. New projects shall represent meaningful architectural boundaries rather than simply reducing file count.
1. The solution shall remain a modular monolith unless a future ADR explicitly supersedes this decision.

## Consequences
### Positive

1. Business domains remain isolated, making the solution easier to understand and maintain.
1. Developers can work within individual projects without needing to understand the entire framework.
1.  Unit testing becomes simpler because projects have clearly defined responsibilities.
1. The architecture supports incremental growth as additional domains and engine components are introduced.
1. Individual projects may be later be published as standalone NuGet packages if doing so provides value.
1. Clear project boundaries encourage loose coupling and high cohesion.
1. Good - The solution remains straightforward to build, debug, and deploy while avoiding the complexity of distributed systems.

### Negative

1. Additional projects increase solution management overhead.
1. Contributors must exercise architectural discipline to avoid inappropriate dependencies between projects.
1. Project boundaries should be periodically reviewed to ensure they continue to represent cohesive business domains.
