# Folder Structure
## Status
Accepted

Date: 2026-07-14

Decider(s): Aaron Mina

## Context and Problem
How should each project be organized?

## Considered Options
1. Layer
1. Feature
1. Domain

## Decision
Domain

Example:
```
Characters
    Models
    Services
    Interfaces
```
Instead of:
```
Controllers
Repositories
Models
Services
```


## Consequences
1. Bad - Requires more discipline
1. Good - Easier to navigate
1. Good - Better encapsulation
