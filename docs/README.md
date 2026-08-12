# Documentation

This directory contains the primary project documentation for the RPG Engine.

The documentation is organized by purpose so that contributors can quickly determine where new documentation belongs and where existing information can be found.

---

## Documentation Structure

```text
docs/
├── adr/
├── standards/
└── README.md
```

### Architectural Decision Records (`adr/`)

Architectural Decision Records (ADRs) document **why** significant architectural decisions were made.

An ADR captures the problem being solved, the alternatives that were considered, the selected solution, and the long-term consequences of the decision. ADRs preserve the architectural history of the project and are intended to remain as permanent records.

Examples include:

- Project Philosophy
- Modular Monolith Architecture
- Development Platform
- Project Organization

Use an ADR when answering questions such as:

- Why was this architectural approach chosen?
- What alternatives were considered?
- What architectural principles govern this decision?

---

### Project Standards (`standards/`)

Project Standards document **how** contributors are expected to work within the project.

Unlike ADRs, standards are living documents that evolve as the project's development practices change.

Examples include:

- Coding Style
- Conventional Commits
- Build Configuration
- Testing Standards
- Pull Request Guidelines

Use a Standard when answering questions such as:

- How should contributors perform this task?
- What conventions should be followed?
- What is the current project expectation?

---

## Choosing the Correct Document

| If your document answers... | Create... |
| --------------------------- | --------- |
| **Why was this architectural decision made?** | ADR |
| **How should contributors work?** | Standard |
| **How do I use this feature?** | User or Developer Documentation |
| **How do I set up the project?** | Contributing or Setup Documentation |

---

## Documentation Principles

The RPG Engine documentation follows these principles:

- Maintain a single authoritative source for each piece of information.
- Avoid duplicating information across documents.
- Reference related documentation instead of copying it.
- Keep documentation focused on a single purpose.
- Update standards as practices evolve.
- Preserve ADRs as historical records of architectural decisions.

---

## Contributing

When adding new documentation:

1. Determine the purpose of the document.
1. Place it in the appropriate directory.
1. Follow the corresponding project template.
1. Reference related documentation where appropriate.
1. Keep the document focused on a single topic.