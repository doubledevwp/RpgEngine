# Adopt a Modular Monolith Architecture

## Status
Accepted

Date: 2026-07-14

Decider(s): Aaron Mina

## Context and Problem

The RPG Engine is intended to become a reusable framework for developing tabletop role-playing game systems rather than a single application. As the framework evolves, additional domains such as character creation, combat, inventory management, rules engines, persistence, APIs, and user interfaces will be introduced.

Without a well-defined architectural structure, the solution could quickly become difficult to navigate, maintain, and extend. Placing all functionality into a single project would increase coupling between unrelated components, make testing more difficult, and reduce the ability to evolve individual subsystems independently.

Conversely, adopting a distributed architecture such as microservices would introduce unnecessary complexity for a framework that is primarily intended to be consumed as a set of libraries.

An architectural approach is needed that provides clear boundaries between domains while remaining simple to develop, test, and distribute.

## Considered Options

### 1. Single Class Library

Place all functionality into a single project.

**Advantages**

- Simplest solution structure.
- Minimal project management overhead.
- Easy for very small applications.

**Disadvantages**

- Poor separation of concerns.
- Difficult to scale as the framework grows.
- Increased coupling between unrelated features.
- Larger compile times.
- Harder to test and maintain.

---

### 2. Modular Monolith

Separate the solution into multiple class libraries, each representing a major business domain while remaining part of a single deployable solution.

**Advantages**

- Clear separation of responsibilities.
- Easier navigation.
- Independent unit testing.
- Encourages loose coupling.
- Individual projects can later become NuGet packages.
- Allows the architecture to grow naturally without unnecessary operational complexity.

**Disadvantages**

- More projects to maintain.
- Requires discipline when defining dependencies.

---

### 3. Microservices

Split the framework into independently deployable services.

**Advantages**

- Independent deployment.
- Independent scaling.
- Clear service ownership.

**Disadvantages**

- Considerably more operational complexity.
- Requires distributed communication.
- Difficult to debug.
- Not appropriate for a reusable framework library.
- Adds infrastructure requirements without providing sufficient value.

## Decision

The RPG Engine will adopt a **Modular Monolith** architecture.

Each major business domain will be implemented as its own project within a single solution. Projects should represent cohesive functional areas of the engine rather than technical layers.

Initial projects include, but are not limited to:

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

This architecture provides clear boundaries while maintaining the simplicity of a single solution. As the framework grows, additional domains can be introduced without disrupting existing components.

The architecture is intended to encourage high cohesion within projects and low coupling between projects.

Although the solution is organized as a modular monolith, individual projects should be designed with sufficient independence that they may later be distributed as standalone NuGet packages if doing so provides value.

## Decision Rules

1. Every major business domain shall be implemented as its own project.
2. Projects shall have a single, well-defined responsibility.
3. Shared abstractions and common functionality belong in `RpgEngine.Core`.
4. Circular project references are prohibited.
5. Projects should depend only on the minimum number of other projects necessary to perform their responsibilities.
6. Test projects shall mirror the production projects they validate.
7. New projects should only be introduced when they represent a distinct architectural boundary rather than simply reducing file count.
8. The solution shall remain a modular monolith unless a future ADR explicitly supersedes this decision.

## Consequences

1. Good - Business domains remain isolated, making the solution easier to understand and maintain.
2. Good - Developers can work within individual projects without needing to understand the entire framework.
3. Good - Unit testing becomes simpler because projects have clearly defined responsibilities.
4. Good - The architecture supports incremental growth as additional game systems and engine components are introduced.
5. Good - Individual projects may be published as independent NuGet packages in the future if desired.
6. Good - Clear project boundaries reduce coupling and encourage better software design.
7. Good - The solution remains simple to build, debug, and deploy while avoiding the complexity of distributed systems.
8. Bad - Additional projects increase solution management overhead.
9. Bad - Developers must exercise discipline to prevent inappropriate dependencies between projects.
10. Bad - Architectural boundaries must be reviewed periodically to ensure projects continue to represent cohesive domains as the framework evolves.