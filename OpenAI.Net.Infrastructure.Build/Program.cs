using ADotNet.Clients;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks.SetupDotNetTaskV1s;
using ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks.SetupDotNetTaskV3s;
using System;
using System.Collections.Generic;
using System.IO;

namespace OpenAI.Net.Infrastructure.Build;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var adoNetClient = new ADotNetClient();

            var githubPipeline = new GithubPipeline
            {
                Name = "OpenAI.Net Build",


                OnEvents = new Events
                {
                    Push = new PushEvent
                    {
                        Branches = new string[] { "main" }
                    },

                    PullRequest = new PullRequestEvent
                    {
                        Branches = new string[] { "main" }
                    }
                },

                Jobs = new Dictionary<string, Job>
                    {
                        {
                            "build",
                            new Job
                            {
                                //EnvironmentVariables = new Dictionary<string, string>
                                //{
                                //    { "ApiKey", "${{ secrets.APIKEY }}" },
                                //    { "OrgId", "${{ secrets.ORGID }}" }
                                //},

                                RunsOn = BuildMachines.WindowsLatest,

                                Steps = new List<GithubTask>
                                {
                                    new CheckoutTaskV3
                                    {
                                        Name = "Pulling Code"
                                    },

                                    new SetupDotNetTaskV3
                                    {
                                        Name = "Installing .NET",

                                        With = new TargetDotNetVersionV3
                                        {
                                            DotNetVersion = "9.0.304"
                                        }
                                    },

                                    new RestoreTask
                                    {
                                        Name = "Restoring Packages"
                                    },

                                    new DotNetBuildTask
                                    {
                                        Name = "Building Solution"
                                    },

                                    new TestTask
                                    {
                                        Name = "Running Tests"
                                    }
                                }
                            }
                        }
                    }
            };

            string buildScriptPath = "../../../../.github/workflows/dotnet.yml";
            string directoryPath = Path.GetDirectoryName(buildScriptPath);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            adoNetClient.SerializeAndWriteToFile(
                adoPipeline: githubPipeline,
                path: buildScriptPath);
        }
    }



//internal class Program
//{
//    static void Main(string[] args)
//    {
//        var adotNetCLient = new ADotNetClient();
//        var githubPipeline = new GithubPipeline
//        {
//            Name = "OpenAI.Net Build",
//            OnEvents = new Events
//            {
//                Push = new PushEvent
//                {
//                    Branches = new string[] { "main" }
//                },
//                PullRequest = new PullRequestEvent
//                {
//                    Branches = new string[] { "main" }
//                }
//            },

//            Jobs = new Jobs
//            {
//                Build = new BuildJob
//                {
//                    RunsOn = BuildMachines.WindowsLatest,
//                    Steps = new List<GithubTask>
//                    {
//                        new CheckoutTaskV2
//                        {
//                            Name = "Pulling Code"
//                        },
//                        new SetupDotNetTaskV1
//                        {
//                            Name = "Installing .NET",
//                            TargetDotNetVersion = new TargetDotNetVersion
//                            {
//                                DotNetVersion = "9.0.304"
//                            }
//                        },
//                        new DotNetBuildTask
//                        {
//                            Name = "Building Solution"
//                        },
//                        new TestTask
//                        {
//                            Name = "Running Tests"
//                        }

//                    }
//                }
//            },
            
//        };
//    }
//}
