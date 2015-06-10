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
let projectName = "Android.Duality.OpenTK"
let projectDescription = "OpenTk running on full openGL on Android"
let projectSummary = projectDescription // TODO: write a summary
let androidSolutionName = "OpenTK.android.sln"
let projectPath = "Source/OpenTK/OpenTK.Android.csproj"
let buildMode = getBuildParamOrDefault "buildMode" "Debug"

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

//Target "android-uitests" (fun () ->
//    AndroidPackage (fun defaults ->
//        {defaults with
//            ProjectPath = "Source/OpenTK/OpenTK.Android.csproj"
//            Configuration = "Release"
//            OutputPath = "Binaries/OpenTK/Release"
//        }) |> ignore
//
//    let appPath = Directory.EnumerateFiles(Path.Combine("src", "TipCalc.Android", "bin", "Release"), "*.apk", SearchOption.AllDirectories).First()
//
//    RunUITests appPath
//)


Target "android-pack"(fun _ ->

     NuGet (fun p -> 
        {p with
            Authors = authors
            Project = projectName
            Description = projectDescription                               
            OutputPath = nugetPackedDir
            WorkingDir = @".\"            
            Summary = projectSummary            
            Version = buildVersion         
            AccessKey = getBuildParamOrDefault "nugetkey" ""
            Publish = hasBuildParam "nugetkey"
            }) 
            "duality.android.opentk.nuspec"
)

//
//"core-build"
//  ==> "core-tests"
//
"Clean"
  ==> "android-build"
  ==> "android-pack"


RunTargetOrDefault "android-pack"