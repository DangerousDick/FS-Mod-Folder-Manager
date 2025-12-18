# .github/upgrades/plan.md

## Table of contents

- Executive Summary
- Migration Strategy
- Detailed Dependency Analysis
- Project-by-Project Plans
- Package Update Reference
- Breaking Changes Catalog
- Testing & Validation Strategy
- Risk Management
- Complexity & Effort Assessment
- Source Control Strategy
- Success Criteria

---

## Executive Summary

Selected Strategy
-----------------
**All-At-Once Strategy** — All projects upgraded simultaneously in a single coordinated operation.

Rationale
---------
- Solution size: 1 project (small)
- Current targets: `net6.0-windows7.0` (WinForms) — SDK-style
- Proposed target (from assessment): `net10.0-windows`
- No NuGet package updates reported in assessment
- High API incompatibility count (binary incompatible items: 2663) but single-project scope makes an atomic approach feasible

Key Metrics (from assessment)
-----------------------------
- Total projects: 1
- Lines of code: 3511
- Estimated LOC to modify: 2702+ (~77% of codebase)
- Binary incompatible APIs: 2663
- Source incompatible APIs: 39

Primary objective
-----------------
Upgrade the repository to target `net10.0-windows` (as proposed in the assessment) and bring project files, package references, and Windows Forms code into compatibility with .NET 10 while preserving behavior.

## Migration Strategy

Strategy selection
------------------
All-At-Once Strategy selected and justified by the small, single-project solution and consistent project type (WinForms, SDK-style). The upgrade will be performed as an atomic operation that updates project target frameworks and packages across the repository in a single coordinated change.

Scope and constraints
---------------------
- All project file changes, package updates (if required), compilation fixes and verification are part of one atomic upgrade pass.
- Preserve repository integrity by creating a dedicated upgrade branch and using a single logical commit (or tightly grouped commits) representing the end-to-end upgrade.
- Prerequisites (SDK, global.json) must be validated before the atomic upgrade begins.

Important notes
---------------
- Many Windows Forms APIs are flagged as binary-incompatible; expect designer and UI code to require manual fixes after TargetFramework update.
- No NuGet package updates were listed in the assessment, but runtime/platform-specific packages (System.Drawing.Common, System.Configuration.ConfigurationManager) may be needed and must be added if code requires them.


## Detailed Dependency Analysis

Summary
-------
- Single project: `FS Mod Manager.csproj` (SDK-style WinForms) — no project-to-project dependencies.
- Migration ordering constraint: trivial (leaves-first rule satisfied — the single project is both leaf and root).

Implication for All-At-Once
---------------------------
Because there is only one project, the All-At-Once approach naturally reduces to performing the atomic upgrade on that project while ensuring prerequisites are handled first.

## Project-by-Project Plans

Project: `FS Mod Manager\FS Mod Manager.csproj`
------------------------------------------------
Current State
- TargetFramework: `net6.0-windows7.0`
- SDK-style: True
- Project type: WinForms
- Files: 11 (8 files reported with incidents)
- LOC: 3511

Target State
- TargetFramework: `net10.0-windows`
- Windows desktop support enabled (see recommended project file changes)

Migration Steps (what to perform during the atomic upgrade)
1. Prerequisites (TASK-000: prepare environment)
   - Validate .NET 10 SDK is installed on build machine(s). If `global.json` exists, update or validate SDK version compatibility.
   - Ensure working tree is clean or follow pending-changes policy (commit/stash/undo as decided). Create upgrade branch from `main` (e.g., `upgrade/dotnet-10`).

2. Atomic Upgrade (TASK-001: single atomic upgrade)
   - Update `TargetFramework` property in `FS Mod Manager.csproj` to `net10.0-windows`.
   - Ensure Windows desktop support: add or verify `<UseWindowsForms>true</UseWindowsForms>` or `<UseWindowsDesktop>true</UseWindowsDesktop>` as required by project templates in .NET 10.
   - Inspect `Directory.Build.props`, `Directory.Packages.props`, or imported MSBuild props for target framework or package-version overrides and update them consistently.
   - Add any required NuGet packages identified during compilation (for example, `System.Configuration.ConfigurationManager` to bridge legacy config, or `System.Drawing.Common` if GDI+ APIs are used and not yet provided). List of packages to add will be determined by build errors.
   - Restore dependencies and build solution.
   - Fix compilation errors caused by framework/API changes (designer code, event signatures, ToolStrip/ToolStripItem/Control APIs). Replace or refactor APIs flagged as binary-incompatible in assessment.
   - Rebuild and ensure solution compiles with 0 errors.

3. Test Validation (TASK-002)
   - Run any automated test projects (none found in assessment). If no test projects exist, run smoke validations as available (see non-automatable verification notes below).
   - Verify application starts on a representative Windows machine and primary flows execute (UI initialization, menu actions, forms that trigger legacy code paths).

Validation checklist (per project)
- [ ] Project file updated to `net10.0-windows`
- [ ] Windows desktop support properties present
- [ ] All compilation errors fixed (0 errors)
- [ ] No remaining package/version conflicts
- [ ] All unit/integration tests (if present) pass

