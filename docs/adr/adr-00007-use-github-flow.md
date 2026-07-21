# Use GitHub Flow
## Status
Accepted

Date: 2026-07-21

Decider(s): Aaron Mina

## Context and Problem
A branching strategy is needed to ensure changes are developed, reviewed, and merged in a consistent manner. The workflow should be simple enough for individual development while also supporting future contributors and pull request reviews.

## Considered Options
1. GitHub Flow
1. Git Flow
1. Trunk-Based Development
1. Custom workflow

## Decision
Use GitHub Flow as the project's branching strategy.

The `main` branch will always represent a stable, releasable state of the project.

All work will be performed on short-lived feature branches created from `main`. Each branch should focus on a single logical change and be merged back into `main` through a Pull Request.

The general workflow will be:

1. Create a branch from `main`.
1. Make small, logical commits following the Conventional Commits specification.
1. Push the branch to GitHub.
1. Open a Pull Request.
1. Review and verify that all automated checks pass.
1. Squash and merge into `main`.
1. Delete the feature branch after merging.

Branch names should clearly describe the work being performed.

Examples:

- `feature/dice-expression-parser`
- `feature/add-character-builder`
- `bugfix/null-reference-in-combat`
- `refactor/rules-engine`
- `docs/architecture-roadmap`
- `test/dice-engine`

## Consequences
1. Bad - Long-running features must be periodically synchronized with `main`.
1. Bad - Large changes should be broken into multiple Pull Requests to keep reviews manageable.
1. Good - Keeps the branching strategy simple and easy to understand.
1. Good - Encourages small, focused Pull Requests.
1. Good - Produces a clean and readable Git history through squash merges.
1. Good - Supports automated CI/CD workflows.
1. Good - Makes it easier for future contributors to understand the development process.
