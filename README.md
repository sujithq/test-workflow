# Test Workflow - .NET 9 Console Application

This is a simple .NET 9 console application with a GitHub Actions build pipeline that intentionally uses outdated actions to demonstrate security and maintenance concerns.

## Project Structure

- `Program.cs` - Main console application
- `ProgramTests.cs` - Unit tests
- `TestWorkflow.csproj` - Main project file
- `TestWorkflow.Tests.csproj` - Test project file
- `TestWorkflow.sln` - Solution file
- `.github/workflows/dotnet-build.yml` - Build pipeline with **outdated actions**

## Outdated Actions Used

The build pipeline intentionally uses the following outdated GitHub Actions:

1. **actions/checkout@v2** (should be v4)
   - Security: Missing token permissions and latest security updates
   - Features: Missing newer checkout features

2. **actions/setup-dotnet@v1** (should be v4)  
   - Security: Outdated Node.js runtime
   - Features: Missing performance improvements and newer .NET versions support

3. **actions/cache@v2** (should be v4)
   - Security: Using deprecated Node.js 12
   - Performance: Missing cache improvements

4. **actions/upload-artifact@v2** (should be v4)
   - Security: Using deprecated Node.js 12  
   - Features: Missing compression and retention improvements

## Security Implications

Using outdated actions can lead to:
- Security vulnerabilities in action dependencies
- Deprecated Node.js runtimes (Node.js 12 is EOL)
- Missing security patches and improvements
- Potential workflow failures as GitHub phases out support

## Building the Project

### Local Build
```bash
dotnet restore
dotnet build --configuration Release
dotnet test --configuration Release
```

### Run the Application
```bash
dotnet run
dotnet run -- arg1 arg2 arg3
```

## GitHub Actions Pipeline

The pipeline runs on:
- Push to main branch
- Pull requests to main branch  
- Manual workflow dispatch

It performs:
1. Checkout code (using outdated action)
2. Setup .NET 9 (using outdated action)
3. Cache NuGet packages (using outdated action)
4. Restore dependencies
5. Build the project
6. Run tests
7. Upload build artifacts (using outdated action)
8. Publish the application (on main branch only)

## Recommendations

To fix the security and maintenance issues:

1. Update `actions/checkout@v2` → `actions/checkout@v4`
2. Update `actions/setup-dotnet@v1` → `actions/setup-dotnet@v4`  
3. Update `actions/cache@v2` → `actions/cache@v4`
4. Update `actions/upload-artifact@v2` → `actions/upload-artifact@v4`

This would resolve security vulnerabilities and provide access to latest features and performance improvements.