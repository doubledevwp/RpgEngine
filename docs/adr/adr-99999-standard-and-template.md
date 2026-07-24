> [!IMPORTANT]
> **Applies to this ADR only!**
>
> This ADR defines the project's standard template for Architectural Decision Records. The template should evolve as the project's documentation needs change, but changes should be applied consistently across the architecture handbook whenever practical.

<br />
<hr />

# ADR Title

## Status
{See Values table below}

Decision Question: {What architectural question does this ADR answer?}

Date: {YYYY-MM-DD}

Decider(s): {Comma separated list of decision makers}

Supersedes: {None|adr-#####}

Superseded By: {None|adr-#####}

## Related Decisions
Depends On: {None|adr-#####}

Extends: {None|adr-#####}

Related To: {None|adr-#####}

## Context and Problem

Describe the architectural problem, goal, or motivation that prompted this decision. Explain why this decision is necessary and what problem it is intended to solve. This section should provide enough context that a future contributor can understand why the decision was made.

## Considered Options

### 1. Option Name

Brief description of the option.

**Advantages**

- Advantage A
- Advantage B

**Disadvantages**

- Disadvantage A
- Disadvantage B

## Decision

The decision should describe the architectural direction that contributors are expected to follow going forward.

It should explain why the selected option was chosen over the alternatives and avoid implementation details unless they are necessary to understand the architectural decision.

## Decision Rules *(Optional)*

List concrete rules that contributors should follow as a result of this decision.

Examples:

1. Rule A
1. Rule B
1. Rule C

> [!NOTE] 
> If the ADR establishes guiding principles rather than enforceable rules, this section may be renamed to **Decision Principles**.

## Consequences

List both the positive and negative consequences of the decision. Whenever possible, explain *why* each consequence exists instead of simply listing it.

**Advantages**

1. Consequence A
1. Consequence B

**Disadvantages**
1. Consequence C
1. Consequence D

## References *(Optional)*
List any documents, standards, ADRs, books, specifications, or other resources that informed this decision.

<br />
<hr />

# Writing Guidelines

Architectural Decision Records document **why** significant architectural decisions were made.

An ADR should answer the following questions:

- What problem or opportunity prompted this decision?
- What alternatives were considered?
- Why was the chosen solution selected?
- What principles or rules should future contributors follow?
- What are the long-term consequences of this decision?

ADRs should describe **architectural decisions**, not implementation details.

An ADR should remain focused on answering a single architectural question. Avoid combining multiple unrelated decisions into a single document. If multiple independent architectural decisions are discovered while writing an ADR, they should generally be documented as separate ADRs to preserve clarity, traceability, and maintainability.

Avoid duplicating information that already has a single authoritative source elsewhere in the project. Reference or link to that source instead, using the appropriate section (for example, Related Decisions or References) when applicable.

Examples of appropriate ADRs include:

- System architecture
- Project organization
- Technology selection
- Dependency direction
- Testing strategy
- Deployment strategy
- Public API philosophy

Examples that generally do **not** require ADRs include:

- Bug fixes
- Individual feature implementations
- Refactoring
- Coding style preferences
- Package upgrades
- Routine maintenance

<br />
<hr />

# Relationships
## Lifecycle Meanings 
| Field             | Purpose                                                                  |
| ----------------- | ------------------------------------------------------------------------ |
| **Supersedes**    | Replaces one or more earlier ADRs.                                       |
| **Superseded By** | Indicates the ADR that replaced this one.                                |
| **Depends On**    | This ADR assumes another ADR remains in effect.                          |
| **Extends**       | Adds detail or constraints to another ADR without replacing it.          |
| **Related To**    | References another ADR with a meaningful but non-dependent relationship. |

## Status Values
| Field          | Definition                                                                        |
| -------------- | --------------------------------------------------------------------------------- |
| **Proposed**   | Under consideration and not yet authoritative.                                    |
| **Accepted**   | Approved and currently authoritative.                                             |
| **Rejected**   | Considered but not adopted.                                                       |
| **Deprecated** | Still present or temporarily usable, but discouraged and expected to be replaced. |
| **Superseded** | Replaced by another accepted ADR.                                                 |
| **Withdrawn**  | Removed from consideration before a final decision.                               |
| **Obsolete**   | No longer applicable because the relevant system or requirement no longer exists. |
