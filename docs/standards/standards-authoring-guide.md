# Standards Authoring Guide

## Purpose

This guide explains how to create and maintain Project Standards for the RPG Engine project.

Project Standards define the expected practices, conventions, and requirements that contributors shall follow throughout the project.

For general documentation conventions, refer to the **Documentation Guide**.

---

## What is a Standard?

A Project Standard defines a repeatable expectation for contributors.

Standards document **how** work is expected to be performed rather than **why** the expectation exists.

Examples include:

- Coding conventions
- Testing practices
- Build configuration
- Commit message conventions
- Pull request requirements

---

## Relationship to ADRs

Architectural Decision Records document **why** a significant architectural decision was made.

Project Standards document **how** contributors are expected to implement or follow that decision.

When an ADR establishes an ongoing project practice, the implementation details should be maintained in a Project Standard rather than the ADR itself.

Not every Project Standard requires an ADR.

Likewise, not every ADR requires a Project Standard.

---

## When to Create a Standard

Create a Project Standard when defining guidance that contributors are expected to follow consistently.

Examples include:

- Coding practices
- Repository conventions
- Build processes
- Testing expectations
- Documentation conventions
- Source control practices
- Continuous Integration processes

---

## When Not to Create a Standard

Do not create a Project Standard for:

- Architectural decisions
- Feature documentation
- Release notes
- Tutorials
- Design discussions
- Temporary processes
- Team announcements

These belong in other forms of project documentation.

---

## Scope

Each Project Standard should define a single subject.

Avoid combining multiple independent topics into a single document.

If a standard becomes difficult to navigate, consider dividing it into multiple standards.

---

## Writing Standards

A Project Standard should:

- Clearly define project expectations.
- State requirements unambiguously.
- Organize related requirements together.
- Reference other documentation instead of duplicating information.

A Project Standard should not:

- Explain architectural reasoning.
- Record historical decisions.
- Duplicate content maintained elsewhere.
- Serve as a tutorial unless instructional material is intentionally included.

---

## Exceptions

When exceptions exist, document them explicitly.

Exceptions should be limited and clearly justified.

Avoid creating exceptions that weaken the intent of the standard.

---

## Maintaining Standards

Unlike ADRs, Project Standards are living documents.

Update a standard whenever project practices evolve.

When making significant changes:

- Preserve consistency with related standards.
- Review references to other documentation.
- Remove obsolete guidance.
- Avoid duplicating information that is maintained elsewhere.

---

## Authoring Checklist

Before publishing a Project Standard, verify that:

- The standard defines a single subject.
- Requirements are clear and unambiguous.
- Related requirements are grouped logically.
- Exceptions are documented when appropriate.
- Related documentation is referenced instead of duplicated.
- External references are included when appropriate.
- The document remains concise and focused.