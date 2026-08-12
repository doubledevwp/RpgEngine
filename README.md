# RpgEngine
[![Conventional Commits](https://img.shields.io/badge/Conventional%20Commits-1.0.0-%23FE5196?logo=conventionalcommits&logoColor=white)](https://conventionalcommits.org)

A modern .NET framework for building modular tabletop RPG engines, games, and developer tools.

## Overview

RPG Engine is a reusable framework for developing tabletop role-playing game systems.

The goal of the project is to provide a modular foundation for implementing game mechanics without tying the engine to a single ruleset, game, or presentation layer.

Applications built on the framework may include:

* Command-line tools
* REST APIs
* Web applications
* Desktop applications
* Discord bots
* Game-specific tools and integrations

The framework itself is intended to provide reusable engine capabilities that these applications can build upon.

> [!NOTE]
> RPG Engine is currently under active development. APIs, modules, and project structure may continue to evolve as the architecture is established.

## Project Philosophy

RPG Engine prioritizes:

* Maintainability
* Readability
* Extensibility
* Correctness

These qualities are intentionally prioritized over development speed.

Significant architectural decisions are documented using [Architectural Decision Records](./docs/adr/), allowing the reasoning behind the framework's design to remain visible as the project evolves.

## Architecture

RPG Engine uses a **Modular Monolith** architecture.

Major business domains are separated into independent projects within a single solution. This provides clear boundaries between engine capabilities while avoiding the operational complexity of a distributed architecture.

Current modules include:

```text
src/
├── RpgEngine.Characters
├── RpgEngine.Combat
├── RpgEngine.Core
├── RpgEngine.Items
├── RpgEngine.Persistence.Memory
└── RpgEngine.Rules
```

The architecture favors:

* High cohesion within projects
* Low coupling between projects
* Clear domain boundaries
* Independent testing
* Future extensibility

## Repository Structure

```text
RpgEngine/
├── docs/               Project documentation
│   ├── adr/            Architectural Decision Records
│   └── standards/      Project development standards
│
├── samples/            Example applications
│   └── ConsoleDemo/
│
├── src/                Production projects
├── tests/              Automated test projects
│
├── RpgEngine.slnx      .NET solution
├── LICENSE
└── README.md
```

## Documentation

Project documentation is organized by purpose.

### Architectural Decision Records

[Architectural Decision Records](./docs/adr/) explain **why** significant architectural decisions were made.

They document:

* The architectural problem
* Alternatives considered
* The selected decision
* Consequences and trade-offs
* Relationships between architectural decisions

### Project Standards

[Project Standards](./docs/standards/) explain **how** contributors are expected to work within the project.

Standards cover development practices such as:

* Commit conventions
* Build configuration
* Coding practices
* Testing practices
* Documentation practices

See the [Documentation Overview](./docs/) for additional information about the documentation structure.

## Building the Project

### Prerequisites

* .NET SDK compatible with the version targeted by the repository
* Git

Clone the repository:

```bash
git clone https://github.com/doubledevwp/RpgEngine.git
cd RpgEngine
```

Build the solution:

```bash
dotnet build RpgEngine.slnx
```

Run the tests:

```bash
dotnet test RpgEngine.slnx
```

## Samples

Example applications are located in the [`samples`](./samples/) directory.

The current console demonstration can be found at:

```text
samples/ConsoleDemo/
```

Samples demonstrate how applications can consume the framework without placing application-specific behavior inside the engine itself.

## Contributing

The project is being developed incrementally, with an emphasis on thoughtful architecture, testing, documentation, and small focused changes.

Before contributing, review:

* [Project Documentation](./docs/)
* [Architectural Decision Records](./docs/adr/)
* [Project Standards](./docs/standards/)

Contributions should follow the architectural decisions and project standards established in those documents.

## License

RPG Engine is licensed under the [MIT License](./LICENSE).
