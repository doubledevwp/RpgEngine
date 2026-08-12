# ADR Authoring Guide

## Purpose

This guide explains how to create and maintain Architectural Decision Records (ADRs) for the RPG Engine project.

Architectural Decision Records document significant architectural decisions and preserve the reasoning behind those decisions for future contributors.

For general documentation conventions, refer to the **[Documentation Guide](./documetation-guide.md)**.

---

## What is an ADR?

An Architectural Decision Record (ADR) documents a single architectural decision.

An ADR records:

- The architectural problem.
- The options that were considered.
- The decision that was made.
- The expected consequences.

An ADR captures **why** a decision was made rather than **how** it was implemented.

---

## When to Create an ADR

Create an ADR when making a significant architectural decision that is expected to influence the project over time.

Examples include:

- Architectural style
- Framework or platform selection
- Repository organization
- Testing strategy
- Dependency strategy
- Long-term development standards
- Cross-cutting architectural patterns

---

## When Not to Create an ADR

Do not create ADRs for routine development work.

Examples include:

- Bug fixes
- Feature implementations
- Refactoring
- Documentation updates
- Temporary workarounds
- Release notes
- Day-to-day development decisions

---

## Decision Questions

Every ADR shall answer a single architectural question.

The Decision Question should clearly describe the problem being solved.

Good examples:

- How should project configuration be centralized?
- Which testing framework should the project adopt?
- How should project modules be organized?

Less desirable examples:

- Build Configuration
- Testing
- Project Structure

The title identifies the decision.

The Decision Question identifies the architectural problem.

---

## Scope

Each ADR should document one architectural decision.

If multiple independent decisions exist, create multiple ADRs.

Small, focused ADRs are easier to review, understand, and maintain.

---

## Decision Status

Each ADR records its current lifecycle.

Available status values are:

- Proposed
- Accepted
- Deprecated
- Rejected
- Superseded
- Withdrawn
- Obsolete

---

## Related Decisions

Architectural decisions often influence one another.

Use the Related Decisions section to document these relationships.

### Depends On

The current ADR relies on another accepted decision.

### Extends

The current ADR builds upon another decision without replacing it.

### Related To

The ADR has a meaningful architectural relationship with another decision.

### Supersedes

The current ADR replaces an earlier ADR.

### Superseded By

A newer ADR replaces the current ADR.

---

## Relationship to Standards

Architectural Decision Records document **why** an architectural decision was made.

Project Standards document **how** contributors are expected to implement or follow that decision.

When an ADR establishes an ongoing project practice, the implementation details should be maintained in a Project Standard rather than the ADR itself.

---

## Maintaining ADRs

Accepted ADRs are historical records.

Do not rewrite an accepted ADR to reflect later architectural changes.

Instead:

- Create a new ADR.
- Link the related decisions.
- Update the status where appropriate.

This preserves the evolution of the project's architecture over time.

---

## Authoring Checklist

Before submitting an ADR, verify that:

- The ADR answers a single Decision Question.
- The architectural problem is clearly described.
- Reasonable alternatives were considered.
- The selected decision is clearly stated.
- Positive and negative consequences are documented.
- Related decisions are referenced where appropriate.
- The ADR does not duplicate information maintained elsewhere.
- References are included when appropriate.
