#r @"tools/FAKE.Core/tools/FakeLib.dll"
#load "build-helpers.fsx"

open Fake
open System
open System.IO
open System.Linq
open BuildHelpers
open Fake.XamarinHelper


let authors = ["Andrea Magnorsky"; "Andrew O'Connor"; "Dean Ellis"; "Adam Duality"]

// project name and description
let projectName = "OpenTk Duality Android runtime"
let projectDescription = "OpenTk running on full openGL on Android"
let projectSummary = projectDescription // TODO: write a summary
let solutionName = "OpenTK.android.sln"
let projectPath = "Source/OpenTK/OpenTK.Android.csproj"
let buildMode = getBuildParamOrDefault "buildMode" "Release"

MSBuildDefaults <- { MSBuildDefaults with Verbosity = Some MSBuildVerbosity.Detailed }


Target "android-build" (fun () ->
//    RestorePackages solutionName

    MSBuild null "Build" ["Configuration", buildMode] [solutionName]
    |> Log "AppBuild-Output: "
)

Target "android-package" (fun () ->
    AndroidPackage (fun defaults ->
        {defaults with
            ProjectPath = "Source/OpenTK/OpenTK.Android.csproj"
            Configuration = "Release"
            OutputPath = "Binaries/OpenTK/Release"
        }) 
//    |> AndroidSignAndAlign (fun defaults ->
//        {defaults with
//            KeystorePath = "tipcalc.keystore"
//            KeystorePassword = "tipcalc" // TODO: don't store this in the build script for a real app!
//            KeystoreAlias = "tipcalc"
//        })
    |> fun file -> TeamCityHelper.PublishArtifact file.FullName
)

Target "android-uitests" (fun () ->
    AndroidPackage (fun defaults ->
        {defaults with
            ProjectPath = "Source/OpenTK/OpenTK.Android.csproj"
            Configuration = "Release"
            OutputPath = "Binaries/OpenTK/Release"
        }) |> ignore

    let appPath = Directory.EnumerateFiles(Path.Combine("src", "TipCalc.Android", "bin", "Release"), "*.apk", SearchOption.AllDirectories).First()

    RunUITests appPath
)

Target "android-testcloud" (fun () ->
    AndroidPackage (fun defaults ->
        {defaults with
            ProjectPath = "src/TipCalc.Android/TipCalc.Android.csproj"
            Configuration = "Release"
            OutputPath = "src/TipCalc.Android/bin/Release"
        }) |> ignore

    let appPath = Directory.EnumerateFiles(Path.Combine("src", "TipCalc.Android", "bin", "Release"), "*.apk", SearchOption.AllDirectories).First()

    getBuildParam "devices" |> RunTestCloudTests appPath
)
//
//"core-build"
//  ==> "core-tests"
//
"android-build"
  ==> "android-uitests"

"android-build"
  ==> "android-testcloud"

"android-build"
  ==> "android-package"

RunTargetOrDefault "android-uitests"