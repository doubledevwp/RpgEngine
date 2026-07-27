# ADR Authoring Guide

This document defines the writing conventions for Architectural Decision Records (ADRs) within the RPG Engine project.

The goal of this guide is to ensure that every ADR follows a consistent structure, writing style, and documentation approach, making the project's architectural history easy to read, understand, and maintain.

---

# Purpose

Architectural Decision Records are historical documents that explain **why** significant architectural decisions were made.

This guide establishes the conventions used when authoring ADRs. It complements the ADR template by providing guidance rather than structure.

---

# General Principles

When writing an ADR:

1. Focus on a single architectural decision.
1. Explain the decision rather than the implementation.
1. Write for future contributors who may have no knowledge of the original discussion.
1. Prefer clarity over completeness.
1. Keep the ADR concise while providing enough context to understand the decision.
1. Reference related documentation instead of duplicating it.

## Keep the Scope Focused

Each ADR should answer a single architectural question.

If documenting one decision requires answering additional architectural questions, consider creating separate ADRs and linking them using the relationship fields.

Smaller, focused ADRs are generally easier to understand, maintain, and reference than large ADRs that attempt to document multiple decisions.

---

# Writing Style

## Use Clear Language

Write using clear, professional language.

Avoid unnecessary jargon or ambiguous wording.

Assume the reader is familiar with software architecture but not necessarily with the history of the project.

---

## Be Objective

Describe the decision and its rationale objectively.

Avoid subjective phrases such as:

- "Obviously..."
- "Everyone knows..."
- "The best solution..."

Instead, explain *why* the selected option was appropriate.

---

## Keep Sections Focused

Each section should answer a single question.

| Section | Purpose |
|---------|---------|
| Context and Problem | Why is this decision necessary? |
| Considered Options | What alternatives were evaluated? |
| Decision | What was chosen? |
| Consequences | What are the long-term effects? |

Avoid discussing unrelated topics.

---

# Decision Guidance

## Decision Question

The Decision Question should be phrased as the architectural question
being answered by the ADR.

Good: 
 > How should project configuration be centralized?

Less Desirable:
> Build Configuration


## Consider Multiple Options

Whenever practical, include multiple reasonable alternatives.

A decision without alternatives often fails to explain *why* the chosen approach was selected.

---

## Explain Trade-offs

Every architectural decision has benefits and drawbacks.

Document both.

Future contributors should understand not only what was gained, but also what was intentionally sacrificed.

---

## Record the Decision

The Decision section should state the outcome clearly.

Avoid mixing rationale into the decision itself.

Good:

> The project will adopt a Modular Monolith architecture.

Less desirable:

> The project will adopt a Modular Monolith because...

The reasoning belongs elsewhere.

---

# Relationships

Reference other ADRs whenever they influence the current decision.

Use the relationship fields consistently.

| Relationship | Meaning |
|-------------|---------|
| Depends On | Requires another ADR. |
| Extends | Builds upon another ADR. |
| Related To | Connected but independent. |
| Supersedes | Updates or amends an earlier ADR. |
| Superseded By | Replaced by a newer ADR. |

---

# Status Values

Use one of the following values.

| Status | Meaning |
|---------|---------|
| Proposed | Under consideration. |
| Accepted | Approved and active. |
| Deprecated | No longer recommended. |
| Rejected | Considered but not adopted. |
| Superseded | Replaced by a newer ADR. |

---

# Naming Convention

ADR filenames shall follow this format.

```
adr-00000-short-descriptive-title.md
```

Examples:

```
adr-00000-project-philosophy.md
adr-00001-adopt-architectural-decision-records.md
adr-00002-adopt-a-modular-monolith-architecture.md
```

ADR numbers are never reused.

---

# Numbering

Assign ADR numbers sequentially.

Once assigned, an ADR number is permanent.

If an ADR is rejected or superseded, its number remains part of the historical record.

---

# Markdown Conventions

Use the project's standard Markdown formatting.

Examples include:

- ATX headings (`#`, `##`, `###`)
- Tables where appropriate
- Callouts for notes
- Repeated `1.` numbering for ordered lists
- Relative links when referencing project documentation

---

# Common Mistakes

Avoid:

- Combining multiple architectural decisions into one ADR.
- Describing implementation details instead of architectural decisions.
- Omitting alternatives.
- Omitting disadvantages.
- Rewriting history after an ADR has been accepted.
- Copying large sections from other ADRs.

---

# Checklist

Before submitting an ADR:

- [ ] One architectural question is answered.
- [ ] Alternatives were considered.
- [ ] Trade-offs are documented.
- [ ] Related ADRs are referenced.
- [ ] The document follows the ADR template.
- [ ] The writing follows this style guide.