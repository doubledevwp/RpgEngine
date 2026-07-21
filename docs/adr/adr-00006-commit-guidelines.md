# Commit Guidelines
## Status
Accepted

Date: 2026-07-14

Decider(s): Aaron Mina

## Context and Problem
Consistant and easy commit messages

## Decision
[Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0)

Recommended commit format:
```
<type>(<scope>): <short description>

[optional body]

[optional footer]
```

> [!IMPORTANT]
>  If the commit is linked to an issue, put it in the footer.  DO NOT USE KEYWORD TO CLOSE ISSUE.  Closing issues will be done manually once code is reviewed and tested.

Example:
```
feat(dice): add expression parser

Added dice expression parser to engine can handle 2d20kh, 4d6kh3, or 2d6+4

#123
```

### Common Commit Types
| Type       | Use For                     | Example                                       |
| ---------- | --------------------------- | --------------------------------------------- |
| `feat`     | New functionality           | `feat(api): add user registration endpoint`   |
| `fix`      | Bug fixes                   | `fix(database): handle null customer records` |
| `docs`     | Documentation only          | `docs(readme): update installation steps`     |
| `style`    | Formatting/no logic changes | `style: apply code formatting`                |
| `refactor` | Code restructuring          | `refactor(logging): extract logger service`   |
| `perf`     | Performance improvements    | `perf(parser): optimize expression parsing`   |
| `test`     | Adding/updating tests       | `test(dice): add advantage roll tests`        |
| `build`    | Build system/dependencies   | `build: upgrade dotnet sdk to 10`             |
| `ci`       | CI/CD changes               | `ci(github): add unit test workflow`          |
| `chore`    | Maintenance tasks           | `chore: update dependencies`                  |
| `revert`   | Undo previous commit        | `revert: remove experimental cache`           |


## Consequences
1. Bad - Need to be more disciplined
1. Bad - There will be more commits
1. Good - Commit messages will be consistant
1. Good - Commit messages will be easier to read at a glance
1. Good - This will force smaller commits
