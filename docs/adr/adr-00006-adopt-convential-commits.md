# Adopt Conventional Commits
## Status
### Accepted

Decision Question: How should commit messages be standardized across the RPG Engine project?

Date: 2026-07-14

Decider(s): Aaron Mina

Supersedes: None

Superseded By: None

## Related Decisions

Depends On: [adr-00000-framework-philosophy](./adr-00000-framework-philosophy.md)

Extends: None

Related To: None

## Context and Problem

As the RPG Engine evolves, the project history will become an increasingly valuable source of information for contributors. Poorly written or inconsistent commit messages make it difficult to understand why changes were made, review project history, generate release notes, or identify when architectural decisions were introduced.

Without a consistent commit strategy, contributors may use different terminology, inconsistent formatting, or commit unrelated changes together. This reduces the usefulness of version control as a development and collaboration tool.

A standardized commit convention is therefore required to improve readability, encourage smaller and more focused commits, and create a consistent project history.

## Considered Options

### 1. Free-Form Commit Messages

Allow contributors to write commit messages in any format.

**Advantages**

- No learning curve.
- Maximum flexibility.
- Minimal overhead.

**Disadvantages**

- Inconsistent commit history.
- Difficult to scan and search.
- Poor support for automated tooling.
- Commit intent may be unclear.

### 2. Conventional Commits

Adopt the Conventional Commits specification.

**Advantages**

- Consistent commit history.
- Clearly communicates the intent of each change.
- Encourages focused commits.
- Supports automated tooling and release generation.
- Widely recognized throughout the software industry.

**Disadvantages**

- Requires contributors to learn the convention.
- Adds minor overhead when creating commits.

## Decision

The RPG Engine shall adopt the **[Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0)** specification for all source control commits.

The complete commit format, commit types, examples, and contributor expectations are defined in the Project Standard:

- [Conventional Commits Standard](../standards/conventional-commits.md)

## Consequences
### Positive
1. Establishes a consistent and searchable project history.
1. Improves readability and understanding of commit intent.
1. Enables compatibility with tooling that understands Conventional Commits.
1. Encourages smaller, more focused commits.

### Negative
1. Contributors must learn and consistently apply the convention.
1. Creating commit messages requires slightly more discipline.
1. Existing contributors may need to adjust established workflows.