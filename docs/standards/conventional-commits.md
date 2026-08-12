# Conventional Commits

## Purpose

Establish a consistent commit message convention across all RPG Engine repositories.

A standardized commit format improves readability, simplifies code reviews, supports automated tooling, and creates a project history that is easy to understand and maintain.

## Scope

This standard applies to all commits made to repositories within the RPG Engine project.

This includes, but is not limited to:

- Source code
- Tests
- Documentation
- Build configuration
- Continuous Integration (CI) workflows
- Project maintenance

Unless otherwise specified, this standard uses the requirement keywords defined in the [Standards Authoring Guide](./authoring-guide.md).

---

## Standard

All commit messages shall follow the Conventional Commits specification.

Commit messages shall use the following format:

```
<type>(<scope>): <short description>

[optional body]

[optional footer]
```

### Subject Line

The subject line shall:

- Begin with a valid commit type.
- Include a concise description of the change.
- Use the imperative mood (for example, *add* rather than *added*).
- Be written in lowercase unless proper nouns require capitalization.
- Clearly describe the primary purpose of the commit.

Contributors should include a scope whenever it improves readability or clearly identifies the affected area of the project.

### Scope

The scope identifies the primary area of the project affected by the change.

Scopes should be concise and descriptive.

A scope may be omitted when the affected area is already obvious or when including one provides little additional value.

### Commit Body

Contributors should include a commit body whenever additional context would benefit future contributors.

A commit body should describe:

- Why the change was made.
- Significant implementation decisions.
- Design considerations.
- Known limitations.
- Follow-up work when appropriate.

The commit body should not simply repeat the subject line.

### Commit Footer

The commit footer may be used to include additional metadata, including:

- Issue references.
- Breaking changes.
- Project-specific references.

#### Issue References

When referencing a project issue, contributors shall include only the issue number in the footer.

Contributors shall not use automatic issue-closing keywords such as:

- Fixes
- Fixed
- Closes
- Closed
- Resolves
- Resolved

Project issues shall be closed manually after:

1. Code review.
1. Testing.
1. Verification.

### Commit Types

The following commit types are approved for use within the RPG Engine project.

| Type | Purpose |
|------|---------|
| `feat` | Introduce new functionality. |
| `fix` | Correct defects or unintended behavior. |
| `docs` | Documentation-only changes. |
| `style` | Formatting or whitespace changes that do not modify behavior. |
| `refactor` | Improve internal structure without changing external behavior. |
| `perf` | Improve performance. |
| `test` | Add or modify automated tests. |
| `build` | Modify the build system or project dependencies. |
| `ci` | Modify Continuous Integration or deployment workflows. |
| `chore` | General maintenance tasks. |
| `revert` | Revert a previous commit. |

Additional commit types may be adopted as the project evolves.

---

## Exceptions

The following commits are exempt from this standard:

- Merge commits generated automatically by Git hosting platforms.
- Commits imported from third-party repositories without modification.
- Commits generated automatically by approved tooling.

Contributors should follow this standard whenever practical, even when an exception applies.

---

## Related Documentation

- [ADR-00006-adopt-conventional-commits](../adr/adr-00006-adopt-convential-commits.md)
- [Standards Authoring Guide](./authoring-guide.md)
- GitHub Contribution Guidelines *(if applicable)*

## References

- [Conventional Commits Specification v1.0.0](https://www.conventionalcommits.org/en/v1.0.0)