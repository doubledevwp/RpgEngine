# Architectural Decision Records (ADRs)

This directory contains the Architectural Decision Records (ADRs) for the RPG Engine project.

Architectural Decision Records document **why** significant architectural decisions were made. They preserve the project's architectural history by recording the problem being solved, the alternatives that were considered, the selected solution, and the long-term consequences of that decision.

Unlike Project Standards, ADRs are historical records. If an architectural decision changes, create a new ADR that supersedes or deprecates the previous decision rather than modifying the original record.

---

# Creating a New ADR

When creating a new ADR:

1. Copy the project ADR template.
1. Assign the next available ADR number.
1. Rename the file using the project naming convention.
1. Complete all required sections.
1. Reference related ADRs where appropriate.
1. Submit the ADR for review.

See:

- [template.md](./template.md)
- [authoring-guide.md](./authoring-guide.md)

---

# When to Create an ADR

Create an ADR when the decision:

- Has long-term architectural impact.
- Influences multiple areas of the project.
- Has multiple reasonable alternatives.
- Is likely to be questioned by future contributors.
- Would be difficult or expensive to reverse.

Examples include:

- System architecture
- Technology selection
- Project organization
- Dependency direction
- Deployment strategy
- Public API philosophy

---

# When Not to Create an ADR

Do not create ADRs for:

- Bug fixes
- Feature implementations
- Coding style
- Build configuration
- Dependency updates
- Routine maintenance
- Temporary workarounds

These topics generally belong in the project standards or other project documentation.

---

# When Writing an ADR

For detailed guidance on writing ADRs, see:

- [authoring-guide.md](./authoring-guide.md)
