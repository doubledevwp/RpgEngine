# Use Architectual Decision Records
## Status
Accepted

Date: 2026-07-18

Decider(s): Aaron Mina

## Context and Problem
I want to track the decisions made in this project.  Which format should I use?

## Considered Options
1. [MADR](https://adr.github.io/madr/examples.html) - There is a Short and Long version
2. [Template based off of Michael Nygard](https://github.com/architecture-decision-record/architecture-decision-record/tree/main/locales/en/templates/decision-record-template-by-michael-nygard) - Simple
3. Something custom

## Decision
I like parts of each of the considered options so I am going to create my own hybrid of sorts.

## Consequences
1. Bad - Will add more time to create this
2. Good - A more thought out and documented process about the project

The format that I want to use is how this ADR is formatted.
1. File naming convention
    1. Prefix: adr-#####
    2. A short description separated by hyphens; -
    3. Markdown extension; .md
2. First section will be formatted as a title
    1. This will be the same short description as the name
3. Second section will be the `Status` information
    1. Status: {Accepted|Deprecated|Proposed|Rejected|Superseded}
    2. Date: {YYYY-MM-DD}
    3. Decider(s): {Comma separated list of people that discussed the change}
4. Third section is for the `Context and Problem`
    1. Explain the issue or idea and what should be solved by this ADR
5. Fourth section are the `Considered Options`
    1. List all and any options to be researched and discussed for this ADR
6. Fifth section is dedicated for the `Decision`
    1. What was chosen and why
7. Sixth section is for `Consequences`
    1. List all and any positive or negative affects from the decision
    2. Use either `Good - ` or `Bad - ` to prefix the line(s)
