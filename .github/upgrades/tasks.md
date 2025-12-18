# FS Mod Manager .NET 10 Upgrade Tasks

## Overview

This document tracks the upgrade of the `FS Mod Manager.csproj` WinForms project to `net10.0-windows`. Work will proceed as prerequisite verification, a single atomic upgrade pass (project file + package adjustments + compilation fixes), followed by automated test validation and a final commit.

**Progress**: 2/4 tasks complete (50%) ![0%](https://progress-bar.xyz/50)

---

## Tasks

### [✓] TASK-001: Verify prerequisites *(Completed: 2025-12-18 07:45)*
**References**: Plan §Project-by-Project Plans, Plan §Source Control Strategy, Plan §Testing & Validation Strategy

- [✓] (1) Verify .NET 10 SDK is installed on the build machine(s) per Plan §Project-by-Project Plans
- [✓] (2) Confirm installed runtime/SDK version meets the minimum requirements for `net10.0-windows` (**Verify**)
- [✓] (3) If a `global.json` file exists, verify compatibility with the installed SDK and update `global.json` version if required per Plan §Project-by-Project Plans (**Verify**)
- [✓] (4) Verify required build tools (dotnet CLI version, MSBuild) and environment variables are present per Plan §Testing & Validation Strategy (**Verify**)

### [✓] TASK-002: Atomic framework and dependency upgrade with compilation fixes *(Completed: 2025-12-18 08:23)*
**References**: Plan §Project-by-Project Plans, Plan §Package Update Reference, Plan §Breaking Changes Catalog, Plan §Detailed Dependency Analysis

- [✓] (1) Update `TargetFramework` in `FS Mod Manager.csproj` to `net10.0-windows` and add/verify Windows desktop support properties (e.g., `<UseWindowsForms>true</UseWindowsForms>`) per Plan §Project-by-Project Plans
- [✓] (2) Inspect and update any MSBuild imports or central files (`Directory.Build.props`, `Directory.Packages.props`) referenced in Plan §Detailed Dependency Analysis to ensure consistent target framework and package-version overrides
- [✓] (3) Add any compatibility packages identified by Plan §Package Update Reference (examples: `System.Configuration.ConfigurationManager`, `System.Drawing.Common`) only as required by build errors
- [✓] (4) Restore dependencies (dotnet restore) and build the solution to identify compilation errors per Plan §Breaking Changes Catalog
- [✓] (5) Fix all compilation errors caused by framework/API changes (designer-generated code, WinForms API changes, configuration APIs) as described in Plan §Breaking Changes Catalog
- [✓] (6) Rebuild solution to verify fixes
- [✓] (7) Solution builds with 0 errors (**Verify**)

### [ ] TASK-003: Run automated tests and validate upgrade
**References**: Plan §Testing & Validation Strategy, Plan §Detailed Dependency Analysis

- [ ] (1) Run all test projects referenced in the plan (assessment shows none listed in Plan §Detailed Dependency Analysis); if no test projects exist, record that no automated tests are present per Plan §Testing & Validation Strategy
- [ ] (2) Fix any test failures (reference Plan §Breaking Changes Catalog for common issues)
- [ ] (3) Re-run tests after fixes
- [ ] (4) All tests pass with 0 failures (**Verify**)

### [ ] TASK-004: Final commit
**References**: Plan §Source Control Strategy

- [ ] (1) Commit all remaining changes with message: "TASK-004: Complete upgrade to `net10.0-windows`"




