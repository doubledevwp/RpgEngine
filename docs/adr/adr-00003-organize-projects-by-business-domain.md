# Organize Projects by Business Domain

## Status
Accepted

Date: 2026-07-14

Decider(s): Aaron Mina

## Context and Problem

ADR-00002 establishes that the RPG Engine is organized as a Modular Monolith composed of multiple independent projects. Once those architectural boundaries have been defined, a consistent approach is required for organizing the source code within each project.

As projects grow, poor organization can make navigation difficult, increase coupling between unrelated components, and reduce developer productivity. A project structure should allow contributors to quickly locate related functionality while encouraging cohesive design and minimizing unnecessary dependencies.

Several organizational strategies are commonly used within software projects. The chosen approach should support the long-term goals established in ADR-00000 while reinforcing the modular architecture defined in ADR-00002.

## Considered Options

### 1. Layer-Oriented Organization

Organize code by technical responsibility.

Example:

```
Controllers
Repositories
Services
Models
Interfaces
```

**Advantages**

- Familiar to many developers.
- Common in web applications.
- Easy to understand for small projects.

**Disadvantages**

- Business functionality becomes scattered across multiple folders.
- Changes to a single feature often require modifications in several locations.
- Encourages coupling around technical concerns rather than business capabilities.

---

### 2. Feature-Oriented Organization

Organize code by individual features.

Example:

```
CharacterCreation
Combat
Inventory
SpellCasting
```

**Advantages**

- Related code remains together.
- Works well for applications with clearly defined user-facing features.
- Simplifies feature ownership.

**Disadvantages**

- Feature boundaries may become difficult to define within a reusable framework.
- Can result in duplicated abstractions when multiple features require similar functionality.

---

### 3. Domain-Oriented Organization

Organize code around business domains and responsibilities.

Example:

```
Characters
    Builders
    Models
    Rules
    Services
    ValueObjects
```

**Advantages**

- Keeps related business concepts together.
- Reinforces the architecture established in ADR-00002.
- Supports extensibility as new capabilities are introduced.
- Encourages high cohesion and low coupling.

**Disadvantages**

- Requires greater architectural discipline.
- Developers unfamiliar with Domain-Driven Design may require time to adapt.

## Decision

Projects within the RPG Engine shall be organized by **business domain** rather than technical layer.

Each project should represent a cohesive business capability of the framework. Within that project, folders should reflect the concepts of that domain instead of generic technical responsibilities.

For example, a Characters project may contain:

```
Characters
    Builders
    Interfaces
    Models
    Rules
    Services
    ValueObjects
```

rather than:

```
Controllers
Repositories
Services
Models
```

The goal is not to eliminate technical organization entirely, but to ensure that code is organized in a way that reflects the business concepts of the framework.

Folder structures should remain simple and evolve naturally as each domain grows. Projects should avoid introducing unnecessary abstraction or deeply nested folder hierarchies before they provide measurable value.

## Decision Rules

1. Projects shall be organized around business domains rather than technical layers.
2. Folder names should describe business concepts whenever practical.
3. Related classes should remain together within the same domain.
4. Deeply nested folder structures should be avoided unless they significantly improve organization.
5. Generic folders such as `Misc`, `Helpers`, `Utilities`, or `Common` should be avoided whenever possible.
6. New folders should represent meaningful organizational boundaries rather than temporary convenience.
7. Shared functionality should be evaluated for placement in `RpgEngine.Core` as defined by ADR-00002 rather than duplicated across projects.
8. Folder organization should prioritize readability and discoverability over strict adherence to patterns.

## Consequences

1. Good - Developers can locate related functionality more quickly because business concepts remain grouped together.
2. Good - Projects become easier to understand without requiring knowledge of the entire framework.
3. Good - Related classes evolve together, improving cohesion and reducing unnecessary dependencies.
4. Good - The organization naturally supports future expansion as new domains are introduced.
5. Good - Folder structures remain consistent across the entire solution, reducing cognitive load for contributors.
6. Good - The project organization reinforces the architectural boundaries established in ADR-00002.
7. Bad - Contributors must exercise discipline to prevent technical-layer thinking from influencing project organization.
8. Bad - Some developers may initially find the structure unfamiliar if they primarily have experience with layer-oriented architectures.
9. Bad - Folder structures should be periodically reviewed to ensure they continue to represent the domain as it evolves.