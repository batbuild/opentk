#r @"packages/FAKE/tools/FakeLib.dll"
#load "build-helpers.fsx"

open Fake
open System
open System.IO
open System.Linq
open BuildHelpers
open Fake.XamarinHelper

//Directories
let openTkBinariesDir = @"Binaries\OpenTK\"
let nugetPackedDir  = @".\nugetPackages"

let authors = ["Andrea Magnorsky"; "Andrew O'Connor"; "Dean Ellis"; "Adam Duality"]

// project name and description
let projectName = "OpenTK.Duality.Android"
let projectDescription = "OpenTk for Duality running on full openGL on Android"
let projectSummary = projectDescription // TODO: write a summary
let androidSolutionName = "OpenTK.android.sln"
let projectPath = "Source/OpenTK/OpenTK.Android.csproj"
let solutionConfig = "Release"
let buildMode = getBuildParamOrDefault "buildMode" solutionConfig

MSBuildDefaults <- { MSBuildDefaults with Verbosity = Some MSBuildVerbosity.Detailed }

Target "Clean" (fun _ -> CleanDirs [openTkBinariesDir; nugetPackedDir; ])

Target "android-build" (fun () ->
    RestorePackages androidSolutionName

    MSBuild null "Build" ["Configuration", buildMode] [androidSolutionName]
    |> Log "AppBuild-Output: "
)

Target "android-package" (fun () ->
    AndroidPackage (fun defaults ->
        {defaults with
            ProjectPath = "Source/OpenTK/OpenTK.Android.csproj"
            Configuration = "Release"
            OutputPath = "Binaries/OpenTK/Release"
        }) 

    |> fun file -> TeamCityHelper.PublishArtifact file.FullName
)

Target "android-pack"(fun _ ->     
     NuGet (fun p -> 
        {p with
            Authors = authors
            Project = projectName
            Description = projectDescription      
            OutputPath = nugetPackedDir                                                
            Summary = projectSummary            
            Version = if isLocalBuild then buildVersion else "0.1."+ buildVersion                    
            WorkingDir = Path.Combine( openTkBinariesDir, solutionConfig)
            AccessKey = getBuildParamOrDefault "nugetkey" ""
            Publish = hasBuildParam "nugetkey"
            PublishUrl = getBuildParamOrDefault "nugetUrl" ""            
            }) 
            "nuget/opentk.duality.android.nuspec"
)

"Clean"
  ==> "android-build"
  ==> "android-pack"


RunTargetOrDefault "android-pack"