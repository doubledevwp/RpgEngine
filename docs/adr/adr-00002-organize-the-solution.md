# Organize the Solution
## Status
Accepted

Date: 2026-07-14

Decider(s): Aaron Mina

## Context and Problem
How should the RPG Engine be organized?

## Considered Options
1. Single class library
1. Multiple class libraries
1. Microservices

##Decision
Multiple class libraries as a modular monolith

Initial projets include:
- Core
- Dice
- Characters
- Combat
- Rules
- Items
- Tests

## Consequences
1. Bad - More projects to maintain
1. Good - Easy to navigate
1. Good - Clear separation of responsibilities
1. Good - Easy to publish individual NuGet packages later
