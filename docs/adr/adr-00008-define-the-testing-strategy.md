# Define the Testing Strategy

## Status
Accepted

Date: 2026-07-21

Decider(s): Aaron Mina

## Context and Problem
As the RPG Engine grows, regressions become increasingly difficult to identify without automated testing. Since the project is intended to be a reusable framework, it is important that changes can be made with confidence while ensuring existing functionality continues to behave as expected.

A testing strategy is needed to define how tests are organized, what should be tested, and the expectations for new features.

## Considered Options
1. Manual testing only
2. Unit tests only
3. Unit tests with integration tests
4. Unit, integration, and end-to-end testing

## Decision
The project will adopt a layered testing strategy.

Every production project will have a corresponding test project.

Example:

```
src/
    RpgEngine.Core
    RpgEngine.Dice
    RpgEngine.Characters

tests/
    RpgEngine.Core.Tests
    RpgEngine.Dice.Tests
    RpgEngine.Characters.Tests
```

The following testing guidelines will be followed:

### Unit Tests
Unit tests verify the behavior of individual classes and methods in isolation.

Examples include:
- Dice rolling algorithms
- Character calculations
- Damage calculations
- Rule evaluation
- Utility methods
- Extension methods
- Value objects

Dependencies should be mocked whenever practical to isolate the component being tested.

### Integration Tests
Integration tests verify that multiple components correctly interact with one another.

Examples include:

- Character creation workflows
- Combat resolution
- Rule engine interactions
- Persistence components
- Serialization and deserialization

Integration tests may use real implementations instead of mocks where appropriate.

### Future End-to-End Tests
End-to-end tests may be added later for applications built on top of the engine, such as:

- REST API
- Blazor UI
- Discord Bot
- Console Application

The core engine itself should remain focused on unit and integration testing.

### Test Organization

Tests should mirror the production namespace and folder structure whenever practical.

Example:

```
src/
    Dice/
        DiceExpressionParser.cs

tests/
    Dice/
        DiceExpressionParserTests.cs
```

### Naming Convention

Test classes should be named after the class under test.

Examples:

- DiceTests
- CharacterBuilderTests
- CombatEngineTests

Individual test methods should clearly describe the expected behavior.

Examples:

- Roll_ReturnsValueWithinRange()
- AddModifier_IncreasesResult()
- CreateCharacter_AssignsStartingHitPoints()

### Code Coverage

The goal is to provide meaningful test coverage rather than pursuing a specific percentage.

Priority should be given to:

- Public APIs
- Business rules
- Mathematical calculations
- Parsing logic
- Rule evaluation
- Edge cases
- Regression scenarios

Trivial getters, setters, and framework-generated code generally do not require direct testing.

## Consequences

1. Bad - Increases development time.
1. Bad - Requires ongoing maintenance as the codebase evolves.
1. Bad - Poorly designed tests can become brittle if implementation details are over-tested.
1. Good - Increases confidence when making changes.
1. Good - Reduces regressions.
1. Good - Encourages loosely coupled and testable designs.
1. Good - Provides executable documentation of expected behavior.
1. Good - Makes refactoring significantly safer.
1. Good - Supports automated CI validation.
