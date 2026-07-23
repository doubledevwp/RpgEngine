# Use Architectural Decision Records

## Status
Accepted

Date: 2026-07-18

Decider(s): Aaron Mina

## Context and Problem

As the RPG Engine evolves, numerous architectural, technological, and organizational decisions will be made. While many of these decisions may seem obvious when they are made, the reasoning behind them often becomes difficult to recall as the project grows and evolves.

Without documenting significant architectural decisions, future contributors—including the original author—may struggle to understand why certain approaches were chosen, what alternatives were considered, or whether a decision is still valid. This can lead to duplicated discussions, inconsistent implementations, and unnecessary architectural drift.

The project philosophy established in ADR-00000 emphasizes maintainability, consistency, and thoughtful design. Capturing architectural decisions in a structured and repeatable format supports those principles by preserving the rationale behind important decisions and providing historical context for future development.

A standardized approach to documenting architectural decisions is therefore required.

## Considered Options

1. **Markdown Architectural Decision Records ([MADR](https://adr.github.io/madr/examples.html))**
   - Provides both short and long templates.
   - Well-established within the software architecture community.
   - Encourages thorough documentation.
   - May include sections that are unnecessary for this project's needs.

1. **[Michael Nygard's ADR Template](https://github.com/architecture-decision-record/architecture-decision-record/tree/main/locales/en/templates/decision-record-template-by-michael-nygard)**
   - The original and widely recognized ADR format.
   - Simple and easy to maintain.
   - Provides only the essential sections.
   - May not provide enough structure for documenting long-term architectural guidance.

1. **Custom Hybrid Format**
   - Combines the simplicity of Nygard's template with the structure of MADR.
   - Can evolve alongside the project.
   - Allows project-specific conventions to be incorporated.
   - Requires additional effort to define and maintain.

## Decision

The RPG Engine will use a custom Architectural Decision Record format based primarily on the concepts introduced by Michael Nygard and MADR while adapting the structure to better fit the needs of this project.

Each ADR **should** clearly communicate:

- The problem being solved.
- The alternatives that were considered.
- The reasoning behind the selected solution.
- The long-term consequences of the decision.
- Any principles or rules established by the decision.

Architectural Decision Records should document **significant architectural decisions**, not implementation details. They should explain *why* the project is designed the way it is rather than describing *how* individual features were implemented.

ADRs are considered living documents. If an architectural decision changes over time, the existing ADR should not be rewritten to hide history. Instead, a new ADR should supersede or deprecate the previous decision, preserving the architectural evolution of the project.

Architectural Decision Records document why the architecture exists in its current form.

They are **not** intended to replace:

- API documentation
- User documentation
- Coding standards
- Development guides
- Pull request descriptions
- Commit history

## Decision Rules

1. Every significant architectural decision shall be documented as an ADR.
1. ADRs shall be written using Markdown.
1. ADR filenames shall follow the convention:

   ```
   adr-#####-short-description.md
   ```

   Example:

   ```
   adr-00002-organize-the-solution.md
   ```

1. ADR numbers are permanent identifiers and shall never be reused.
1. Existing ADRs should not be rewritten to change historical decisions. Instead, they should be superseded or deprecated by a new ADR when appropriate.
1. Every ADR shall include the following sections:
   - Title
   - Status
   - Date
   - Decider(s)
   - Context and Problem
   - Considered Options
   - Decision
   - Decision Rules or Decision Principles (when applicable)
   - Consequences
1. ADRs should focus on architectural decisions rather than implementation details, coding standards, or routine maintenance activities.
1. ADRs should be concise but provide sufficient detail for future contributors to understand the reasoning behind each decision.

## Consequences

1. Good - Important architectural decisions will be preserved alongside the source code instead of being lost in commit history or personal notes.
1. Good - Future contributors will better understand not only *what* decisions were made, but *why* they were made.
1. Good - Architectural discussions can build upon previous decisions instead of repeatedly revisiting the same topics.
1. Good - The project will develop a documented architectural history that records how the framework evolved over time.
1. Good - New contributors will have a centralized source of architectural guidance, reducing onboarding time.
1. Good - Architectural consistency will improve because new decisions can reference and build upon existing ADRs.
1. Bad - Writing ADRs requires additional effort before or during implementation.
1. Bad - ADRs must be maintained as the project evolves to ensure they remain accurate and relevant.
1. Bad - Contributors must exercise judgment to determine which decisions warrant an ADR versus documentation in coding standards or developer guides.
