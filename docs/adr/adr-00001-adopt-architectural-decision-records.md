# Adopt Architectural Decision Records

## Status
### Accepted

Decision Question: How should significant architectural decisions be documented throughout the RPG Engine?

Date: 2026-07-18

Decider(s): Aaron Mina

Supersedes: None

Superseded By: None

## Related Decisions

Depends On: [adr-00001-framework-philosophy](./adr-00000-framework-philosophy.md)

Extends: None

Related To: [adr-99999-standard-and-template](./adr-99999-standard-and-template.md)

## Context and Problem

As the RPG Engine evolves, numerous architectural, technological, and organizational decisions will be made. While many of these decisions may seem obvious when they are made, the reasoning behind them often becomes difficult to recall as the framework grows and evolves.

Without documenting significant architectural decisions, future contributors—including the original author—may struggle to understand why certain approaches were chosen, what alternatives were considered, or whether a decision is still valid. This can lead to duplicated discussions, inconsistent implementations, and unnecessary architectural drift.

The framework philosophy established in ADR-00000 emphasizes maintainability, consistency, and thoughtful design. Capturing architectural decisions in a structured and repeatable format supports those principles by preserving the rationale behind important decisions and providing historical context for future development.

A standardized approach to documenting architectural decisions is therefore required.

## Considered Options

### 1. **Markdown Architectural Decision Records ([MADR](https://adr.github.io/madr/examples.html))**

**Advantages**
   - Provides both short and long templates.
   - Well-established within the software architecture community.
   - Encourages thorough documentation.

**Disadvantages**
   - May include sections that are unnecessary for this framework's needs.

### 2. **[Michael Nygard's ADR Template](https://github.com/architecture-decision-record/architecture-decision-record/tree/main/locales/en/templates/decision-record-template-by-michael-nygard)**

**Advantages**
   - The original and widely recognized ADR format.
   - Simple and easy to maintain.
   - Provides only the essential sections.

**Disadvantages**
   - May not provide enough structure for documenting long-term architectural guidance.

### 3. **Custom Hybrid Format**
**Advantages**
   - Combines the simplicity of Nygard's template with the structure of MADR.
   - Can evolve alongside the framework.
   - Allows framework-specific conventions to be incorporated.

**Disadvantages**
   - Requires additional effort to define and maintain.

## Decision

The RPG Engine shall document significant architectural decisions using the standardized Architectural Decision Record format defined by this project.

Each ADR **shall** clearly communicate:

- The problem being solved.
- The alternatives that were considered.
- The reasoning behind the selected solution.
- The long-term consequences of the decision.
- Any principles or rules established by the decision.

Architectural Decision Records should document **significant architectural decisions**, not implementation details. They should explain *why* the framework is designed the way it is rather than describing *how* individual features were implemented.

Architectural Decision Records are living documents that describe the current and historical evolution of the framework's architecture. Historical decisions should be preserved. When an architectural decision changes, a new ADR should supersede, deprecate, or otherwise relate to the previous decision rather than rewriting history.

Architectural Decision Records document why the architecture exists in its current form.

They are **not** intended to replace:

- API documentation
- User documentation
- Coding standards
- Development guides
- Pull request descriptions
- Commit history

> [!Note]
> The ADR standard itself is subject to architectural evolution. Changes to the standard should be documented thoughtfully and applied consistently across the architecture handbook whenever practical.

## Decision Rules

1. Every significant architectural decision shall be documented as an ADR.
1. Every ADR shall answer a single architectural question.
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
1. Every ADR shall conform to the standard template defined by [ADR-99999-standard-and-template](./adr-99999-standard-and-template.md).
1. ADRs should focus on architectural decisions rather than implementation details, coding standards, or routine maintenance activities.
1. ADRs should be concise but provide sufficient detail for future contributors to understand the reasoning behind each decision.

## Consequences
### Positive
1. Important architectural decisions will be preserved alongside the source code instead of being lost in commit history or personal notes.
1. Future contributors will better understand not only *what* decisions were made, but *why* they were made.
1. Architectural discussions can build upon previous decisions instead of repeatedly revisiting the same topics.
1. The framework will develop a documented architectural history that records how the framework evolved over time.
1. New contributors will have a centralized and consistent source of architectural guidance, reducing onboarding time.
1. Architectural consistency will improve because new decisions can reference and build upon existing ADRs.

### Negative
1. Writing ADRs requires additional effort before or during implementation.
1. ADRs must be maintained as the framework evolves to ensure they remain accurate and relevant.
1. Contributors must exercise judgment to determine which decisions warrant an ADR versus documentation in coding standards or developer guides.