What will likely require manual code changes
- Designer-generated UI code referencing types/members that changed (ToolStripMenuItem constructors, ToolStripItem properties, Control collections, etc.)
- Legacy configuration access via `System.Configuration.ApplicationSettingsBase` — consider migration to `Microsoft.Extensions.Configuration` or add `System.Configuration.ConfigurationManager` package as bridge
- Any direct use of `System.Drawing` APIs — consider `System.Drawing.Common` or move to cross-platform alternatives

## Package Update Reference

Assessment indicates no NuGet package entries requiring updates. However, the following packages are commonly required during WinForms migrations and should be considered if build/runtime errors indicate their absence:

- `System.Configuration.ConfigurationManager` — add when legacy app.config usage requires the ConfigurationManager API (Assessment flagged 37 legacy configuration issues).
- `System.Drawing.Common` — add if code uses GDI+ APIs (assessment flagged 2 instances). Note: on .NET 6+ this package has platform considerations; test on Windows.

If any package additions are required, list exact current and target versions in this section using versions discovered during the atomic upgrade.

## Breaking Changes Catalog

Top expected breaking-change areas (from assessment):
- Windows Forms API binary incompatible changes (primary): `ToolStripMenuItem`, `TextBox`, `Button`, `Label`, `ListBox`, `ToolStripStatusLabel`, `ToolStripSeparator`, `StatusStrip`, `MenuStrip`, `ContextMenuStrip`, `Control` members and collections.
- Designer/InitializeComponent changes: generated code may reference API shapes that changed; expect to update code generated by the WinForms designer.
- Legacy configuration APIs: `ApplicationSettingsBase.Item(string)` and related config access may need the `System.Configuration.ConfigurationManager` package or a code migration to the `Microsoft.Extensions.Configuration` patterns.
- System.Drawing/GDI+: check for methods or overloads that became platform-specific; consider migrating heavy imaging code to `ImageSharp` or `SkiaSharp` if cross-platform is desired.

Guidance
- Use the build output after updating the project to identify exact failing members; address them by replacing deprecated APIs, updating usages or adding compatibility packages.
- For designer issues, try re-generating designer code with the WinForms designer in Visual Studio targeting .NET 10 after the project file change, or update InitializeComponent code carefully preserving custom modifications.

## Testing & Validation Strategy

Automated testing
- Run all test projects after the atomic upgrade. Assessment shows no test projects; add or enable tests where available.

Build validation
- Successful outcome: solution builds with 0 errors.

Runtime validation
- Launch the application on Windows and verify primary UI flows. (This is a manual smoke validation and should be documented in PR notes—do not convert to an automated task unless automation exists.)

Validation checkpoints
- Pre-upgrade: SDK validation, branch creation.
- Post-atomic-upgrade: compile success.
- Post-fix: smoke run and manual verification of major UI flows.

## Risk Management

Primary risks
- High code impact: ~77% of codebase flagged for changes ? High chance of compilations and behavioral fixes.
- Windows Forms binary incompatibilities: many UI APIs changed — may require careful manual fixes in designer code.
- Lack of automated tests: increases manual validation burden.

Mitigations
- Use an isolated upgrade branch and single atomic commit to enable easy rollback.
- Preserve backups (stashed changes, patch) before starting.
- Triage build errors by category: designer-generated vs hand-written UI logic vs configuration usage.
- Where possible, add automated unit tests for critical logic before migrating (if feasible).
- Keep a short feedback loop: perform build and fix cycle during the atomic upgrade step.

Contingency
- If an unrecoverable blocking issue is found during the atomic pass, revert changes on the upgrade branch and assess incremental approach for problematic areas.

## Complexity & Effort Assessment

Overall complexity: Medium-High (single project but high API incompatibility and high LOC impact).

Per-project complexity
- `FS Mod Manager.csproj`: High — 2702+ LOC likely to change; many Windows Forms API breaks.

Recommended focus
- Prioritize resolving designer-file and ToolStrip/ToolStripItem related compilation errors as they represent the largest share of incompatibilities.

## Source Control Strategy

Branching
- Create a dedicated upgrade branch from `main`: e.g., `upgrade/dotnet-10`.

Pending changes
- Ensure working tree is clean. If pending changes exist, follow the chosen action (commit, stash, or undo) before starting.

Commit strategy
- Prefer a single atomic commit representing the completed upgrade pass (this aligns with All-At-Once Strategy). If that is impractical, keep commits tightly focused and include a clear PR description listing known post-upgrade work.

Code review
- Submit a PR from `upgrade/dotnet-10` into `main`. PR should include build logs, a summary of changes, and validation notes (manual smoke steps).

## Success Criteria

The upgrade is complete when all of the following are true:
1. All projects target the proposed frameworks from the assessment (`FS Mod Manager.csproj` ? `net10.0-windows`).
2. All package updates suggested or required by the build are applied and documented.
3. Solution builds with 0 errors.
4. Automated tests (if present) pass.
5. No outstanding critical security vulnerabilities in packages remain.
6. PR accepted and merge performed into the main branch following standard review.

?? Requires validation
- Confirm presence and contents of any `global.json` files and update SDK version if present.
- Confirm whether Visual Studio designer regeneration is required and document manual steps.

